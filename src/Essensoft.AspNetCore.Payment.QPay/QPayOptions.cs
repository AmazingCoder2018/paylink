﻿namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayOptions
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// API秘钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// API证书文件 文件路径或文件的Base64串
        /// </summary>
        public string Certificate { get; set; }
    }
}
