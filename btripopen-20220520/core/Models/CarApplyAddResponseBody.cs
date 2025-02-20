// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarApplyAddResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("err_code")]
        [Validation(Required=false)]
        public int? ErrCode { get; set; }

        [NameInMap("err_msg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public long? Module { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
