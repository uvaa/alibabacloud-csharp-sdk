// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateConfigRuleEvaluationResultsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResults EvaluationResults { get; set; }
        public class ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResults : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("EvaluationResultList")]
            [Validation(Required=false)]
            public List<ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList> EvaluationResultList { get; set; }
            public class ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList : TeaModel {
                public int? RiskLevel { get; set; }
                public string ComplianceType { get; set; }
                public long? ResultRecordedTimestamp { get; set; }
                public string Annotation { get; set; }
                public long? ConfigRuleInvokedTimestamp { get; set; }
                public string InvokingEventMessageType { get; set; }
                public ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier EvaluationResultIdentifier { get; set; }
                public class ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier : TeaModel {
                    [NameInMap("OrderingTimestamp")]
                    [Validation(Required=false)]
                    public long? OrderingTimestamp { get; set; }

                    [NameInMap("EvaluationResultQualifier")]
                    [Validation(Required=false)]
                    public ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier EvaluationResultQualifier { get; set; }
                    public class ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier : TeaModel {
                        [NameInMap("ResourceOwnerId")]
                        [Validation(Required=false)]
                        public long? ResourceOwnerId { get; set; }
                        [NameInMap("ConfigRuleArn")]
                        [Validation(Required=false)]
                        public string ConfigRuleArn { get; set; }
                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }
                        [NameInMap("ConfigRuleName")]
                        [Validation(Required=false)]
                        public string ConfigRuleName { get; set; }
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }
                        [NameInMap("ConfigRuleId")]
                        [Validation(Required=false)]
                        public string ConfigRuleId { get; set; }
                        [NameInMap("ResourceName")]
                        [Validation(Required=false)]
                        public string ResourceName { get; set; }
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }
                        [NameInMap("CompliancePackId")]
                        [Validation(Required=false)]
                        public string CompliancePackId { get; set; }
                    };

                }
                public bool? RemediationEnabled { get; set; }
            }
        };

    }

}