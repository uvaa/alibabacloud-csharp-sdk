// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UnInstallClusterAddonsRequest : TeaModel {
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<UnInstallClusterAddonsRequestAddons> Addons { get; set; }
        public class UnInstallClusterAddonsRequestAddons : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
