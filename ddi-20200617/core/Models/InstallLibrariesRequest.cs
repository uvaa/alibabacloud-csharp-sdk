// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class InstallLibrariesRequest : TeaModel {
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ClusterBizIdList")]
        [Validation(Required=false)]
        public List<string> ClusterBizIdList { get; set; }

        [NameInMap("LibraryBizId")]
        [Validation(Required=false)]
        public string LibraryBizId { get; set; }

    }

}