// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchAddThingTopoRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("GwProductKey")]
        [Validation(Required=false)]
        public string GwProductKey { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public Dictionary<string, object> Ext { get; set; }

        [NameInMap("GwDeviceName")]
        [Validation(Required=false)]
        public string GwDeviceName { get; set; }

        [NameInMap("TopoAddItem")]
        [Validation(Required=false)]
        public List<BatchAddThingTopoRequestTopoAddItem> TopoAddItem { get; set; }
        public class BatchAddThingTopoRequestTopoAddItem : TeaModel {
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            [NameInMap("SignMethod")]
            [Validation(Required=false)]
            public string SignMethod { get; set; }

            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

        }

    }

}