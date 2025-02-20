// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateQualityRuleRequest : TeaModel {
        [NameInMap("BlockType")]
        [Validation(Required=false)]
        public int? BlockType { get; set; }

        [NameInMap("Checker")]
        [Validation(Required=false)]
        public int? Checker { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("CriticalThreshold")]
        [Validation(Required=false)]
        public string CriticalThreshold { get; set; }

        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        [NameInMap("ExpectValue")]
        [Validation(Required=false)]
        public string ExpectValue { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("MethodName")]
        [Validation(Required=false)]
        public string MethodName { get; set; }

        [NameInMap("OpenSwitch")]
        [Validation(Required=false)]
        public bool? OpenSwitch { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("PredictType")]
        [Validation(Required=false)]
        public int? PredictType { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        [NameInMap("PropertyType")]
        [Validation(Required=false)]
        public string PropertyType { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public int? TemplateId { get; set; }

        [NameInMap("Trend")]
        [Validation(Required=false)]
        public string Trend { get; set; }

        [NameInMap("WarningThreshold")]
        [Validation(Required=false)]
        public string WarningThreshold { get; set; }

        [NameInMap("WhereCondition")]
        [Validation(Required=false)]
        public string WhereCondition { get; set; }

    }

}
