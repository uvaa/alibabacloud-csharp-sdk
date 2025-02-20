// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNewProjectEipMonitorDataResponseBody : TeaModel {
        [NameInMap("EipMonitorDatas")]
        [Validation(Required=false)]
        public DescribeNewProjectEipMonitorDataResponseBodyEipMonitorDatas EipMonitorDatas { get; set; }
        public class DescribeNewProjectEipMonitorDataResponseBodyEipMonitorDatas : TeaModel {
            [NameInMap("EipMonitorData")]
            [Validation(Required=false)]
            public List<DescribeNewProjectEipMonitorDataResponseBodyEipMonitorDatasEipMonitorData> EipMonitorData { get; set; }
            public class DescribeNewProjectEipMonitorDataResponseBodyEipMonitorDatasEipMonitorData : TeaModel {
                public int? EipBandwidth { get; set; }
                public int? EipFlow { get; set; }
                public int? EipPackets { get; set; }
                public int? EipRX { get; set; }
                public int? EipTX { get; set; }
                public string TimeStamp { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
