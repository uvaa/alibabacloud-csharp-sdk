// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class DeleteUserGroupRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("IsvSubId")]
        [Validation(Required=true)]
        public string IsvSubId { get; set; }

        [NameInMap("UserGroupId")]
        [Validation(Required=true)]
        public string UserGroupId { get; set; }

    }

}