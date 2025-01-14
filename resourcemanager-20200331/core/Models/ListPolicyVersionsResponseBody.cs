// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListPolicyVersionsResponseBody : TeaModel {
        [NameInMap("PolicyVersions")]
        [Validation(Required=false)]
        public ListPolicyVersionsResponseBodyPolicyVersions PolicyVersions { get; set; }
        public class ListPolicyVersionsResponseBodyPolicyVersions : TeaModel {
            [NameInMap("PolicyVersion")]
            [Validation(Required=false)]
            public List<ListPolicyVersionsResponseBodyPolicyVersionsPolicyVersion> PolicyVersion { get; set; }
            public class ListPolicyVersionsResponseBodyPolicyVersionsPolicyVersion : TeaModel {
                public string CreateDate { get; set; }
                public bool? IsDefaultVersion { get; set; }
                public string VersionId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
