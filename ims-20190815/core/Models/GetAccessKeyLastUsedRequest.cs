// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAccessKeyLastUsedRequest : TeaModel {
        [NameInMap("UserAccessKeyId")]
        [Validation(Required=false)]
        public string UserAccessKeyId { get; set; }

        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
