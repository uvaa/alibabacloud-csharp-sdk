// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListUserSerivceGroupsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListUserSerivceGroupsResponseBodyData Data { get; set; }
        public class ListUserSerivceGroupsResponseBodyData : TeaModel {
            [NameInMap("ramId")]
            [Validation(Required=false)]
            public long? RamId { get; set; }
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("serviceGroups")]
            [Validation(Required=false)]
            public List<ListUserSerivceGroupsResponseBodyDataServiceGroups> ServiceGroups { get; set; }
            public class ListUserSerivceGroupsResponseBodyDataServiceGroups : TeaModel {
                public long? ServiceGroupId { get; set; }
                public string ServiceGroupName { get; set; }
                public string ServiceGroupDescription { get; set; }
            }
        };

    }

}