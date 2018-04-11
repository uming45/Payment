using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeTicketTicketcodeUseModel : AlipayObject
    {
        /// <summary>
        /// 外部请求号，支持英文字母和数字，由开发者自行定义（不允许重复）
        /// </summary>
        [JsonProperty("request_id")]
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 12位的券码，券码为纯数字，且唯一不重复
        /// </summary>
        [JsonProperty("ticket_code")]
        [XmlElement("ticket_code")]
        public string TicketCode { get; set; }
    }
}
