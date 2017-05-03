using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mavplus.Phantom.Win
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
            writer.WriteLine("<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/><title>" + title + "</title></head><body>");
            writer.WriteLine("<div style=\"height:20px;color:blue;text-align:center;\"><p>" + desc + "</p></div>");
            writer.WriteLine("<ul>");
            writer.WriteLine("</ul>");
            writer.WriteLine("</body></html>");
        }

        public void Login()
        {
            StartHttpListener();

            string[] arrayScopes = new string[]
            {
                "read_user","write_user","monitor_user",
                "read_router","writer_router","monitor_router",
                "read_pixel_pro","write_pixel_pro","monitor_pixel_pro",
                "read_generic_module","write_generic_module","monitor_generic_module",
                "read_door_accessor","write_door_accessor","monitor_door_accessor",
                "read_wall_switch","write_wall_switch","monitor_wall_switch",
                //"read_infrared_sensor","write_infrared_sensor","monitor_infrared_sensor",
                "read_door_sensor","write_door_sensor","monitor_door_sensor",
                "read_bulb","write_bulb","monitor_bulb",
                "read_switch","write_switch","monitor_switch",
                //"read_iodetector","write_iodetector","monitor_iodetector",
                //"read_irda_hub","write_irda_hub","monitor_irda_hub",
                //"read_ac_controller","write_ac_controller","monitor_ac_controller",
                //"read_upnp","write_upnp",
                "apply_scenario","write_scenario",
                //"monitor_app", "monitor_occupy",
            };
            string scope = string.Join("+", arrayScopes);

            string url = string.Format("https://huantengsmart.com/oauth2/authorize?client_id={0}&scope={1}&redirect_uri={2}&response_type=code",
                SecretKeys.Phantom.AppId,
                scope,
                System.Web.HttpUtility.UrlEncode("http://localhost:6060/18ec7769c06d45d788d1d3d73612d2d2", Encoding.UTF8));
            System.Diagnostics.Process.Start(url);
        }
    }
}
