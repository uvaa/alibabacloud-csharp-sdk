// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class DeleteFileResponseBody : TeaModel {
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DeleteFileResponseBodyResult Result { get; set; }
        public class DeleteFileResponseBodyResult : TeaModel {
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }
            [NameInMap("BranchName")]
            [Validation(Required=false)]
            public string BranchName { get; set; }
        };

    }

}
