// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class GetRepositoryTagV2ResponseBody : TeaModel {
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetRepositoryTagV2ResponseBodyResult Result { get; set; }
        public class GetRepositoryTagV2ResponseBodyResult : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Commit")]
            [Validation(Required=false)]
            public GetRepositoryTagV2ResponseBodyResultCommit Commit { get; set; }
            public class GetRepositoryTagV2ResponseBodyResultCommit : TeaModel {
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

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("CommitterName")]
                [Validation(Required=false)]
                public string CommitterName { get; set; }

                [NameInMap("AuthorEmail")]
                [Validation(Required=false)]
                public string AuthorEmail { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("CommitterEmail")]
                [Validation(Required=false)]
                public string CommitterEmail { get; set; }

                [NameInMap("CommittedDate")]
                [Validation(Required=false)]
                public string CommittedDate { get; set; }

                [NameInMap("ParentIds")]
                [Validation(Required=false)]
                public List<string> ParentIds { get; set; }

                [NameInMap("Signature")]
                [Validation(Required=false)]
                public GetRepositoryTagV2ResponseBodyResultCommitSignature Signature { get; set; }
                public class GetRepositoryTagV2ResponseBodyResultCommitSignature : TeaModel {
                    [NameInMap("VerificationStatus")]
                    [Validation(Required=false)]
                    public string VerificationStatus { get; set; }
                    [NameInMap("GpgKeyId")]
                    [Validation(Required=false)]
                    public string GpgKeyId { get; set; }
                };

            }
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public GetRepositoryTagV2ResponseBodyResultSignature Signature { get; set; }
            public class GetRepositoryTagV2ResponseBodyResultSignature : TeaModel {
                [NameInMap("VerificationStatus")]
                [Validation(Required=false)]
                public string VerificationStatus { get; set; }

                [NameInMap("GpgKeyId")]
                [Validation(Required=false)]
                public string GpgKeyId { get; set; }

            }
        };

    }

}
