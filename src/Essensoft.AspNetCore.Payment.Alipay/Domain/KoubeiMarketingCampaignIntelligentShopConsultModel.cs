using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentShopConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignIntelligentShopConsultModel : AlipayObject
    {
        /// <summary>
        /// 根据不同场景,过滤不同的门店数据,可参考值:CREATE_NORMAL:正常创建;RENEWAL_OLD:原方案续期;RENEWAL_NEW:新方案续期
        /// </summary>
        [JsonProperty("biz_scene")]
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonProperty("operator_context")]
        [XmlElement("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 外部业务id，请尽量保持足够的复杂，方便定位数据来源
        /// </summary>
        [JsonProperty("out_request_no")]
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 当前页码，默认：“1”
        /// </summary>
        [JsonProperty("page_index")]
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 每页项数[1, 500]， 默认500
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 智能营销方案的方案id（template_code替代该值，无需传递）
        /// </summary>
        [JsonProperty("plan_id")]
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 结合biz_scene一起使用,值为RENEWAL_OLD:原方案续期、RENEWAL_NEW:新方案续期,要求必传
        /// </summary>
        [JsonProperty("promo_id")]
        [XmlElement("promo_id")]
        public string PromoId { get; set; }

        /// <summary>
        /// 营销模板的编号，默认GENERAL_EXPERIENCE（不传值）  可选枚举：  GENERAL_EXPERIENCE：全场体验；  GENERAL_NORMAL：全场普通；  GENERAL_20171212：全场2017双12版；  CROWD_EXPERIENCE：千人千券体验；  CROWD_NORMAL：千人千券普通；  CROWD_20171212：千人千券2017双12版；
        /// </summary>
        [JsonProperty("template_code")]
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
