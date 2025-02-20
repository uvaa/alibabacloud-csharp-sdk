// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateSCIMServerCredentialStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SCIMServerCredential")]
        [Validation(Required=false)]
        public UpdateSCIMServerCredentialStatusResponseBodySCIMServerCredential SCIMServerCredential { get; set; }
        public class UpdateSCIMServerCredentialStatusResponseBodySCIMServerCredential : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }
            [NameInMap("CredentialType")]
            [Validation(Required=false)]
            public string CredentialType { get; set; }
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

    }

}
