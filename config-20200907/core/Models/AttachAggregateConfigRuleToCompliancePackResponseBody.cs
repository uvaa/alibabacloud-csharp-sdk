// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class AttachAggregateConfigRuleToCompliancePackResponseBody : TeaModel {
        [NameInMap("OperateRuleResult")]
        [Validation(Required=false)]
        public AttachAggregateConfigRuleToCompliancePackResponseBodyOperateRuleResult OperateRuleResult { get; set; }
        public class AttachAggregateConfigRuleToCompliancePackResponseBodyOperateRuleResult : TeaModel {
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=false)]
            public List<AttachAggregateConfigRuleToCompliancePackResponseBodyOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class AttachAggregateConfigRuleToCompliancePackResponseBodyOperateRuleResultOperateRuleItemList : TeaModel {
                public string ConfigRuleId { get; set; }
                public string ErrorCode { get; set; }
                public bool? Success { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
