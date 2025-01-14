// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ListBodyDbsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBodyDbsResponseBodyData Data { get; set; }
        public class ListBodyDbsResponseBodyData : TeaModel {
            [NameInMap("DbList")]
            [Validation(Required=false)]
            public List<ListBodyDbsResponseBodyDataDbList> DbList { get; set; }
            public class ListBodyDbsResponseBodyDataDbList : TeaModel {
                public long? Id { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
        };

        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
