// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryOTAFirmwareResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("FirmwareInfo")]
        [Validation(Required=false)]
        public QueryOTAFirmwareResponseBodyFirmwareInfo FirmwareInfo { get; set; }
        public class QueryOTAFirmwareResponseBodyFirmwareInfo : TeaModel {
            [NameInMap("FirmwareName")]
            [Validation(Required=false)]
            public string FirmwareName { get; set; }
            [NameInMap("FirmwareId")]
            [Validation(Required=false)]
            public string FirmwareId { get; set; }
            [NameInMap("SrcVersion")]
            [Validation(Required=false)]
            public string SrcVersion { get; set; }
            [NameInMap("DestVersion")]
            [Validation(Required=false)]
            public string DestVersion { get; set; }
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }
            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("FirmwareDesc")]
            [Validation(Required=false)]
            public string FirmwareDesc { get; set; }
            [NameInMap("FirmwareSign")]
            [Validation(Required=false)]
            public string FirmwareSign { get; set; }
            [NameInMap("FirmwareSize")]
            [Validation(Required=false)]
            public int? FirmwareSize { get; set; }
            [NameInMap("FirmwareUrl")]
            [Validation(Required=false)]
            public string FirmwareUrl { get; set; }
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }
            [NameInMap("SignMethod")]
            [Validation(Required=false)]
            public string SignMethod { get; set; }
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }
            [NameInMap("VerifyProgress")]
            [Validation(Required=false)]
            public int? VerifyProgress { get; set; }
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }
        };

    }

}