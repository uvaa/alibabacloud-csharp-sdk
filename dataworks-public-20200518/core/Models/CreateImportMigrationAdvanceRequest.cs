// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateImportMigrationAdvanceRequest : TeaModel {
        [NameInMap("PackageFileObject")]
        [Validation(Required=true)]
        public Stream PackageFileObject { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=true)]
        public long? ProjectId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=true)]
        public string Name { get; set; }

        [NameInMap("PackageType")]
        [Validation(Required=true)]
        public string PackageType { get; set; }

        [NameInMap("ResourceGroupMap")]
        [Validation(Required=false)]
        public string ResourceGroupMap { get; set; }

        [NameInMap("WorkspaceMap")]
        [Validation(Required=false)]
        public string WorkspaceMap { get; set; }

        [NameInMap("CalculateEngineMap")]
        [Validation(Required=false)]
        public string CalculateEngineMap { get; set; }

        [NameInMap("CommitRule")]
        [Validation(Required=false)]
        public string CommitRule { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}