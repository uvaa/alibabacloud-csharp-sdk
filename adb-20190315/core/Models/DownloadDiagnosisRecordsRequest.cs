// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DownloadDiagnosisRecordsRequest : TeaModel {
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("MaxPeakMemory")]
        [Validation(Required=false)]
        public long? MaxPeakMemory { get; set; }

        [NameInMap("MaxScanSize")]
        [Validation(Required=false)]
        public long? MaxScanSize { get; set; }

        [NameInMap("MinPeakMemory")]
        [Validation(Required=false)]
        public long? MinPeakMemory { get; set; }

        [NameInMap("MinScanSize")]
        [Validation(Required=false)]
        public long? MinScanSize { get; set; }

        [NameInMap("QueryCondition")]
        [Validation(Required=false)]
        public string QueryCondition { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
