// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AttachAppPolicyToIdentityResponseBody : TeaModel {
        [NameInMap("FailedPolicyNames")]
        [Validation(Required=false)]
        public List<string> FailedPolicyNames { get; set; }

        [NameInMap("NonExistPolicyNames")]
        [Validation(Required=false)]
        public List<string> NonExistPolicyNames { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
