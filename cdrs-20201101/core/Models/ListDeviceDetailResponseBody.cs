// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListDeviceDetailResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDeviceDetailResponseBodyData> Data { get; set; }
        public class ListDeviceDetailResponseBodyData : TeaModel {
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            [NameInMap("DataSourcePoi")]
            [Validation(Required=false)]
            public string DataSourcePoi { get; set; }

            [NameInMap("NearPoi")]
            [Validation(Required=false)]
            public string NearPoi { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}