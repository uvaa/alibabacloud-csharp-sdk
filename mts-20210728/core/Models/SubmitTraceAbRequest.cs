// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class SubmitTraceAbRequest : TeaModel {
        /// <summary>
        /// 任务结果回调
        /// </summary>
        [NameInMap("CallBack")]
        [Validation(Required=false)]
        public string CallBack { get; set; }

        /// <summary>
        /// 溯源水印ab流处理视频输入
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// 水印强度
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        /// <summary>
        /// 溯源水印ab流处理输出
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// 用户自定义数据，最大长度1024个字节
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}