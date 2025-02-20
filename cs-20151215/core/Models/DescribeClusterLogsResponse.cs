// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterLogsResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=true)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public List<DescribeClusterLogsResponseBody> Body { get; set; }
        public class DescribeClusterLogsResponseBody : TeaModel {
            [NameInMap("ID")]
            [Validation(Required=false)]
            public long? ID { get; set; }

            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("cluster_log")]
            [Validation(Required=false)]
            public string ClusterLog { get; set; }

            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
