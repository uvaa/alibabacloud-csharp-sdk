// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20200618.Models
{
    public class ElementSmartVerifyAdvanceRequest : TeaModel {
        [NameInMap("CertFileObject")]
        [Validation(Required=true)]
        public Stream CertFileObject { get; set; }

        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        [NameInMap("CertNationalEmblemUrl")]
        [Validation(Required=false)]
        public string CertNationalEmblemUrl { get; set; }

        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        [NameInMap("CertUrl")]
        [Validation(Required=false)]
        public string CertUrl { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

    }

}
