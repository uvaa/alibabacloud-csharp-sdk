// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceIPArrayListResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceIPArrayListResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceIPArrayListResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceIPArray")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceIPArrayListResponseBodyItemsDBInstanceIPArray> DBInstanceIPArray { get; set; }
            public class DescribeDBInstanceIPArrayListResponseBodyItemsDBInstanceIPArray : TeaModel {
                public string DBInstanceIPArrayAttribute { get; set; }
                public string DBInstanceIPArrayName { get; set; }
                public string SecurityIPList { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
