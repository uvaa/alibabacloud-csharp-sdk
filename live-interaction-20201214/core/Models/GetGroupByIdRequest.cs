// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetGroupByIdRequest : TeaModel {
        /// <summary>
        /// APP ID, IMPaaS租户的ID
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 群会话信息获取的请求体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public GetGroupByIdRequestRequestParams RequestParams { get; set; }
        public class GetGroupByIdRequestRequestParams : TeaModel {
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
        };

    }

}
