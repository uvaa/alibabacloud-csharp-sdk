// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeDiagnosisSettingsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeDiagnosisSettingsResponseBodyResult Result { get; set; }
        public class DescribeDiagnosisSettingsResponseBodyResult : TeaModel {
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
        };

    }

}
