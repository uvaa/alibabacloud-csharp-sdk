// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFrontVulPatchListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FrontPatchList")]
        [Validation(Required=false)]
        public List<DescribeFrontVulPatchListResponseBodyFrontPatchList> FrontPatchList { get; set; }
        public class DescribeFrontVulPatchListResponseBodyFrontPatchList : TeaModel {
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("PatchList")]
            [Validation(Required=false)]
            public List<DescribeFrontVulPatchListResponseBodyFrontPatchListPatchList> PatchList { get; set; }
            public class DescribeFrontVulPatchListResponseBodyFrontPatchListPatchList : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

            }

        }

    }

}