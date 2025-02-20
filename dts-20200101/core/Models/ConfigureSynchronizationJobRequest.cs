// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureSynchronizationJobRequest : TeaModel {
        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public ConfigureSynchronizationJobRequestSourceEndpoint SourceEndpoint { get; set; }
        public class ConfigureSynchronizationJobRequestSourceEndpoint : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }
        };

        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public ConfigureSynchronizationJobRequestDestinationEndpoint DestinationEndpoint { get; set; }
        public class ConfigureSynchronizationJobRequestDestinationEndpoint : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }
            [NameInMap("DataBaseName")]
            [Validation(Required=false)]
            public string DataBaseName { get; set; }
        };

        [NameInMap("PartitionKey")]
        [Validation(Required=false)]
        public ConfigureSynchronizationJobRequestPartitionKey PartitionKey { get; set; }
        public class ConfigureSynchronizationJobRequestPartitionKey : TeaModel {
            [NameInMap("ModifyTime_Year")]
            [Validation(Required=false)]
            public bool? ModifyTimeYear { get; set; }
            [NameInMap("ModifyTime_Month")]
            [Validation(Required=false)]
            public bool? ModifyTimeMonth { get; set; }
            [NameInMap("ModifyTime_Day")]
            [Validation(Required=false)]
            public bool? ModifyTimeDay { get; set; }
            [NameInMap("ModifyTime_Hour")]
            [Validation(Required=false)]
            public bool? ModifyTimeHour { get; set; }
            [NameInMap("ModifyTime_Minute")]
            [Validation(Required=false)]
            public bool? ModifyTimeMinute { get; set; }
        };

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SynchronizationJobName")]
        [Validation(Required=false)]
        public string SynchronizationJobName { get; set; }

        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        [NameInMap("StructureInitialization")]
        [Validation(Required=false)]
        public bool? StructureInitialization { get; set; }

        [NameInMap("DataInitialization")]
        [Validation(Required=false)]
        public bool? DataInitialization { get; set; }

        [NameInMap("SynchronizationObjects")]
        [Validation(Required=false)]
        public string SynchronizationObjects { get; set; }

        [NameInMap("MigrationReserved")]
        [Validation(Required=false)]
        public string MigrationReserved { get; set; }

        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

    }

}
