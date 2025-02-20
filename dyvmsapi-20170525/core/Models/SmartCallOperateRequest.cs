// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SmartCallOperateRequest : TeaModel {
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
