// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodTranscodeDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TranscodeData")]
        [Validation(Required=false)]
        public DescribeVodTranscodeDataResponseBodyTranscodeData TranscodeData { get; set; }
        public class DescribeVodTranscodeDataResponseBodyTranscodeData : TeaModel {
            [NameInMap("TranscodeDataItem")]
            [Validation(Required=false)]
            public List<DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItem> TranscodeDataItem { get; set; }
            public class DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItem : TeaModel {
                [NameInMap("DataItem")]
                [Validation(Required=false)]
                public List<DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItemDataItem> DataItem { get; set; }
                public class DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItemDataItem : TeaModel {
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }
        };

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

    }

}