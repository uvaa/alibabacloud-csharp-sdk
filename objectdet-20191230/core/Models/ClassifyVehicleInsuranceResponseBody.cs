// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class ClassifyVehicleInsuranceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClassifyVehicleInsuranceResponseBodyData Data { get; set; }
        public class ClassifyVehicleInsuranceResponseBodyData : TeaModel {
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ClassifyVehicleInsuranceResponseBodyDataLabels> Labels { get; set; }
            public class ClassifyVehicleInsuranceResponseBodyDataLabels : TeaModel {
                public string Name { get; set; }
                public float? Score { get; set; }
            }
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
