// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiskMonitorDataResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public List<DescribeDiskMonitorDataResponseBodyMonitorData> MonitorData { get; set; }
        public class DescribeDiskMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("BPSRead")]
            [Validation(Required=false)]
            public int? BPSRead { get; set; }

            [NameInMap("IOPSRead")]
            [Validation(Required=false)]
            public int? IOPSRead { get; set; }

            [NameInMap("LatencyRead")]
            [Validation(Required=false)]
            public int? LatencyRead { get; set; }

            [NameInMap("BPSTotal")]
            [Validation(Required=false)]
            public int? BPSTotal { get; set; }

            [NameInMap("IOPSTotal")]
            [Validation(Required=false)]
            public int? IOPSTotal { get; set; }

            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            [NameInMap("LatencyWrite")]
            [Validation(Required=false)]
            public int? LatencyWrite { get; set; }

            [NameInMap("IOPSWrite")]
            [Validation(Required=false)]
            public int? IOPSWrite { get; set; }

            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            [NameInMap("BPSWrite")]
            [Validation(Required=false)]
            public int? BPSWrite { get; set; }

        }

    }

}