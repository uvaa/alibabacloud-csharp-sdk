// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainBpsDataByTimeStampRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("TimePoint")]
        [Validation(Required=true)]
        public string TimePoint { get; set; }

        [NameInMap("IspNames")]
        [Validation(Required=true)]
        public string IspNames { get; set; }

        [NameInMap("LocationNames")]
        [Validation(Required=true)]
        public string LocationNames { get; set; }

    }

}