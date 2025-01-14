// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListServiceGroupsResponseBody : TeaModel {
        /// <summary>
        /// 服务组列表
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListServiceGroupsResponseBodyData> Data { get; set; }
        public class ListServiceGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// ENABLE 启用 DISABLE 禁用
            /// </summary>
            [NameInMap("enableWebhook")]
            [Validation(Required=false)]
            public string EnableWebhook { get; set; }

            /// <summary>
            /// 是否已经排班
            /// </summary>
            [NameInMap("isScheduled")]
            [Validation(Required=false)]
            public bool? IsScheduled { get; set; }

            /// <summary>
            /// 服务组描述
            /// </summary>
            [NameInMap("serviceGroupDescription")]
            [Validation(Required=false)]
            public string ServiceGroupDescription { get; set; }

            /// <summary>
            /// 服务组ID
            /// </summary>
            [NameInMap("serviceGroupId")]
            [Validation(Required=false)]
            public long? ServiceGroupId { get; set; }

            /// <summary>
            /// 服务组名字
            /// </summary>
            [NameInMap("serviceGroupName")]
            [Validation(Required=false)]
            public string ServiceGroupName { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// 服务组用户列表
            /// </summary>
            [NameInMap("users")]
            [Validation(Required=false)]
            public List<ListServiceGroupsResponseBodyDataUsers> Users { get; set; }
            public class ListServiceGroupsResponseBodyDataUsers : TeaModel {
                /// <summary>
                /// 邮箱
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// 手机号
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// 服务组ID
                /// </summary>
                [NameInMap("serviceGroupId")]
                [Validation(Required=false)]
                public long? ServiceGroupId { get; set; }

                /// <summary>
                /// 用户ID
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// 用户名字
                /// </summary>
                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// webhook 跳转地址
            /// </summary>
            [NameInMap("webhookLink")]
            [Validation(Required=false)]
            public string WebhookLink { get; set; }

            /// <summary>
            /// WEIXIN_GROUP微信DING_GROUP钉钉FEISHU_GROUP飞书
            /// </summary>
            [NameInMap("webhookType")]
            [Validation(Required=false)]
            public string WebhookType { get; set; }

        }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
