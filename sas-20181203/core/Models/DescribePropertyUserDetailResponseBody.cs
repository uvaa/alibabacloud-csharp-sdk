// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUserDetailResponseBody : TeaModel {
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertyUserDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertyUserDetailResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<DescribePropertyUserDetailResponseBodyPropertys> Propertys { get; set; }
        public class DescribePropertyUserDetailResponseBodyPropertys : TeaModel {
            [NameInMap("AccountsExpirationDate")]
            [Validation(Required=false)]
            public string AccountsExpirationDate { get; set; }

            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            [NameInMap("GroupNames")]
            [Validation(Required=false)]
            public List<string> GroupNames { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("IsCouldLogin")]
            [Validation(Required=false)]
            public int? IsCouldLogin { get; set; }

            [NameInMap("IsPasswdExpired")]
            [Validation(Required=false)]
            public int? IsPasswdExpired { get; set; }

            [NameInMap("IsPasswdLocked")]
            [Validation(Required=false)]
            public int? IsPasswdLocked { get; set; }

            [NameInMap("IsRoot")]
            [Validation(Required=false)]
            public string IsRoot { get; set; }

            [NameInMap("IsSudoer")]
            [Validation(Required=false)]
            public int? IsSudoer { get; set; }

            [NameInMap("IsUserExpired")]
            [Validation(Required=false)]
            public int? IsUserExpired { get; set; }

            [NameInMap("LastLoginIp")]
            [Validation(Required=false)]
            public string LastLoginIp { get; set; }

            [NameInMap("LastLoginTime")]
            [Validation(Required=false)]
            public string LastLoginTime { get; set; }

            [NameInMap("LastLoginTimeDt")]
            [Validation(Required=false)]
            public long? LastLoginTimeDt { get; set; }

            [NameInMap("LastLoginTimestamp")]
            [Validation(Required=false)]
            public long? LastLoginTimestamp { get; set; }

            [NameInMap("PasswordExpirationDate")]
            [Validation(Required=false)]
            public string PasswordExpirationDate { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
