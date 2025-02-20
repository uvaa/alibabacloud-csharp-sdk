// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CancelOTATaskByJobRequest : TeaModel {
        [NameInMap("CancelInProgressTask")]
        [Validation(Required=false)]
        public bool? CancelInProgressTask { get; set; }

        [NameInMap("CancelNotifiedTask")]
        [Validation(Required=false)]
        public bool? CancelNotifiedTask { get; set; }

        [NameInMap("CancelQueuedTask")]
        [Validation(Required=false)]
        public bool? CancelQueuedTask { get; set; }

        [NameInMap("CancelScheduledTask")]
        [Validation(Required=false)]
        public bool? CancelScheduledTask { get; set; }

        [NameInMap("CancelUnconfirmedTask")]
        [Validation(Required=false)]
        public bool? CancelUnconfirmedTask { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
