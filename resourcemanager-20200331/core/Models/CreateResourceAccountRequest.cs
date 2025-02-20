// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateResourceAccountRequest : TeaModel {
        [NameInMap("AccountNamePrefix")]
        [Validation(Required=false)]
        public string AccountNamePrefix { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("ParentFolderId")]
        [Validation(Required=false)]
        public string ParentFolderId { get; set; }

        [NameInMap("PayerAccountId")]
        [Validation(Required=false)]
        public string PayerAccountId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateResourceAccountRequestTag> Tag { get; set; }
        public class CreateResourceAccountRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
