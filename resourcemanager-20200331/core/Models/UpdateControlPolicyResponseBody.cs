// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateControlPolicyResponseBody : TeaModel {
        [NameInMap("ControlPolicy")]
        [Validation(Required=false)]
        public UpdateControlPolicyResponseBodyControlPolicy ControlPolicy { get; set; }
        public class UpdateControlPolicyResponseBodyControlPolicy : TeaModel {
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("EffectScope")]
            [Validation(Required=false)]
            public string EffectScope { get; set; }
            [NameInMap("AttachmentCount")]
            [Validation(Required=false)]
            public string AttachmentCount { get; set; }
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}