// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            [NameInMap("AcceleratorType")]
            [Validation(Required=false)]
            public string AcceleratorType { get; set; }

            [NameInMap("Accessibility")]
            [Validation(Required=false)]
            public string Accessibility { get; set; }

            [NameInMap("AccumulatedRunningTimeInMs")]
            [Validation(Required=false)]
            public long? AccumulatedRunningTimeInMs { get; set; }

            [NameInMap("Datasets")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesDatasets> Datasets { get; set; }
            public class ListInstancesResponseBodyInstancesDatasets : TeaModel {
                [NameInMap("DatasetId")]
                [Validation(Required=false)]
                public string DatasetId { get; set; }

                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

            }

            [NameInMap("EcsSpec")]
            [Validation(Required=false)]
            public string EcsSpec { get; set; }

            [NameInMap("EnvironmentVariables")]
            [Validation(Required=false)]
            public Dictionary<string, string> EnvironmentVariables { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceShutdownTimer")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesInstanceShutdownTimer InstanceShutdownTimer { get; set; }
            public class ListInstancesResponseBodyInstancesInstanceShutdownTimer : TeaModel {
                [NameInMap("DueTime")]
                [Validation(Required=false)]
                public string DueTime { get; set; }
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }
                [NameInMap("GmtModifiedTime")]
                [Validation(Required=false)]
                public string GmtModifiedTime { get; set; }
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }
                [NameInMap("RemainingTimeInMs")]
                [Validation(Required=false)]
                public long? RemainingTimeInMs { get; set; }
            };

            [NameInMap("InstanceUrl")]
            [Validation(Required=false)]
            public string InstanceUrl { get; set; }

            [NameInMap("JupyterlabUrl")]
            [Validation(Required=false)]
            public string JupyterlabUrl { get; set; }

            [NameInMap("LatestSnapshot")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesLatestSnapshot LatestSnapshot { get; set; }
            public class ListInstancesResponseBodyInstancesLatestSnapshot : TeaModel {
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }
                [NameInMap("GmtModifiedTime")]
                [Validation(Required=false)]
                public string GmtModifiedTime { get; set; }
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }
                [NameInMap("RepositoryUrl")]
                [Validation(Required=false)]
                public string RepositoryUrl { get; set; }
            };

            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            [NameInMap("ReasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            [NameInMap("RequestedResource")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesRequestedResource RequestedResource { get; set; }
            public class ListInstancesResponseBodyInstancesRequestedResource : TeaModel {
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public string CPU { get; set; }
                [NameInMap("GPU")]
                [Validation(Required=false)]
                public string GPU { get; set; }
                [NameInMap("GPUType")]
                [Validation(Required=false)]
                public string GPUType { get; set; }
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }
                [NameInMap("SharedMemory")]
                [Validation(Required=false)]
                public string SharedMemory { get; set; }
            };

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TerminalUrl")]
            [Validation(Required=false)]
            public string TerminalUrl { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("UserVpc")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesUserVpc UserVpc { get; set; }
            public class ListInstancesResponseBodyInstancesUserVpc : TeaModel {
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }
            };

            [NameInMap("WebIDEUrl")]
            [Validation(Required=false)]
            public string WebIDEUrl { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
