// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainReqHitRateDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ReqHitRateInterval")]
        [Validation(Required=false)]
        public DescribeDomainReqHitRateDataResponseBodyReqHitRateInterval ReqHitRateInterval { get; set; }
        public class DescribeDomainReqHitRateDataResponseBodyReqHitRateInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainReqHitRateDataResponseBodyReqHitRateIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainReqHitRateDataResponseBodyReqHitRateIntervalDataModule : TeaModel {
                public string HttpsValue { get; set; }
                public string TimeStamp { get; set; }
                public string Value { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
