// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEmgVulItemRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("RiskStatus")]
        [Validation(Required=false)]
        public string RiskStatus { get; set; }

        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

        [NameInMap("VulName")]
        [Validation(Required=false)]
        public string VulName { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}