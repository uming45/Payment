using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DiscountDstCampPrizeModel Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountDstCampPrizeModel : AlipayObject
    {
        /// <summary>
        /// 预算id,商户先调预算创建接口得到预算id,传入
        /// </summary>
        [JsonProperty("budget_id")]
        [XmlElement("budget_id")]
        public string BudgetId { get; set; }

        /// <summary>
        /// 折扣幅度必须为0.1到1之间的小数(保留小数点后2位)
        /// </summary>
        [JsonProperty("discount_rate")]
        [XmlElement("discount_rate")]
        public string DiscountRate { get; set; }

        /// <summary>
        /// 奖品id  修改传值 ，新增可以不传
        /// </summary>
        [JsonProperty("id")]
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 单次优惠上限(元),单笔上限金额只能填写数字，大于等于0，小数点后最多2位，整数部分不能超过10位
        /// </summary>
        [JsonProperty("max_discount_amt")]
        [XmlElement("max_discount_amt")]
        public string MaxDiscountAmt { get; set; }
    }
}
