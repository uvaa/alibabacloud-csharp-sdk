// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMigrationProcessResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetMigrationProcessResponseBodyData> Data { get; set; }
        public class GetMigrationProcessResponseBodyData : TeaModel {
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

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
