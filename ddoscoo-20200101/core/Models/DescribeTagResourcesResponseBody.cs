// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeTagResourcesResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public DescribeTagResourcesResponseBodyTagResources TagResources { get; set; }
        public class DescribeTagResourcesResponseBodyTagResources : TeaModel {
            [NameInMap("TagResource")]
            [Validation(Required=false)]
            public List<DescribeTagResourcesResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class DescribeTagResourcesResponseBodyTagResourcesTagResource : TeaModel {
                public string ResourceType { get; set; }
                public string TagValue { get; set; }
                public string ResourceId { get; set; }
                public string TagKey { get; set; }
            }
        };

    }

}