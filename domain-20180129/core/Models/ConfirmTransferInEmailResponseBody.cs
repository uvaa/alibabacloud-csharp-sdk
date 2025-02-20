// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class ConfirmTransferInEmailResponseBody : TeaModel {
        [NameInMap("FailList")]
        [Validation(Required=false)]
        public ConfirmTransferInEmailResponseBodyFailList FailList { get; set; }
        public class ConfirmTransferInEmailResponseBodyFailList : TeaModel {
            [NameInMap("FailDomain")]
            [Validation(Required=false)]
            public List<string> FailDomain { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessList")]
        [Validation(Required=false)]
        public ConfirmTransferInEmailResponseBodySuccessList SuccessList { get; set; }
        public class ConfirmTransferInEmailResponseBodySuccessList : TeaModel {
            [NameInMap("SuccessDomain")]
            [Validation(Required=false)]
            public List<string> SuccessDomain { get; set; }
        };

    }

}
