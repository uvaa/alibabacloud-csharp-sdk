// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetBaselineKeyPathRequest : TeaModel {
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public long? BaselineId { get; set; }

        [NameInMap("Bizdate")]
        [Validation(Required=false)]
        public string Bizdate { get; set; }

        [NameInMap("InGroupId")]
        [Validation(Required=false)]
        public int? InGroupId { get; set; }

    }

}
