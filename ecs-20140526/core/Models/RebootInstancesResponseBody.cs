// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RebootInstancesResponseBody : TeaModel {
        [NameInMap("InstanceResponses")]
        [Validation(Required=false)]
        public RebootInstancesResponseBodyInstanceResponses InstanceResponses { get; set; }
        public class RebootInstancesResponseBodyInstanceResponses : TeaModel {
            [NameInMap("InstanceResponse")]
            [Validation(Required=false)]
            public List<RebootInstancesResponseBodyInstanceResponsesInstanceResponse> InstanceResponse { get; set; }
            public class RebootInstancesResponseBodyInstanceResponsesInstanceResponse : TeaModel {
                public string Code { get; set; }
                public string CurrentStatus { get; set; }
                public string InstanceId { get; set; }
                public string Message { get; set; }
                public string PreviousStatus { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
