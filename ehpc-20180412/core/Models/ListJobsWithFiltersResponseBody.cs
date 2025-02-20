// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListJobsWithFiltersResponseBody : TeaModel {
        /// <summary>
        /// Jobs
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListJobsWithFiltersResponseBodyJobs> Jobs { get; set; }
        public class ListJobsWithFiltersResponseBodyJobs : TeaModel {
            [NameInMap("ArrayRequest")]
            [Validation(Required=false)]
            public string ArrayRequest { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public string LastModifyTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NodeList")]
            [Validation(Required=false)]
            public string NodeList { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            [NameInMap("Resources")]
            [Validation(Required=false)]
            public ListJobsWithFiltersResponseBodyJobsResources Resources { get; set; }
            public class ListJobsWithFiltersResponseBodyJobsResources : TeaModel {
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public long? Cores { get; set; }
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public long? Nodes { get; set; }
            };

            [NameInMap("ShellPath")]
            [Validation(Required=false)]
            public string ShellPath { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Stderr")]
            [Validation(Required=false)]
            public string Stderr { get; set; }

            [NameInMap("Stdout")]
            [Validation(Required=false)]
            public string Stdout { get; set; }

            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

        }

        /// <summary>
        /// PageNumber
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// PageSize
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// TotalCount本次请求条件下的数据总量，此参数为可选参数，默认可不返回
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
