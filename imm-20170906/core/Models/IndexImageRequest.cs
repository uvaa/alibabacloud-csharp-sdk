// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class IndexImageRequest : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        [NameInMap("RemarksA")]
        [Validation(Required=false)]
        public string RemarksA { get; set; }

        [NameInMap("RemarksB")]
        [Validation(Required=false)]
        public string RemarksB { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("SourceUri")]
        [Validation(Required=false)]
        public string SourceUri { get; set; }

        [NameInMap("SourcePosition")]
        [Validation(Required=false)]
        public string SourcePosition { get; set; }

        [NameInMap("RemarksC")]
        [Validation(Required=false)]
        public string RemarksC { get; set; }

        [NameInMap("RemarksD")]
        [Validation(Required=false)]
        public string RemarksD { get; set; }

        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

        [NameInMap("RealUid")]
        [Validation(Required=false)]
        public string RealUid { get; set; }

        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("RemarksArrayA")]
        [Validation(Required=false)]
        public string RemarksArrayA { get; set; }

        [NameInMap("RemarksArrayB")]
        [Validation(Required=false)]
        public string RemarksArrayB { get; set; }

    }

}