// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("RDSRegion")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsRDSRegion> RDSRegion { get; set; }
            public class DescribeRegionsResponseBodyRegionsRDSRegion : TeaModel {
                public string RegionId { get; set; }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
