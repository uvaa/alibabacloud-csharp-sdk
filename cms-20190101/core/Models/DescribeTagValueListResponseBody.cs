// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeTagValueListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TagValues")]
        [Validation(Required=false)]
        public DescribeTagValueListResponseBodyTagValues TagValues { get; set; }
        public class DescribeTagValueListResponseBodyTagValues : TeaModel {
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public List<string> TagValue { get; set; }
        };

    }

}
