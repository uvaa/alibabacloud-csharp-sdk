// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeProtectionModuleCodeConfigRequest : TeaModel {
        [NameInMap("CodeType")]
        [Validation(Required=false)]
        public int? CodeType { get; set; }

        [NameInMap("CodeValue")]
        [Validation(Required=false)]
        public int? CodeValue { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
