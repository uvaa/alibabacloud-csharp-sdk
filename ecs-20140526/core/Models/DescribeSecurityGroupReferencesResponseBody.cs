// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSecurityGroupReferencesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityGroupReferences")]
        [Validation(Required=false)]
        public List<DescribeSecurityGroupReferencesResponseBodySecurityGroupReferences> SecurityGroupReferences { get; set; }
        public class DescribeSecurityGroupReferencesResponseBodySecurityGroupReferences : TeaModel {
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("ReferencingSecurityGroups")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesReferencingSecurityGroups> ReferencingSecurityGroups { get; set; }
            public class DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesReferencingSecurityGroups : TeaModel {
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

            }

        }

    }

}