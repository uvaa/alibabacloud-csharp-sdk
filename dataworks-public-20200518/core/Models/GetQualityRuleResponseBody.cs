// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetQualityRuleResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityRuleResponseBodyData Data { get; set; }
        public class GetQualityRuleResponseBodyData : TeaModel {
            [NameInMap("BlockType")]
            [Validation(Required=false)]
            public int? BlockType { get; set; }
            [NameInMap("OnDutyAccountName")]
            [Validation(Required=false)]
            public string OnDutyAccountName { get; set; }
            [NameInMap("WarningThreshold")]
            [Validation(Required=false)]
            public string WarningThreshold { get; set; }
            [NameInMap("Property")]
            [Validation(Required=false)]
            public string Property { get; set; }
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public int? RuleType { get; set; }
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }
            [NameInMap("OnDuty")]
            [Validation(Required=false)]
            public string OnDuty { get; set; }
            [NameInMap("Checker")]
            [Validation(Required=false)]
            public int? Checker { get; set; }
            [NameInMap("FixCheck")]
            [Validation(Required=false)]
            public bool? FixCheck { get; set; }
            [NameInMap("MethodId")]
            [Validation(Required=false)]
            public int? MethodId { get; set; }
            [NameInMap("CriticalThreshold")]
            [Validation(Required=false)]
            public string CriticalThreshold { get; set; }
            [NameInMap("PredictType")]
            [Validation(Required=false)]
            public int? PredictType { get; set; }
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }
            [NameInMap("CheckerName")]
            [Validation(Required=false)]
            public string CheckerName { get; set; }
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }
            [NameInMap("MethodName")]
            [Validation(Required=false)]
            public string MethodName { get; set; }
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public long? EntityId { get; set; }
            [NameInMap("WhereCondition")]
            [Validation(Required=false)]
            public string WhereCondition { get; set; }
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }
            [NameInMap("ExpectValue")]
            [Validation(Required=false)]
            public string ExpectValue { get; set; }
            [NameInMap("Trend")]
            [Validation(Required=false)]
            public string Trend { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public int? TemplateId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
        };

    }

}