// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class BatchSetScdnDomainConfigsResponseBody : TeaModel {
        [NameInMap("DomainConfigList")]
        [Validation(Required=false)]
        public BatchSetScdnDomainConfigsResponseBodyDomainConfigList DomainConfigList { get; set; }
        public class BatchSetScdnDomainConfigsResponseBodyDomainConfigList : TeaModel {
            [NameInMap("DomainConfigModel")]
            [Validation(Required=false)]
            public List<BatchSetScdnDomainConfigsResponseBodyDomainConfigListDomainConfigModel> DomainConfigModel { get; set; }
            public class BatchSetScdnDomainConfigsResponseBodyDomainConfigListDomainConfigModel : TeaModel {
                public long? ConfigId { get; set; }
                public string DomainName { get; set; }
                public string FunctionName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
