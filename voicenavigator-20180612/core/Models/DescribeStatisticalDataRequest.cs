// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class DescribeStatisticalDataRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TimeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

        [NameInMap("BeginTimeLeftRange")]
        [Validation(Required=false)]
        public long? BeginTimeLeftRange { get; set; }

        [NameInMap("BeginTimeRightRange")]
        [Validation(Required=false)]
        public long? BeginTimeRightRange { get; set; }

    }

}
