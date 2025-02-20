// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyTrafficControlRequest : TeaModel {
        [NameInMap("ApiDefault")]
        [Validation(Required=false)]
        public int? ApiDefault { get; set; }

        [NameInMap("AppDefault")]
        [Validation(Required=false)]
        public int? AppDefault { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("TrafficControlId")]
        [Validation(Required=false)]
        public string TrafficControlId { get; set; }

        [NameInMap("TrafficControlName")]
        [Validation(Required=false)]
        public string TrafficControlName { get; set; }

        [NameInMap("TrafficControlUnit")]
        [Validation(Required=false)]
        public string TrafficControlUnit { get; set; }

        [NameInMap("UserDefault")]
        [Validation(Required=false)]
        public int? UserDefault { get; set; }

    }

}
