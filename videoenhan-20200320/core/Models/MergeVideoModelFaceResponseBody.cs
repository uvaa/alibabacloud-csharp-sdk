// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class MergeVideoModelFaceResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public MergeVideoModelFaceResponseBodyData Data { get; set; }
        public class MergeVideoModelFaceResponseBodyData : TeaModel {
            [NameInMap("VideoURL")]
            [Validation(Required=false)]
            public string VideoURL { get; set; }
        };

    }

}
