// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class CreateIntentShrinkRequest : TeaModel {
        [NameInMap("IntentDefinition")]
        [Validation(Required=false)]
        public string IntentDefinitionShrink { get; set; }

        [NameInMap("DialogId")]
        [Validation(Required=false)]
        public long? DialogId { get; set; }

    }

}