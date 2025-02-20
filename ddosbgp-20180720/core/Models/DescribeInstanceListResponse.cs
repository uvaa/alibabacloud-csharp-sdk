// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeInstanceListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public long? Total { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=true)]
        public List<DescribeInstanceListResponseInstanceList> InstanceList { get; set; }
        public class DescribeInstanceListResponseInstanceList : TeaModel {
            [NameInMap("ExpireTime")]
            [Validation(Required=true)]
            public long? ExpireTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("Product")]
            [Validation(Required=true)]
            public string Product { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=true)]
            public string Remark { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("IpType")]
            [Validation(Required=true)]
            public string IpType { get; set; }

            [NameInMap("AutoRenewal")]
            [Validation(Required=true)]
            public bool? AutoRenewal { get; set; }

            [NameInMap("BlackholdingCount")]
            [Validation(Required=true)]
            public string BlackholdingCount { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public long? GmtCreate { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=true)]
            public string InstanceType { get; set; }

        }

    }

}
