// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAccessStrategiesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public List<DescribeGtmAccessStrategiesResponseBodyStrategies> Strategies { get; set; }
        public class DescribeGtmAccessStrategiesResponseBodyStrategies : TeaModel {
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public string AccessMode { get; set; }

            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            [NameInMap("DefaultAddrPoolMonitorStatus")]
            [Validation(Required=false)]
            public string DefaultAddrPoolMonitorStatus { get; set; }

            [NameInMap("StrategyMode")]
            [Validation(Required=false)]
            public string StrategyMode { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DefaultAddrPoolStatus")]
            [Validation(Required=false)]
            public string DefaultAddrPoolStatus { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Lines")]
            [Validation(Required=false)]
            public List<DescribeGtmAccessStrategiesResponseBodyStrategiesLines> Lines { get; set; }
            public class DescribeGtmAccessStrategiesResponseBodyStrategiesLines : TeaModel {
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

            }

            [NameInMap("FailoverAddrPoolId")]
            [Validation(Required=false)]
            public string FailoverAddrPoolId { get; set; }

            [NameInMap("DefaultAddrPoolId")]
            [Validation(Required=false)]
            public string DefaultAddrPoolId { get; set; }

            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public string StrategyId { get; set; }

            [NameInMap("FailoverAddrPoolStatus")]
            [Validation(Required=false)]
            public string FailoverAddrPoolStatus { get; set; }

            [NameInMap("AccessStatus")]
            [Validation(Required=false)]
            public string AccessStatus { get; set; }

            [NameInMap("FailoverAddrPoolMonitorStatus")]
            [Validation(Required=false)]
            public string FailoverAddrPoolMonitorStatus { get; set; }

            [NameInMap("DefaultAddrPoolName")]
            [Validation(Required=false)]
            public string DefaultAddrPoolName { get; set; }

            [NameInMap("FailoverAddrPoolName")]
            [Validation(Required=false)]
            public string FailoverAddrPoolName { get; set; }

            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

        }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

    }

}