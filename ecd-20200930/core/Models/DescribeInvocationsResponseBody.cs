// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public List<DescribeInvocationsResponseBodyInvocations> Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("InvocationStatus")]
            [Validation(Required=false)]
            public string InvocationStatus { get; set; }

            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

            [NameInMap("CommandType")]
            [Validation(Required=false)]
            public string CommandType { get; set; }

            [NameInMap("CommandContent")]
            [Validation(Required=false)]
            public string CommandContent { get; set; }

            [NameInMap("InvokeDesktops")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvokeDesktops> InvokeDesktops { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvokeDesktops : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("Repeats")]
                [Validation(Required=false)]
                public int? Repeats { get; set; }

                [NameInMap("DesktopId")]
                [Validation(Required=false)]
                public string DesktopId { get; set; }

                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

                [NameInMap("Dropped")]
                [Validation(Required=false)]
                public int? Dropped { get; set; }

                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                [NameInMap("ExitCode")]
                [Validation(Required=false)]
                public long? ExitCode { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("ErrorInfo")]
                [Validation(Required=false)]
                public string ErrorInfo { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

            }

        }

    }

}