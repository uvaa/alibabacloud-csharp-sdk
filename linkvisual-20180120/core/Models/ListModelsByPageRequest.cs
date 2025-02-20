// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class ListModelsByPageRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("AlgorithmId")]
        [Validation(Required=false)]
        public long? AlgorithmId { get; set; }

        [NameInMap("SizeType")]
        [Validation(Required=false)]
        public string SizeType { get; set; }

        [NameInMap("ModelPackageStandard")]
        [Validation(Required=false)]
        public string ModelPackageStandard { get; set; }

        [NameInMap("Hardware")]
        [Validation(Required=false)]
        public string Hardware { get; set; }

        [NameInMap("NamePattern")]
        [Validation(Required=false)]
        public string NamePattern { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

    }

}
