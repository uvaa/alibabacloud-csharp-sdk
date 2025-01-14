// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class EndConferenceRequest : TeaModel {
        [NameInMap("BearerTokenClientId")]
        [Validation(Required=false)]
        public string BearerTokenClientId { get; set; }

        [NameInMap("BearerTokenScope")]
        [Validation(Required=false)]
        public string BearerTokenScope { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
