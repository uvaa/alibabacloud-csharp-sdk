// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class IvrCallRequest : TeaModel {
        [NameInMap("ByeCode")]
        [Validation(Required=false)]
        public string ByeCode { get; set; }

        [NameInMap("ByeTtsParams")]
        [Validation(Required=false)]
        public string ByeTtsParams { get; set; }

        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        [NameInMap("MenuKeyMap")]
        [Validation(Required=false)]
        public List<IvrCallRequestMenuKeyMap> MenuKeyMap { get; set; }
        public class IvrCallRequestMenuKeyMap : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("TtsParams")]
            [Validation(Required=false)]
            public string TtsParams { get; set; }

        }

        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public long? PlayTimes { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("StartCode")]
        [Validation(Required=false)]
        public string StartCode { get; set; }

        [NameInMap("StartTtsParams")]
        [Validation(Required=false)]
        public string StartTtsParams { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
