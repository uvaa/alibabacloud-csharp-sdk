// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class ListWebHostingCustomDomainsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListWebHostingCustomDomainsResponseBodyData> Data { get; set; }
        public class ListWebHostingCustomDomainsResponseBodyData : TeaModel {
            [NameInMap("AccessControlAllowOrigin")]
            [Validation(Required=false)]
            public string AccessControlAllowOrigin { get; set; }

            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("EnableCors")]
            [Validation(Required=false)]
            public bool? EnableCors { get; set; }

            [NameInMap("ForceRedirectType")]
            [Validation(Required=false)]
            public string ForceRedirectType { get; set; }

            [NameInMap("SslProtocol")]
            [Validation(Required=false)]
            public string SslProtocol { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
