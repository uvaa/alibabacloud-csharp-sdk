// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetFeatureDetailsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Terraform")]
        [Validation(Required=false)]
        public GetFeatureDetailsResponseBodyTerraform Terraform { get; set; }
        public class GetFeatureDetailsResponseBodyTerraform : TeaModel {
            [NameInMap("SupportedResourceTypes")]
            [Validation(Required=false)]
            public GetFeatureDetailsResponseBodyTerraformSupportedResourceTypes SupportedResourceTypes { get; set; }
            public class GetFeatureDetailsResponseBodyTerraformSupportedResourceTypes : TeaModel {
                [NameInMap("CustomTag")]
                [Validation(Required=false)]
                public List<string> CustomTag { get; set; }

                [NameInMap("EstimateCost")]
                [Validation(Required=false)]
                public List<string> EstimateCost { get; set; }

                [NameInMap("SystemTag")]
                [Validation(Required=false)]
                public List<string> SystemTag { get; set; }

            }
            [NameInMap("SupportedVersions")]
            [Validation(Required=false)]
            public List<GetFeatureDetailsResponseBodyTerraformSupportedVersions> SupportedVersions { get; set; }
            public class GetFeatureDetailsResponseBodyTerraformSupportedVersions : TeaModel {
                public List<GetFeatureDetailsResponseBodyTerraformSupportedVersionsProviderVersions> ProviderVersions { get; set; }
                public class GetFeatureDetailsResponseBodyTerraformSupportedVersionsProviderVersions : TeaModel {
                    public string ProviderName { get; set; }
                    public List<string> SupportedVersions { get; set; }
                }
                public string TerraformVersion { get; set; }
                public string Transform { get; set; }
            }
        };

    }

}