// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeCollectorResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeCollectorResponseBodyResult Result { get; set; }
        public class DescribeCollectorResponseBodyResult : TeaModel {
            [NameInMap("collectorPaths")]
            [Validation(Required=false)]
            public List<string> CollectorPaths { get; set; }
            [NameInMap("configs")]
            [Validation(Required=false)]
            public List<DescribeCollectorResponseBodyResultConfigs> Configs { get; set; }
            public class DescribeCollectorResponseBodyResultConfigs : TeaModel {
                public string Content { get; set; }
                public string FileName { get; set; }
            }
            [NameInMap("dryRun")]
            [Validation(Required=false)]
            public bool? DryRun { get; set; }
            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<DescribeCollectorResponseBodyResultExtendConfigs> ExtendConfigs { get; set; }
            public class DescribeCollectorResponseBodyResultExtendConfigs : TeaModel {
                public string ConfigType { get; set; }
                public bool? EnableMonitoring { get; set; }
                public string GroupId { get; set; }
                public string Host { get; set; }
                public List<string> Hosts { get; set; }
                public string InstanceId { get; set; }
                public string InstanceType { get; set; }
                public string KibanaHost { get; set; }
                public List<DescribeCollectorResponseBodyResultExtendConfigsMachines> Machines { get; set; }
                public class DescribeCollectorResponseBodyResultExtendConfigsMachines : TeaModel {
                    public string AgentStatus { get; set; }
                    public string InstanceId { get; set; }
                }
                public string Protocol { get; set; }
                public string SuccessPodsCount { get; set; }
                public string TotalPodsCount { get; set; }
                public string Type { get; set; }
                public string UserName { get; set; }
            }
            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }
            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }
            [NameInMap("resId")]
            [Validation(Required=false)]
            public string ResId { get; set; }
            [NameInMap("resType")]
            [Validation(Required=false)]
            public string ResType { get; set; }
            [NameInMap("resVersion")]
            [Validation(Required=false)]
            public string ResVersion { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
        };

    }

}
