// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class UpdateGroupMembersRoleShrinkRequest : TeaModel {
        /// <summary>
        /// App ID。IMPaaS租户的ID。
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 更新群成员角色请求体。
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public string RequestParamsShrink { get; set; }

    }

}
