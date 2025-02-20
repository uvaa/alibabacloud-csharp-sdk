// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAcceleratorsResponseBody : TeaModel {
        [NameInMap("Accelerators")]
        [Validation(Required=false)]
        public List<ListAcceleratorsResponseBodyAccelerators> Accelerators { get; set; }
        public class ListAcceleratorsResponseBodyAccelerators : TeaModel {
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("BasicBandwidthPackage")]
            [Validation(Required=false)]
            public ListAcceleratorsResponseBodyAcceleratorsBasicBandwidthPackage BasicBandwidthPackage { get; set; }
            public class ListAcceleratorsResponseBodyAcceleratorsBasicBandwidthPackage : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }
                [NameInMap("BandwidthType")]
                [Validation(Required=false)]
                public string BandwidthType { get; set; }
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }
            };

            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("CrossDomainBandwidthPackage")]
            [Validation(Required=false)]
            public ListAcceleratorsResponseBodyAcceleratorsCrossDomainBandwidthPackage CrossDomainBandwidthPackage { get; set; }
            public class ListAcceleratorsResponseBodyAcceleratorsCrossDomainBandwidthPackage : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }
            };

            [NameInMap("DdosId")]
            [Validation(Required=false)]
            public string DdosId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DnsName")]
            [Validation(Required=false)]
            public string DnsName { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// 加速区配置
            /// </summary>
            [NameInMap("IpSetConfig")]
            [Validation(Required=false)]
            public ListAcceleratorsResponseBodyAcceleratorsIpSetConfig IpSetConfig { get; set; }
            public class ListAcceleratorsResponseBodyAcceleratorsIpSetConfig : TeaModel {
                [NameInMap("AccessMode")]
                [Validation(Required=false)]
                public string AccessMode { get; set; }
            };

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SecondDnsName")]
            [Validation(Required=false)]
            public string SecondDnsName { get; set; }

            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
