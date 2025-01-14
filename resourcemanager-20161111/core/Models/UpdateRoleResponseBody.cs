// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20161111.Models
{
    public class UpdateRoleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public UpdateRoleResponseBodyRole Role { get; set; }
        public class UpdateRoleResponseBodyRole : TeaModel {
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }
            [NameInMap("AssumeRolePolicyDocument")]
            [Validation(Required=false)]
            public string AssumeRolePolicyDocument { get; set; }
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("MaxSessionDuration")]
            [Validation(Required=false)]
            public long? MaxSessionDuration { get; set; }
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }
            [NameInMap("RolePrincipalName")]
            [Validation(Required=false)]
            public string RolePrincipalName { get; set; }
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }
        };

    }

}
