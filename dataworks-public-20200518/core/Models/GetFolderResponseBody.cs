// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetFolderResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFolderResponseBodyData Data { get; set; }
        public class GetFolderResponseBodyData : TeaModel {
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }
            [NameInMap("FolderPath")]
            [Validation(Required=false)]
            public string FolderPath { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
