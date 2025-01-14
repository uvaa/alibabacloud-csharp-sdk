// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListFlowProjectUserResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListFlowProjectUserResponseBodyUsers Users { get; set; }
        public class ListFlowProjectUserResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListFlowProjectUserResponseBodyUsersUser> User { get; set; }
            public class ListFlowProjectUserResponseBodyUsersUser : TeaModel {
                public string AccountUserId { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string OwnerId { get; set; }
                public string ProjectId { get; set; }
                public string UserName { get; set; }
            }
        };

    }

}
