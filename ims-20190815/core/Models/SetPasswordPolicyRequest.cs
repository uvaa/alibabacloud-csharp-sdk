// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetPasswordPolicyRequest : TeaModel {
        [NameInMap("HardExpire")]
        [Validation(Required=false)]
        public bool? HardExpire { get; set; }

        [NameInMap("MaxLoginAttemps")]
        [Validation(Required=false)]
        public int? MaxLoginAttemps { get; set; }

        [NameInMap("MaxPasswordAge")]
        [Validation(Required=false)]
        public int? MaxPasswordAge { get; set; }

        [NameInMap("MinimumPasswordDifferentCharacter")]
        [Validation(Required=false)]
        public int? MinimumPasswordDifferentCharacter { get; set; }

        [NameInMap("MinimumPasswordLength")]
        [Validation(Required=false)]
        public int? MinimumPasswordLength { get; set; }

        [NameInMap("PasswordNotContainUserName")]
        [Validation(Required=false)]
        public bool? PasswordNotContainUserName { get; set; }

        [NameInMap("PasswordReusePrevention")]
        [Validation(Required=false)]
        public int? PasswordReusePrevention { get; set; }

        [NameInMap("RequireLowercaseCharacters")]
        [Validation(Required=false)]
        public bool? RequireLowercaseCharacters { get; set; }

        [NameInMap("RequireNumbers")]
        [Validation(Required=false)]
        public bool? RequireNumbers { get; set; }

        [NameInMap("RequireSymbols")]
        [Validation(Required=false)]
        public bool? RequireSymbols { get; set; }

        [NameInMap("RequireUppercaseCharacters")]
        [Validation(Required=false)]
        public bool? RequireUppercaseCharacters { get; set; }

    }

}
