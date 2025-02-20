// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleTargetListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ContactParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyContactParameters ContactParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyContactParameters : TeaModel {
            [NameInMap("ContactParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyContactParametersContactParameter> ContactParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodyContactParametersContactParameter : TeaModel {
                public string ContactGroupName { get; set; }
                public string Id { get; set; }
                public string Level { get; set; }
            }
        };

        [NameInMap("FcParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyFcParameters FcParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyFcParameters : TeaModel {
            [NameInMap("FCParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyFcParametersFCParameter> FCParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodyFcParametersFCParameter : TeaModel {
                public string Arn { get; set; }
                public string FunctionName { get; set; }
                public string Id { get; set; }
                public string Region { get; set; }
                public string ServiceName { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("MnsParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyMnsParameters MnsParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyMnsParameters : TeaModel {
            [NameInMap("MnsParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyMnsParametersMnsParameter> MnsParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodyMnsParametersMnsParameter : TeaModel {
                public string Arn { get; set; }
                public string Id { get; set; }
                public string Queue { get; set; }
                public string Region { get; set; }
                public string Topic { get; set; }
            }
        };

        [NameInMap("OpenApiParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyOpenApiParameters OpenApiParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyOpenApiParameters : TeaModel {
            [NameInMap("OpenApiParameters")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyOpenApiParametersOpenApiParameters> OpenApiParameters { get; set; }
            public class DescribeEventRuleTargetListResponseBodyOpenApiParametersOpenApiParameters : TeaModel {
                public string Action { get; set; }
                public string Arn { get; set; }
                public string Id { get; set; }
                public string Product { get; set; }
                public string Region { get; set; }
                public string Role { get; set; }
                public string Version { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlsParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodySlsParameters SlsParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodySlsParameters : TeaModel {
            [NameInMap("SlsParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodySlsParametersSlsParameter> SlsParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodySlsParametersSlsParameter : TeaModel {
                public string Arn { get; set; }
                public string Id { get; set; }
                public string LogStore { get; set; }
                public string Project { get; set; }
                public string Region { get; set; }
            }
        };

        [NameInMap("WebhookParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyWebhookParameters WebhookParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyWebhookParameters : TeaModel {
            [NameInMap("WebhookParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyWebhookParametersWebhookParameter> WebhookParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodyWebhookParametersWebhookParameter : TeaModel {
                public string Id { get; set; }
                public string Method { get; set; }
                public string Protocol { get; set; }
                public string Url { get; set; }
            }
        };

    }

}
