// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTranscodeJobShrinkRequest : TeaModel {
        [NameInMap("InputGroup")]
        [Validation(Required=false)]
        public string InputGroupShrink { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OutputGroup")]
        [Validation(Required=false)]
        public string OutputGroupShrink { get; set; }

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public string ScheduleConfigShrink { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
