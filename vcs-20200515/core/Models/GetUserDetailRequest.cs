// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetUserDetailRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("IsvSubId")]
        [Validation(Required=true)]
        public string IsvSubId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=true)]
        public long UserId { get; set; }

        [NameInMap("NeedFaceDetail")]
        [Validation(Required=false)]
        public bool? NeedFaceDetail { get; set; }

    }

}