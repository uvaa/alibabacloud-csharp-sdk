// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListBindingsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Bindings")]
        [Validation(Required=false)]
        public List<ListBindingsResponseBodyBindings> Bindings { get; set; }
        public class ListBindingsResponseBodyBindings : TeaModel {
            [NameInMap("Binding")]
            [Validation(Required=false)]
            public ListBindingsResponseBodyBindingsBinding Binding { get; set; }
            public class ListBindingsResponseBodyBindingsBinding : TeaModel {
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }
                [NameInMap("DatasetName")]
                [Validation(Required=false)]
                public string DatasetName { get; set; }
                [NameInMap("URI")]
                [Validation(Required=false)]
                public string URI { get; set; }
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }
                [NameInMap("Phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }
            };

        }

    }

}