// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20200618.Models
{
    public class ElementSmartVerifyResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=true)]
        public ElementSmartVerifyResponseResultObject ResultObject { get; set; }
        public class ElementSmartVerifyResponseResultObject : TeaModel {
            [NameInMap("Passed")]
            [Validation(Required=true)]
            public string Passed { get; set; }
            [NameInMap("SubCode")]
            [Validation(Required=true)]
            public string SubCode { get; set; }
            [NameInMap("MaterialInfo")]
            [Validation(Required=true)]
            public string MaterialInfo { get; set; }
        };

    }

}