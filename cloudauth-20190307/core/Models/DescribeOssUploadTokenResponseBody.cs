// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeOssUploadTokenResponseBody : TeaModel {
        [NameInMap("OssUploadToken")]
        [Validation(Required=false)]
        public DescribeOssUploadTokenResponseBodyOssUploadToken OssUploadToken { get; set; }
        public class DescribeOssUploadTokenResponseBodyOssUploadToken : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }
            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public long? Expired { get; set; }
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }
            [NameInMap("Secret")]
            [Validation(Required=false)]
            public string Secret { get; set; }
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
