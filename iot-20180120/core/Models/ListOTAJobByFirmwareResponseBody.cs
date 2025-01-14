// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAJobByFirmwareResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListOTAJobByFirmwareResponseBodyData Data { get; set; }
        public class ListOTAJobByFirmwareResponseBodyData : TeaModel {
            [NameInMap("SimpleOTAJobInfo")]
            [Validation(Required=false)]
            public List<ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfo> SimpleOTAJobInfo { get; set; }
            public class ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfo : TeaModel {
                public string FirmwareId { get; set; }
                public string JobId { get; set; }
                public string JobStatus { get; set; }
                public string JobType { get; set; }
                public string ProductKey { get; set; }
                public string SelectionType { get; set; }
                public ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfoTags Tags { get; set; }
                public class ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfoTags : TeaModel {
                    [NameInMap("OtaTagDTO")]
                    [Validation(Required=false)]
                    public List<ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfoTagsOtaTagDTO> OtaTagDTO { get; set; }
                    public class ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfoTagsOtaTagDTO : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string TargetSelection { get; set; }
                public string UtcCreate { get; set; }
                public string UtcEndTime { get; set; }
                public string UtcModified { get; set; }
                public string UtcStartTime { get; set; }
            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
