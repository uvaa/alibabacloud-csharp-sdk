// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class InterpolateVideoFrameResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public InterpolateVideoFrameResponseData Data { get; set; }
        public class InterpolateVideoFrameResponseData : TeaModel {
            [NameInMap("VideoURL")]
            [Validation(Required=true)]
            public string VideoURL { get; set; }
        };

    }

}