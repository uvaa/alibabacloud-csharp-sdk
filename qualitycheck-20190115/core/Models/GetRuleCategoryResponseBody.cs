// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetRuleCategoryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRuleCategoryResponseBodyData Data { get; set; }
        public class GetRuleCategoryResponseBodyData : TeaModel {
            [NameInMap("RuleCountInfo")]
            [Validation(Required=false)]
            public List<GetRuleCategoryResponseBodyDataRuleCountInfo> RuleCountInfo { get; set; }
            public class GetRuleCategoryResponseBodyDataRuleCountInfo : TeaModel {
                public bool? Select { get; set; }
                public int? Type { get; set; }
                public string TypeName { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
