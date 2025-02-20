// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserCertificateExpireCountResponseBody : TeaModel {
        [NameInMap("ExpireWithin30DaysCount")]
        [Validation(Required=false)]
        public int? ExpireWithin30DaysCount { get; set; }

        [NameInMap("ExpiredCount")]
        [Validation(Required=false)]
        public int? ExpiredCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
