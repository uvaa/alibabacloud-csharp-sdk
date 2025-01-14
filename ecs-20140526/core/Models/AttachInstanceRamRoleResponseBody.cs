// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AttachInstanceRamRoleResponseBody : TeaModel {
        [NameInMap("AttachInstanceRamRoleResults")]
        [Validation(Required=false)]
        public AttachInstanceRamRoleResponseBodyAttachInstanceRamRoleResults AttachInstanceRamRoleResults { get; set; }
        public class AttachInstanceRamRoleResponseBodyAttachInstanceRamRoleResults : TeaModel {
            [NameInMap("AttachInstanceRamRoleResult")]
            [Validation(Required=false)]
            public List<AttachInstanceRamRoleResponseBodyAttachInstanceRamRoleResultsAttachInstanceRamRoleResult> AttachInstanceRamRoleResult { get; set; }
            public class AttachInstanceRamRoleResponseBodyAttachInstanceRamRoleResultsAttachInstanceRamRoleResult : TeaModel {
                public string Code { get; set; }
                public string InstanceId { get; set; }
                public string Message { get; set; }
                public bool? Success { get; set; }
            }
        };

        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
