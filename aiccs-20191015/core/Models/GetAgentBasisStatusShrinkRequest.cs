// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAgentBasisStatusShrinkRequest : TeaModel {
        /// <summary>
        /// AICCS实例ID，在智能联络中心控制台上可以看到
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 开始日期时间戳（毫秒）
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// 结束日期时间戳（毫秒）
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// 每页大小（默认为10)
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 当前页（默认为1）
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// 坐席id列表
        /// </summary>
        [NameInMap("AgentIds")]
        [Validation(Required=false)]
        public string AgentIdsShrink { get; set; }

        /// <summary>
        /// 部门id列表
        /// </summary>
        [NameInMap("DepIds")]
        [Validation(Required=false)]
        public string DepIdsShrink { get; set; }

    }

}
