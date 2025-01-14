// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectObjectResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectObjectResponseBodyData Data { get; set; }
        public class DetectObjectResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectObjectResponseBodyDataElements> Elements { get; set; }
            public class DetectObjectResponseBodyDataElements : TeaModel {
                public List<string> Boxes { get; set; }
                public float? Score { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
