// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAntiBruteForceRulesResponseBody : TeaModel {
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeAntiBruteForceRulesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeAntiBruteForceRulesResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeAntiBruteForceRulesResponseBodyRules> Rules { get; set; }
        public class DescribeAntiBruteForceRulesResponseBodyRules : TeaModel {
            [NameInMap("DefaultRule")]
            [Validation(Required=false)]
            public bool? DefaultRule { get; set; }

            [NameInMap("EnableSmartRule")]
            [Validation(Required=false)]
            public bool? EnableSmartRule { get; set; }

            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            [NameInMap("ForbiddenTime")]
            [Validation(Required=false)]
            public int? ForbiddenTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("MachineCount")]
            [Validation(Required=false)]
            public int? MachineCount { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Span")]
            [Validation(Required=false)]
            public int? Span { get; set; }

            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

        }

    }

}
