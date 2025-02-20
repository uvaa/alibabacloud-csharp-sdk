// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RetouchSkinAdvanceRequest : TeaModel {
        [NameInMap("ImageURLObject")]
        [Validation(Required=true)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("RetouchDegree")]
        [Validation(Required=false)]
        public float? RetouchDegree { get; set; }

        [NameInMap("WhiteningDegree")]
        [Validation(Required=false)]
        public float? WhiteningDegree { get; set; }

    }

}
