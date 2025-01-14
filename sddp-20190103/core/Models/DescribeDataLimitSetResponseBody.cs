// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitSetResponseBody : TeaModel {
        [NameInMap("DataLimitSet")]
        [Validation(Required=false)]
        public DescribeDataLimitSetResponseBodyDataLimitSet DataLimitSet { get; set; }
        public class DescribeDataLimitSetResponseBodyDataLimitSet : TeaModel {
            [NameInMap("DataLimitList")]
            [Validation(Required=false)]
            public List<DescribeDataLimitSetResponseBodyDataLimitSetDataLimitList> DataLimitList { get; set; }
            public class DescribeDataLimitSetResponseBodyDataLimitSetDataLimitList : TeaModel {
                public int? CheckStatus { get; set; }
                public string CheckStatusName { get; set; }
                public string Connector { get; set; }
                public long? GmtCreate { get; set; }
                public long? Id { get; set; }
                public string LocalName { get; set; }
                public string ParentId { get; set; }
                public string RegionId { get; set; }
                public long? ResourceType { get; set; }
                public string ResourceTypeCode { get; set; }
                public string UserName { get; set; }
            }
            [NameInMap("OssBucketList")]
            [Validation(Required=false)]
            public List<DescribeDataLimitSetResponseBodyDataLimitSetOssBucketList> OssBucketList { get; set; }
            public class DescribeDataLimitSetResponseBodyDataLimitSetOssBucketList : TeaModel {
                public string BucketName { get; set; }
                public string RegionId { get; set; }
            }
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<DescribeDataLimitSetResponseBodyDataLimitSetRegionList> RegionList { get; set; }
            public class DescribeDataLimitSetResponseBodyDataLimitSetRegionList : TeaModel {
                public string LocalName { get; set; }
                public string RegionId { get; set; }
            }
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public long? ResourceType { get; set; }
            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
