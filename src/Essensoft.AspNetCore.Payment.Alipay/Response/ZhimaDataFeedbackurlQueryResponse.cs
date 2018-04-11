using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaDataFeedbackurlQueryResponse.
    /// </summary>
    public class ZhimaDataFeedbackurlQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 反馈模板地址
        /// </summary>
        [JsonProperty("feedback_url")]
        [XmlElement("feedback_url")]
        public string FeedbackUrl { get; set; }
    }
}
