// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportVulRequest : TeaModel {
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        [NameInMap("AttachTypes")]
        [Validation(Required=false)]
        public string AttachTypes { get; set; }

        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        [NameInMap("SearchTags")]
        [Validation(Required=false)]
        public string SearchTags { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

        [NameInMap("VpcInstanceIds")]
        [Validation(Required=false)]
        public string VpcInstanceIds { get; set; }

    }

}
