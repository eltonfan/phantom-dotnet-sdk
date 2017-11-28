using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elton.Phantom.Win
{
    partial class MainForm
    {
        HttpListener httpListener = new HttpListener();

        void StartHttpListener()
        {
            httpListener.AuthenticationSchemes = AuthenticationSchemes.Anonymous;
            httpListener.Prefixes.Add("http://localhost:6060/");
            httpListener.Start();
            new Thread(new ThreadStart(delegate
            {
                while (true)
                {
                    HttpListenerContext httpListenerContext = httpListener.GetContext();

                    //成功：GET redirect_uri/?code=authorize_code
                    //失败：GET redirect_uri/?error=access_denied&error_description=The+resource+owner+or+authorization+server+denied+the+request.
                    var queryString = httpListenerContext.Request.QueryString;

                    string title = "";
                    string desc = "";
                    try
                    {
                        if (!string.IsNullOrEmpty(queryString["error"]))
                        {
                            httpListenerContext.Response.StatusCode = 200;
                            title = queryString["error"];
                            desc = queryString["error_description"];
                            continue;
                        }

                        if (string.IsNullOrEmpty(queryString["code"]))
                        {
                            httpListenerContext.Response.StatusCode = 200;
                            title = "Failed";
                            desc = "The code query is empty.";
                            continue;
                        }
                        string authorizeCode = queryString["code"];
                        ApiVersion2.PhantomAPI api = new ApiVersion2.PhantomAPI(PhantomConfiguration.Default);
                        var token = api.CreateToken(authorizeCode);

                        settings.AccessToken = token.access_token;
                        settings.RefreshToken = token.refresh_token;
                        settings.Save();

                        client.Connect(settings.AccessToken);

                        log.Info("AccessToken: " + token.access_token);

                        httpListenerContext.Response.StatusCode = 200;
                        title = "Finished";
                        desc = "Well done, you now have an access token which allows you to call Phantom API on behalf of the user.<br />Please return to the application.";
                    }
                    catch(Exception ex)
                    {
                        log.Error("Failed to create token.", ex);
                    }
                    finally
                    {
                        using (StreamWriter writer = new StreamWriter(httpListenerContext.Response.OutputStream))
                        {
                            WriteHtml(writer, title, desc);
                        }
                    }
                }
            })).Start();
        }

        void WriteHtml(StreamWriter writer, string title, string desc)
        {
            string template = Properties.Resources.HTML_Finished;
            var html = template
                .Replace("%title%", title)
                .Replace("%desc%", desc);

            writer.Write(html);
        }

        public void Login()
        {
            StartHttpListener();
            var scope = PhantomScopes.GetString();
            PhantomConfiguration config = PhantomConfiguration.Default;
            string url = string.Format("https://huantengsmart.com/oauth2/authorize?client_id={0}&scope={1}&redirect_uri={2}&response_type=code",
                config.AppId,
                scope,
                System.Web.HttpUtility.UrlEncode(config.RedirectUri, Encoding.UTF8));
            System.Diagnostics.Process.Start(url);
        }
    }
}
