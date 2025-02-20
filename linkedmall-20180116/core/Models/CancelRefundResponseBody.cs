// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class CancelRefundResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RefundApplicationData")]
        [Validation(Required=false)]
        public CancelRefundResponseBodyRefundApplicationData RefundApplicationData { get; set; }
        public class CancelRefundResponseBodyRefundApplicationData : TeaModel {
            [NameInMap("DisputeType")]
            [Validation(Required=false)]
            public int? DisputeType { get; set; }
            [NameInMap("SubLmOrderId")]
            [Validation(Required=false)]
            public string SubLmOrderId { get; set; }
            [NameInMap("DisputeStatus")]
            [Validation(Required=false)]
            public int? DisputeStatus { get; set; }
        };

    }

}
