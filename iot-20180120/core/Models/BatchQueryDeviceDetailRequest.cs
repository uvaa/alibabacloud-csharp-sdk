// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchQueryDeviceDetailRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("RealTenantId")]
        [Validation(Required=false)]
        public string RealTenantId { get; set; }

        [NameInMap("RealTripartiteKey")]
        [Validation(Required=false)]
        public string RealTripartiteKey { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public List<string> DeviceName { get; set; }

    }

}