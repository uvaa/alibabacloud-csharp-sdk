// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnCertificateSigningRequestResponseBody : TeaModel {
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        [NameInMap("PubMd5")]
        [Validation(Required=false)]
        public string PubMd5 { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
