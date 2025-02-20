// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ReleaseMovieSeatResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("ActionResult")]
        [Validation(Required=false)]
        public ReleaseMovieSeatResponseBodyActionResult ActionResult { get; set; }
        public class ReleaseMovieSeatResponseBodyActionResult : TeaModel {
            [NameInMap("ReturnCode")]
            [Validation(Required=false)]
            public string ReturnCode { get; set; }
            [NameInMap("ReturnValue")]
            [Validation(Required=false)]
            public string ReturnValue { get; set; }
            [NameInMap("ReturnMessage")]
            [Validation(Required=false)]
            public string ReturnMessage { get; set; }
        };

    }

}
