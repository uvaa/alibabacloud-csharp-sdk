// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackResponseBody : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public string DeletionProtection { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        [NameInMap("DriftDetectionTime")]
        [Validation(Required=false)]
        public string DriftDetectionTime { get; set; }

        [NameInMap("Interface")]
        [Validation(Required=false)]
        public string Interface { get; set; }

        [NameInMap("Log")]
        [Validation(Required=false)]
        public GetStackResponseBodyLog Log { get; set; }
        public class GetStackResponseBodyLog : TeaModel {
            [NameInMap("ResourceLogs")]
            [Validation(Required=false)]
            public List<GetStackResponseBodyLogResourceLogs> ResourceLogs { get; set; }
            public class GetStackResponseBodyLogResourceLogs : TeaModel {
                public List<GetStackResponseBodyLogResourceLogsLogs> Logs { get; set; }
                public class GetStackResponseBodyLogResourceLogsLogs : TeaModel {
                    public string Content { get; set; }
                    public List<string> Keys { get; set; }
                }
                public string ResourceName { get; set; }
            }
            [NameInMap("TerraformLogs")]
            [Validation(Required=false)]
            public List<GetStackResponseBodyLogTerraformLogs> TerraformLogs { get; set; }
            public class GetStackResponseBodyLogTerraformLogs : TeaModel {
                public string Command { get; set; }
                public string Content { get; set; }
                public string Stream { get; set; }
            }
        };

        [NameInMap("NotificationURLs")]
        [Validation(Required=false)]
        public List<string> NotificationURLs { get; set; }

        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Outputs { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetStackResponseBodyParameters> Parameters { get; set; }
        public class GetStackResponseBodyParameters : TeaModel {
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        [NameInMap("ParentStackId")]
        [Validation(Required=false)]
        public string ParentStackId { get; set; }

        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceProgress")]
        [Validation(Required=false)]
        public GetStackResponseBodyResourceProgress ResourceProgress { get; set; }
        public class GetStackResponseBodyResourceProgress : TeaModel {
            [NameInMap("FailedResourceCount")]
            [Validation(Required=false)]
            public int? FailedResourceCount { get; set; }
            [NameInMap("InProgressResourceCount")]
            [Validation(Required=false)]
            public int? InProgressResourceCount { get; set; }
            [NameInMap("InProgressResourceDetails")]
            [Validation(Required=false)]
            public List<GetStackResponseBodyResourceProgressInProgressResourceDetails> InProgressResourceDetails { get; set; }
            public class GetStackResponseBodyResourceProgressInProgressResourceDetails : TeaModel {
                public float? ProgressTargetValue { get; set; }
                public float? ProgressValue { get; set; }
                public string ResourceName { get; set; }
                public string ResourceType { get; set; }
            }
            [NameInMap("PendingResourceCount")]
            [Validation(Required=false)]
            public int? PendingResourceCount { get; set; }
            [NameInMap("SuccessResourceCount")]
            [Validation(Required=false)]
            public int? SuccessResourceCount { get; set; }
            [NameInMap("TotalResourceCount")]
            [Validation(Required=false)]
            public int? TotalResourceCount { get; set; }
        };

        [NameInMap("RootStackId")]
        [Validation(Required=false)]
        public string RootStackId { get; set; }

        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("StackDriftStatus")]
        [Validation(Required=false)]
        public string StackDriftStatus { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        [NameInMap("StackType")]
        [Validation(Required=false)]
        public string StackType { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetStackResponseBodyTags> Tags { get; set; }
        public class GetStackResponseBodyTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TemplateDescription")]
        [Validation(Required=false)]
        public string TemplateDescription { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public int? TimeoutInMinutes { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
