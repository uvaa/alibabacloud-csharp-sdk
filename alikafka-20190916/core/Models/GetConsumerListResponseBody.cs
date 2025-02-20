// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetConsumerListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ConsumerList")]
        [Validation(Required=false)]
        public GetConsumerListResponseBodyConsumerList ConsumerList { get; set; }
        public class GetConsumerListResponseBodyConsumerList : TeaModel {
            [NameInMap("ConsumerVO")]
            [Validation(Required=false)]
            public List<GetConsumerListResponseBodyConsumerListConsumerVO> ConsumerVO { get; set; }
            public class GetConsumerListResponseBodyConsumerListConsumerVO : TeaModel {
                public string ConsumerId { get; set; }
                public string InstanceId { get; set; }
                public string RegionId { get; set; }
                public string Remark { get; set; }
                public GetConsumerListResponseBodyConsumerListConsumerVOTags Tags { get; set; }
                public class GetConsumerListResponseBodyConsumerListConsumerVOTags : TeaModel {
                    [NameInMap("TagVO")]
                    [Validation(Required=false)]
                    public List<GetConsumerListResponseBodyConsumerListConsumerVOTagsTagVO> TagVO { get; set; }
                    public class GetConsumerListResponseBodyConsumerListConsumerVOTagsTagVO : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
