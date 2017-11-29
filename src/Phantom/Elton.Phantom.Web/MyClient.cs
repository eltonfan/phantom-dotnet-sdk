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

        readonly PhantomClient client = null;
        private MyClient()
        {
            client = new PhantomClient();
        }

        public PhantomClient Client
        {
            get => client;
        }
    }
}
