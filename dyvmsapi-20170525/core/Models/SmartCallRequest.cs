// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SmartCallRequest : TeaModel {
        [NameInMap("ActionCodeBreak")]
        [Validation(Required=false)]
        public bool? ActionCodeBreak { get; set; }

        [NameInMap("ActionCodeTimeBreak")]
        [Validation(Required=false)]
        public int? ActionCodeTimeBreak { get; set; }

        [NameInMap("AsrBaseId")]
        [Validation(Required=false)]
        public string AsrBaseId { get; set; }

        [NameInMap("AsrModelId")]
        [Validation(Required=false)]
        public string AsrModelId { get; set; }

        [NameInMap("BackgroundFileCode")]
        [Validation(Required=false)]
        public string BackgroundFileCode { get; set; }

        [NameInMap("BackgroundSpeed")]
        [Validation(Required=false)]
        public int? BackgroundSpeed { get; set; }

        [NameInMap("BackgroundVolume")]
        [Validation(Required=false)]
        public int? BackgroundVolume { get; set; }

        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        [NameInMap("DynamicId")]
        [Validation(Required=false)]
        public string DynamicId { get; set; }

        [NameInMap("EarlyMediaAsr")]
        [Validation(Required=false)]
        public bool? EarlyMediaAsr { get; set; }

        [NameInMap("EnableITN")]
        [Validation(Required=false)]
        public bool? EnableITN { get; set; }

        [NameInMap("MuteTime")]
        [Validation(Required=false)]
        public int? MuteTime { get; set; }

        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PauseTime")]
        [Validation(Required=false)]
        public int? PauseTime { get; set; }

        [NameInMap("RecordFlag")]
        [Validation(Required=false)]
        public bool? RecordFlag { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        [NameInMap("Speed")]
        [Validation(Required=false)]
        public int? Speed { get; set; }

        [NameInMap("StreamAsr")]
        [Validation(Required=false)]
        public int? StreamAsr { get; set; }

        [NameInMap("TtsConf")]
        [Validation(Required=false)]
        public bool? TtsConf { get; set; }

        [NameInMap("TtsSpeed")]
        [Validation(Required=false)]
        public int? TtsSpeed { get; set; }

        [NameInMap("TtsStyle")]
        [Validation(Required=false)]
        public string TtsStyle { get; set; }

        [NameInMap("TtsVolume")]
        [Validation(Required=false)]
        public int? TtsVolume { get; set; }

        [NameInMap("VoiceCode")]
        [Validation(Required=false)]
        public string VoiceCode { get; set; }

        [NameInMap("VoiceCodeParam")]
        [Validation(Required=false)]
        public string VoiceCodeParam { get; set; }

        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
