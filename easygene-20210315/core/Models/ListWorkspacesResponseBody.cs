// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// 主机ID
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// 最大结果数
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 下次查询的起始Token
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 返回总个数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 工作空间数组
        /// </summary>
        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public List<ListWorkspacesResponseBodyWorkspaces> Workspaces { get; set; }
        public class ListWorkspacesResponseBodyWorkspaces : TeaModel {
            /// <summary>
            /// 工作空间描述
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 任务生命周期
            /// </summary>
            [NameInMap("JobLifecycle")]
            [Validation(Required=false)]
            public int? JobLifecycle { get; set; }

            /// <summary>
            /// 工作空间标签
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            /// <summary>
            /// OSS工作路径
            /// </summary>
            [NameInMap("OssRoot")]
            [Validation(Required=false)]
            public string OssRoot { get; set; }

            /// <summary>
            /// 工作空间Bucket名字
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// RAM Role
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 最后修改时间
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            /// <summary>
            /// 工作空间名称
            /// </summary>
            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

            /// <summary>
            /// 工作空间状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 地域ID
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}