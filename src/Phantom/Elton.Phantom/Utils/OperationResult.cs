
using Newtonsoft.Json;

namespace Elton.Phantom
{
    /// <summary>
    /// OperationResult
    /// </summary>
    internal class OperationResult
    {
        /// <summary>
        /// 操作成功与否
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
        /// <summary>
        /// 若操作失败，返回失败原因
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
