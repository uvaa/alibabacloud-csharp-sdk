// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryConsumerGroupListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryConsumerGroupListResponseBodyData Data { get; set; }
        public class QueryConsumerGroupListResponseBodyData : TeaModel {
            [NameInMap("ConsumerGroupDTO")]
            [Validation(Required=false)]
            public List<QueryConsumerGroupListResponseBodyDataConsumerGroupDTO> ConsumerGroupDTO { get; set; }
            public class QueryConsumerGroupListResponseBodyDataConsumerGroupDTO : TeaModel {
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string CreateTime { get; set; }
            }
        };

    }

}