// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetTransferableNodesRequest : TeaModel {
        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

    }

}