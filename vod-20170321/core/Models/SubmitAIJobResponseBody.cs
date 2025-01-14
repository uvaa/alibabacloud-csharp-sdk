// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIJobResponseBody : TeaModel {
        [NameInMap("AIJobList")]
        [Validation(Required=false)]
        public SubmitAIJobResponseBodyAIJobList AIJobList { get; set; }
        public class SubmitAIJobResponseBodyAIJobList : TeaModel {
            [NameInMap("AIJob")]
            [Validation(Required=false)]
            public List<SubmitAIJobResponseBodyAIJobListAIJob> AIJob { get; set; }
            public class SubmitAIJobResponseBodyAIJobListAIJob : TeaModel {
                public string JobId { get; set; }
                public string MediaId { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
