// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainStationSearchResponseBody : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public TrainStationSearchResponseBodyModule Module { get; set; }
        public class TrainStationSearchResponseBodyModule : TeaModel {
            [NameInMap("cities")]
            [Validation(Required=false)]
            public List<TrainStationSearchResponseBodyModuleCities> Cities { get; set; }
            public class TrainStationSearchResponseBodyModuleCities : TeaModel {
                public string Code { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
