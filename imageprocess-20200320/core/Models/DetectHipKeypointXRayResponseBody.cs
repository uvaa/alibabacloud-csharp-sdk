// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectHipKeypointXRayResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectHipKeypointXRayResponseBodyData Data { get; set; }
        public class DetectHipKeypointXRayResponseBodyData : TeaModel {
            [NameInMap("KeyPoints")]
            [Validation(Required=false)]
            public List<DetectHipKeypointXRayResponseBodyDataKeyPoints> KeyPoints { get; set; }
            public class DetectHipKeypointXRayResponseBodyDataKeyPoints : TeaModel {
                public float? Value { get; set; }
                public List<string> Coordinates { get; set; }
                public DetectHipKeypointXRayResponseBodyDataKeyPointsTag Tag { get; set; }
                public class DetectHipKeypointXRayResponseBodyDataKeyPointsTag : TeaModel {
                    [NameInMap("Direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }
            }
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }
            [NameInMap("OrgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }
        };

    }

}