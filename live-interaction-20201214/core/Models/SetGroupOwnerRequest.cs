// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class SetGroupOwnerRequest : TeaModel {
        /// <summary>
        /// App ID，IMPaaS租户的ID
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 群主转让的请求体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public SetGroupOwnerRequestRequestParams RequestParams { get; set; }
        public class SetGroupOwnerRequestRequestParams : TeaModel {
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("NewOwnerAppUid")]
            [Validation(Required=false)]
            public string NewOwnerAppUid { get; set; }
        };

    }

}