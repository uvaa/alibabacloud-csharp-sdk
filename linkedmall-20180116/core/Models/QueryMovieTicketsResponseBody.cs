// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryMovieTicketsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("MovieTicket")]
        [Validation(Required=false)]
        public QueryMovieTicketsResponseBodyMovieTicket MovieTicket { get; set; }
        public class QueryMovieTicketsResponseBodyMovieTicket : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TbOrderId")]
            [Validation(Required=false)]
            public string TbOrderId { get; set; }
            [NameInMap("TicketContents")]
            [Validation(Required=false)]
            public string TicketContents { get; set; }
            [NameInMap("ReturnMessage")]
            [Validation(Required=false)]
            public string ReturnMessage { get; set; }
        };

    }

}
