// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeInvocationsResponseBodyInvocations Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvocation : TeaModel {
                public string CommandContent { get; set; }
                public string CommandDescription { get; set; }
                public string CommandId { get; set; }
                public string CommandName { get; set; }
                public string CommandType { get; set; }
                public string CreationTime { get; set; }
                public string Frequency { get; set; }
                public string InvocationStatus { get; set; }
                public string InvokeId { get; set; }
                public DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstances InvokeInstances { get; set; }
                public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstances : TeaModel {
                    [NameInMap("InvokeInstance")]
                    [Validation(Required=false)]
                    public List<DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance> InvokeInstance { get; set; }
                    public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance : TeaModel {
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        [NameInMap("Dropped")]
                        [Validation(Required=false)]
                        public int? Dropped { get; set; }

                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        [NameInMap("ExitCode")]
                        [Validation(Required=false)]
                        public long? ExitCode { get; set; }

                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("InstanceInvokeStatus")]
                        [Validation(Required=false)]
                        public string InstanceInvokeStatus { get; set; }

                        [NameInMap("InvocationStatus")]
                        [Validation(Required=false)]
                        public string InvocationStatus { get; set; }

                        [NameInMap("Output")]
                        [Validation(Required=false)]
                        public string Output { get; set; }

                        [NameInMap("Repeats")]
                        [Validation(Required=false)]
                        public int? Repeats { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("StopTime")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                        [NameInMap("Timed")]
                        [Validation(Required=false)]
                        public bool? Timed { get; set; }

                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }
                public string InvokeStatus { get; set; }
                public string Parameters { get; set; }
                public string RepeatMode { get; set; }
                public bool? Timed { get; set; }
                public long? Timeout { get; set; }
                public string Username { get; set; }
                public string WorkingDir { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
