using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAccountUseridBatchqueryResponse.
    /// </summary>
    public class AlipayUserAccountUseridBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户列表
        /// </summary>
        [JsonProperty("user_id_list")]
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
