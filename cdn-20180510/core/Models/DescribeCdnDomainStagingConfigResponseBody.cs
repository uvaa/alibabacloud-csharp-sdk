// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainStagingConfigResponseBody : TeaModel {
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeCdnDomainStagingConfigResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeCdnDomainStagingConfigResponseBodyDomainConfigs : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            [NameInMap("FunctionArgs")]
            [Validation(Required=false)]
            public List<DescribeCdnDomainStagingConfigResponseBodyDomainConfigsFunctionArgs> FunctionArgs { get; set; }
            public class DescribeCdnDomainStagingConfigResponseBodyDomainConfigsFunctionArgs : TeaModel {
                [NameInMap("ArgName")]
                [Validation(Required=false)]
                public string ArgName { get; set; }

                [NameInMap("ArgValue")]
                [Validation(Required=false)]
                public string ArgValue { get; set; }

            }

            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
