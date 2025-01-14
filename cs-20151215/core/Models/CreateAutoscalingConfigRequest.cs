// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateAutoscalingConfigRequest : TeaModel {
        [NameInMap("cool_down_duration")]
        [Validation(Required=false)]
        public string CoolDownDuration { get; set; }

        [NameInMap("expander")]
        [Validation(Required=false)]
        public string Expander { get; set; }

        [NameInMap("gpu_utilization_threshold")]
        [Validation(Required=false)]
        public string GpuUtilizationThreshold { get; set; }

        [NameInMap("scale_down_enabled")]
        [Validation(Required=false)]
        public bool? ScaleDownEnabled { get; set; }

        [NameInMap("scan_interval")]
        [Validation(Required=false)]
        public string ScanInterval { get; set; }

        [NameInMap("unneeded_duration")]
        [Validation(Required=false)]
        public string UnneededDuration { get; set; }

        [NameInMap("utilization_threshold")]
        [Validation(Required=false)]
        public string UtilizationThreshold { get; set; }

    }

}
