// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyDBInstanceConnectionModeRequest : TeaModel {
        [NameInMap("ConnectionMode")]
        [Validation(Required=false)]
        public string ConnectionMode { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

    }

}
