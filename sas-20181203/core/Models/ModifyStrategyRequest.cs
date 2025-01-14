// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyStrategyRequest : TeaModel {
        [NameInMap("CustomType")]
        [Validation(Required=false)]
        public string CustomType { get; set; }

        [NameInMap("CycleDays")]
        [Validation(Required=false)]
        public string CycleDays { get; set; }

        [NameInMap("CycleStartTime")]
        [Validation(Required=false)]
        public string CycleStartTime { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RiskCustomParams")]
        [Validation(Required=false)]
        public string RiskCustomParams { get; set; }

        [NameInMap("RiskSubTypeName")]
        [Validation(Required=false)]
        public string RiskSubTypeName { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
