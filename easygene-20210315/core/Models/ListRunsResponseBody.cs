// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListRunsResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 主机ID
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// 最大返回结果
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 下次查询Token
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 返回个数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 任务列表
        /// </summary>
        [NameInMap("Runs")]
        [Validation(Required=false)]
        public List<ListRunsResponseBodyRuns> Runs { get; set; }
        public class ListRunsResponseBodyRuns : TeaModel {
            /// <summary>
            /// 应用名称
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// 应用来源
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// 应用命名空间
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// 应用原名
            /// </summary>
            [NameInMap("AppOrigName")]
            [Validation(Required=false)]
            public string AppOrigName { get; set; }

            /// <summary>
            /// 任务标签
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            /// <summary>
            /// 任务名称
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 应用版本号
            /// </summary>
            [NameInMap("Revision")]
            [Validation(Required=false)]
            public string Revision { get; set; }

            /// <summary>
            /// 任务ID
            /// </summary>
            [NameInMap("RunId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// 任务状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 提交时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// 提交ID
            /// </summary>
            [NameInMap("SubmissionId")]
            [Validation(Required=false)]
            public string SubmissionId { get; set; }

            /// <summary>
            /// 实体名称
            /// </summary>
            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            /// <summary>
            /// 实体对象ID
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// 运行目录
            /// </summary>
            [NameInMap("ExecuteDirectory")]
            [Validation(Required=false)]
            public string ExecuteDirectory { get; set; }

            [NameInMap("ExecuteOptions")]
            [Validation(Required=false)]
            public ListRunsResponseBodyRunsExecuteOptions ExecuteOptions { get; set; }
            public class ListRunsResponseBodyRunsExecuteOptions : TeaModel {
                [NameInMap("CallCaching")]
                [Validation(Required=false)]
                public bool? CallCaching { get; set; }
                [NameInMap("DeleteIntermediateResults")]
                [Validation(Required=false)]
                public bool? DeleteIntermediateResults { get; set; }
                [NameInMap("FailureMode")]
                [Validation(Required=false)]
                public string FailureMode { get; set; }
            };

            /// <summary>
            /// 输入参数
            /// </summary>
            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public string Inputs { get; set; }

            [NameInMap("DefaultRuntime")]
            [Validation(Required=false)]
            public string DefaultRuntime { get; set; }

            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}