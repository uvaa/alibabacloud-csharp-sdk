// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoInfosResponseBody : TeaModel {
        [NameInMap("NonExistVideoIds")]
        [Validation(Required=false)]
        public List<string> NonExistVideoIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VideoList")]
        [Validation(Required=false)]
        public List<GetVideoInfosResponseBodyVideoList> VideoList { get; set; }
        public class GetVideoInfosResponseBodyVideoList : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public List<string> Snapshots { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            [NameInMap("TemplateGroupId")]
            [Validation(Required=false)]
            public string TemplateGroupId { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
