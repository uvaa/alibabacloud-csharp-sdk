// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class SetDBInstancePlanStatusRequest : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        [NameInMap("PlanStatus")]
        [Validation(Required=false)]
        public string PlanStatus { get; set; }

    }

}
