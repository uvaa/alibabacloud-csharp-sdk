// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListServiceVersionsResponseBody : TeaModel {
        /// <summary>
        /// 排序方向
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// 下次查询token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 版本列表
        /// </summary>
        [NameInMap("versions")]
        [Validation(Required=false)]
        public List<ListServiceVersionsResponseBodyVersions> Versions { get; set; }
        public class ListServiceVersionsResponseBodyVersions : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// 版本描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 上次更新时间
            /// </summary>
            [NameInMap("lastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            /// <summary>
            /// 版本ID
            /// </summary>
            [NameInMap("versionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

    }

}