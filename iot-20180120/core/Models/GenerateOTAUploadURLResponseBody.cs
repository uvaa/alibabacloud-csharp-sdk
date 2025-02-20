// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GenerateOTAUploadURLResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateOTAUploadURLResponseBodyData Data { get; set; }
        public class GenerateOTAUploadURLResponseBodyData : TeaModel {
            [NameInMap("FirmwareUrl")]
            [Validation(Required=false)]
            public string FirmwareUrl { get; set; }
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }
            [NameInMap("OSSAccessKeyId")]
            [Validation(Required=false)]
            public string OSSAccessKeyId { get; set; }
            [NameInMap("ObjectStorage")]
            [Validation(Required=false)]
            public string ObjectStorage { get; set; }
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
