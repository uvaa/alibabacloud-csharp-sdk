// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class GenerateVideoCoverResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateVideoCoverResponseBodyData Data { get; set; }
        public class GenerateVideoCoverResponseBodyData : TeaModel {
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public List<GenerateVideoCoverResponseBodyDataOutputs> Outputs { get; set; }
            public class GenerateVideoCoverResponseBodyDataOutputs : TeaModel {
                public float? Confidence { get; set; }
                public string ImageURL { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
