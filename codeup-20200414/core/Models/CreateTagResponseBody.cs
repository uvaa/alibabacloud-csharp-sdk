// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class CreateTagResponseBody : TeaModel {
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateTagResponseBodyResult Result { get; set; }
        public class CreateTagResponseBodyResult : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("CommitInfo")]
            [Validation(Required=false)]
            public CreateTagResponseBodyResultCommitInfo CommitInfo { get; set; }
            public class CreateTagResponseBodyResultCommitInfo : TeaModel {
                [NameInMap("ShortId")]
                [Validation(Required=false)]
                public string ShortId { get; set; }

                [NameInMap("AuthorName")]
                [Validation(Required=false)]
                public string AuthorName { get; set; }

                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("AuthoredDate")]
                [Validation(Required=false)]
                public string AuthoredDate { get; set; }

                [NameInMap("CommitterName")]
                [Validation(Required=false)]
                public string CommitterName { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("AuthorEmail")]
                [Validation(Required=false)]
                public string AuthorEmail { get; set; }

                [NameInMap("CommitterEmail")]
                [Validation(Required=false)]
                public string CommitterEmail { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("CommittedDate")]
                [Validation(Required=false)]
                public string CommittedDate { get; set; }

                [NameInMap("ParentIds")]
                [Validation(Required=false)]
                public List<string> ParentIds { get; set; }

            }
            [NameInMap("Release")]
            [Validation(Required=false)]
            public CreateTagResponseBodyResultRelease Release { get; set; }
            public class CreateTagResponseBodyResultRelease : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }
        };

    }

}
