// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceIndicesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListInstanceIndicesResponseBodyHeaders Headers { get; set; }
        public class ListInstanceIndicesResponseBodyHeaders : TeaModel {
            [NameInMap("X-Managed-StorageSize")]
            [Validation(Required=false)]
            public long? XManagedStorageSize { get; set; }
            [NameInMap("X-Managed-Count")]
            [Validation(Required=false)]
            public int? XManagedCount { get; set; }
        };

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListInstanceIndicesResponseBodyResult> Result { get; set; }
        public class ListInstanceIndicesResponseBodyResult : TeaModel {
            [NameInMap("isManaged")]
            [Validation(Required=false)]
            public string IsManaged { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("managedStatus")]
            [Validation(Required=false)]
            public string ManagedStatus { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("health")]
            [Validation(Required=false)]
            public string Health { get; set; }

        }

    }

}