// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListRoomsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListRoomsResponseBodyResult Result { get; set; }
        public class ListRoomsResponseBodyResult : TeaModel {
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }
            [NameInMap("RoomInfoList")]
            [Validation(Required=false)]
            public List<ListRoomsResponseBodyResultRoomInfoList> RoomInfoList { get; set; }
            public class ListRoomsResponseBodyResultRoomInfoList : TeaModel {
                public string AppId { get; set; }
                public string CreateTime { get; set; }
                public Dictionary<string, string> Extension { get; set; }
                public string Notice { get; set; }
                public long? OnlineCount { get; set; }
                public List<ListRoomsResponseBodyResultRoomInfoListPluginInstanceInfoList> PluginInstanceInfoList { get; set; }
                public class ListRoomsResponseBodyResultRoomInfoListPluginInstanceInfoList : TeaModel {
                    public long? CreateTime { get; set; }
                    public Dictionary<string, string> Extension { get; set; }
                    public string PluginId { get; set; }
                    public string PluginType { get; set; }
                }
                public string RoomId { get; set; }
                public string RoomOwnerId { get; set; }
                public string TemplateId { get; set; }
                public string Title { get; set; }
                public long? Uv { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
