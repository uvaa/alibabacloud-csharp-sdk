// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodeInputOrOutputResponse : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=true)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=true)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public List<ListNodeInputOrOutputResponseData> Data { get; set; }
        public class ListNodeInputOrOutputResponseData : TeaModel {
            [NameInMap("TableName")]
            [Validation(Required=true)]
            public string TableName { get; set; }

            [NameInMap("Data")]
            [Validation(Required=true)]
            public string Data { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=true)]
            public long? NodeId { get; set; }

        }

    }

}