// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregatorsResponseBody : TeaModel {
        [NameInMap("AggregatorsResult")]
        [Validation(Required=false)]
        public ListAggregatorsResponseBodyAggregatorsResult AggregatorsResult { get; set; }
        public class ListAggregatorsResponseBodyAggregatorsResult : TeaModel {
            [NameInMap("Aggregators")]
            [Validation(Required=false)]
            public List<ListAggregatorsResponseBodyAggregatorsResultAggregators> Aggregators { get; set; }
            public class ListAggregatorsResponseBodyAggregatorsResultAggregators : TeaModel {
                public long? AccountId { get; set; }
                public long? AggregatorAccountCount { get; set; }
                public long? AggregatorCreateTimestamp { get; set; }
                public string AggregatorId { get; set; }
                public string AggregatorName { get; set; }
                public int? AggregatorStatus { get; set; }
                public string AggregatorType { get; set; }
                public string Description { get; set; }
            }
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
