/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AddHotlineNumberRequest : TeaModel {
        /// <summary>
        /// 实例id
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 号码
        /// </summary>
        [NameInMap("HotlineNumber")]
        [Validation(Required=false)]
        public string HotlineNumber { get; set; }

        /// <summary>
        /// 号码描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 是否用于入呼
        /// </summary>
        [NameInMap("EnableInbound")]
        [Validation(Required=false)]
        public bool? EnableInbound { get; set; }

        /// <summary>
        /// 入呼ivr流程id
        /// </summary>
        [NameInMap("InboundFlowId")]
        [Validation(Required=false)]
        public long? InboundFlowId { get; set; }

        /// <summary>
        /// 是否用于外呼
        /// </summary>
        [NameInMap("EnableOutbound")]
        [Validation(Required=false)]
        public bool? EnableOutbound { get; set; }

        /// <summary>
        /// 外呼是否对所有部门生效
        /// </summary>
        [NameInMap("OutboundAllDepart")]
        [Validation(Required=false)]
        public bool? OutboundAllDepart { get; set; }

        /// <summary>
        /// 是否开启入呼满意度
        /// </summary>
        [NameInMap("EnableInboundEvaluation")]
        [Validation(Required=false)]
        public bool? EnableInboundEvaluation { get; set; }

        /// <summary>
        /// 是否开启外呼满意度
        /// </summary>
        [NameInMap("EnableOutboundEvaluation")]
        [Validation(Required=false)]
        public bool? EnableOutboundEvaluation { get; set; }

        /// <summary>
        /// 满意度等级
        /// </summary>
        [NameInMap("EvaluationLevel")]
        [Validation(Required=false)]
        public int? EvaluationLevel { get; set; }

        /// <summary>
        /// 外呼生效范围
        /// </summary>
        [NameInMap("OutboundRangeList")]
        [Validation(Required=false)]
        public List<AddHotlineNumberRequestOutboundRangeList> OutboundRangeList { get; set; }
        public class AddHotlineNumberRequestOutboundRangeList : TeaModel {
            /// <summary>
            /// 生效部门id
            /// </summary>
            [NameInMap("DepartmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            /// <summary>
            /// 生效技能组列表（部门123下）
            /// </summary>
            [NameInMap("GroupIdList")]
            [Validation(Required=false)]
            public List<long?> GroupIdList { get; set; }

        }

    }

}