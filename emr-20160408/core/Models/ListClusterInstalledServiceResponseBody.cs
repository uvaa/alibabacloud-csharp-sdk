// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterInstalledServiceResponseBody : TeaModel {
        [NameInMap("ClusterInstalledServiceList")]
        [Validation(Required=false)]
        public ListClusterInstalledServiceResponseBodyClusterInstalledServiceList ClusterInstalledServiceList { get; set; }
        public class ListClusterInstalledServiceResponseBodyClusterInstalledServiceList : TeaModel {
            [NameInMap("ClusterInstalledService")]
            [Validation(Required=false)]
            public List<ListClusterInstalledServiceResponseBodyClusterInstalledServiceListClusterInstalledService> ClusterInstalledService { get; set; }
            public class ListClusterInstalledServiceResponseBodyClusterInstalledServiceListClusterInstalledService : TeaModel {
                public ListClusterInstalledServiceResponseBodyClusterInstalledServiceListClusterInstalledServiceServiceActionList ServiceActionList { get; set; }
                public class ListClusterInstalledServiceResponseBodyClusterInstalledServiceListClusterInstalledServiceServiceActionList : TeaModel {
                    [NameInMap("ServiceAction")]
                    [Validation(Required=false)]
                    public List<ListClusterInstalledServiceResponseBodyClusterInstalledServiceListClusterInstalledServiceServiceActionListServiceAction> ServiceAction { get; set; }
                    public class ListClusterInstalledServiceResponseBodyClusterInstalledServiceListClusterInstalledServiceServiceActionListServiceAction : TeaModel {
                        [NameInMap("ActionName")]
                        [Validation(Required=false)]
                        public string ActionName { get; set; }

                        [NameInMap("Command")]
                        [Validation(Required=false)]
                        public string Command { get; set; }

                        [NameInMap("ComponentName")]
                        [Validation(Required=false)]
                        public string ComponentName { get; set; }

                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        [NameInMap("ServiceName")]
                        [Validation(Required=false)]
                        public string ServiceName { get; set; }

                    }

                }
                public string ServiceDisplayName { get; set; }
                public string ServiceEcmVersion { get; set; }
                public string ServiceName { get; set; }
                public string ServiceVersion { get; set; }
                public string State { get; set; }
                public int? AbnormalNum { get; set; }
                public string Comment { get; set; }
                public int? NeedRestartNum { get; set; }
                public int? NotStartedNum { get; set; }
                public bool? OnlyClient { get; set; }
                public string ServiceStatus { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
