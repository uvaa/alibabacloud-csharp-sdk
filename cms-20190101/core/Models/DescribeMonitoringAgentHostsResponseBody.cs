// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentHostsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public DescribeMonitoringAgentHostsResponseBodyHosts Hosts { get; set; }
        public class DescribeMonitoringAgentHostsResponseBodyHosts : TeaModel {
            [NameInMap("Host")]
            [Validation(Required=false)]
            public List<DescribeMonitoringAgentHostsResponseBodyHostsHost> Host { get; set; }
            public class DescribeMonitoringAgentHostsResponseBodyHostsHost : TeaModel {
                public string AgentVersion { get; set; }
                public long? AliUid { get; set; }
                public string EipAddress { get; set; }
                public string EipId { get; set; }
                public string HostName { get; set; }
                public string InstanceId { get; set; }
                public string InstanceTypeFamily { get; set; }
                public string IpGroup { get; set; }
                public string NatIp { get; set; }
                public string NetworkType { get; set; }
                public string OperatingSystem { get; set; }
                public string Region { get; set; }
                public string SerialNumber { get; set; }
                public bool? IsAliyunHost { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageTotal")]
        [Validation(Required=false)]
        public int? PageTotal { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
