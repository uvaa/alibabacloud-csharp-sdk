// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeUserPermissionsResponseBody : TeaModel {
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<DescribeUserPermissionsResponseBodyPermissions> Permissions { get; set; }
        public class DescribeUserPermissionsResponseBodyPermissions : TeaModel {
            [NameInMap("IsRamRole")]
            [Validation(Required=false)]
            public string IsRamRole { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
