using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 发放代金券
    /// </summary>
    public class WeChatPaySendCouponRequest : IWeChatPayCertificateRequest<WeChatPaySendCouponResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 代金券批次id
        /// </summary>
        public string CouponStockId { get; set; }

        /// <summary>
        /// openid记录数
        /// </summary>
        public string OpenIdCount { get; set; }

        /// <summary>
        /// 商户单据号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 协议版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        public string Type { get; set; }

        #region IWeChatPayCertificateRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/send_coupon";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary()
            {
                { "appid", AppId },
                { "coupon_stock_id", CouponStockId },
                { "openid_count", OpenIdCount },
                { "partner_trade_no", PartnerTradeNo },
                { "openid", OpenId },
                { "op_user_id", OpUserId },
                { "device_info", DeviceInfo },
                { "version", Version },
                { "type", Type },
            };
            return parameters;
        }

        #endregion
    }
}
