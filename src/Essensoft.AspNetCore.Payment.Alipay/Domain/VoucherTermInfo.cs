using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherTermInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherTermInfo : AlipayObject
    {
        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("descriptions")]
        [XmlArray("descriptions")]
        [XmlArrayItem("string")]
        public List<string> Descriptions { get; set; }

        /// <summary>
        /// 详情title
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
