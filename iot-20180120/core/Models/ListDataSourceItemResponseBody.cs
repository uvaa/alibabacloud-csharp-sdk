// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDataSourceItemResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DataSourceItems")]
        [Validation(Required=false)]
        public ListDataSourceItemResponseBodyDataSourceItems DataSourceItems { get; set; }
        public class ListDataSourceItemResponseBodyDataSourceItems : TeaModel {
            [NameInMap("dataSourceItem")]
            [Validation(Required=false)]
            public List<ListDataSourceItemResponseBodyDataSourceItemsDataSourceItem> DataSourceItem { get; set; }
            public class ListDataSourceItemResponseBodyDataSourceItemsDataSourceItem : TeaModel {
                public long? DataSourceItemId { get; set; }
                public string DeviceName { get; set; }
                public string ProductKey { get; set; }
                public string ScopeType { get; set; }
                public string Topic { get; set; }
            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
