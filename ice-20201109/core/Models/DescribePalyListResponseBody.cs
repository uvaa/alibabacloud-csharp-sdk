// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribePalyListResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PlayList")]
        [Validation(Required=false)]
        public List<DescribePalyListResponseBodyPlayList> PlayList { get; set; }
        public class DescribePalyListResponseBodyPlayList : TeaModel {
            [NameInMap("FirstFrameDuration")]
            [Validation(Required=false)]
            public string FirstFrameDuration { get; set; }

            [NameInMap("PlayDuration")]
            [Validation(Required=false)]
            public string PlayDuration { get; set; }

            [NameInMap("PlayType")]
            [Validation(Required=false)]
            public string PlayType { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StuckDuration")]
            [Validation(Required=false)]
            public string StuckDuration { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            [NameInMap("VideoDuration")]
            [Validation(Required=false)]
            public string VideoDuration { get; set; }

            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public long? TotalCnt { get; set; }

    }

}
