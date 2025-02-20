// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayUserTotalResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserPlayStatisTotals")]
        [Validation(Required=false)]
        public DescribePlayUserTotalResponseBodyUserPlayStatisTotals UserPlayStatisTotals { get; set; }
        public class DescribePlayUserTotalResponseBodyUserPlayStatisTotals : TeaModel {
            [NameInMap("UserPlayStatisTotal")]
            [Validation(Required=false)]
            public List<DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotal> UserPlayStatisTotal { get; set; }
            public class DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotal : TeaModel {
                public string Date { get; set; }
                public string PlayDuration { get; set; }
                public string PlayRange { get; set; }
                public DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotalUV UV { get; set; }
                public class DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotalUV : TeaModel {
                    [NameInMap("Android")]
                    [Validation(Required=false)]
                    public string Android { get; set; }

                    [NameInMap("Flash")]
                    [Validation(Required=false)]
                    public string Flash { get; set; }

                    [NameInMap("HTML5")]
                    [Validation(Required=false)]
                    public string HTML5 { get; set; }

                    [NameInMap("iOS")]
                    [Validation(Required=false)]
                    public string IOS { get; set; }

                }
                public DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotalVV VV { get; set; }
                public class DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotalVV : TeaModel {
                    [NameInMap("Android")]
                    [Validation(Required=false)]
                    public string Android { get; set; }

                    [NameInMap("Flash")]
                    [Validation(Required=false)]
                    public string Flash { get; set; }

                    [NameInMap("HTML5")]
                    [Validation(Required=false)]
                    public string HTML5 { get; set; }

                    [NameInMap("iOS")]
                    [Validation(Required=false)]
                    public string IOS { get; set; }

                }
            }
        };

    }

}
