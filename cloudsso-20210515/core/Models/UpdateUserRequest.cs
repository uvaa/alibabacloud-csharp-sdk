// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateUserRequest : TeaModel {
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

        [NameInMap("NewEmail")]
        [Validation(Required=false)]
        public string NewEmail { get; set; }

        [NameInMap("NewFirstName")]
        [Validation(Required=false)]
        public string NewFirstName { get; set; }

        [NameInMap("NewLastName")]
        [Validation(Required=false)]
        public string NewLastName { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
