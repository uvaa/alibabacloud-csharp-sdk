// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListGlobalAppsRequest : TeaModel {
        /// <summary>
        /// 模糊查询字段：NamesapceName  AppName  Categories AppDescription
        /// </summary>
        [NameInMap("Search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// 是否倒序，默认倒序排列
        /// </summary>
        [NameInMap("IsReversed")]
        [Validation(Required=false)]
        public bool? IsReversed { get; set; }

        /// <summary>
        /// 用来标记当前开始读取的位置，置空表示从头开始。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 一批返回的最大数据量
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 可见范围
        /// </summary>
        [NameInMap("AppScope")]
        [Validation(Required=false)]
        public string AppScope { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// 工具集
        /// </summary>
        [NameInMap("Toolkit")]
        [Validation(Required=false)]
        public string Toolkit { get; set; }

        /// <summary>
        /// 区域Id
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}