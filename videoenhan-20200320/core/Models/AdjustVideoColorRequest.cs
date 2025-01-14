// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class AdjustVideoColorRequest : TeaModel {
        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public long? VideoBitrate { get; set; }

        [NameInMap("VideoCodec")]
        [Validation(Required=false)]
        public string VideoCodec { get; set; }

        [NameInMap("VideoFormat")]
        [Validation(Required=false)]
        public string VideoFormat { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

    }

}
