// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ListFaceEntitiesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFaceEntitiesResponseBodyData Data { get; set; }
        public class ListFaceEntitiesResponseBodyData : TeaModel {
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<ListFaceEntitiesResponseBodyDataEntities> Entities { get; set; }
            public class ListFaceEntitiesResponseBodyDataEntities : TeaModel {
                public long? CreatedAt { get; set; }
                public string DbName { get; set; }
                public string EntityId { get; set; }
                public int? FaceCount { get; set; }
                public string Labels { get; set; }
                public long? UpdatedAt { get; set; }
            }
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
