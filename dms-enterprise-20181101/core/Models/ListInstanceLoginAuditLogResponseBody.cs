// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListInstanceLoginAuditLogResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("InstanceLoginAuditLogList")]
        [Validation(Required=false)]
        public ListInstanceLoginAuditLogResponseBodyInstanceLoginAuditLogList InstanceLoginAuditLogList { get; set; }
        public class ListInstanceLoginAuditLogResponseBodyInstanceLoginAuditLogList : TeaModel {
            [NameInMap("InstanceLoginAuditLog")]
            [Validation(Required=false)]
            public List<ListInstanceLoginAuditLogResponseBodyInstanceLoginAuditLogListInstanceLoginAuditLog> InstanceLoginAuditLog { get; set; }
            public class ListInstanceLoginAuditLogResponseBodyInstanceLoginAuditLogListInstanceLoginAuditLog : TeaModel {
                public string DbUser { get; set; }
                public long? InstanceId { get; set; }
                public string InstanceName { get; set; }
                public string OpTime { get; set; }
                public string RequestIp { get; set; }
                public long? UserId { get; set; }
                public string UserName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
