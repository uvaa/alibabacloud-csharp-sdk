// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeEndPointEventListRequest : TeaModel {
        /// <summary>
        /// APP ID。
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 频道ID
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// 创建频道时间，使用UNIX时间戳表示，单位：秒。
        /// </summary>
        [NameInMap("CreatedTs")]
        [Validation(Required=false)]
        public long? CreatedTs { get; set; }

        /// <summary>
        /// 释放频道时间，使用UNIX时间戳表示，单位：秒。参数为空表示获取当前时间。
        /// </summary>
        [NameInMap("DestroyedTs")]
        [Validation(Required=false)]
        public long? DestroyedTs { get; set; }

        /// <summary>
        /// 用户ID列表，多个用英文逗号（,）分隔。
        /// </summary>
        [NameInMap("UserIdList")]
        [Validation(Required=false)]
        public string UserIdList { get; set; }

    }

}