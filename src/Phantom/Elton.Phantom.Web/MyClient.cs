using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elton.Phantom.Web
{
    public class MyClient
    {
        static MyClient instance = null;
        public static MyClient Default
        {
            get
            {
                if (instance == null)
                    instance = new MyClient();
                return instance;
            }
        }

        readonly PhantomConfiguration config;
        readonly PhantomClient client;
        private MyClient()
        {
            this.config = new PhantomConfiguration(
                SecretKeys.PhantomAlexa.AppId,
                SecretKeys.PhantomAlexa.AppSecret,
                SecretKeys.PhantomAlexa.RedirectUri);
            this.client = new PhantomClient(config);
        }

        public PhantomConfiguration Configuration => config;
        public PhantomClient Client => client;
    }
}
