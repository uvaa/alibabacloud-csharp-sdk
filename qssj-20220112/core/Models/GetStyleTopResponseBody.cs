// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetStyleTopResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetStyleTopResponseBodyData> Data { get; set; }
        public class GetStyleTopResponseBodyData : TeaModel {
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            [NameInMap("Color")]
            [Validation(Required=false)]
            public string Color { get; set; }

            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            [NameInMap("Material")]
            [Validation(Required=false)]
            public string Material { get; set; }

            [NameInMap("ProductLink")]
            [Validation(Required=false)]
            public string ProductLink { get; set; }

            [NameInMap("SalesVolume")]
            [Validation(Required=false)]
            public double? SalesVolume { get; set; }

            [NameInMap("SearchVolume")]
            [Validation(Required=false)]
            public double? SearchVolume { get; set; }

            [NameInMap("Style")]
            [Validation(Required=false)]
            public string Style { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessResponse")]
        [Validation(Required=false)]
        public string SuccessResponse { get; set; }

    }

}
