// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainsResponseBody : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeDomainsResponseBodyDomains> Domains { get; set; }
        public class DescribeDomainsResponseBodyDomains : TeaModel {
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("RecordCount")]
            [Validation(Required=false)]
            public long? RecordCount { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDomainsResponseBodyDomainsTags> Tags { get; set; }
            public class DescribeDomainsResponseBodyDomainsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            [NameInMap("AliDomain")]
            [Validation(Required=false)]
            public bool? AliDomain { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("InstanceEndTime")]
            [Validation(Required=false)]
            public string InstanceEndTime { get; set; }

            [NameInMap("InstanceExpired")]
            [Validation(Required=false)]
            public bool? InstanceExpired { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            [NameInMap("DnsServers")]
            [Validation(Required=false)]
            public List<string> DnsServers { get; set; }

            [NameInMap("VersionCode")]
            [Validation(Required=false)]
            public string VersionCode { get; set; }

            [NameInMap("PunyCode")]
            [Validation(Required=false)]
            public string PunyCode { get; set; }

            [NameInMap("RegistrantEmail")]
            [Validation(Required=false)]
            public string RegistrantEmail { get; set; }

            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            [NameInMap("Starmark")]
            [Validation(Required=false)]
            public bool? Starmark { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

    }

}