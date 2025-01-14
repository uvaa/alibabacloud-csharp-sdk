// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class CreateEventRecordPlanRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public string EventTypes { get; set; }

        [NameInMap("PreRecordDuration")]
        [Validation(Required=false)]
        public int? PreRecordDuration { get; set; }

        [NameInMap("RecordDuration")]
        [Validation(Required=false)]
        public int? RecordDuration { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
