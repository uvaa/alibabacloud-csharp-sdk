// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDedicatedHostsChargeTypeResponseBody : TeaModel {
        [NameInMap("FeeOfInstances")]
        [Validation(Required=false)]
        public ModifyDedicatedHostsChargeTypeResponseBodyFeeOfInstances FeeOfInstances { get; set; }
        public class ModifyDedicatedHostsChargeTypeResponseBodyFeeOfInstances : TeaModel {
            [NameInMap("FeeOfInstance")]
            [Validation(Required=false)]
            public List<ModifyDedicatedHostsChargeTypeResponseBodyFeeOfInstancesFeeOfInstance> FeeOfInstance { get; set; }
            public class ModifyDedicatedHostsChargeTypeResponseBodyFeeOfInstancesFeeOfInstance : TeaModel {
                public string Currency { get; set; }
                public string Fee { get; set; }
                public string InstanceId { get; set; }
            }
        };

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
