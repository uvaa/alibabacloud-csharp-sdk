// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDISyncTaskMetricInfoResponseBody : TeaModel {
        [NameInMap("MetricInfo")]
        [Validation(Required=false)]
        public GetDISyncTaskMetricInfoResponseBodyMetricInfo MetricInfo { get; set; }
        public class GetDISyncTaskMetricInfoResponseBodyMetricInfo : TeaModel {
            [NameInMap("DeleteReaderRecords")]
            [Validation(Required=false)]
            public long? DeleteReaderRecords { get; set; }
            [NameInMap("DeleteWriterRecords")]
            [Validation(Required=false)]
            public long? DeleteWriterRecords { get; set; }
            [NameInMap("InsertReaderRecords")]
            [Validation(Required=false)]
            public long? InsertReaderRecords { get; set; }
            [NameInMap("InsertWriterRecords")]
            [Validation(Required=false)]
            public long? InsertWriterRecords { get; set; }
            [NameInMap("LastTaskDelay")]
            [Validation(Required=false)]
            public long? LastTaskDelay { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("SumReaderRecords")]
            [Validation(Required=false)]
            public long? SumReaderRecords { get; set; }
            [NameInMap("SumWriterRecords")]
            [Validation(Required=false)]
            public long? SumWriterRecords { get; set; }
            [NameInMap("UpdateReaderRecords")]
            [Validation(Required=false)]
            public long? UpdateReaderRecords { get; set; }
            [NameInMap("UpdateWriterRecords")]
            [Validation(Required=false)]
            public long? UpdateWriterRecords { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
