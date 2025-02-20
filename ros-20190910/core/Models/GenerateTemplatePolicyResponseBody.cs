// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GenerateTemplatePolicyResponseBody : TeaModel {
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GenerateTemplatePolicyResponseBodyPolicy Policy { get; set; }
        public class GenerateTemplatePolicyResponseBodyPolicy : TeaModel {
            [NameInMap("Statement")]
            [Validation(Required=false)]
            public List<GenerateTemplatePolicyResponseBodyPolicyStatement> Statement { get; set; }
            public class GenerateTemplatePolicyResponseBodyPolicyStatement : TeaModel {
                public List<string> Action { get; set; }
                public string Effect { get; set; }
                public string Resource { get; set; }
            }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
