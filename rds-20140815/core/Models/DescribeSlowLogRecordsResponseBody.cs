// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("SQLSlowRecord")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyItemsSQLSlowRecord> SQLSlowRecord { get; set; }
            public class DescribeSlowLogRecordsResponseBodyItemsSQLSlowRecord : TeaModel {
                public string ApplicationName { get; set; }
                public string ClientHostName { get; set; }
                public long? CpuTime { get; set; }
                public string DBName { get; set; }
                public string ExecutionStartTime { get; set; }
                public string HostAddress { get; set; }
                public long? LastRowsAffectedCount { get; set; }
                public long? LockTimes { get; set; }
                public long? LogicalIORead { get; set; }
                public long? ParseRowCounts { get; set; }
                public long? PhysicalIORead { get; set; }
                public long? QueryTimeMS { get; set; }
                public long? QueryTimes { get; set; }
                public long? ReturnRowCounts { get; set; }
                public long? RowsAffectedCount { get; set; }
                public string SQLHash { get; set; }
                public string SQLText { get; set; }
                public string UserName { get; set; }
                public long? WriteIOCount { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
