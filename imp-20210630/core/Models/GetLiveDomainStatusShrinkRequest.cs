// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetLiveDomainStatusShrinkRequest : TeaModel {
        /// <summary>
        /// 应用唯一标识
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 直播域名列表
        /// </summary>
        [NameInMap("LiveDomainList")]
        [Validation(Required=false)]
        public string LiveDomainListShrink { get; set; }

    }

}