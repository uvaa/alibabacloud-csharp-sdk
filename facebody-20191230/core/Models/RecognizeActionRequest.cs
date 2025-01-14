// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizeActionRequest : TeaModel {
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("URLList")]
        [Validation(Required=false)]
        public List<RecognizeActionRequestURLList> URLList { get; set; }
        public class RecognizeActionRequestURLList : TeaModel {
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

            [NameInMap("imageData")]
            [Validation(Required=false)]
            public byte[] ImageData { get; set; }

        }

        [NameInMap("VideoData")]
        [Validation(Required=false)]
        public byte[] VideoData { get; set; }

        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

    }

}
