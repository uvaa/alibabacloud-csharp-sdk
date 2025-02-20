// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class AppendEntityMemberRequest : TeaModel {
        /// <summary>
        /// 业务空间key,不设置则访问默认业务空间，key值在主账号业务管理页面获取
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("ApplyType")]
        [Validation(Required=false)]
        public string ApplyType { get; set; }

        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        [NameInMap("Member")]
        [Validation(Required=false)]
        public AppendEntityMemberRequestMember Member { get; set; }
        public class AppendEntityMemberRequestMember : TeaModel {
            [NameInMap("MemberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }
            [NameInMap("Synonyms")]
            [Validation(Required=false)]
            public List<string> Synonyms { get; set; }
        };

    }

}
