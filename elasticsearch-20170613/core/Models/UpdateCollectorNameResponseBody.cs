// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateCollectorNameResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateCollectorNameResponseBodyResult Result { get; set; }
        public class UpdateCollectorNameResponseBodyResult : TeaModel {
            [NameInMap("resId")]
            [Validation(Required=false)]
            public string ResId { get; set; }
            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }
            [NameInMap("dryRun")]
            [Validation(Required=false)]
            public bool? DryRun { get; set; }
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("resType")]
            [Validation(Required=false)]
            public string ResType { get; set; }
            [NameInMap("resVersion")]
            [Validation(Required=false)]
            public string ResVersion { get; set; }
            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("configs")]
            [Validation(Required=false)]
            public List<UpdateCollectorNameResponseBodyResultConfigs> Configs { get; set; }
            public class UpdateCollectorNameResponseBodyResultConfigs : TeaModel {
                public string Content { get; set; }
                public string FileName { get; set; }
            }
            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<UpdateCollectorNameResponseBodyResultExtendConfigs> ExtendConfigs { get; set; }
            public class UpdateCollectorNameResponseBodyResultExtendConfigs : TeaModel {
                public string SuccessPodsCount { get; set; }
                public string Protocol { get; set; }
                public string UserName { get; set; }
                public string TotalPodsCount { get; set; }
                public string Type { get; set; }
                public string KibanaHost { get; set; }
                public bool? EnableMonitoring { get; set; }
                public string ConfigType { get; set; }
                public string InstanceType { get; set; }
                public string GroupId { get; set; }
                public string Host { get; set; }
                public string InstanceId { get; set; }
                public List<UpdateCollectorNameResponseBodyResultExtendConfigsMachines> Machines { get; set; }
                public class UpdateCollectorNameResponseBodyResultExtendConfigsMachines : TeaModel {
                    public string AgentStatus { get; set; }
                    public string InstanceId { get; set; }
                }
                public List<string> Hosts { get; set; }
            }
            [NameInMap("collectorPaths")]
            [Validation(Required=false)]
            public List<string> CollectorPaths { get; set; }
        };

    }

}