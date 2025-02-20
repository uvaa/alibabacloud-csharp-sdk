// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAffectedMaliciousFileImagesResponseBody : TeaModel {
        [NameInMap("AffectedMaliciousFileImagesResponse")]
        [Validation(Required=false)]
        public List<DescribeAffectedMaliciousFileImagesResponseBodyAffectedMaliciousFileImagesResponse> AffectedMaliciousFileImagesResponse { get; set; }
        public class DescribeAffectedMaliciousFileImagesResponseBodyAffectedMaliciousFileImagesResponse : TeaModel {
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            [NameInMap("FirstScanTimestamp")]
            [Validation(Required=false)]
            public long? FirstScanTimestamp { get; set; }

            [NameInMap("HighLight")]
            [Validation(Required=false)]
            public string HighLight { get; set; }

            [NameInMap("ImageUuid")]
            [Validation(Required=false)]
            public string ImageUuid { get; set; }

            [NameInMap("LatestScanTimestamp")]
            [Validation(Required=false)]
            public long? LatestScanTimestamp { get; set; }

            [NameInMap("LatestVerifyTimestamp")]
            [Validation(Required=false)]
            public long? LatestVerifyTimestamp { get; set; }

            [NameInMap("Layer")]
            [Validation(Required=false)]
            public string Layer { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("MaliciousMd5")]
            [Validation(Required=false)]
            public string MaliciousMd5 { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            [NameInMap("RepoInstanceId")]
            [Validation(Required=false)]
            public string RepoInstanceId { get; set; }

            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            [NameInMap("RepoRegionId")]
            [Validation(Required=false)]
            public string RepoRegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeAffectedMaliciousFileImagesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeAffectedMaliciousFileImagesResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
