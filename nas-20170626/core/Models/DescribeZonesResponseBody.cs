// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesZone> Zone { get; set; }
            public class DescribeZonesResponseBodyZonesZone : TeaModel {
                public DescribeZonesResponseBodyZonesZonePerformance Performance { get; set; }
                public class DescribeZonesResponseBodyZonesZonePerformance : TeaModel {
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public List<string> Protocol { get; set; }

                }
                public DescribeZonesResponseBodyZonesZoneCapacity Capacity { get; set; }
                public class DescribeZonesResponseBodyZonesZoneCapacity : TeaModel {
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public List<string> Protocol { get; set; }

                }
                public string ZoneId { get; set; }
                public DescribeZonesResponseBodyZonesZoneInstanceTypes InstanceTypes { get; set; }
                public class DescribeZonesResponseBodyZonesZoneInstanceTypes : TeaModel {
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public List<DescribeZonesResponseBodyZonesZoneInstanceTypesInstanceType> InstanceType { get; set; }
                    public class DescribeZonesResponseBodyZonesZoneInstanceTypesInstanceType : TeaModel {
                        [NameInMap("StorageType")]
                        [Validation(Required=false)]
                        public string StorageType { get; set; }

                        [NameInMap("ProtocolType")]
                        [Validation(Required=false)]
                        public string ProtocolType { get; set; }

                    }

                }
            }
        };

    }

}
