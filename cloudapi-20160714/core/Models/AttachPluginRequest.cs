// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class AttachPluginRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("ApiIds")]
        [Validation(Required=false)]
        public string ApiIds { get; set; }

        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

    }

}