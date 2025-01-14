// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendBatchSmsRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PhoneNumberJson")]
        [Validation(Required=false)]
        public string PhoneNumberJson { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SignNameJson")]
        [Validation(Required=false)]
        public string SignNameJson { get; set; }

        [NameInMap("SmsUpExtendCodeJson")]
        [Validation(Required=false)]
        public string SmsUpExtendCodeJson { get; set; }

        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateParamJson")]
        [Validation(Required=false)]
        public string TemplateParamJson { get; set; }

    }

}
