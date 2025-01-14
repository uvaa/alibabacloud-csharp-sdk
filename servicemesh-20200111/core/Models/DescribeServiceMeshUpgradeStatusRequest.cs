// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshUpgradeStatusRequest : TeaModel {
        [NameInMap("AllIstioGatewayFullNames")]
        [Validation(Required=false)]
        public string AllIstioGatewayFullNames { get; set; }

        [NameInMap("GuestClusterIds")]
        [Validation(Required=false)]
        public string GuestClusterIds { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
