// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20200618.Models
{
    public class DescribeSmartVerifyResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=true)]
        public DescribeSmartVerifyResponseResultObject ResultObject { get; set; }
        public class DescribeSmartVerifyResponseResultObject : TeaModel {
            [NameInMap("MaterialInfo")]
            [Validation(Required=true)]
            public string MaterialInfo { get; set; }
            [NameInMap("Passed")]
            [Validation(Required=true)]
            public string Passed { get; set; }
            [NameInMap("PassedScore")]
            [Validation(Required=true)]
            public float? PassedScore { get; set; }
            [NameInMap("SubCode")]
            [Validation(Required=true)]
            public string SubCode { get; set; }
        };

    }

}
