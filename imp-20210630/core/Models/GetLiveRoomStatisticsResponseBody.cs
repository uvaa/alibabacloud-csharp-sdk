// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetLiveRoomStatisticsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 创建场景化直播返回的结果。
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetLiveRoomStatisticsResponseBodyResult Result { get; set; }
        public class GetLiveRoomStatisticsResponseBodyResult : TeaModel {
            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("Uv")]
            [Validation(Required=false)]
            public long? Uv { get; set; }
            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }
            [NameInMap("MessageCount")]
            [Validation(Required=false)]
            public long? MessageCount { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }
            [NameInMap("WatchLiveTime")]
            [Validation(Required=false)]
            public long? WatchLiveTime { get; set; }
        };

    }

}