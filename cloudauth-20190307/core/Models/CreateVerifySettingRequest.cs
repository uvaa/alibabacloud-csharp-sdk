// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateVerifySettingRequest : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=true)]
        public string BizType { get; set; }

        [NameInMap("BizName")]
        [Validation(Required=true)]
        public string BizName { get; set; }

        [NameInMap("Solution")]
        [Validation(Required=true)]
        public string Solution { get; set; }

        [NameInMap("GuideStep")]
        [Validation(Required=false)]
        public bool? GuideStep { get; set; }

        [NameInMap("PrivacyStep")]
        [Validation(Required=false)]
        public bool? PrivacyStep { get; set; }

        [NameInMap("ResultStep")]
        [Validation(Required=false)]
        public bool? ResultStep { get; set; }

    }

}