// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20161111.Models
{
    public class ListResourceGroupsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroups")]
        [Validation(Required=false)]
        public ListResourceGroupsResponseBodyResourceGroups ResourceGroups { get; set; }
        public class ListResourceGroupsResponseBodyResourceGroups : TeaModel {
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public List<ListResourceGroupsResponseBodyResourceGroupsResourceGroup> ResourceGroup { get; set; }
            public class ListResourceGroupsResponseBodyResourceGroupsResourceGroup : TeaModel {
                public string AccountId { get; set; }
                public string CreateDate { get; set; }
                public string DisplayName { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
