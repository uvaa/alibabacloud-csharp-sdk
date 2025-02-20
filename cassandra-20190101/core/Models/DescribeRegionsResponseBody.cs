// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeRegionsResponseBodyRegionsRegion : TeaModel {
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public List<DescribeRegionsResponseBodyRegionsRegionZone> Zone { get; set; }
                public class DescribeRegionsResponseBodyRegionsRegionZone : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }

            }
        };

    }

}
