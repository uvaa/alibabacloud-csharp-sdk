// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class VerifyPhoneWithTokenResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GateVerify")]
        [Validation(Required=false)]
        public VerifyPhoneWithTokenResponseBodyGateVerify GateVerify { get; set; }
        public class VerifyPhoneWithTokenResponseBodyGateVerify : TeaModel {
            [NameInMap("VerifyId")]
            [Validation(Required=false)]
            public string VerifyId { get; set; }
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
