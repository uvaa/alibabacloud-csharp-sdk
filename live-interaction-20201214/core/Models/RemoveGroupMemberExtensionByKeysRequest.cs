// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class RemoveGroupMemberExtensionByKeysRequest : TeaModel {
        /// <summary>
        /// App ID, IMPaaS租户的ID
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 删除群成员扩展信息的请求体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public RemoveGroupMemberExtensionByKeysRequestRequestParams RequestParams { get; set; }
        public class RemoveGroupMemberExtensionByKeysRequestRequestParams : TeaModel {
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("AppUid")]
            [Validation(Required=false)]
            public string AppUid { get; set; }
            [NameInMap("Keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }
        };

    }

}
