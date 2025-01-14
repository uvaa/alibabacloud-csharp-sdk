// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedContainerInstancesRequest : TeaModel {
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        [NameInMap("GroupField")]
        [Validation(Required=false)]
        public string GroupField { get; set; }

        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
