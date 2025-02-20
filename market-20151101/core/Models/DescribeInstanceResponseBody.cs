// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        [NameInMap("AppJson")]
        [Validation(Required=false)]
        public string AppJson { get; set; }

        [NameInMap("BeganOn")]
        [Validation(Required=false)]
        public long? BeganOn { get; set; }

        [NameInMap("ComponentJson")]
        [Validation(Required=false)]
        public string ComponentJson { get; set; }

        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public string Constraints { get; set; }

        [NameInMap("CreatedOn")]
        [Validation(Required=false)]
        public long? CreatedOn { get; set; }

        [NameInMap("EndOn")]
        [Validation(Required=false)]
        public long? EndOn { get; set; }

        [NameInMap("ExtendJson")]
        [Validation(Required=false)]
        public string ExtendJson { get; set; }

        [NameInMap("HostJson")]
        [Validation(Required=false)]
        public string HostJson { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        [NameInMap("IsTrial")]
        [Validation(Required=false)]
        public bool? IsTrial { get; set; }

        [NameInMap("Modules")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyModules Modules { get; set; }
        public class DescribeInstanceResponseBodyModules : TeaModel {
            [NameInMap("Module")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyModulesModule> Module { get; set; }
            public class DescribeInstanceResponseBodyModulesModule : TeaModel {
                public string Code { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public DescribeInstanceResponseBodyModulesModuleProperties Properties { get; set; }
                public class DescribeInstanceResponseBodyModulesModuleProperties : TeaModel {
                    [NameInMap("Property")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceResponseBodyModulesModulePropertiesProperty> Property { get; set; }
                    public class DescribeInstanceResponseBodyModulesModulePropertiesProperty : TeaModel {
                        [NameInMap("DisplayUnit")]
                        [Validation(Required=false)]
                        public string DisplayUnit { get; set; }

                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("PropertyValues")]
                        [Validation(Required=false)]
                        public DescribeInstanceResponseBodyModulesModulePropertiesPropertyPropertyValues PropertyValues { get; set; }
                        public class DescribeInstanceResponseBodyModulesModulePropertiesPropertyPropertyValues : TeaModel {
                            [NameInMap("PropertyValue")]
                            [Validation(Required=false)]
                            public List<DescribeInstanceResponseBodyModulesModulePropertiesPropertyPropertyValuesPropertyValue> PropertyValue { get; set; }
                            public class DescribeInstanceResponseBodyModulesModulePropertiesPropertyPropertyValuesPropertyValue : TeaModel {
                                public string DisplayName { get; set; }
                                public string Max { get; set; }
                                public string Min { get; set; }
                                public string Remark { get; set; }
                                public string Step { get; set; }
                                public string Type { get; set; }
                                public string Value { get; set; }
                            }
                        };

                        [NameInMap("ShowType")]
                        [Validation(Required=false)]
                        public string ShowType { get; set; }

                    }

                }
            }
        };

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("ProductSkuCode")]
        [Validation(Required=false)]
        public string ProductSkuCode { get; set; }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("RelationalData")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyRelationalData RelationalData { get; set; }
        public class DescribeInstanceResponseBodyRelationalData : TeaModel {
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }
        };

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SupplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

    }

}
