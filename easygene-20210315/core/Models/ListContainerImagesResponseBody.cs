// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListContainerImagesResponseBody : TeaModel {
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 容器镜像
        /// </summary>
        [NameInMap("ContainerImages")]
        [Validation(Required=false)]
        public List<ListContainerImagesResponseBodyContainerImages> ContainerImages { get; set; }
        public class ListContainerImagesResponseBodyContainerImages : TeaModel {
            /// <summary>
            /// 容器镜像名称空间名称
            /// </summary>
            [NameInMap("ContainerImageNamespace")]
            [Validation(Required=false)]
            public string ContainerImageNamespace { get; set; }

            /// <summary>
            /// 容器镜像名称
            /// </summary>
            [NameInMap("ContainerImageName")]
            [Validation(Required=false)]
            public string ContainerImageName { get; set; }

            /// <summary>
            /// 容器镜像描述
            /// </summary>
            [NameInMap("ContainerImageDescription")]
            [Validation(Required=false)]
            public string ContainerImageDescription { get; set; }

            /// <summary>
            /// 容器镜像版本
            /// </summary>
            [NameInMap("ContainerImageVersions")]
            [Validation(Required=false)]
            public List<string> ContainerImageVersions { get; set; }

            /// <summary>
            /// 容器镜像所在区域
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// 容器镜像仓库名称
            /// </summary>
            [NameInMap("ContainerRegistry")]
            [Validation(Required=false)]
            public string ContainerRegistry { get; set; }

            /// <summary>
            /// 最后更新时间
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

        }

    }

}