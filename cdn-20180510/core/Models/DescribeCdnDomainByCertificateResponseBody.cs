// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainByCertificateResponseBody : TeaModel {
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeCdnDomainByCertificateResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeCdnDomainByCertificateResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeCdnDomainByCertificateResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeCdnDomainByCertificateResponseBodyCertInfosCertInfo : TeaModel {
                public string CertCaIsLegacy { get; set; }
                public string CertExpireTime { get; set; }
                public string CertExpired { get; set; }
                public string CertStartTime { get; set; }
                public string CertSubjectCommonName { get; set; }
                public string CertType { get; set; }
                public string DomainList { get; set; }
                public string DomainNames { get; set; }
                public string Issuer { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
