// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmMonitorAvailableConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public List<DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodes> IspCityNodes { get; set; }
        public class DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodes : TeaModel {
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("Mainland")]
            [Validation(Required=false)]
            public bool? Mainland { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

            [NameInMap("CityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("DefaultSelected")]
            [Validation(Required=false)]
            public bool? DefaultSelected { get; set; }

        }

    }

}