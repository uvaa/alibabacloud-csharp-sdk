// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class EstablishRelationTableToBusinessRequest : TeaModel {
        [NameInMap("BusinessId")]
        [Validation(Required=false)]
        public string BusinessId { get; set; }

        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

    }

}
