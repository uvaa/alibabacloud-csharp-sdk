// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineAgentDetailReportResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHotlineAgentDetailReportResponseBodyData Data { get; set; }
        public class GetHotlineAgentDetailReportResponseBodyData : TeaModel {
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public List<string> Rows { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<GetHotlineAgentDetailReportResponseBodyDataColumns> Columns { get; set; }
            public class GetHotlineAgentDetailReportResponseBodyDataColumns : TeaModel {
                public string Key { get; set; }
                public string Title { get; set; }
            }
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

    }

}
