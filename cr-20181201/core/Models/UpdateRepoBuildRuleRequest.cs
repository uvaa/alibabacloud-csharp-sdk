// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateRepoBuildRuleRequest : TeaModel {
        [NameInMap("BuildArgs")]
        [Validation(Required=false)]
        public List<string> BuildArgs { get; set; }

        [NameInMap("BuildRuleId")]
        [Validation(Required=false)]
        public string BuildRuleId { get; set; }

        [NameInMap("DockerfileLocation")]
        [Validation(Required=false)]
        public string DockerfileLocation { get; set; }

        [NameInMap("DockerfileName")]
        [Validation(Required=false)]
        public string DockerfileName { get; set; }

        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Platforms")]
        [Validation(Required=false)]
        public List<string> Platforms { get; set; }

        [NameInMap("PushName")]
        [Validation(Required=false)]
        public string PushName { get; set; }

        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

    }

}
