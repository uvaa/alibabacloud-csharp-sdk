// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeClusterServiceConfigTagResponseBody : TeaModel {
        [NameInMap("ConfigTagList")]
        [Validation(Required=false)]
        public DescribeClusterServiceConfigTagResponseBodyConfigTagList ConfigTagList { get; set; }
        public class DescribeClusterServiceConfigTagResponseBodyConfigTagList : TeaModel {
            [NameInMap("ConfigTag")]
            [Validation(Required=false)]
            public List<DescribeClusterServiceConfigTagResponseBodyConfigTagListConfigTag> ConfigTag { get; set; }
            public class DescribeClusterServiceConfigTagResponseBodyConfigTagListConfigTag : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<DescribeClusterServiceConfigTagResponseBodyConfigTagListConfigTagValue> Value { get; set; }
                public class DescribeClusterServiceConfigTagResponseBodyConfigTagListConfigTagValue : TeaModel {
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("ValueDesc")]
                    [Validation(Required=false)]
                    public string ValueDesc { get; set; }

                }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}