// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetTrendStatisticResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTrendStatisticResponseBodyData Data { get; set; }
        public class GetTrendStatisticResponseBodyData : TeaModel {
            [NameInMap("CommodityCount")]
            [Validation(Required=false)]
            public long? CommodityCount { get; set; }
            [NameInMap("Sales")]
            [Validation(Required=false)]
            public double? Sales { get; set; }
            [NameInMap("ShopCount")]
            [Validation(Required=false)]
            public long? ShopCount { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessResponse")]
        [Validation(Required=false)]
        public bool? SuccessResponse { get; set; }

    }

}
