// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselineStatusesRequest : TeaModel {
        [NameInMap("BaselineTypes")]
        [Validation(Required=false)]
        public string BaselineTypes { get; set; }

        [NameInMap("Bizdate")]
        [Validation(Required=false)]
        public string Bizdate { get; set; }

        [NameInMap("FinishStatus")]
        [Validation(Required=false)]
        public string FinishStatus { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("SearchText")]
        [Validation(Required=false)]
        public string SearchText { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public long? TopicId { get; set; }

    }

}
