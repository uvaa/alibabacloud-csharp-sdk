// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class ListOpenJMeterScenesRequest : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 场景id
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// 场景名
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

    }

}
