// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetRuleActionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleActionInfo")]
        [Validation(Required=false)]
        public GetRuleActionResponseBodyRuleActionInfo RuleActionInfo { get; set; }
        public class GetRuleActionResponseBodyRuleActionInfo : TeaModel {
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public string Configuration { get; set; }
            [NameInMap("ErrorActionFlag")]
            [Validation(Required=false)]
            public bool? ErrorActionFlag { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
