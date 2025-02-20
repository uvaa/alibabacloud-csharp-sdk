// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeElasticityAssuranceInstancesResponseBody : TeaModel {
        [NameInMap("ElasticityAssuranceItem")]
        [Validation(Required=false)]
        public DescribeElasticityAssuranceInstancesResponseBodyElasticityAssuranceItem ElasticityAssuranceItem { get; set; }
        public class DescribeElasticityAssuranceInstancesResponseBodyElasticityAssuranceItem : TeaModel {
            [NameInMap("InstanceIdSet")]
            [Validation(Required=false)]
            public List<DescribeElasticityAssuranceInstancesResponseBodyElasticityAssuranceItemInstanceIdSet> InstanceIdSet { get; set; }
            public class DescribeElasticityAssuranceInstancesResponseBodyElasticityAssuranceItemInstanceIdSet : TeaModel {
                public string InstanceId { get; set; }
            }
        };

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
