// Coded by chuangen http://chuangen.name.

using Elton.Phantom.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom.Version1
{
    /// <summary>
    /// 实现对幻腾API的各功能封装。
    /// </summary>
    /// <remarks> https://huantengsmart.com/doc/api_v1 </remarks>
    public partial class PhantomAPI : PhantomApiCore
    {
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(typeof(PhantomAPI));

        readonly Dictionary<int, Bulb> dicBulbs = new Dictionary<int, Bulb>();

        public PhantomAPI(PhantomConfiguration config)
            : base(config)
        {
            client.DefaultParameters.Add(new Parameter
            {
                Name = "Accept",
                Type = ParameterType.HttpHeader,
                Value = "application/vnd.huantengsmart-v1+json",
            });//"application/json"
        }

        public bool Ping()
        {
            string result = this.GetJson<string>("ping.json");
            if (string.IsNullOrEmpty(result))
                return false;

            return result.Contains("pong");
        }
    }
}
