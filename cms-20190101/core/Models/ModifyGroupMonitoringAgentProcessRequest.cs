// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyGroupMonitoringAgentProcessRequest : TeaModel {
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<ModifyGroupMonitoringAgentProcessRequestAlertConfig> AlertConfig { get; set; }
        public class ModifyGroupMonitoringAgentProcessRequestAlertConfig : TeaModel {
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            [NameInMap("EscalationsLevel")]
            [Validation(Required=false)]
            public string EscalationsLevel { get; set; }

            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public string SilenceTime { get; set; }

            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

            [NameInMap("Times")]
            [Validation(Required=false)]
            public string Times { get; set; }

            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("MatchExpressFilterRelation")]
        [Validation(Required=false)]
        public string MatchExpressFilterRelation { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
