using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketOrderAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketOrderAcceptModel : AlipayObject
    {
        /// <summary>
        /// 服务商品订单ID
        /// </summary>
        [JsonProperty("commodity_order_id")]
        [XmlElement("commodity_order_id")]
        public string CommodityOrderId { get; set; }
    }
}
