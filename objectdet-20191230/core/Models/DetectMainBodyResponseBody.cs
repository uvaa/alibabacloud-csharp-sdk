// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectMainBodyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectMainBodyResponseBodyData Data { get; set; }
        public class DetectMainBodyResponseBodyData : TeaModel {
            [NameInMap("Location")]
            [Validation(Required=false)]
            public DetectMainBodyResponseBodyDataLocation Location { get; set; }
            public class DetectMainBodyResponseBodyDataLocation : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public int? X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public int? Y { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
