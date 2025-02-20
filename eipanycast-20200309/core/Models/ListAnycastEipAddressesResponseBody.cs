// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class ListAnycastEipAddressesResponseBody : TeaModel {
        [NameInMap("AnycastList")]
        [Validation(Required=false)]
        public List<ListAnycastEipAddressesResponseBodyAnycastList> AnycastList { get; set; }
        public class ListAnycastEipAddressesResponseBodyAnycastList : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("AnycastEipBindInfoList")]
            [Validation(Required=false)]
            public List<ListAnycastEipAddressesResponseBodyAnycastListAnycastEipBindInfoList> AnycastEipBindInfoList { get; set; }
            public class ListAnycastEipAddressesResponseBodyAnycastListAnycastEipBindInfoList : TeaModel {
                [NameInMap("BindInstanceId")]
                [Validation(Required=false)]
                public string BindInstanceId { get; set; }

                [NameInMap("BindInstanceRegionId")]
                [Validation(Required=false)]
                public string BindInstanceRegionId { get; set; }

                [NameInMap("BindInstanceType")]
                [Validation(Required=false)]
                public string BindInstanceType { get; set; }

                [NameInMap("BindTime")]
                [Validation(Required=false)]
                public string BindTime { get; set; }

            }

            [NameInMap("AnycastId")]
            [Validation(Required=false)]
            public string AnycastId { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ServiceLocation")]
            [Validation(Required=false)]
            public string ServiceLocation { get; set; }

            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public int? ServiceManaged { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
