// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeEipAddressesResponseBody : TeaModel {
        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public DescribeEipAddressesResponseBodyEipAddresses EipAddresses { get; set; }
        public class DescribeEipAddressesResponseBodyEipAddresses : TeaModel {
            [NameInMap("EipAddress")]
            [Validation(Required=false)]
            public List<DescribeEipAddressesResponseBodyEipAddressesEipAddress> EipAddress { get; set; }
            public class DescribeEipAddressesResponseBodyEipAddressesEipAddress : TeaModel {
                public string AllocationId { get; set; }
                public string AllocationTime { get; set; }
                public string Bandwidth { get; set; }
                public string ChargeType { get; set; }
                public string EipBandwidth { get; set; }
                public string ExpiredTime { get; set; }
                public string InstanceId { get; set; }
                public string InstanceType { get; set; }
                public string InternetChargeType { get; set; }
                public string IpAddress { get; set; }
                public DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocks OperationLocks { get; set; }
                public class DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocks : TeaModel {
                    [NameInMap("LockReason")]
                    [Validation(Required=false)]
                    public List<DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocksLockReason> LockReason { get; set; }
                    public class DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocksLockReason : TeaModel {
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }
                public string RegionId { get; set; }
                public string Status { get; set; }
            }
        };

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
