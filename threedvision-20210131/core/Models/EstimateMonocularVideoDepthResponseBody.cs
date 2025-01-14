// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Threedvision20210131.Models
{
    public class EstimateMonocularVideoDepthResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public EstimateMonocularVideoDepthResponseBodyData Data { get; set; }
        public class EstimateMonocularVideoDepthResponseBodyData : TeaModel {
            [NameInMap("DepthUrl")]
            [Validation(Required=false)]
            public string DepthUrl { get; set; }
            [NameInMap("DepthVisUrl")]
            [Validation(Required=false)]
            public string DepthVisUrl { get; set; }
        };

    }

}
