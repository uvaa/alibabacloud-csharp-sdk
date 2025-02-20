// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListFlowClusterResponseBody : TeaModel {
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public ListFlowClusterResponseBodyClusters Clusters { get; set; }
        public class ListFlowClusterResponseBodyClusters : TeaModel {
            [NameInMap("ClusterInfo")]
            [Validation(Required=false)]
            public List<ListFlowClusterResponseBodyClustersClusterInfo> ClusterInfo { get; set; }
            public class ListFlowClusterResponseBodyClustersClusterInfo : TeaModel {
                public string ChargeType { get; set; }
                public string CreateResource { get; set; }
                public long? CreateTime { get; set; }
                public long? ExpiredTime { get; set; }
                public ListFlowClusterResponseBodyClustersClusterInfoFailReason FailReason { get; set; }
                public class ListFlowClusterResponseBodyClustersClusterInfoFailReason : TeaModel {
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    [NameInMap("RequestId")]
                    [Validation(Required=false)]
                    public string RequestId { get; set; }

                }
                public bool? HasUncompletedOrder { get; set; }
                public string Id { get; set; }
                public string K8sClusterId { get; set; }
                public string Name { get; set; }
                public string OrderList { get; set; }
                public ListFlowClusterResponseBodyClustersClusterInfoOrderTaskInfo OrderTaskInfo { get; set; }
                public class ListFlowClusterResponseBodyClustersClusterInfoOrderTaskInfo : TeaModel {
                    [NameInMap("CurrentCount")]
                    [Validation(Required=false)]
                    public int? CurrentCount { get; set; }

                    [NameInMap("OrderIdList")]
                    [Validation(Required=false)]
                    public string OrderIdList { get; set; }

                    [NameInMap("TargetCount")]
                    [Validation(Required=false)]
                    public int? TargetCount { get; set; }

                }
                public int? Period { get; set; }
                public int? RunningTime { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
            }
        };

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

    }

}
