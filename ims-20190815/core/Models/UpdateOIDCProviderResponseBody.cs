// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateOIDCProviderResponseBody : TeaModel {
        [NameInMap("OIDCProvider")]
        [Validation(Required=false)]
        public UpdateOIDCProviderResponseBodyOIDCProvider OIDCProvider { get; set; }
        public class UpdateOIDCProviderResponseBodyOIDCProvider : TeaModel {
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }
            [NameInMap("ClientIds")]
            [Validation(Required=false)]
            public string ClientIds { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Fingerprints")]
            [Validation(Required=false)]
            public string Fingerprints { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("IssuerUrl")]
            [Validation(Required=false)]
            public string IssuerUrl { get; set; }
            [NameInMap("OIDCProviderName")]
            [Validation(Required=false)]
            public string OIDCProviderName { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}