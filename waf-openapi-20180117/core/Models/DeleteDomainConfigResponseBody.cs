// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20180117.Models
{
    public class DeleteDomainConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DeleteDomainConfigResponseBodyResult Result { get; set; }
        public class DeleteDomainConfigResponseBodyResult : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("WafTaskId")]
            [Validation(Required=false)]
            public string WafTaskId { get; set; }
        };

    }

}