// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryProductTopicResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryProductTopicResponseBodyData Data { get; set; }
        public class QueryProductTopicResponseBodyData : TeaModel {
            [NameInMap("ProductTopicInfo")]
            [Validation(Required=false)]
            public List<QueryProductTopicResponseBodyDataProductTopicInfo> ProductTopicInfo { get; set; }
            public class QueryProductTopicResponseBodyDataProductTopicInfo : TeaModel {
                public string Desc { get; set; }
                public string Id { get; set; }
                public string Operation { get; set; }
                public string ProductKey { get; set; }
                public string TopicShortName { get; set; }
            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
