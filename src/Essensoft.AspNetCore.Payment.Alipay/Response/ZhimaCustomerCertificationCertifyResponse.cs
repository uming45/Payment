using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerCertificationCertifyResponse.
    /// </summary>
    public class ZhimaCustomerCertificationCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 一次认证的唯一标识，在商户调用认证初始化接口的时候获取，认证完成返回的biz_no和请求的一致
        /// </summary>
        [JsonProperty("biz_no")]
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 认证不通过的原因
        /// </summary>
        [JsonProperty("failed_reason")]
        [XmlElement("failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// 认证是否通过,通过为true，不通过为false
        /// </summary>
        [JsonProperty("passed")]
        [XmlElement("passed")]
        public string Passed { get; set; }
    }
}
