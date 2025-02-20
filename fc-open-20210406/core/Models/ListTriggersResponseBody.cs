// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListTriggersResponseBody : TeaModel {
        /// <summary>
        /// 用来返回更多的查询结果。如果这个值没有返回，则说明没有更多结果
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Trigger列表
        /// </summary>
        [NameInMap("triggers")]
        [Validation(Required=false)]
        public List<ListTriggersResponseBodyTriggers> Triggers { get; set; }
        public class ListTriggersResponseBodyTriggers : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 域名名称，使用域名名称拼接上函数计算域名，可以采用HTTP协议调用到触发器对应版本的函数。例如{domainName}.cn-shanghai.fc.aliyuncs.com
            /// </summary>
            [NameInMap("domainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// 调用函数使用的RAM角色的ARN
            /// </summary>
            [NameInMap("invocationRole")]
            [Validation(Required=false)]
            public string InvocationRole { get; set; }

            /// <summary>
            /// 上次修改时间
            /// </summary>
            [NameInMap("lastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            /// <summary>
            /// service版本
            /// </summary>
            [NameInMap("qualifier")]
            [Validation(Required=false)]
            public string Qualifier { get; set; }

            /// <summary>
            /// event source的Aliyun Resource Name（ARN
            /// </summary>
            [NameInMap("sourceArn")]
            [Validation(Required=false)]
            public string SourceArn { get; set; }

            /// <summary>
            /// trigger配置对象
            /// </summary>
            [NameInMap("triggerConfig")]
            [Validation(Required=false)]
            public string TriggerConfig { get; set; }

            [NameInMap("triggerId")]
            [Validation(Required=false)]
            public string TriggerId { get; set; }

            /// <summary>
            /// trigger名称
            /// </summary>
            [NameInMap("triggerName")]
            [Validation(Required=false)]
            public string TriggerName { get; set; }

            /// <summary>
            /// trigger类型，如 oss, log, tablestore, timer, http, cdn_events, mns_topic
            /// </summary>
            [NameInMap("triggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// 公网域名地址。在互联网可以通过HTTP协议或者HTTPS协议访问HTTP Trigger。
            /// </summary>
            [NameInMap("urlInternet")]
            [Validation(Required=false)]
            public string UrlInternet { get; set; }

            /// <summary>
            /// 私网域名地址。在VPC可以通过HTTP协议或者HTTPS协议访问HTTP Trigger。
            /// </summary>
            [NameInMap("urlIntranet")]
            [Validation(Required=false)]
            public string UrlIntranet { get; set; }

        }

    }

}
