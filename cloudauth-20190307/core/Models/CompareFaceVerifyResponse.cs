// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CompareFaceVerifyResponse : TeaModel {
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
        public CompareFaceVerifyResponseResultObject ResultObject { get; set; }
        public class CompareFaceVerifyResponseResultObject : TeaModel {
            [NameInMap("Passed")]
            [Validation(Required=true)]
            public string Passed { get; set; }
            [NameInMap("VerifyScore")]
            [Validation(Required=true)]
            public float? VerifyScore { get; set; }
        };

    }

}