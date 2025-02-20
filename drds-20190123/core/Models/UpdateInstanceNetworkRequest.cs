// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class UpdateInstanceNetworkRequest : TeaModel {
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public int? ClassicExpiredDays { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("RetainClassic")]
        [Validation(Required=false)]
        public bool? RetainClassic { get; set; }

        [NameInMap("SrcInstanceNetworkType")]
        [Validation(Required=false)]
        public string SrcInstanceNetworkType { get; set; }

    }

}
