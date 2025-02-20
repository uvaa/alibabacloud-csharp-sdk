// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetUserMuteSettingRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public GetUserMuteSettingRequestRequestParams RequestParams { get; set; }
        public class GetUserMuteSettingRequestRequestParams : TeaModel {
            [NameInMap("AppUids")]
            [Validation(Required=false)]
            public List<string> AppUids { get; set; }
        };

    }

}
