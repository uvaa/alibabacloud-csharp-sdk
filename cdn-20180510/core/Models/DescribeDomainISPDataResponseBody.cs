// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainISPDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public DescribeDomainISPDataResponseBodyValue Value { get; set; }
        public class DescribeDomainISPDataResponseBodyValue : TeaModel {
            [NameInMap("ISPProportionData")]
            [Validation(Required=false)]
            public List<DescribeDomainISPDataResponseBodyValueISPProportionData> ISPProportionData { get; set; }
            public class DescribeDomainISPDataResponseBodyValueISPProportionData : TeaModel {
                public string AvgObjectSize { get; set; }
                public string AvgResponseRate { get; set; }
                public string AvgResponseTime { get; set; }
                public string Bps { get; set; }
                public string BytesProportion { get; set; }
                public string ISP { get; set; }
                public string IspEname { get; set; }
                public string Proportion { get; set; }
                public string Qps { get; set; }
                public string ReqErrRate { get; set; }
                public string TotalBytes { get; set; }
                public string TotalQuery { get; set; }
            }
        };

    }

}
