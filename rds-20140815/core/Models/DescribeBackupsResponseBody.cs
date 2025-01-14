// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyItems Items { get; set; }
        public class DescribeBackupsResponseBodyItems : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeBackupsResponseBodyItemsBackup> Backup { get; set; }
            public class DescribeBackupsResponseBodyItemsBackup : TeaModel {
                public DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDB BackupDownloadLinkByDB { get; set; }
                public class DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDB : TeaModel {
                    [NameInMap("BackupDownloadLinkByDB")]
                    [Validation(Required=false)]
                    public List<DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDBBackupDownloadLinkByDB> BackupDownloadLinkByDB { get; set; }
                    public class DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDBBackupDownloadLinkByDB : TeaModel {
                        [NameInMap("DataBase")]
                        [Validation(Required=false)]
                        public string DataBase { get; set; }

                        [NameInMap("DownloadLink")]
                        [Validation(Required=false)]
                        public string DownloadLink { get; set; }

                        [NameInMap("IntranetDownloadLink")]
                        [Validation(Required=false)]
                        public string IntranetDownloadLink { get; set; }

                    }

                }
                public string BackupDownloadURL { get; set; }
                public string BackupEndTime { get; set; }
                public string BackupId { get; set; }
                public string BackupInitiator { get; set; }
                public string BackupIntranetDownloadURL { get; set; }
                public string BackupMethod { get; set; }
                public string BackupMode { get; set; }
                public long? BackupSize { get; set; }
                public string BackupStartTime { get; set; }
                public string BackupStatus { get; set; }
                public string BackupType { get; set; }
                public string Checksum { get; set; }
                public long? ConsistentTime { get; set; }
                public string CopyOnlyBackup { get; set; }
                public string DBInstanceId { get; set; }
                public string Encryption { get; set; }
                public string HostInstanceID { get; set; }
                public int? IsAvail { get; set; }
                public string MetaStatus { get; set; }
                public string ResourceGroupId { get; set; }
                public string StorageClass { get; set; }
                public string StoreStatus { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalEcsSnapshotSize")]
        [Validation(Required=false)]
        public long? TotalEcsSnapshotSize { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
