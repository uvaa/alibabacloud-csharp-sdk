// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceMeshes")]
        [Validation(Required=false)]
        public List<DescribeServiceMeshesResponseBodyServiceMeshes> ServiceMeshes { get; set; }
        public class DescribeServiceMeshesResponseBodyServiceMeshes : TeaModel {
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeServiceMeshesResponseBodyServiceMeshesEndpoints Endpoints { get; set; }
            public class DescribeServiceMeshesResponseBodyServiceMeshesEndpoints : TeaModel {
                [NameInMap("IntranetPilotEndpoint")]
                [Validation(Required=false)]
                public string IntranetPilotEndpoint { get; set; }
                [NameInMap("ReverseTunnelEndpoint")]
                [Validation(Required=false)]
                public string ReverseTunnelEndpoint { get; set; }
                [NameInMap("PublicPilotEndpoint")]
                [Validation(Required=false)]
                public string PublicPilotEndpoint { get; set; }
                [NameInMap("IntranetApiServerEndpoint")]
                [Validation(Required=false)]
                public string IntranetApiServerEndpoint { get; set; }
                [NameInMap("PublicApiServerEndpoint")]
                [Validation(Required=false)]
                public string PublicApiServerEndpoint { get; set; }
            };

            [NameInMap("ServiceMeshInfo")]
            [Validation(Required=false)]
            public DescribeServiceMeshesResponseBodyServiceMeshesServiceMeshInfo ServiceMeshInfo { get; set; }
            public class DescribeServiceMeshesResponseBodyServiceMeshesServiceMeshInfo : TeaModel {
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }
                [NameInMap("ServiceMeshId")]
                [Validation(Required=false)]
                public string ServiceMeshId { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }
            };

            [NameInMap("Spec")]
            [Validation(Required=false)]
            public DescribeServiceMeshesResponseBodyServiceMeshesSpec Spec { get; set; }
            public class DescribeServiceMeshesResponseBodyServiceMeshesSpec : TeaModel {
                [NameInMap("Network")]
                [Validation(Required=false)]
                public DescribeServiceMeshesResponseBodyServiceMeshesSpecNetwork Network { get; set; }
                public class DescribeServiceMeshesResponseBodyServiceMeshesSpecNetwork : TeaModel {
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    [NameInMap("VSwitches")]
                    [Validation(Required=false)]
                    public List<string> VSwitches { get; set; }

                }
                [NameInMap("LoadBalancer")]
                [Validation(Required=false)]
                public DescribeServiceMeshesResponseBodyServiceMeshesSpecLoadBalancer LoadBalancer { get; set; }
                public class DescribeServiceMeshesResponseBodyServiceMeshesSpecLoadBalancer : TeaModel {
                    [NameInMap("PilotPublicEip")]
                    [Validation(Required=false)]
                    public bool? PilotPublicEip { get; set; }

                    [NameInMap("PilotPublicLoadbalancerId")]
                    [Validation(Required=false)]
                    public string PilotPublicLoadbalancerId { get; set; }

                    [NameInMap("ApiServerLoadbalancerId")]
                    [Validation(Required=false)]
                    public string ApiServerLoadbalancerId { get; set; }

                    [NameInMap("ApiServerPublicEip")]
                    [Validation(Required=false)]
                    public bool? ApiServerPublicEip { get; set; }

                }
                [NameInMap("MeshConfig")]
                [Validation(Required=false)]
                public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfig MeshConfig { get; set; }
                public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfig : TeaModel {
                    [NameInMap("Telemetry")]
                    [Validation(Required=false)]
                    public bool? Telemetry { get; set; }

                    [NameInMap("OutboundTrafficPolicy")]
                    [Validation(Required=false)]
                    public string OutboundTrafficPolicy { get; set; }

                    [NameInMap("Tracing")]
                    [Validation(Required=false)]
                    public bool? Tracing { get; set; }

                    [NameInMap("StrictMtls")]
                    [Validation(Required=false)]
                    public bool? StrictMtls { get; set; }

                    [NameInMap("Pilot")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigPilot Pilot { get; set; }
                    public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigPilot : TeaModel {
                        [NameInMap("Http10Enabled")]
                        [Validation(Required=false)]
                        public bool? Http10Enabled { get; set; }
                        [NameInMap("TraceSampling")]
                        [Validation(Required=false)]
                        public float? TraceSampling { get; set; }
                    };

                    [NameInMap("Mtls")]
                    [Validation(Required=false)]
                    public bool? Mtls { get; set; }

                    [NameInMap("SidecarInjector")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigSidecarInjector SidecarInjector { get; set; }
                    public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigSidecarInjector : TeaModel {
                        [NameInMap("EnableNamespacesByDefault")]
                        [Validation(Required=false)]
                        public bool? EnableNamespacesByDefault { get; set; }
                        [NameInMap("AutoInjectionPolicyEnabled")]
                        [Validation(Required=false)]
                        public bool? AutoInjectionPolicyEnabled { get; set; }
                        [NameInMap("InitCNIConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigSidecarInjectorInitCNIConfiguration InitCNIConfiguration { get; set; }
                        public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigSidecarInjectorInitCNIConfiguration : TeaModel {
                            [NameInMap("ExcludeNamespaces")]
                            [Validation(Required=false)]
                            public string ExcludeNamespaces { get; set; }

                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                        }
                    };

                }
            };

            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<string> Clusters { get; set; }

        }

    }

}