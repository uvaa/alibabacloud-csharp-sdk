// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateWatermarkResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WatermarkInfo")]
        [Validation(Required=false)]
        public UpdateWatermarkResponseBodyWatermarkInfo WatermarkInfo { get; set; }
        public class UpdateWatermarkResponseBodyWatermarkInfo : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("WatermarkConfig")]
            [Validation(Required=false)]
            public string WatermarkConfig { get; set; }
            [NameInMap("WatermarkId")]
            [Validation(Required=false)]
            public string WatermarkId { get; set; }
        };

    }

}
