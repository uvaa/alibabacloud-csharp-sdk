// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class CreateAudioFileRequest : TeaModel {
        [NameInMap("AudioFileName")]
        [Validation(Required=false)]
        public string AudioFileName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OssFileKey")]
        [Validation(Required=false)]
        public string OssFileKey { get; set; }

    }

}
