// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeFlowInstanceResponseBody : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        [NameInMap("DependencyFlowList")]
        [Validation(Required=false)]
        public DescribeFlowInstanceResponseBodyDependencyFlowList DependencyFlowList { get; set; }
        public class DescribeFlowInstanceResponseBodyDependencyFlowList : TeaModel {
            [NameInMap("ParentFlow")]
            [Validation(Required=false)]
            public List<DescribeFlowInstanceResponseBodyDependencyFlowListParentFlow> ParentFlow { get; set; }
            public class DescribeFlowInstanceResponseBodyDependencyFlowListParentFlow : TeaModel {
                public long? BizDate { get; set; }
                public string DependencyFlowId { get; set; }
                public string DependencyInstanceId { get; set; }
                public string FlowId { get; set; }
                public string FlowInstanceId { get; set; }
                public bool? Meet { get; set; }
                public string ProjectId { get; set; }
                public string ScheduleKey { get; set; }
            }
        };

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("Graph")]
        [Validation(Required=false)]
        public string Graph { get; set; }

        [NameInMap("HasNodeFailed")]
        [Validation(Required=false)]
        public bool? HasNodeFailed { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Lifecycle")]
        [Validation(Required=false)]
        public string Lifecycle { get; set; }

        [NameInMap("LogArchiveLocation")]
        [Validation(Required=false)]
        public string LogArchiveLocation { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("NodeInstance")]
        [Validation(Required=false)]
        public DescribeFlowInstanceResponseBodyNodeInstance NodeInstance { get; set; }
        public class DescribeFlowInstanceResponseBodyNodeInstance : TeaModel {
            [NameInMap("NodeInstance")]
            [Validation(Required=false)]
            public List<DescribeFlowInstanceResponseBodyNodeInstanceNodeInstance> NodeInstance { get; set; }
            public class DescribeFlowInstanceResponseBodyNodeInstanceNodeInstance : TeaModel {
                public string ClusterId { get; set; }
                public long? Duration { get; set; }
                public long? EndTime { get; set; }
                public string ExternalId { get; set; }
                public string ExternalInfo { get; set; }
                public string ExternalStatus { get; set; }
                public string FailAct { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string HostName { get; set; }
                public string Id { get; set; }
                public string JobId { get; set; }
                public string JobName { get; set; }
                public string JobType { get; set; }
                public string MaxRetry { get; set; }
                public string NodeName { get; set; }
                public bool? Pending { get; set; }
                public string ProjectId { get; set; }
                public int? Retries { get; set; }
                public string RetryInterval { get; set; }
                public long? StartTime { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public long? ScheduleTime { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
