// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectLivingFaceRequest : TeaModel {
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DetectLivingFaceRequestTasks> Tasks { get; set; }
        public class DetectLivingFaceRequestTasks : TeaModel {
            [NameInMap("ImageData")]
            [Validation(Required=false)]
            public byte[] ImageData { get; set; }

            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

    }

}
