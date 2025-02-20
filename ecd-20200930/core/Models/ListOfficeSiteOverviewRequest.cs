// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListOfficeSiteOverviewRequest : TeaModel {
        [NameInMap("ForceRefresh")]
        [Validation(Required=false)]
        public bool? ForceRefresh { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public List<string> OfficeSiteId { get; set; }

        [NameInMap("QueryRange")]
        [Validation(Required=false)]
        public int? QueryRange { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
