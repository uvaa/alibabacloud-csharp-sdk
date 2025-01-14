// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class QueryServicePackAndPriceResponseBody : TeaModel {
        [NameInMap("ChargeAmount")]
        [Validation(Required=false)]
        public int? ChargeAmount { get; set; }

        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("DiscountPrice")]
        [Validation(Required=false)]
        public float? DiscountPrice { get; set; }

        [NameInMap("OriginalAmount")]
        [Validation(Required=false)]
        public int? OriginalAmount { get; set; }

        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public float? OriginalPrice { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServicePack")]
        [Validation(Required=false)]
        public QueryServicePackAndPriceResponseBodyServicePack ServicePack { get; set; }
        public class QueryServicePackAndPriceResponseBodyServicePack : TeaModel {
            [NameInMap("ServicePackInfo")]
            [Validation(Required=false)]
            public List<QueryServicePackAndPriceResponseBodyServicePackServicePackInfo> ServicePackInfo { get; set; }
            public class QueryServicePackAndPriceResponseBodyServicePackServicePackInfo : TeaModel {
                public int? Capacity { get; set; }
                public int? EndTime { get; set; }
                public string InstanceName { get; set; }
                public int? StartTime { get; set; }
            }
        };

        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

    }

}
