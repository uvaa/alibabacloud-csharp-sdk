// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamRecordIndexFileResponseBody : TeaModel {
        [NameInMap("RecordIndexInfo")]
        [Validation(Required=false)]
        public DescribeLiveStreamRecordIndexFileResponseBodyRecordIndexInfo RecordIndexInfo { get; set; }
        public class DescribeLiveStreamRecordIndexFileResponseBodyRecordIndexInfo : TeaModel {
            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }
            [NameInMap("RecordUrl")]
            [Validation(Required=false)]
            public string RecordUrl { get; set; }
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("OssObject")]
            [Validation(Required=false)]
            public string OssObject { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }
            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
