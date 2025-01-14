// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ModifyDesensitizationStrategyRequest : TeaModel {
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        [NameInMap("IsLogic")]
        [Validation(Required=false)]
        public bool? IsLogic { get; set; }

        [NameInMap("IsReset")]
        [Validation(Required=false)]
        public bool? IsReset { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public int? RuleId { get; set; }

        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
