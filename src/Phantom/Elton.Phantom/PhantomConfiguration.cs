// Coded by chuangen http://chuangen.name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom
{
    /// <summary>
    /// 幻腾接口配置。（配置客户端信息）
    /// </summary>
    public class PhantomConfiguration
    {
        static PhantomConfiguration instance = null;
        public static PhantomConfiguration Default
        {
            get
            {
                if (instance == null)
                    instance = new PhantomConfiguration();

                return instance;
            }
        }

        public string AppId { get; set; } = null;
        public string AppSecret { get; set; } = null;
        public string RedirectUri { get; set; } = null;
        /// <summary>
        /// 客户端的 User-Agent。
        /// </summary>
        public string UserAgent { get; set; } = null;
        /// <summary>
        /// 请求的时间间隔。（毫秒）
        /// </summary>
        public int RequestInterval { get; set; } = 20 * 1000;

        private PhantomConfiguration()
        { }
    }
}
