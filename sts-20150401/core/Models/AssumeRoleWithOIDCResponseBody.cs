// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleWithOIDCResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OIDCTokenInfo")]
        [Validation(Required=false)]
        public AssumeRoleWithOIDCResponseBodyOIDCTokenInfo OIDCTokenInfo { get; set; }
        public class AssumeRoleWithOIDCResponseBodyOIDCTokenInfo : TeaModel {
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }
            [NameInMap("ClientIds")]
            [Validation(Required=false)]
            public string ClientIds { get; set; }
        };

        [NameInMap("AssumedRoleUser")]
        [Validation(Required=false)]
        public AssumeRoleWithOIDCResponseBodyAssumedRoleUser AssumedRoleUser { get; set; }
        public class AssumeRoleWithOIDCResponseBodyAssumedRoleUser : TeaModel {
            [NameInMap("AssumedRoleId")]
            [Validation(Required=false)]
            public string AssumedRoleId { get; set; }
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }
        };

        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public AssumeRoleWithOIDCResponseBodyCredentials Credentials { get; set; }
        public class AssumeRoleWithOIDCResponseBodyCredentials : TeaModel {
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }
        };

    }

}