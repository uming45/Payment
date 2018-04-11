using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandMapplyorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandMapplyorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝端商户入驻申请单据号
        /// </summary>
        [JsonProperty("order_no")]
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
