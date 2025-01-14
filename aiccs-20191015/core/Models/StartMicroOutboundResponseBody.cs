// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class StartMicroOutboundResponseBody : TeaModel {
        [NameInMap("CustomerInfo")]
        [Validation(Required=false)]
        public string CustomerInfo { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InvokeCmdId")]
        [Validation(Required=false)]
        public string InvokeCmdId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("InvokeCreateTime")]
        [Validation(Required=false)]
        public string InvokeCreateTime { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
