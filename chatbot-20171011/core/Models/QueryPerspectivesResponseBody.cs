// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class QueryPerspectivesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Perspectives")]
        [Validation(Required=false)]
        public List<QueryPerspectivesResponseBodyPerspectives> Perspectives { get; set; }
        public class QueryPerspectivesResponseBodyPerspectives : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("PerspectiveId")]
            [Validation(Required=false)]
            public string PerspectiveId { get; set; }

            [NameInMap("SelfDefine")]
            [Validation(Required=false)]
            public string SelfDefine { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PerspectiveCode")]
            [Validation(Required=false)]
            public string PerspectiveCode { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

        }

    }

}