// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("LogOption")]
        [Validation(Required=false)]
        public string LogOption { get; set; }

        [NameInMap("OutputOption")]
        [Validation(Required=false)]
        public string OutputOption { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ShowResourceProgress")]
        [Validation(Required=false)]
        public string ShowResourceProgress { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
