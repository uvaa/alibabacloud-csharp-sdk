// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetAutoInjectionLabelSyncStatusResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=true)]
        public string Status { get; set; }

    }

}