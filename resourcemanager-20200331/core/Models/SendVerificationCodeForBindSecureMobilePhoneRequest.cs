// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class SendVerificationCodeForBindSecureMobilePhoneRequest : TeaModel {
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("SecureMobilePhone")]
        [Validation(Required=false)]
        public string SecureMobilePhone { get; set; }

    }

}
