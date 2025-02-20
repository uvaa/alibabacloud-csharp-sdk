// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortResponseBody : TeaModel {
        [NameInMap("NetworkRules")]
        [Validation(Required=false)]
        public List<DescribePortResponseBodyNetworkRules> NetworkRules { get; set; }
        public class DescribePortResponseBodyNetworkRules : TeaModel {
            [NameInMap("BackendPort")]
            [Validation(Required=false)]
            public int? BackendPort { get; set; }

            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            [NameInMap("FrontendProtocol")]
            [Validation(Required=false)]
            public string FrontendProtocol { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IsAutoCreate")]
            [Validation(Required=false)]
            public bool? IsAutoCreate { get; set; }

            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<string> RealServers { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
