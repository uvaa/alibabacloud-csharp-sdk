// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetTransferableNodesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetTransferableNodesResponseBodyResult> Result { get; set; }
        public class GetTransferableNodesResponseBodyResult : TeaModel {
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

        }

    }

}
