// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCommandsResponseBody : TeaModel {
        [NameInMap("Commands")]
        [Validation(Required=false)]
        public DescribeCommandsResponseBodyCommands Commands { get; set; }
        public class DescribeCommandsResponseBodyCommands : TeaModel {
            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<DescribeCommandsResponseBodyCommandsCommand> Command { get; set; }
            public class DescribeCommandsResponseBodyCommandsCommand : TeaModel {
                public string Category { get; set; }
                public string CommandContent { get; set; }
                public string CommandId { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public bool? EnableParameter { get; set; }
                public int? InvokeTimes { get; set; }
                public bool? Latest { get; set; }
                public string Name { get; set; }
                public DescribeCommandsResponseBodyCommandsCommandParameterDefinitions ParameterDefinitions { get; set; }
                public class DescribeCommandsResponseBodyCommandsCommandParameterDefinitions : TeaModel {
                    [NameInMap("ParameterDefinition")]
                    [Validation(Required=false)]
                    public List<DescribeCommandsResponseBodyCommandsCommandParameterDefinitionsParameterDefinition> ParameterDefinition { get; set; }
                    public class DescribeCommandsResponseBodyCommandsCommandParameterDefinitionsParameterDefinition : TeaModel {
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                        [NameInMap("PossibleValues")]
                        [Validation(Required=false)]
                        public DescribeCommandsResponseBodyCommandsCommandParameterDefinitionsParameterDefinitionPossibleValues PossibleValues { get; set; }
                        public class DescribeCommandsResponseBodyCommandsCommandParameterDefinitionsParameterDefinitionPossibleValues : TeaModel {
                            [NameInMap("PossibleValue")]
                            [Validation(Required=false)]
                            public List<string> PossibleValue { get; set; }
                        };

                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                    }

                }
                public DescribeCommandsResponseBodyCommandsCommandParameterNames ParameterNames { get; set; }
                public class DescribeCommandsResponseBodyCommandsCommandParameterNames : TeaModel {
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public List<string> ParameterName { get; set; }

                }
                public string Provider { get; set; }
                public long? Timeout { get; set; }
                public string Type { get; set; }
                public int? Version { get; set; }
                public string WorkingDir { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
