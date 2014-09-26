using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.API
{
    /// <summary>
    /// URL参数。
    /// </summary>
    internal class UrlSegment
    {
        public string Key { get; private set; }
        public string Value { get; private set; }
        public UrlSegment(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
