// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifySettingResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("VerifySettingList")]
        [Validation(Required=true)]
        public List<DescribeVerifySettingResponseVerifySettingList> VerifySettingList { get; set; }
        public class DescribeVerifySettingResponseVerifySettingList : TeaModel {
            [NameInMap("BizType")]
            [Validation(Required=true)]
            public string BizType { get; set; }

            [NameInMap("BizName")]
            [Validation(Required=true)]
            public string BizName { get; set; }

            [NameInMap("Solution")]
            [Validation(Required=true)]
            public string Solution { get; set; }

            [NameInMap("StepList")]
            [Validation(Required=true)]
            public List<string> StepList { get; set; }

        }

    }

}