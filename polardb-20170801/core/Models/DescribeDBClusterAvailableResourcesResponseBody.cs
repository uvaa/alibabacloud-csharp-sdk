// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAvailableResourcesResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeDBClusterAvailableResourcesResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeDBClusterAvailableResourcesResponseBodyAvailableZones : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SupportedEngines")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAvailableResourcesResponseBodyAvailableZonesSupportedEngines> SupportedEngines { get; set; }
            public class DescribeDBClusterAvailableResourcesResponseBodyAvailableZonesSupportedEngines : TeaModel {
                [NameInMap("AvailableResources")]
                [Validation(Required=false)]
                public List<DescribeDBClusterAvailableResourcesResponseBodyAvailableZonesSupportedEnginesAvailableResources> AvailableResources { get; set; }
                public class DescribeDBClusterAvailableResourcesResponseBodyAvailableZonesSupportedEnginesAvailableResources : TeaModel {
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("DBNodeClass")]
                    [Validation(Required=false)]
                    public string DBNodeClass { get; set; }

                }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

            }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
