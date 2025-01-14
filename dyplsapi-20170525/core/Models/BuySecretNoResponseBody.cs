// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BuySecretNoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretBuyInfoDTO")]
        [Validation(Required=false)]
        public BuySecretNoResponseBodySecretBuyInfoDTO SecretBuyInfoDTO { get; set; }
        public class BuySecretNoResponseBodySecretBuyInfoDTO : TeaModel {
            [NameInMap("SecretNo")]
            [Validation(Required=false)]
            public string SecretNo { get; set; }
        };

    }

}
