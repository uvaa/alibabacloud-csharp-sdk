// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeTagsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeTagsResponseBodyTags Tags { get; set; }
        public class DescribeTagsResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeTagsResponseBodyTagsTag> Tag { get; set; }
            public class DescribeTagsResponseBodyTagsTag : TeaModel {
                public DescribeTagsResponseBodyTagsTagResourceTypeCount ResourceTypeCount { get; set; }
                public class DescribeTagsResponseBodyTagsTagResourceTypeCount : TeaModel {
                    [NameInMap("Ddh")]
                    [Validation(Required=false)]
                    public int? Ddh { get; set; }

                    [NameInMap("Disk")]
                    [Validation(Required=false)]
                    public int? Disk { get; set; }

                    [NameInMap("Eni")]
                    [Validation(Required=false)]
                    public int? Eni { get; set; }

                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public int? Image { get; set; }

                    [NameInMap("Instance")]
                    [Validation(Required=false)]
                    public int? Instance { get; set; }

                    [NameInMap("KeyPair")]
                    [Validation(Required=false)]
                    public int? KeyPair { get; set; }

                    [NameInMap("LaunchTemplate")]
                    [Validation(Required=false)]
                    public int? LaunchTemplate { get; set; }

                    [NameInMap("ReservedInstance")]
                    [Validation(Required=false)]
                    public int? ReservedInstance { get; set; }

                    [NameInMap("Securitygroup")]
                    [Validation(Required=false)]
                    public int? Securitygroup { get; set; }

                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public int? Snapshot { get; set; }

                    [NameInMap("SnapshotPolicy")]
                    [Validation(Required=false)]
                    public int? SnapshotPolicy { get; set; }

                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public int? Volume { get; set; }

                }
                public string TagKey { get; set; }
                public string TagValue { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
