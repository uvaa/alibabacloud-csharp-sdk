// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateProblemTimelineResponseBody : TeaModel {
        /// <summary>
        /// Object
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateProblemTimelineResponseBodyData Data { get; set; }
        public class CreateProblemTimelineResponseBodyData : TeaModel {
            [NameInMap("problemTimelineId")]
            [Validation(Required=false)]
            public long? ProblemTimelineId { get; set; }
        };

        /// <summary>
        /// id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
