// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryDISyncTaskConfigProcessResultRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=true)]
        public long? ProjectId { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=true)]
        public string TaskType { get; set; }

        [NameInMap("AsyncProcessId")]
        [Validation(Required=true)]
        public long? AsyncProcessId { get; set; }

    }

}