// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListLiveRoomsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListLiveRoomsResponseBodyResult Result { get; set; }
        public class ListLiveRoomsResponseBodyResult : TeaModel {
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("LiveList")]
            [Validation(Required=false)]
            public List<ListLiveRoomsResponseBodyResultLiveList> LiveList { get; set; }
            public class ListLiveRoomsResponseBodyResultLiveList : TeaModel {
                public string AnchorId { get; set; }
                public string AnchorNick { get; set; }
                public string AppId { get; set; }
                public string ChatId { get; set; }
                public string CoverUrl { get; set; }
                public long? CreateTime { get; set; }
                public long? EndTime { get; set; }
                public Dictionary<string, string> Extension { get; set; }
                public string LiveId { get; set; }
                public string Notice { get; set; }
                public long? OnlineCount { get; set; }
                public long? Pv { get; set; }
                public string RoomId { get; set; }
                public long? StartTime { get; set; }
                public int? Status { get; set; }
                public string Title { get; set; }
                public long? Uv { get; set; }
            }
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
