// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnConnectionsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VpnConnections")]
        [Validation(Required=false)]
        public DescribeVpnConnectionsResponseBodyVpnConnections VpnConnections { get; set; }
        public class DescribeVpnConnectionsResponseBodyVpnConnections : TeaModel {
            [NameInMap("VpnConnection")]
            [Validation(Required=false)]
            public List<DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnection> VpnConnection { get; set; }
            public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnection : TeaModel {
                public string AttachInstanceId { get; set; }
                public string AttachType { get; set; }
                public long? CreateTime { get; set; }
                public bool? CrossAccountAuthorized { get; set; }
                public string CustomerGatewayId { get; set; }
                public bool? EffectImmediately { get; set; }
                public bool? EnableDpd { get; set; }
                public bool? EnableNatTraversal { get; set; }
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionIkeConfig IkeConfig { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionIkeConfig : TeaModel {
                    [NameInMap("IkeAuthAlg")]
                    [Validation(Required=false)]
                    public string IkeAuthAlg { get; set; }

                    [NameInMap("IkeEncAlg")]
                    [Validation(Required=false)]
                    public string IkeEncAlg { get; set; }

                    [NameInMap("IkeLifetime")]
                    [Validation(Required=false)]
                    public long? IkeLifetime { get; set; }

                    [NameInMap("IkeMode")]
                    [Validation(Required=false)]
                    public string IkeMode { get; set; }

                    [NameInMap("IkePfs")]
                    [Validation(Required=false)]
                    public string IkePfs { get; set; }

                    [NameInMap("IkeVersion")]
                    [Validation(Required=false)]
                    public string IkeVersion { get; set; }

                    [NameInMap("LocalId")]
                    [Validation(Required=false)]
                    public string LocalId { get; set; }

                    [NameInMap("Psk")]
                    [Validation(Required=false)]
                    public string Psk { get; set; }

                    [NameInMap("RemoteId")]
                    [Validation(Required=false)]
                    public string RemoteId { get; set; }

                }
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionIpsecConfig IpsecConfig { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionIpsecConfig : TeaModel {
                    [NameInMap("IpsecAuthAlg")]
                    [Validation(Required=false)]
                    public string IpsecAuthAlg { get; set; }

                    [NameInMap("IpsecEncAlg")]
                    [Validation(Required=false)]
                    public string IpsecEncAlg { get; set; }

                    [NameInMap("IpsecLifetime")]
                    [Validation(Required=false)]
                    public long? IpsecLifetime { get; set; }

                    [NameInMap("IpsecPfs")]
                    [Validation(Required=false)]
                    public string IpsecPfs { get; set; }

                }
                public string LocalSubnet { get; set; }
                public string Name { get; set; }
                public string NetworkType { get; set; }
                public string RemoteCaCertificate { get; set; }
                public string RemoteSubnet { get; set; }
                public string Spec { get; set; }
                public string State { get; set; }
                public string Status { get; set; }
                public string TransitRouterId { get; set; }
                public string TransitRouterName { get; set; }
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionVcoHealthCheck VcoHealthCheck { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionVcoHealthCheck : TeaModel {
                    [NameInMap("Dip")]
                    [Validation(Required=false)]
                    public string Dip { get; set; }

                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public string Enable { get; set; }

                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    [NameInMap("Retry")]
                    [Validation(Required=false)]
                    public int? Retry { get; set; }

                    [NameInMap("Sip")]
                    [Validation(Required=false)]
                    public string Sip { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionVpnBgpConfig VpnBgpConfig { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionVpnBgpConfig : TeaModel {
                    [NameInMap("AuthKey")]
                    [Validation(Required=false)]
                    public string AuthKey { get; set; }

                    [NameInMap("LocalAsn")]
                    [Validation(Required=false)]
                    public long? LocalAsn { get; set; }

                    [NameInMap("LocalBgpIp")]
                    [Validation(Required=false)]
                    public string LocalBgpIp { get; set; }

                    [NameInMap("PeerAsn")]
                    [Validation(Required=false)]
                    public long? PeerAsn { get; set; }

                    [NameInMap("PeerBgpIp")]
                    [Validation(Required=false)]
                    public string PeerBgpIp { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("TunnelCidr")]
                    [Validation(Required=false)]
                    public string TunnelCidr { get; set; }

                }
                public string VpnConnectionId { get; set; }
                public string VpnGatewayId { get; set; }
            }
        };

    }

}
