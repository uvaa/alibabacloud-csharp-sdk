// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetSmartHandleJobResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("FEExtend")]
        [Validation(Required=false)]
        public string FEExtend { get; set; }

        [NameInMap("SmartJobInfo")]
        [Validation(Required=false)]
        public GetSmartHandleJobResponseBodySmartJobInfo SmartJobInfo { get; set; }
        public class GetSmartHandleJobResponseBodySmartJobInfo : TeaModel {
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("EditingConfig")]
            [Validation(Required=false)]
            public string EditingConfig { get; set; }
            [NameInMap("InputConfig")]
            [Validation(Required=false)]
            public GetSmartHandleJobResponseBodySmartJobInfoInputConfig InputConfig { get; set; }
            public class GetSmartHandleJobResponseBodySmartJobInfoInputConfig : TeaModel {
                [NameInMap("InputFile")]
                [Validation(Required=false)]
                public string InputFile { get; set; }

                [NameInMap("JobParameters")]
                [Validation(Required=false)]
                public string JobParameters { get; set; }

            }
            [NameInMap("outputConfig")]
            [Validation(Required=false)]
            public string OutputConfig { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }
        };

    }

}