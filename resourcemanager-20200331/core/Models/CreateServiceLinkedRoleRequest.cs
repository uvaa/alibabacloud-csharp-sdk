// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateServiceLinkedRoleRequest : TeaModel {
        [NameInMap("ServiceName")]
        [Validation(Required=true)]
        public string ServiceName { get; set; }

        [NameInMap("CustomSuffix")]
        [Validation(Required=false)]
        public string CustomSuffix { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}