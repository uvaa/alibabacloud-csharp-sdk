// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class PromoteResourceAccountRequest : TeaModel {
        [NameInMap("AccountId")]
        [Validation(Required=true)]
        public string AccountId { get; set; }

        [NameInMap("Email")]
        [Validation(Required=true)]
        public string Email { get; set; }

    }

}