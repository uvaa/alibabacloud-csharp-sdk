// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectHipKeypointXRayResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public DetectHipKeypointXRayResponseData Data { get; set; }
        public class DetectHipKeypointXRayResponseData : TeaModel {
            [NameInMap("ImageUrl")]
            [Validation(Required=true)]
            public string ImageUrl { get; set; }
            [NameInMap("OrgId")]
            [Validation(Required=true)]
            public string OrgId { get; set; }
            [NameInMap("OrgName")]
            [Validation(Required=true)]
            public string OrgName { get; set; }
            [NameInMap("KeyPoints")]
            [Validation(Required=true)]
            public List<DetectHipKeypointXRayResponseDataKeyPoints> KeyPoints { get; set; }
            public class DetectHipKeypointXRayResponseDataKeyPoints : TeaModel {
                public float? Value { get; set; }
                public DetectHipKeypointXRayResponseDataKeyPointsTag Tag { get; set; }
                public class DetectHipKeypointXRayResponseDataKeyPointsTag : TeaModel {
                    [NameInMap("Direction")]
                    [Validation(Required=true)]
                    public string Direction { get; set; }

                    [NameInMap("Label")]
                    [Validation(Required=true)]
                    public string Label { get; set; }

                }
                public List<string> Coordinates { get; set; }
            }
        };

    }

}