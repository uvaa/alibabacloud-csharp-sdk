// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAncestorsResponseBody : TeaModel {
        [NameInMap("Folders")]
        [Validation(Required=false)]
        public ListAncestorsResponseBodyFolders Folders { get; set; }
        public class ListAncestorsResponseBodyFolders : TeaModel {
            [NameInMap("Folder")]
            [Validation(Required=false)]
            public List<ListAncestorsResponseBodyFoldersFolder> Folder { get; set; }
            public class ListAncestorsResponseBodyFoldersFolder : TeaModel {
                public string CreateTime { get; set; }
                public string FolderId { get; set; }
                public string FolderName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
