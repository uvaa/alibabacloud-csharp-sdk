// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class StartApplicationRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("EccInfo")]
        [Validation(Required=false)]
        public string EccInfo { get; set; }

    }

}
