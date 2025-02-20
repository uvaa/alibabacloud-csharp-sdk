// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypesResponseBody : TeaModel {
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public DescribeInstanceTypesResponseBodyInstanceTypes InstanceTypes { get; set; }
        public class DescribeInstanceTypesResponseBodyInstanceTypes : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public List<DescribeInstanceTypesResponseBodyInstanceTypesInstanceType> InstanceType { get; set; }
            public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceType : TeaModel {
                public int? BaselineCredit { get; set; }
                public int? CpuCoreCount { get; set; }
                public int? DiskQuantity { get; set; }
                public int? EniIpv6AddressQuantity { get; set; }
                public int? EniPrivateIpAddressQuantity { get; set; }
                public int? EniQuantity { get; set; }
                public int? EniTotalQuantity { get; set; }
                public bool? EniTrunkSupported { get; set; }
                public int? EriQuantity { get; set; }
                public int? GPUAmount { get; set; }
                public string GPUSpec { get; set; }
                public int? InitialCredit { get; set; }
                public int? InstanceBandwidthRx { get; set; }
                public int? InstanceBandwidthTx { get; set; }
                public string InstanceFamilyLevel { get; set; }
                public long? InstancePpsRx { get; set; }
                public long? InstancePpsTx { get; set; }
                public string InstanceTypeFamily { get; set; }
                public string InstanceTypeId { get; set; }
                public int? LocalStorageAmount { get; set; }
                public long? LocalStorageCapacity { get; set; }
                public string LocalStorageCategory { get; set; }
                public int? MaximumQueueNumberPerEni { get; set; }
                public float? MemorySize { get; set; }
                public string NvmeSupport { get; set; }
                public int? PrimaryEniQueueNumber { get; set; }
                public int? QueuePairNumber { get; set; }
                public int? SecondaryEniQueueNumber { get; set; }
                public int? TotalEniQueueQuantity { get; set; }
            }
        };

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
