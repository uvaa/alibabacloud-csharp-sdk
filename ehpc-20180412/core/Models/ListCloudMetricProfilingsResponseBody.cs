// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCloudMetricProfilingsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Profilings")]
        [Validation(Required=false)]
        public List<ListCloudMetricProfilingsResponseBodyProfilings> Profilings { get; set; }
        public class ListCloudMetricProfilingsResponseBodyProfilings : TeaModel {
            [NameInMap("ProfilingId")]
            [Validation(Required=false)]
            public string ProfilingId { get; set; }

            [NameInMap("TriggerTime")]
            [Validation(Required=false)]
            public string TriggerTime { get; set; }

            [NameInMap("Pid")]
            [Validation(Required=false)]
            public int? Pid { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Freq")]
            [Validation(Required=false)]
            public int? Freq { get; set; }

        }

    }

}