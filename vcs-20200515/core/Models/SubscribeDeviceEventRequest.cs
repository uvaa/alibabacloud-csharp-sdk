// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class SubscribeDeviceEventRequest : TeaModel {
        [NameInMap("DeviceId")]
        [Validation(Required=true)]
        public string DeviceId { get; set; }

        [NameInMap("PushConfig")]
        [Validation(Required=true)]
        public string PushConfig { get; set; }

    }

}