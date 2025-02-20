// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryDevicePurifyPlansResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDevicePurifyPlansResponseBodyData Data { get; set; }
        public class QueryDevicePurifyPlansResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryDevicePurifyPlansResponseBodyDataList> List { get; set; }
            public class QueryDevicePurifyPlansResponseBodyDataList : TeaModel {
                public int? EndTime { get; set; }
                public int? StartTime { get; set; }
                public string ProductKey { get; set; }
                public string DeviceName { get; set; }
                public string UserId { get; set; }
                public string PlanId { get; set; }
                public string TenantId { get; set; }
                public string IotId { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
