// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageaudit20191230.Models
{
    public class ScanImageRequest : TeaModel {
        [NameInMap("Task")]
        [Validation(Required=false)]
        public List<ScanImageRequestTask> Task { get; set; }
        public class ScanImageRequestTask : TeaModel {
            [NameInMap("ImageTimeMillisecond")]
            [Validation(Required=false)]
            public long? ImageTimeMillisecond { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

            [NameInMap("MaxFrames")]
            [Validation(Required=false)]
            public int? MaxFrames { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

        }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public List<string> Scene { get; set; }

    }

}
