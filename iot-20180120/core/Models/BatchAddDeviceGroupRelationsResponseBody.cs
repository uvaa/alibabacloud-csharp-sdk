// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchAddDeviceGroupRelationsResponseBody : TeaModel {
        [NameInMap("AlreadyRelatedGroupDeviceCount")]
        [Validation(Required=false)]
        public int? AlreadyRelatedGroupDeviceCount { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ExceedTenGroupDeviceCount")]
        [Validation(Required=false)]
        public int? ExceedTenGroupDeviceCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("SuccessAddedDeviceCount")]
        [Validation(Required=false)]
        public int? SuccessAddedDeviceCount { get; set; }

        [NameInMap("ValidDeviceCount")]
        [Validation(Required=false)]
        public int? ValidDeviceCount { get; set; }

    }

}
