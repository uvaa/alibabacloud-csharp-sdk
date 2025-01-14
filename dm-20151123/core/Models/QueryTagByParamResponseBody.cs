// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryTagByParamResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryTagByParamResponseBodyData Data { get; set; }
        public class QueryTagByParamResponseBodyData : TeaModel {
            [NameInMap("tag")]
            [Validation(Required=false)]
            public List<QueryTagByParamResponseBodyDataTag> Tag { get; set; }
            public class QueryTagByParamResponseBodyDataTag : TeaModel {
                public string TagId { get; set; }
                public string TagName { get; set; }
            }
        };

    }

}
