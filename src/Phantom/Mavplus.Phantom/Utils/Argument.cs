// Coded by chuangen http://chuangen.name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom
{
    /// <summary>
    /// 请求参数。
    /// </summary>
    internal class Argument
    {
        public string Key { get; private set; }
        public object Value { get; private set; }
        public Argument(string key, object value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
