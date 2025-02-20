// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryClusterDetailResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryClusterDetailResponseBodyData Data { get; set; }
        public class QueryClusterDetailResponseBodyData : TeaModel {
            [NameInMap("AclEntryList")]
            [Validation(Required=false)]
            public string AclEntryList { get; set; }
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }
            [NameInMap("ClusterAliasName")]
            [Validation(Required=false)]
            public string ClusterAliasName { get; set; }
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }
            [NameInMap("ClusterSpecification")]
            [Validation(Required=false)]
            public string ClusterSpecification { get; set; }
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }
            [NameInMap("ClusterVersion")]
            [Validation(Required=false)]
            public string ClusterVersion { get; set; }
            [NameInMap("ConnectionType")]
            [Validation(Required=false)]
            public string ConnectionType { get; set; }
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("DiskCapacity")]
            [Validation(Required=false)]
            public long? DiskCapacity { get; set; }
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }
            [NameInMap("InitCostTime")]
            [Validation(Required=false)]
            public long? InitCostTime { get; set; }
            [NameInMap("InitStatus")]
            [Validation(Required=false)]
            public string InitStatus { get; set; }
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("InstanceModels")]
            [Validation(Required=false)]
            public List<QueryClusterDetailResponseBodyDataInstanceModels> InstanceModels { get; set; }
            public class QueryClusterDetailResponseBodyDataInstanceModels : TeaModel {
                public string CreationTimestamp { get; set; }
                public string HealthStatus { get; set; }
                public string InternetIp { get; set; }
                public string Ip { get; set; }
                public string PodName { get; set; }
                public string Role { get; set; }
                public string SingleTunnelVip { get; set; }
                public string Zone { get; set; }
            }
            [NameInMap("InternetAddress")]
            [Validation(Required=false)]
            public string InternetAddress { get; set; }
            [NameInMap("InternetDomain")]
            [Validation(Required=false)]
            public string InternetDomain { get; set; }
            [NameInMap("InternetPort")]
            [Validation(Required=false)]
            public string InternetPort { get; set; }
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }
            [NameInMap("IntranetDomain")]
            [Validation(Required=false)]
            public string IntranetDomain { get; set; }
            [NameInMap("IntranetPort")]
            [Validation(Required=false)]
            public string IntranetPort { get; set; }
            [NameInMap("MemoryCapacity")]
            [Validation(Required=false)]
            public long? MemoryCapacity { get; set; }
            [NameInMap("MseVersion")]
            [Validation(Required=false)]
            public string MseVersion { get; set; }
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }
            [NameInMap("OrderClusterVersion")]
            [Validation(Required=false)]
            public string OrderClusterVersion { get; set; }
            [NameInMap("PayInfo")]
            [Validation(Required=false)]
            public string PayInfo { get; set; }
            [NameInMap("PubNetworkFlow")]
            [Validation(Required=false)]
            public string PubNetworkFlow { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
