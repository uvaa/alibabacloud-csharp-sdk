// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class SetGroupMemberExtensionByKeysRequest : TeaModel {
        /// <summary>
        /// App ID, IMPaaS租户的ID
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 设置群成员扩展信息的请求体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public SetGroupMemberExtensionByKeysRequestRequestParams RequestParams { get; set; }
        public class SetGroupMemberExtensionByKeysRequestRequestParams : TeaModel {
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("AppUid")]
            [Validation(Required=false)]
            public string AppUid { get; set; }
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extensions { get; set; }
        };

    }

}
