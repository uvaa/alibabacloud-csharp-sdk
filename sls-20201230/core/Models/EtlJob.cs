// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class EtlJob : TeaModel {
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("etlJobName")]
        [Validation(Required=false)]
        public string EtlJobName { get; set; }

        [NameInMap("functionConfig")]
        [Validation(Required=false)]
        public EtlJobFunctionConfig FunctionConfig { get; set; }
        public class EtlJobFunctionConfig : TeaModel {
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }
            [NameInMap("functionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }
            [NameInMap("functionProvider")]
            [Validation(Required=false)]
            public string FunctionProvider { get; set; }
            [NameInMap("regionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }
            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }
        };

        [NameInMap("functionParameter")]
        [Validation(Required=false)]
        public Dictionary<string, object> FunctionParameter { get; set; }

        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public EtlJobLogConfig LogConfig { get; set; }
        public class EtlJobLogConfig : TeaModel {
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }
            [NameInMap("logstoreName")]
            [Validation(Required=false)]
            public string LogstoreName { get; set; }
            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }
        };

        [NameInMap("sourceConfig")]
        [Validation(Required=false)]
        public EtlJobSourceConfig SourceConfig { get; set; }
        public class EtlJobSourceConfig : TeaModel {
            [NameInMap("logstoreName")]
            [Validation(Required=false)]
            public string LogstoreName { get; set; }
        };

        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public EtlJobTriggerConfig TriggerConfig { get; set; }
        public class EtlJobTriggerConfig : TeaModel {
            [NameInMap("maxRetryTime")]
            [Validation(Required=false)]
            public int? MaxRetryTime { get; set; }
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }
            [NameInMap("startingPosition")]
            [Validation(Required=false)]
            public string StartingPosition { get; set; }
            [NameInMap("startingUnixtime")]
            [Validation(Required=false)]
            public long? StartingUnixtime { get; set; }
            [NameInMap("triggerInterval")]
            [Validation(Required=false)]
            public int? TriggerInterval { get; set; }
        };

    }

}
