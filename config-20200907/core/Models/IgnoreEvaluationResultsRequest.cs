// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class IgnoreEvaluationResultsRequest : TeaModel {
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        [NameInMap("IgnoreDate")]
        [Validation(Required=false)]
        public string IgnoreDate { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<IgnoreEvaluationResultsRequestResources> Resources { get; set; }
        public class IgnoreEvaluationResultsRequestResources : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("ResourceAccountId")]
            [Validation(Required=false)]
            public long? ResourceAccountId { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
