2022-08-17 Version: 2.2.9
- GetFeatureDetail returns supported resource types for terraform risk check.

2022-07-21 Version: 2.2.8
- GetTemplateSummary support Parameters and ClientToken.

2022-07-13 Version: 2.2.7
- PreviewStack adds StackId and returns Action to support preview stack update.

2022-06-30 Version: 2.2.6
- ValidateTemplate returns ResourceTypes.
- GetStackResource supports ResourceAttributes.
- GetStack supports LogOption and returns ResourceLogs.

2022-06-09 Version: 2.2.5
- The parameter of GetStack, ListTemplates adds IncludeTags.
- The response of GetStack, ListTemplates adds Tags.

2022-05-19 Version: 2.2.4
- GetFeatureDetails supports ResourceCleaner.

2022-05-07 Version: 2.2.3
- Added diagnostic feature interface.

2022-04-25 Version: 2.2.2
- The Feature parameter of GetFeatureDetails is supported to be specified as TemplateScratch, which indicates the supported resource types for the template scratch.

2022-02-28 Version: 2.2.1
- The response of GetServiceProvisions adds DependentServiceNames.

2022-02-22 Version: 2.2.0
- The parameter of GetStack, GetTemplate, ListTemplates, ListTemplateVersions adds AcceptLanguage.
- The response of GetStack, GetTemplate adds Interface.
- The parameter of CreateStack, CreateChangeSet adds ServiceManaged.
- The response of GetStack adds ServiceManaged, ServiceName.
- The response of ListStacks adds ServiceManaged, ServiceName in Stacks.

2022-01-18 Version: 2.1.0
- Added EntityType to ListResourceTypes parameters.
- Added EntityType to GetResourceType return value.

2022-01-12 Version: 2.0.6
- GetFeatureDetails return value adds UpdateAllowedTransforms.

2022-01-05 Version: 2.0.5
- GetTemplate return value adds TemplateId, TemplateVersion, TemplateScratchId and TemplateURL.

2021-12-20 Version: 2.0.4
- CreateStack, PreviewStack and GetTemplateEstimateCost parameters supports specifing TemplateScratchRegionId.
- GetTemplateScratch return value adds StackProvision and UsageType in Stacks.
- GetTemplate return value adds ShareSource in Permissions.

2021-12-14 Version: 2.0.3
- Fix the issue that some parameters cannot be passed.

2021-12-07 Version: 2.0.2
- API GetStack supports Log for Terraform Stack.
- API GetChangeSet supports Log for Terraform Stack.
- API PreviewStack supports Log for Terraform Stack.

2021-11-30 Version: 2.0.1
- API GetStack supports Log for Terraform Stack.
- API GetChangeSet supports Log for Terraform Stack.
- API PreviewStack supports Log for Terraform Stack.

2021-11-22 Version: 2.0.0
- Add API GetServiceProvisions.
- Add API GetTemplateParameterConstraints.
- Add API GetFeatureDetails.
- CreateChangeSet supports Parallelism.

2021-09-23 Version: 1.1.3
- Terraform stack supports custom of parallelism.

2021-09-16 Version: 1.1.2
- Fixed the property AdministratorRoleName in GetStackGroupOperation  to AdministrationRoleName.

2021-09-03 Version: 1.1.1
- Fix type error of StackGroup and StackInstance parameters.

2021-09-03 Version: 1.1.0
- StackGroup supports specify resource folder to deploy StackInstances.
- StackGroup supports SERVICE_MANAGED and SELF_MANAGED permission models.

2021-08-27 Version: 1.0.4
- Support ClientToken for ValidateTemplate.

2021-07-20 Version: 1.0.3
- GetStack supports resource progress.
- ValidateTemplate supports Outputs.

2021-01-22 Version: 1.0.2
- Generated csharp 2019-09-10 for ROS.

2021-01-22 Version: 0.3.0
- Generated csharp 2019-09-10 for ROS.

2021-01-21 Version: 0.2.3
- Generated csharp 2019-09-10 for ROS.

2021-01-21 Version: 0.2.2
- Generated csharp 2019-09-10 for ROS.

2021-01-21 Version: 0.2.1
- The creation and update APIs of the stack supports specifing tags, and the query and list APIs supports obtaining tags.

2020-12-30 Version: 1.0.0
- AMP Version Change.

2020-12-17 Version: 0.2.0
- Support template version.
- Support to share template.
- Stack and StackGroup support TemplateId and TemplateVersion.
- Add GenerateTemplatePolicy which can generate RAM policy by template.

