// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteAggregateConfigRulesRequest : TeaModel {
        [NameInMap("ConfigRuleIds")]
        [Validation(Required=false)]
        public string ConfigRuleIds { get; set; }

        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

    }

}