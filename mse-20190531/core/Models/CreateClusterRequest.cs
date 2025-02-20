// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateClusterRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("ClusterSpecification")]
        [Validation(Required=false)]
        public string ClusterSpecification { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("ClusterVersion")]
        [Validation(Required=false)]
        public string ClusterVersion { get; set; }

        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// 用于区分基础/专业版本
        /// </summary>
        [NameInMap("MseVersion")]
        [Validation(Required=false)]
        public string MseVersion { get; set; }

        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        [NameInMap("PrivateSlbSpecification")]
        [Validation(Required=false)]
        public string PrivateSlbSpecification { get; set; }

        [NameInMap("PubNetworkFlow")]
        [Validation(Required=false)]
        public string PubNetworkFlow { get; set; }

        [NameInMap("PubSlbSpecification")]
        [Validation(Required=false)]
        public string PubSlbSpecification { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
