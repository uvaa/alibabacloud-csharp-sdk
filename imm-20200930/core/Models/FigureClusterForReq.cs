// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FigureClusterForReq : TeaModel {
        [NameInMap("Cover")]
        [Validation(Required=false)]
        public FigureClusterForReqCover Cover { get; set; }
        public class FigureClusterForReqCover : TeaModel {
            [NameInMap("Figures")]
            [Validation(Required=false)]
            public List<FigureClusterForReqCoverFigures> Figures { get; set; }
            public class FigureClusterForReqCoverFigures : TeaModel {
                public string FigureId { get; set; }
            }
        };

        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

    }

}
