// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeregisterManagedInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Instance")]
        [Validation(Required=false)]
        public DeregisterManagedInstanceResponseBodyInstance Instance { get; set; }
        public class DeregisterManagedInstanceResponseBodyInstance : TeaModel {
            [NameInMap("LastInvokedTime")]
            [Validation(Required=false)]
            public string LastInvokedTime { get; set; }
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }
            [NameInMap("ActivationId")]
            [Validation(Required=false)]
            public string ActivationId { get; set; }
            [NameInMap("RegistrationTime")]
            [Validation(Required=false)]
            public string RegistrationTime { get; set; }
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }
            [NameInMap("InvocationCount")]
            [Validation(Required=false)]
            public long? InvocationCount { get; set; }
            [NameInMap("OsVersion")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }
            [NameInMap("MachineId")]
            [Validation(Required=false)]
            public string MachineId { get; set; }
        };

    }

}