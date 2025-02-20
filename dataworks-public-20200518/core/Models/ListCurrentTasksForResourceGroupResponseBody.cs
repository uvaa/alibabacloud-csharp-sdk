// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListCurrentTasksForResourceGroupResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCurrentTasksForResourceGroupResponseBodyData Data { get; set; }
        public class ListCurrentTasksForResourceGroupResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<ListCurrentTasksForResourceGroupResponseBodyDataTasks> Tasks { get; set; }
            public class ListCurrentTasksForResourceGroupResponseBodyDataTasks : TeaModel {
                public string Concurrency { get; set; }
                public string ProjectName { get; set; }
                public int? Status { get; set; }
                public string TaskId { get; set; }
                public string TaskName { get; set; }
                public string TaskSource { get; set; }
                public int? TaskType { get; set; }
            }
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
