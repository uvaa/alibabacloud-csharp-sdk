// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateADConnectorDirectoryRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("DomainUserName")]
        [Validation(Required=true)]
        public string DomainUserName { get; set; }

        [NameInMap("DomainPassword")]
        [Validation(Required=true)]
        public string DomainPassword { get; set; }

        [NameInMap("DnsAddress")]
        [Validation(Required=false)]
        public List<string> DnsAddress { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

        [NameInMap("DirectoryName")]
        [Validation(Required=false)]
        public string DirectoryName { get; set; }

    }

}