// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetIndexResponseBody : TeaModel {
        [NameInMap("index_mode")]
        [Validation(Required=false)]
        public string IndexMode { get; set; }

        [NameInMap("keys")]
        [Validation(Required=false)]
        public Dictionary<string, KeysValue> Keys { get; set; }

        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        [NameInMap("line")]
        [Validation(Required=false)]
        public GetIndexResponseBodyLine Line { get; set; }
        public class GetIndexResponseBodyLine : TeaModel {
            [NameInMap("caseSensitive")]
            [Validation(Required=false)]
            public bool? CaseSensitive { get; set; }
            [NameInMap("chn")]
            [Validation(Required=false)]
            public bool? Chn { get; set; }
            [NameInMap("exclude_keys")]
            [Validation(Required=false)]
            public List<string> ExcludeKeys { get; set; }
            [NameInMap("include_keys")]
            [Validation(Required=false)]
            public List<string> IncludeKeys { get; set; }
            [NameInMap("token")]
            [Validation(Required=false)]
            public List<string> Token { get; set; }
        };

        [NameInMap("log_reduce")]
        [Validation(Required=false)]
        public bool? LogReduce { get; set; }

        [NameInMap("log_reduce_black_list")]
        [Validation(Required=false)]
        public List<string> LogReduceBlackList { get; set; }

        [NameInMap("log_reduce_white_list")]
        [Validation(Required=false)]
        public List<string> LogReduceWhiteList { get; set; }

        [NameInMap("max_text_len")]
        [Validation(Required=false)]
        public int? MaxTextLen { get; set; }

        [NameInMap("storage")]
        [Validation(Required=false)]
        public string Storage { get; set; }

        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
