// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CancelCoordinationForMonitoringRequest : TeaModel {
        [NameInMap("CoIds")]
        [Validation(Required=false)]
        public List<string> CoIds { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
