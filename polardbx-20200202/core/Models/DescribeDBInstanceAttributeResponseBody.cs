// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DBInstance")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyDBInstance DBInstance { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyDBInstance : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("RightsSeparationStatus")]
            [Validation(Required=false)]
            public string RightsSeparationStatus { get; set; }
            [NameInMap("DBNodeCount")]
            [Validation(Required=false)]
            public int? DBNodeCount { get; set; }
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public string Expired { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }
            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public long? StorageUsed { get; set; }
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }
            [NameInMap("DBInstanceType")]
            [Validation(Required=false)]
            public string DBInstanceType { get; set; }
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }
            [NameInMap("LatestMinorVersion")]
            [Validation(Required=false)]
            public string LatestMinorVersion { get; set; }
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }
            [NameInMap("RightsSeparationEnabled")]
            [Validation(Required=false)]
            public bool? RightsSeparationEnabled { get; set; }
            [NameInMap("VPCId")]
            [Validation(Required=false)]
            public string VPCId { get; set; }
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }
            [NameInMap("KindCode")]
            [Validation(Required=false)]
            public int? KindCode { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("DBNodes")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDBInstanceDBNodes> DBNodes { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDBInstanceDBNodes : TeaModel {
                public string ComputeNodeId { get; set; }
                public string NodeClass { get; set; }
                public string DataNodeId { get; set; }
                public string ZoneId { get; set; }
                public string Id { get; set; }
                public string RegionId { get; set; }
            }
            [NameInMap("ConnAddrs")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDBInstanceConnAddrs> ConnAddrs { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDBInstanceConnAddrs : TeaModel {
                public string Type { get; set; }
                public string VSwitchId { get; set; }
                public string Port { get; set; }
                public string VPCId { get; set; }
                public string ConnectionString { get; set; }
            }
            [NameInMap("ReadDBInstances")]
            [Validation(Required=false)]
            public List<string> ReadDBInstances { get; set; }
        };

    }

}