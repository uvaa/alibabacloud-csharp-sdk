// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListEndpointGroupsRequest : TeaModel {
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("AccessLogSwitch")]
        [Validation(Required=false)]
        public string AccessLogSwitch { get; set; }

        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        [NameInMap("EndpointGroupType")]
        [Validation(Required=false)]
        public string EndpointGroupType { get; set; }

        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
