// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateConsumerGroupRequest : TeaModel {
        [NameInMap("consumerGroup")]
        [Validation(Required=false)]
        public string ConsumerGroup { get; set; }

        [NameInMap("order")]
        [Validation(Required=false)]
        public bool? Order { get; set; }

        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
