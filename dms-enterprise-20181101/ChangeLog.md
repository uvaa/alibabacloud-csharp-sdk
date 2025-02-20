2022-07-27 Version: 1.38.0
- Support ListProxies API to return protocolType, protocolPort and remove mysqlPort.
- Support GetProxy API to return protocolType, protocolPort and remove mysqlPort.

2022-06-08 Version: 1.37.0
- Support GetDataCorrectOrderDetail API to return execMode type.
- Support CreateDataCorrectOrder, CreateFreeLockCorrectOrder API submit with execMode type.


2022-04-21 Version: 1.36.0
- Add API OfflineTaskFlow.

2022-04-15 Version: 1.35.0
- Rename the return of ListTaskFlow API.

2022-04-12 Version: 1.34.0
- Remove redundant input for API ListTaskFlow.

2022-04-06 Version: 1.33.0
- Support output dagName, dagOwnerId for api listTaskFlowAndScenario.
- Change output DbType to DwDbType for api GetLhSpaceByName.

2022-03-31 Version: 1.32.0
- Supported ListTaskFlow, ListTaskFlowInstance, GetTaskInstanceRelation, GetLhSpaceByName, DeleteLakeHouseSpace, DeleteTaskFlow API.

2022-03-24 Version: 1.31.0
- Supported CreateLakeHouseSpace,AddLhMembers,DeleteLhMembers,ListLhTaskFlowAndScenario,ChangeLhDagOwner,ReDeployLhDagVersion API.

2022-03-18 Version: 1.30.0
- Supported CreateStandardGroup, ListStandardGroups API.

2022-03-10 Version: 1.29.0
- Disabled Spark Job API.

2022-01-21 Version: 1.28.0
- Supported RestartDataCorrectSQLJob,PauseDataCorrectSQLJob API.
- Supported ListDataCorrectPreCheckSQL to return tableNames information.

2022-01-07 Version: 1.27.0
- Supported GetSparkJobDetail,GetSparkJobExecutorLogs,KillSparkJob,GetSparkJobDriverLog,GetSparkJobLog,SubmitSparkJob API.

2021-12-20 Version: 1.26.0
- Supported ListLogicDatabases to return Alias information.
- Supported ListDBTaskSQLJobDetail to return sql execute startTime and endTime information.

2021-11-29 Version: 1.25.0
- Supported ListLogicTableRouteConfig, AddLogicTableRouteConfig, DeleteLogicTableRouteConfig API.
- Supported ModifyDataCorrectExecSQL, RetryDataCorrectPreCheck API.
- Supported GetDBTaskSQLJobLog API.
- Supported ListDBTaskSQLJobDetail to return execute log information.

2021-11-18 Version: 1.24.0
- Support ListInstanceLoginAuditLog, ListProxySQLExecAuditLog API.
- Support GetOpLog API to return OpUserId information.

2021-11-04 Version: 1.23.0
- Support ListSQLExecAuditLog API.
- Support ListUsers, GetUser API to return information of Email, Webhook and DingRobot.
- Support GetApprovalDetail API to return information of CreateTime.

2021-10-25 Version: 1.22.0
- Support ListInstances and GetInstance API to return StandardGroup information.
- Support ListUserPermissions, GrantUserPermission, GrantUserPermission to operate instance permission.
- Support ChangeColumnSecLevel API.
- Support CreateLogicDatabase, EditLogicDatabase, DeleteLogicDatabase API.

2021-08-12 Version: 1.21.0
- Support CreateProxy, DeleteProxy, GetProxy, ListProxies, CreateProxyAccess, DeleteProxyAccess, ListProxyAccesses, InspectProxyAccessSecret Safety Protection Management APIs.

2021-07-06 Version: 1.20.0
- Support ListDataCorrectPreCheckDB,ListDataCorrectPreCheckSQL Order API.

2021-06-29 Version: 1.19.0
- Support GetSQLReviewOptimizeDetail,ListSQLReviewOriginSQL Order API.

2021-04-22 Version: 1.17.0
- Support GetPhysicalDatabase API.

2021-04-12 Version: 1.16.0
- Support GetDBTopology API.

2021-03-30 Version: 1.15.0
- Support ListDDLPublishRecords API.
- Fixed GetMetaTableColumn, GetMetaTableDetailInfo API response param DataLength lack of precision.

2021-03-10 Version: 1.14.0
- Support CreateDataCorrectOrder, CreateDataImportOrder, CreateFreeLockCorrectOrder, CreateDataCronClearOrder API.
- Support GetDataCorrectTaskDetail API.
- Support GetTableTopology API.
- Support CreateOrder API to apply order attachment.

2021-03-01 Version: 1.13.0
- Support TableStructSync Order API.
- Support Upload File API.
- Support GetOwnerApplyOrderDetail, GetPermApplyOrderDetail API.
- Support ListDBTaskSQLJob, ListDBTaskSQLJobDetail API.
- Support GetDataCorrectSQLFile API.

2020-12-30 Version: 1.0.0
- AMP Version Change.

