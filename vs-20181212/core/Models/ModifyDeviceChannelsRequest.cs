// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ModifyDeviceChannelsRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ShowLog")]
        [Validation(Required=false)]
        public string ShowLog { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Dsn")]
        [Validation(Required=false)]
        public string Dsn { get; set; }

        [NameInMap("DeviceStatus")]
        [Validation(Required=false)]
        public string DeviceStatus { get; set; }

        [NameInMap("Channels")]
        [Validation(Required=false)]
        public string Channels { get; set; }

    }

}