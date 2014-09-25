using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.Models
{
    /// <summary>
    /// 用户信息。
    /// </summary>
    public class User
    {
        public int user_uniq_id { get; set;}
        public string name { get; set;}
        public string email { get; set;}
        public float home_long { get; set;}
        public float home_lat { get; set;}
        public int home_coming_scenario_id { get; set;}
        public int home_leaving_scenario_id { get; set;}
        public int device_count { get; set;}
        public DateTime created_at { get; set;}
        public DateTime updated_at { get; set;}
        public string deprecated_token { get; set;}
    }
}
