// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceOriginalServiceDataRequest : TeaModel {
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public int? Asc { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
