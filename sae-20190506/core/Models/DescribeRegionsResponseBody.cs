// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeRegionsResponseBodyRegionsRegion : TeaModel {
                public string LocalName { get; set; }
                public DescribeRegionsResponseBodyRegionsRegionRecommendZones RecommendZones { get; set; }
                public class DescribeRegionsResponseBodyRegionsRegionRecommendZones : TeaModel {
                    [NameInMap("RecommendZone")]
                    [Validation(Required=false)]
                    public List<string> RecommendZone { get; set; }

                }
                public string RegionEndpoint { get; set; }
                public string RegionId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
