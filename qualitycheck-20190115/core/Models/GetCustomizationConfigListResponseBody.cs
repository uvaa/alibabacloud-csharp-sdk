// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetCustomizationConfigListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomizationConfigListResponseBodyData Data { get; set; }
        public class GetCustomizationConfigListResponseBodyData : TeaModel {
            [NameInMap("ModelCustomizationDataSetPo")]
            [Validation(Required=false)]
            public List<GetCustomizationConfigListResponseBodyDataModelCustomizationDataSetPo> ModelCustomizationDataSetPo { get; set; }
            public class GetCustomizationConfigListResponseBodyDataModelCustomizationDataSetPo : TeaModel {
                public string CreateTime { get; set; }
                public string ModeCustomizationId { get; set; }
                public long? ModelId { get; set; }
                public string ModelName { get; set; }
                public int? ModelStatus { get; set; }
                public int? TaskType { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
