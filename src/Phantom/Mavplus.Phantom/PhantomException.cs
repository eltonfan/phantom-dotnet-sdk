// Coded by chuangen http://chuangen.name.

using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom
{
    /// <summary>
    /// 通过HTTPS访问幻腾应用编程接口期间出错时引发的异常。
    /// </summary>
    public class PhantomException : Exception
    {
        /// <summary>
        /// 初始化 PhantomException 类的新实例。
        /// </summary>
        public PhantomException()
            : base()
        { }
        /// <summary>
        /// 使用指定的错误消息初始化 PhantomException 类的新实例。
        /// </summary>
        /// <param name="message">错误消息的文本。</param>
        public PhantomException(string message)
            : base(message)
        { }
        /// <summary>
        /// 用指定的错误信息和嵌套异常初始化 PhantomException 类的新实例。
        /// </summary>
        /// <param name="message">错误消息的文本。</param>
        /// <param name="innerException">嵌套异常。</param>
        public PhantomException(string message, Exception innerException)
            : base(message, innerException)
        { }
        /// <summary>
        /// 用指定的错误信息和状态初始化 PhantomException 类的新实例。
        /// </summary>
        /// <param name="message">错误消息的文本。</param>
        /// <param name="status">PhantomExceptionStatus 值之一。</param>
        public PhantomException(string message, PhantomExceptionStatus status)
            : base(message)
        {
            this.Status = status;
        }
        /// <summary>
        /// 用指定的错误信息、嵌套异常、状态和响应初始化 PhantomException 类的新实例。
        /// </summary>
        /// <param name="message">错误消息的文本。</param>
        /// <param name="innerException">嵌套异常。</param>
        /// <param name="status">PhantomExceptionStatus 值之一。</param>
        /// <param name="response">包含来自远程主机的响应的 IRestResponse 实例。</param>
        public PhantomException(string message, Exception innerException, PhantomExceptionStatus status, IRestResponse response)
            : base(message, innerException)
        {
            this.Status = status;
            this.Response = response;
        }

        /// <summary>
        /// 获取远程主机返回的响应。
        /// </summary>
        /// <value>如果可从 Internet 资源获得响应，则为包含来自 Internet 资源的错误响应的 IRestResponse 实例；否则为 null。</value>
        public IRestResponse Response { get; private set; }
        /// <summary>
        /// 获取响应的状态。
        /// </summary>
        /// <value>PhantomExceptionStatus 值之一。</value>
        public PhantomExceptionStatus Status { get; private set; }
    }

    public class PhantomUnauthorizedException : PhantomException
    {
        public PhantomUnauthorizedException()
            : base()
        { }
    }

    /// <summary>
    /// Phantom错误编号。
    /// </summary>
    public enum PhantomExceptionStatus
    {
        /// <summary>
        /// 无错误编号错误
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        A04010,
        A04011,
        A04012,
        A04030,
        A04040,
        A04041,
        A04220,
        A04221,
        B00001,
        B00002,
        B00003,
        B00004,
    }
}
