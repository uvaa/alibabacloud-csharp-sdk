// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedBlockStorageClustersResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DedicatedBlockStorageClusters")]
        [Validation(Required=false)]
        public DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClusters DedicatedBlockStorageClusters { get; set; }
        public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClusters : TeaModel {
            [NameInMap("DedicatedBlockStorageCluster")]
            [Validation(Required=false)]
            public List<DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageCluster> DedicatedBlockStorageCluster { get; set; }
            public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageCluster : TeaModel {
                public string Status { get; set; }
                public string PerformanceLevel { get; set; }
                public string Description { get; set; }
                public string ExpiredTime { get; set; }
                public string CreateTime { get; set; }
                public string ZoneId { get; set; }
                public string Category { get; set; }
                public string DedicatedBlockStorageClusterName { get; set; }
                public string DedicatedBlockStorageClusterId { get; set; }
                public DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageClusterDedicatedBlockStorageClusterCapacity DedicatedBlockStorageClusterCapacity { get; set; }
                public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageClusterDedicatedBlockStorageClusterCapacity : TeaModel {
                    [NameInMap("TotalCapacity")]
                    [Validation(Required=false)]
                    public long? TotalCapacity { get; set; }

                    [NameInMap("AvailableCapacity")]
                    [Validation(Required=false)]
                    public long? AvailableCapacity { get; set; }

                }
            }
        };

    }

}