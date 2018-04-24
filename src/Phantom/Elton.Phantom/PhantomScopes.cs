using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Elton.Phantom
{
    public class PhantomScopes
    {
        [Flags]
        public enum ScopeTypes
        {
            Read = 0x01,
            Write = 0x02,
            Monitor = 0x04,
            Apply = 0x08,
        }

        public class ScopeItem
        {
            public string Name { get; set; }
            public ScopeTypes Types { get; set; }
        }

        readonly List<ScopeItem> listItems = new List<ScopeItem>(); 
        private PhantomScopes()
        {
            Add("user", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("router", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("pixel_pro", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("generic_module", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("door_accessor", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("wall_switch", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("infrared_sensor", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("infrared_remote", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("elevator", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("door_sensor", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("bulb", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("switch", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("snp_inside", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("iodetector", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("irda_hub", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
            Add("ac_controller", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);

            Add("upnp", ScopeTypes.Read | ScopeTypes.Write);//
            Add("scenario", ScopeTypes.Apply | ScopeTypes.Write | ScopeTypes.Monitor);//
            Add("app", ScopeTypes.Monitor);
            Add("occupy", ScopeTypes.Monitor);
            Add("betech", ScopeTypes.Monitor);
            Add("huohe", ScopeTypes.Monitor);
            Add("lumen", ScopeTypes.Monitor);

            Add("door_lock", ScopeTypes.Read | ScopeTypes.Write | ScopeTypes.Monitor);
        }

        public void Add(string name, ScopeTypes types)
        {
            listItems.Add(new ScopeItem { Name = name, Types = types });
        }

        static PhantomScopes instance = null;
        public static string GetString()
        {
            if (instance == null)
                instance = new PhantomScopes();

            var sb = new StringBuilder();
            foreach (var item in instance.listItems)
            {
                foreach (ScopeTypes type in Enum.GetValues(typeof(ScopeTypes)))
                {
                    if ((item.Types & type) == type)
                        sb.Append($"{type.ToString().ToLower()}_{item.Name}+");
                }
            }

            return sb.ToString().TrimEnd('+');
        }
    }
}

