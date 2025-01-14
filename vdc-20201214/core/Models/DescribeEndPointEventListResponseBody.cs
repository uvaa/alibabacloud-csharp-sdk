// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeEndPointEventListResponseBody : TeaModel {
        /// <summary>
        /// 用户基本信息列表。
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribeEndPointEventListResponseBodyNodes> Nodes { get; set; }
        public class DescribeEndPointEventListResponseBodyNodes : TeaModel {
            /// <summary>
            /// 事件数据列表
            /// </summary>
            [NameInMap("EventDataItems")]
            [Validation(Required=false)]
            public List<DescribeEndPointEventListResponseBodyNodesEventDataItems> EventDataItems { get; set; }
            public class DescribeEndPointEventListResponseBodyNodesEventDataItems : TeaModel {
                /// <summary>
                /// 事件列表。
                /// </summary>
                [NameInMap("EventList")]
                [Validation(Required=false)]
                public List<DescribeEndPointEventListResponseBodyNodesEventDataItemsEventList> EventList { get; set; }
                public class DescribeEndPointEventListResponseBodyNodesEventDataItemsEventList : TeaModel {
                    [NameInMap("Acs")]
                    [Validation(Required=false)]
                    public string Acs { get; set; }

                    [NameInMap("EventCode")]
                    [Validation(Required=false)]
                    public string EventCode { get; set; }

                    /// <summary>
                    /// 事件名称。
                    /// </summary>
                    [NameInMap("EventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                    /// <summary>
                    /// 事件类型，取值：USER：用户事件。SYSTEM：系统事件。
                    /// </summary>
                    [NameInMap("EventType")]
                    [Validation(Required=false)]
                    public string EventType { get; set; }

                    [NameInMap("Os")]
                    [Validation(Required=false)]
                    public string Os { get; set; }

                    [NameInMap("Sdk")]
                    [Validation(Required=false)]
                    public string Sdk { get; set; }

                    [NameInMap("StreamName")]
                    [Validation(Required=false)]
                    public string StreamName { get; set; }

                    [NameInMap("StreamType")]
                    [Validation(Required=false)]
                    public string StreamType { get; set; }

                    [NameInMap("TrackCode")]
                    [Validation(Required=false)]
                    public string TrackCode { get; set; }

                    [NameInMap("TrackName")]
                    [Validation(Required=false)]
                    public string TrackName { get; set; }

                    /// <summary>
                    /// 事件发生的时间，使用UNIX时间戳表示，单位：秒。
                    /// </summary>
                    [NameInMap("Ts")]
                    [Validation(Required=false)]
                    public long? Ts { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// 第一个事件发生的时间，使用UNIX时间戳表示，单位：秒。
                /// </summary>
                [NameInMap("Ts")]
                [Validation(Required=false)]
                public long? Ts { get; set; }

            }

            /// <summary>
            /// 用户ID
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
