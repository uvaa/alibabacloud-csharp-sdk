// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        [NameInMap("EndpointGroups")]
        [Validation(Required=false)]
        public List<GetHealthStatusResponseBodyEndpointGroups> EndpointGroups { get; set; }
        public class GetHealthStatusResponseBodyEndpointGroups : TeaModel {
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            [NameInMap("EndpointGroupType")]
            [Validation(Required=false)]
            public string EndpointGroupType { get; set; }

            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            [NameInMap("ForwardingRuleIds")]
            [Validation(Required=false)]
            public List<string> ForwardingRuleIds { get; set; }

            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<GetHealthStatusResponseBodyEndpointGroupsEndpoints> Endpoints { get; set; }
            public class GetHealthStatusResponseBodyEndpointGroupsEndpoints : TeaModel {
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                [NameInMap("HealthDetail")]
                [Validation(Required=false)]
                public string HealthDetail { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}