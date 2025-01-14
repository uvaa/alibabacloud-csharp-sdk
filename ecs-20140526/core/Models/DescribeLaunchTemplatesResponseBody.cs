// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplatesResponseBody : TeaModel {
        [NameInMap("LaunchTemplateSets")]
        [Validation(Required=false)]
        public DescribeLaunchTemplatesResponseBodyLaunchTemplateSets LaunchTemplateSets { get; set; }
        public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSets : TeaModel {
            [NameInMap("LaunchTemplateSet")]
            [Validation(Required=false)]
            public List<DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSet> LaunchTemplateSet { get; set; }
            public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSet : TeaModel {
                public string CreateTime { get; set; }
                public string CreatedBy { get; set; }
                public long? DefaultVersionNumber { get; set; }
                public long? LatestVersionNumber { get; set; }
                public string LaunchTemplateId { get; set; }
                public string LaunchTemplateName { get; set; }
                public string ModifiedTime { get; set; }
                public string ResourceGroupId { get; set; }
                public DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSetTags Tags { get; set; }
                public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSetTagsTag> Tag { get; set; }
                    public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSetTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
