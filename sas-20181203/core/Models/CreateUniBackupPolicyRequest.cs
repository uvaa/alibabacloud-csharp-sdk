// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateUniBackupPolicyRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        [NameInMap("DatabaseType")]
        [Validation(Required=false)]
        public string DatabaseType { get; set; }

        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        [NameInMap("SpeedLimiter")]
        [Validation(Required=false)]
        public long? SpeedLimiter { get; set; }

        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        [NameInMap("DatabaseAddByUser")]
        [Validation(Required=false)]
        public string DatabaseAddByUser { get; set; }

        [NameInMap("UniRegionId")]
        [Validation(Required=false)]
        public string UniRegionId { get; set; }

        [NameInMap("FullPlan")]
        [Validation(Required=false)]
        public Dictionary<string, object> FullPlan { get; set; }

        [NameInMap("IncPlan")]
        [Validation(Required=false)]
        public Dictionary<string, object> IncPlan { get; set; }

    }

}