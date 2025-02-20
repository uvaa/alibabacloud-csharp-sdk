// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20190325.Models
{
    public class SearchImageResponseBody : TeaModel {
        [NameInMap("Auctions")]
        [Validation(Required=false)]
        public List<SearchImageResponseBodyAuctions> Auctions { get; set; }
        public class SearchImageResponseBodyAuctions : TeaModel {
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            [NameInMap("CustomContent")]
            [Validation(Required=false)]
            public string CustomContent { get; set; }

            [NameInMap("IntAttr")]
            [Validation(Required=false)]
            public int? IntAttr { get; set; }

            [NameInMap("PicName")]
            [Validation(Required=false)]
            public string PicName { get; set; }

            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            [NameInMap("SortExprValues")]
            [Validation(Required=false)]
            public string SortExprValues { get; set; }

            [NameInMap("StrAttr")]
            [Validation(Required=false)]
            public string StrAttr { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Head")]
        [Validation(Required=false)]
        public SearchImageResponseBodyHead Head { get; set; }
        public class SearchImageResponseBodyHead : TeaModel {
            [NameInMap("DocsFound")]
            [Validation(Required=false)]
            public int? DocsFound { get; set; }
            [NameInMap("DocsReturn")]
            [Validation(Required=false)]
            public int? DocsReturn { get; set; }
            [NameInMap("SearchTime")]
            [Validation(Required=false)]
            public int? SearchTime { get; set; }
        };

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("PicInfo")]
        [Validation(Required=false)]
        public SearchImageResponseBodyPicInfo PicInfo { get; set; }
        public class SearchImageResponseBodyPicInfo : TeaModel {
            [NameInMap("AllCategories")]
            [Validation(Required=false)]
            public List<SearchImageResponseBodyPicInfoAllCategories> AllCategories { get; set; }
            public class SearchImageResponseBodyPicInfoAllCategories : TeaModel {
                public int? Id { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
