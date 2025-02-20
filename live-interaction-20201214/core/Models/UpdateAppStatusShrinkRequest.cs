// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class UpdateAppStatusShrinkRequest : TeaModel {
        /// <summary>
        /// 应用Id
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 请求
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public string RequestParamsShrink { get; set; }

    }

}
