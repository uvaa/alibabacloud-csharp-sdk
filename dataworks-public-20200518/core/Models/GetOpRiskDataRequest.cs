// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOpRiskDataRequest : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=true)]
        public int? PageNo { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Date")]
        [Validation(Required=true)]
        public string Date { get; set; }

        [NameInMap("RiskType")]
        [Validation(Required=false)]
        public string RiskType { get; set; }

    }

}