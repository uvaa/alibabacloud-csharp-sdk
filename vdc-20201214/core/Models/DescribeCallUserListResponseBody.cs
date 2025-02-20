// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeCallUserListResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public int? TotalCnt { get; set; }

        [NameInMap("UserDetailList")]
        [Validation(Required=false)]
        public List<DescribeCallUserListResponseBodyUserDetailList> UserDetailList { get; set; }
        public class DescribeCallUserListResponseBodyUserDetailList : TeaModel {
            [NameInMap("CallExp")]
            [Validation(Required=false)]
            public string CallExp { get; set; }

            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            [NameInMap("DurMetricStatData")]
            [Validation(Required=false)]
            public DescribeCallUserListResponseBodyUserDetailListDurMetricStatData DurMetricStatData { get; set; }
            public class DescribeCallUserListResponseBodyUserDetailListDurMetricStatData : TeaModel {
                [NameInMap("PubAudio")]
                [Validation(Required=false)]
                public long? PubAudio { get; set; }
                [NameInMap("PubVideo360")]
                [Validation(Required=false)]
                public long? PubVideo360 { get; set; }
                [NameInMap("PubVideo720")]
                [Validation(Required=false)]
                public long? PubVideo720 { get; set; }
                [NameInMap("PubVideoScreenShare")]
                [Validation(Required=false)]
                public long? PubVideoScreenShare { get; set; }
                [NameInMap("SubAudio")]
                [Validation(Required=false)]
                public long? SubAudio { get; set; }
                [NameInMap("SubVideo1080")]
                [Validation(Required=false)]
                public long? SubVideo1080 { get; set; }
                [NameInMap("SubVideo360")]
                [Validation(Required=false)]
                public long? SubVideo360 { get; set; }
                [NameInMap("SubVideo720")]
                [Validation(Required=false)]
                public long? SubVideo720 { get; set; }
                [NameInMap("SubVideoScreenShare")]
                [Validation(Required=false)]
                public long? SubVideoScreenShare { get; set; }
            };

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("LocationCn")]
            [Validation(Required=false)]
            public string LocationCn { get; set; }

            [NameInMap("LocationEn")]
            [Validation(Required=false)]
            public string LocationEn { get; set; }

            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            [NameInMap("NetworkList")]
            [Validation(Required=false)]
            public List<string> NetworkList { get; set; }

            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribeCallUserListResponseBodyUserDetailListOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribeCallUserListResponseBodyUserDetailListOnlinePeriods : TeaModel {
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

            }

            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("OsList")]
            [Validation(Required=false)]
            public List<string> OsList { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            [NameInMap("SdkVersionList")]
            [Validation(Required=false)]
            public List<string> SdkVersionList { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserIdAlias")]
            [Validation(Required=false)]
            public string UserIdAlias { get; set; }

        }

    }

}
