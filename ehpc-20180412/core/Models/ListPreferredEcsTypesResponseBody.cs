// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListPreferredEcsTypesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Series")]
        [Validation(Required=false)]
        public ListPreferredEcsTypesResponseBodySeries Series { get; set; }
        public class ListPreferredEcsTypesResponseBodySeries : TeaModel {
            [NameInMap("SeriesInfo")]
            [Validation(Required=false)]
            public List<ListPreferredEcsTypesResponseBodySeriesSeriesInfo> SeriesInfo { get; set; }
            public class ListPreferredEcsTypesResponseBodySeriesSeriesInfo : TeaModel {
                public ListPreferredEcsTypesResponseBodySeriesSeriesInfoRoles Roles { get; set; }
                public class ListPreferredEcsTypesResponseBodySeriesSeriesInfoRoles : TeaModel {
                    [NameInMap("Compute")]
                    [Validation(Required=false)]
                    public ListPreferredEcsTypesResponseBodySeriesSeriesInfoRolesCompute Compute { get; set; }
                    public class ListPreferredEcsTypesResponseBodySeriesSeriesInfoRolesCompute : TeaModel {
                        [NameInMap("InstanceTypeId")]
                        [Validation(Required=false)]
                        public List<string> InstanceTypeId { get; set; }
                    };

                    [NameInMap("Login")]
                    [Validation(Required=false)]
                    public ListPreferredEcsTypesResponseBodySeriesSeriesInfoRolesLogin Login { get; set; }
                    public class ListPreferredEcsTypesResponseBodySeriesSeriesInfoRolesLogin : TeaModel {
                        [NameInMap("InstanceTypeId")]
                        [Validation(Required=false)]
                        public List<string> InstanceTypeId { get; set; }
                    };

                    [NameInMap("Manager")]
                    [Validation(Required=false)]
                    public ListPreferredEcsTypesResponseBodySeriesSeriesInfoRolesManager Manager { get; set; }
                    public class ListPreferredEcsTypesResponseBodySeriesSeriesInfoRolesManager : TeaModel {
                        [NameInMap("InstanceTypeId")]
                        [Validation(Required=false)]
                        public List<string> InstanceTypeId { get; set; }
                    };

                }
                public string SeriesId { get; set; }
                public string SeriesName { get; set; }
            }
        };

        [NameInMap("SupportSpotInstance")]
        [Validation(Required=false)]
        public bool? SupportSpotInstance { get; set; }

    }

}
