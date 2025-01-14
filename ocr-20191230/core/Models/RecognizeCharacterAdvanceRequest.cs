// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeCharacterAdvanceRequest : TeaModel {
        [NameInMap("ImageURLObject")]
        [Validation(Required=true)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("MinHeight")]
        [Validation(Required=false)]
        public int? MinHeight { get; set; }

        [NameInMap("OutputProbability")]
        [Validation(Required=false)]
        public bool? OutputProbability { get; set; }

    }

}
