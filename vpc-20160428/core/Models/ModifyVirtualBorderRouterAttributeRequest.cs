// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVirtualBorderRouterAttributeRequest : TeaModel {
        [NameInMap("AssociatedPhysicalConnections")]
        [Validation(Required=false)]
        public string AssociatedPhysicalConnections { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("CircuitCode")]
        [Validation(Required=false)]
        public string CircuitCode { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DetectMultiplier")]
        [Validation(Required=false)]
        public long? DetectMultiplier { get; set; }

        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public bool? EnableIpv6 { get; set; }

        [NameInMap("LocalGatewayIp")]
        [Validation(Required=false)]
        public string LocalGatewayIp { get; set; }

        [NameInMap("LocalIpv6GatewayIp")]
        [Validation(Required=false)]
        public string LocalIpv6GatewayIp { get; set; }

        [NameInMap("MinRxInterval")]
        [Validation(Required=false)]
        public long? MinRxInterval { get; set; }

        [NameInMap("MinTxInterval")]
        [Validation(Required=false)]
        public long? MinTxInterval { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PeerGatewayIp")]
        [Validation(Required=false)]
        public string PeerGatewayIp { get; set; }

        [NameInMap("PeerIpv6GatewayIp")]
        [Validation(Required=false)]
        public string PeerIpv6GatewayIp { get; set; }

        [NameInMap("PeeringIpv6SubnetMask")]
        [Validation(Required=false)]
        public string PeeringIpv6SubnetMask { get; set; }

        [NameInMap("PeeringSubnetMask")]
        [Validation(Required=false)]
        public string PeeringSubnetMask { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public int? VlanId { get; set; }

    }

}
