// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dms_enterprise20181101.Models;

namespace AlibabaCloud.SDK.Dms_enterprise20181101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dms-enterprise", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        public ApproveOrderResponse ApproveOrderWithOptions(ApproveOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApproveOrderResponse>(DoRPCRequest("ApproveOrder", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApproveOrderResponse> ApproveOrderWithOptionsAsync(ApproveOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApproveOrderResponse>(await DoRPCRequestAsync("ApproveOrder", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApproveOrderResponse ApproveOrder(ApproveOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApproveOrderWithOptions(request, runtime);
        }

        public async Task<ApproveOrderResponse> ApproveOrderAsync(ApproveOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApproveOrderWithOptionsAsync(request, runtime);
        }

        public CheckFinishMissionResponse CheckFinishMissionWithOptions(CheckFinishMissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CheckFinishMissionResponse>(DoRPCRequest("CheckFinishMission", "2018-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CheckFinishMissionResponse> CheckFinishMissionWithOptionsAsync(CheckFinishMissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CheckFinishMissionResponse>(await DoRPCRequestAsync("CheckFinishMission", "2018-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public CheckFinishMissionResponse CheckFinishMission(CheckFinishMissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckFinishMissionWithOptions(request, runtime);
        }

        public async Task<CheckFinishMissionResponse> CheckFinishMissionAsync(CheckFinishMissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckFinishMissionWithOptionsAsync(request, runtime);
        }

        public CloseOrderResponse CloseOrderWithOptions(CloseOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloseOrderResponse>(DoRPCRequest("CloseOrder", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CloseOrderResponse> CloseOrderWithOptionsAsync(CloseOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloseOrderResponse>(await DoRPCRequestAsync("CloseOrder", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CloseOrderResponse CloseOrder(CloseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseOrderWithOptions(request, runtime);
        }

        public async Task<CloseOrderResponse> CloseOrderAsync(CloseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseOrderWithOptionsAsync(request, runtime);
        }

        public CreateOrderResponse CreateOrderWithOptions(CreateOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOrderShrinkRequest request = new CreateOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PluginParam))
            {
                request.PluginParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PluginParam, "PluginParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOrderResponse>(DoRPCRequest("CreateOrder", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateOrderResponse> CreateOrderWithOptionsAsync(CreateOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOrderShrinkRequest request = new CreateOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PluginParam))
            {
                request.PluginParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PluginParam, "PluginParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOrderResponse>(await DoRPCRequestAsync("CreateOrder", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateOrderResponse CreateOrder(CreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOrderWithOptions(request, runtime);
        }

        public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOrderWithOptionsAsync(request, runtime);
        }

        public CreatePublishGroupTaskResponse CreatePublishGroupTaskWithOptions(CreatePublishGroupTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePublishGroupTaskResponse>(DoRPCRequest("CreatePublishGroupTask", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePublishGroupTaskResponse> CreatePublishGroupTaskWithOptionsAsync(CreatePublishGroupTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePublishGroupTaskResponse>(await DoRPCRequestAsync("CreatePublishGroupTask", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePublishGroupTaskResponse CreatePublishGroupTask(CreatePublishGroupTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePublishGroupTaskWithOptions(request, runtime);
        }

        public async Task<CreatePublishGroupTaskResponse> CreatePublishGroupTaskAsync(CreatePublishGroupTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePublishGroupTaskWithOptionsAsync(request, runtime);
        }

        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(DoRPCRequest("DeleteInstance", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoRPCRequestAsync("DeleteInstance", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserResponse>(DoRPCRequest("DeleteUser", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserResponse>(await DoRPCRequestAsync("DeleteUser", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserWithOptions(request, runtime);
        }

        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserWithOptionsAsync(request, runtime);
        }

        public DisableUserResponse DisableUserWithOptions(DisableUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableUserResponse>(DoRPCRequest("DisableUser", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableUserResponse> DisableUserWithOptionsAsync(DisableUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableUserResponse>(await DoRPCRequestAsync("DisableUser", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableUserResponse DisableUser(DisableUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableUserWithOptions(request, runtime);
        }

        public async Task<DisableUserResponse> DisableUserAsync(DisableUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableUserWithOptionsAsync(request, runtime);
        }

        public EnableUserResponse EnableUserWithOptions(EnableUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableUserResponse>(DoRPCRequest("EnableUser", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableUserResponse> EnableUserWithOptionsAsync(EnableUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableUserResponse>(await DoRPCRequestAsync("EnableUser", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableUserResponse EnableUser(EnableUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableUserWithOptions(request, runtime);
        }

        public async Task<EnableUserResponse> EnableUserAsync(EnableUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableUserWithOptionsAsync(request, runtime);
        }

        public ExecuteDataCorrectResponse ExecuteDataCorrectWithOptions(ExecuteDataCorrectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExecuteDataCorrectShrinkRequest request = new ExecuteDataCorrectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionDetail))
            {
                request.ActionDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionDetail, "ActionDetail", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteDataCorrectResponse>(DoRPCRequest("ExecuteDataCorrect", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecuteDataCorrectResponse> ExecuteDataCorrectWithOptionsAsync(ExecuteDataCorrectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExecuteDataCorrectShrinkRequest request = new ExecuteDataCorrectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionDetail))
            {
                request.ActionDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionDetail, "ActionDetail", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteDataCorrectResponse>(await DoRPCRequestAsync("ExecuteDataCorrect", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecuteDataCorrectResponse ExecuteDataCorrect(ExecuteDataCorrectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteDataCorrectWithOptions(request, runtime);
        }

        public async Task<ExecuteDataCorrectResponse> ExecuteDataCorrectAsync(ExecuteDataCorrectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteDataCorrectWithOptionsAsync(request, runtime);
        }

        public ExecuteDataExportResponse ExecuteDataExportWithOptions(ExecuteDataExportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExecuteDataExportShrinkRequest request = new ExecuteDataExportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionDetail))
            {
                request.ActionDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionDetail, "ActionDetail", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteDataExportResponse>(DoRPCRequest("ExecuteDataExport", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecuteDataExportResponse> ExecuteDataExportWithOptionsAsync(ExecuteDataExportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExecuteDataExportShrinkRequest request = new ExecuteDataExportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionDetail))
            {
                request.ActionDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionDetail, "ActionDetail", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteDataExportResponse>(await DoRPCRequestAsync("ExecuteDataExport", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecuteDataExportResponse ExecuteDataExport(ExecuteDataExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteDataExportWithOptions(request, runtime);
        }

        public async Task<ExecuteDataExportResponse> ExecuteDataExportAsync(ExecuteDataExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteDataExportWithOptionsAsync(request, runtime);
        }

        public ExecuteScriptResponse ExecuteScriptWithOptions(ExecuteScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteScriptResponse>(DoRPCRequest("ExecuteScript", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecuteScriptResponse> ExecuteScriptWithOptionsAsync(ExecuteScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteScriptResponse>(await DoRPCRequestAsync("ExecuteScript", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecuteScriptResponse ExecuteScript(ExecuteScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteScriptWithOptions(request, runtime);
        }

        public async Task<ExecuteScriptResponse> ExecuteScriptAsync(ExecuteScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteScriptWithOptionsAsync(request, runtime);
        }

        public GetApprovalDetailResponse GetApprovalDetailWithOptions(GetApprovalDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetApprovalDetailResponse>(DoRPCRequest("GetApprovalDetail", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetApprovalDetailResponse> GetApprovalDetailWithOptionsAsync(GetApprovalDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetApprovalDetailResponse>(await DoRPCRequestAsync("GetApprovalDetail", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetApprovalDetailResponse GetApprovalDetail(GetApprovalDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApprovalDetailWithOptions(request, runtime);
        }

        public async Task<GetApprovalDetailResponse> GetApprovalDetailAsync(GetApprovalDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApprovalDetailWithOptionsAsync(request, runtime);
        }

        public GetDatabaseResponse GetDatabaseWithOptions(GetDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDatabaseResponse>(DoRPCRequest("GetDatabase", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDatabaseResponse> GetDatabaseWithOptionsAsync(GetDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDatabaseResponse>(await DoRPCRequestAsync("GetDatabase", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDatabaseResponse GetDatabase(GetDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDatabaseWithOptions(request, runtime);
        }

        public async Task<GetDatabaseResponse> GetDatabaseAsync(GetDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDatabaseWithOptionsAsync(request, runtime);
        }

        public GetDataCorrectBackupFilesResponse GetDataCorrectBackupFilesWithOptions(GetDataCorrectBackupFilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDataCorrectBackupFilesShrinkRequest request = new GetDataCorrectBackupFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionDetail))
            {
                request.ActionDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionDetail, "ActionDetail", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataCorrectBackupFilesResponse>(DoRPCRequest("GetDataCorrectBackupFiles", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDataCorrectBackupFilesResponse> GetDataCorrectBackupFilesWithOptionsAsync(GetDataCorrectBackupFilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDataCorrectBackupFilesShrinkRequest request = new GetDataCorrectBackupFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionDetail))
            {
                request.ActionDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionDetail, "ActionDetail", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataCorrectBackupFilesResponse>(await DoRPCRequestAsync("GetDataCorrectBackupFiles", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDataCorrectBackupFilesResponse GetDataCorrectBackupFiles(GetDataCorrectBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataCorrectBackupFilesWithOptions(request, runtime);
        }

        public async Task<GetDataCorrectBackupFilesResponse> GetDataCorrectBackupFilesAsync(GetDataCorrectBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataCorrectBackupFilesWithOptionsAsync(request, runtime);
        }

        public GetDataCorrectOrderDetailResponse GetDataCorrectOrderDetailWithOptions(GetDataCorrectOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataCorrectOrderDetailResponse>(DoRPCRequest("GetDataCorrectOrderDetail", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDataCorrectOrderDetailResponse> GetDataCorrectOrderDetailWithOptionsAsync(GetDataCorrectOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataCorrectOrderDetailResponse>(await DoRPCRequestAsync("GetDataCorrectOrderDetail", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDataCorrectOrderDetailResponse GetDataCorrectOrderDetail(GetDataCorrectOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataCorrectOrderDetailWithOptions(request, runtime);
        }

        public async Task<GetDataCorrectOrderDetailResponse> GetDataCorrectOrderDetailAsync(GetDataCorrectOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataCorrectOrderDetailWithOptionsAsync(request, runtime);
        }

        public GetDataExportDownloadURLResponse GetDataExportDownloadURLWithOptions(GetDataExportDownloadURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataExportDownloadURLResponse>(DoRPCRequest("GetDataExportDownloadURL", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDataExportDownloadURLResponse> GetDataExportDownloadURLWithOptionsAsync(GetDataExportDownloadURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataExportDownloadURLResponse>(await DoRPCRequestAsync("GetDataExportDownloadURL", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDataExportDownloadURLResponse GetDataExportDownloadURL(GetDataExportDownloadURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataExportDownloadURLWithOptions(request, runtime);
        }

        public async Task<GetDataExportDownloadURLResponse> GetDataExportDownloadURLAsync(GetDataExportDownloadURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataExportDownloadURLWithOptionsAsync(request, runtime);
        }

        public GetDataExportOrderDetailResponse GetDataExportOrderDetailWithOptions(GetDataExportOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataExportOrderDetailResponse>(DoRPCRequest("GetDataExportOrderDetail", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDataExportOrderDetailResponse> GetDataExportOrderDetailWithOptionsAsync(GetDataExportOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataExportOrderDetailResponse>(await DoRPCRequestAsync("GetDataExportOrderDetail", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDataExportOrderDetailResponse GetDataExportOrderDetail(GetDataExportOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataExportOrderDetailWithOptions(request, runtime);
        }

        public async Task<GetDataExportOrderDetailResponse> GetDataExportOrderDetailAsync(GetDataExportOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataExportOrderDetailWithOptionsAsync(request, runtime);
        }

        public GetInstanceResponse GetInstanceWithOptions(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceResponse>(DoRPCRequest("GetInstance", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceResponse>(await DoRPCRequestAsync("GetInstance", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceWithOptions(request, runtime);
        }

        public async Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceWithOptionsAsync(request, runtime);
        }

        public GetLogicDatabaseResponse GetLogicDatabaseWithOptions(GetLogicDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogicDatabaseResponse>(DoRPCRequest("GetLogicDatabase", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLogicDatabaseResponse> GetLogicDatabaseWithOptionsAsync(GetLogicDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogicDatabaseResponse>(await DoRPCRequestAsync("GetLogicDatabase", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLogicDatabaseResponse GetLogicDatabase(GetLogicDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogicDatabaseWithOptions(request, runtime);
        }

        public async Task<GetLogicDatabaseResponse> GetLogicDatabaseAsync(GetLogicDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogicDatabaseWithOptionsAsync(request, runtime);
        }

        public GetMetaTableColumnResponse GetMetaTableColumnWithOptions(GetMetaTableColumnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTableColumnResponse>(DoRPCRequest("GetMetaTableColumn", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMetaTableColumnResponse> GetMetaTableColumnWithOptionsAsync(GetMetaTableColumnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTableColumnResponse>(await DoRPCRequestAsync("GetMetaTableColumn", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMetaTableColumnResponse GetMetaTableColumn(GetMetaTableColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableColumnWithOptions(request, runtime);
        }

        public async Task<GetMetaTableColumnResponse> GetMetaTableColumnAsync(GetMetaTableColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableColumnWithOptionsAsync(request, runtime);
        }

        public GetMetaTableDetailInfoResponse GetMetaTableDetailInfoWithOptions(GetMetaTableDetailInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTableDetailInfoResponse>(DoRPCRequest("GetMetaTableDetailInfo", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMetaTableDetailInfoResponse> GetMetaTableDetailInfoWithOptionsAsync(GetMetaTableDetailInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTableDetailInfoResponse>(await DoRPCRequestAsync("GetMetaTableDetailInfo", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMetaTableDetailInfoResponse GetMetaTableDetailInfo(GetMetaTableDetailInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableDetailInfoWithOptions(request, runtime);
        }

        public async Task<GetMetaTableDetailInfoResponse> GetMetaTableDetailInfoAsync(GetMetaTableDetailInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableDetailInfoWithOptionsAsync(request, runtime);
        }

        public GetOpLogResponse GetOpLogWithOptions(GetOpLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOpLogResponse>(DoRPCRequest("GetOpLog", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOpLogResponse> GetOpLogWithOptionsAsync(GetOpLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOpLogResponse>(await DoRPCRequestAsync("GetOpLog", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOpLogResponse GetOpLog(GetOpLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOpLogWithOptions(request, runtime);
        }

        public async Task<GetOpLogResponse> GetOpLogAsync(GetOpLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOpLogWithOptionsAsync(request, runtime);
        }

        public GetOrderBaseInfoResponse GetOrderBaseInfoWithOptions(GetOrderBaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOrderBaseInfoResponse>(DoRPCRequest("GetOrderBaseInfo", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOrderBaseInfoResponse> GetOrderBaseInfoWithOptionsAsync(GetOrderBaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOrderBaseInfoResponse>(await DoRPCRequestAsync("GetOrderBaseInfo", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOrderBaseInfoResponse GetOrderBaseInfo(GetOrderBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOrderBaseInfoWithOptions(request, runtime);
        }

        public async Task<GetOrderBaseInfoResponse> GetOrderBaseInfoAsync(GetOrderBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOrderBaseInfoWithOptionsAsync(request, runtime);
        }

        public GetTableDBTopologyResponse GetTableDBTopologyWithOptions(GetTableDBTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTableDBTopologyResponse>(DoRPCRequest("GetTableDBTopology", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTableDBTopologyResponse> GetTableDBTopologyWithOptionsAsync(GetTableDBTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTableDBTopologyResponse>(await DoRPCRequestAsync("GetTableDBTopology", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTableDBTopologyResponse GetTableDBTopology(GetTableDBTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTableDBTopologyWithOptions(request, runtime);
        }

        public async Task<GetTableDBTopologyResponse> GetTableDBTopologyAsync(GetTableDBTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTableDBTopologyWithOptionsAsync(request, runtime);
        }

        public GetUserResponse GetUserWithOptions(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserResponse>(DoRPCRequest("GetUser", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserResponse>(await DoRPCRequestAsync("GetUser", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserWithOptions(request, runtime);
        }

        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserWithOptionsAsync(request, runtime);
        }

        public GetUserActiveTenantResponse GetUserActiveTenantWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetUserActiveTenantResponse>(DoRPCRequest("GetUserActiveTenant", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserActiveTenantResponse> GetUserActiveTenantWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetUserActiveTenantResponse>(await DoRPCRequestAsync("GetUserActiveTenant", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserActiveTenantResponse GetUserActiveTenant()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserActiveTenantWithOptions(runtime);
        }

        public async Task<GetUserActiveTenantResponse> GetUserActiveTenantAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserActiveTenantWithOptionsAsync(runtime);
        }

        public GrantUserPermissionResponse GrantUserPermissionWithOptions(GrantUserPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantUserPermissionResponse>(DoRPCRequest("GrantUserPermission", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GrantUserPermissionResponse> GrantUserPermissionWithOptionsAsync(GrantUserPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantUserPermissionResponse>(await DoRPCRequestAsync("GrantUserPermission", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GrantUserPermissionResponse GrantUserPermission(GrantUserPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantUserPermissionWithOptions(request, runtime);
        }

        public async Task<GrantUserPermissionResponse> GrantUserPermissionAsync(GrantUserPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantUserPermissionWithOptionsAsync(request, runtime);
        }

        public ListColumnsResponse ListColumnsWithOptions(ListColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListColumnsResponse>(DoRPCRequest("ListColumns", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListColumnsResponse> ListColumnsWithOptionsAsync(ListColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListColumnsResponse>(await DoRPCRequestAsync("ListColumns", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListColumnsResponse ListColumns(ListColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListColumnsWithOptions(request, runtime);
        }

        public async Task<ListColumnsResponse> ListColumnsAsync(ListColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListColumnsWithOptionsAsync(request, runtime);
        }

        public ListDatabasesResponse ListDatabasesWithOptions(ListDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDatabasesResponse>(DoRPCRequest("ListDatabases", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDatabasesResponse> ListDatabasesWithOptionsAsync(ListDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDatabasesResponse>(await DoRPCRequestAsync("ListDatabases", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDatabasesResponse ListDatabases(ListDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDatabasesWithOptions(request, runtime);
        }

        public async Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDatabasesWithOptionsAsync(request, runtime);
        }

        public ListDatabaseUserPermssionsResponse ListDatabaseUserPermssionsWithOptions(ListDatabaseUserPermssionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDatabaseUserPermssionsResponse>(DoRPCRequest("ListDatabaseUserPermssions", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDatabaseUserPermssionsResponse> ListDatabaseUserPermssionsWithOptionsAsync(ListDatabaseUserPermssionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDatabaseUserPermssionsResponse>(await DoRPCRequestAsync("ListDatabaseUserPermssions", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDatabaseUserPermssionsResponse ListDatabaseUserPermssions(ListDatabaseUserPermssionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDatabaseUserPermssionsWithOptions(request, runtime);
        }

        public async Task<ListDatabaseUserPermssionsResponse> ListDatabaseUserPermssionsAsync(ListDatabaseUserPermssionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDatabaseUserPermssionsWithOptionsAsync(request, runtime);
        }

        public ListIndexesResponse ListIndexesWithOptions(ListIndexesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIndexesResponse>(DoRPCRequest("ListIndexes", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListIndexesResponse> ListIndexesWithOptionsAsync(ListIndexesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIndexesResponse>(await DoRPCRequestAsync("ListIndexes", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListIndexesResponse ListIndexes(ListIndexesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIndexesWithOptions(request, runtime);
        }

        public async Task<ListIndexesResponse> ListIndexesAsync(ListIndexesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIndexesWithOptionsAsync(request, runtime);
        }

        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstancesResponse>(DoRPCRequest("ListInstances", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstancesResponse>(await DoRPCRequestAsync("ListInstances", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        public ListLogicDatabasesResponse ListLogicDatabasesWithOptions(ListLogicDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLogicDatabasesResponse>(DoRPCRequest("ListLogicDatabases", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListLogicDatabasesResponse> ListLogicDatabasesWithOptionsAsync(ListLogicDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLogicDatabasesResponse>(await DoRPCRequestAsync("ListLogicDatabases", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListLogicDatabasesResponse ListLogicDatabases(ListLogicDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLogicDatabasesWithOptions(request, runtime);
        }

        public async Task<ListLogicDatabasesResponse> ListLogicDatabasesAsync(ListLogicDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLogicDatabasesWithOptionsAsync(request, runtime);
        }

        public ListLogicTablesResponse ListLogicTablesWithOptions(ListLogicTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLogicTablesResponse>(DoRPCRequest("ListLogicTables", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListLogicTablesResponse> ListLogicTablesWithOptionsAsync(ListLogicTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLogicTablesResponse>(await DoRPCRequestAsync("ListLogicTables", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListLogicTablesResponse ListLogicTables(ListLogicTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLogicTablesWithOptions(request, runtime);
        }

        public async Task<ListLogicTablesResponse> ListLogicTablesAsync(ListLogicTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLogicTablesWithOptionsAsync(request, runtime);
        }

        public ListOrdersResponse ListOrdersWithOptions(ListOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrdersResponse>(DoRPCRequest("ListOrders", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOrdersResponse> ListOrdersWithOptionsAsync(ListOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrdersResponse>(await DoRPCRequestAsync("ListOrders", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOrdersResponse ListOrders(ListOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrdersWithOptions(request, runtime);
        }

        public async Task<ListOrdersResponse> ListOrdersAsync(ListOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrdersWithOptionsAsync(request, runtime);
        }

        public ListSensitiveColumnsResponse ListSensitiveColumnsWithOptions(ListSensitiveColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSensitiveColumnsResponse>(DoRPCRequest("ListSensitiveColumns", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSensitiveColumnsResponse> ListSensitiveColumnsWithOptionsAsync(ListSensitiveColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSensitiveColumnsResponse>(await DoRPCRequestAsync("ListSensitiveColumns", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSensitiveColumnsResponse ListSensitiveColumns(ListSensitiveColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSensitiveColumnsWithOptions(request, runtime);
        }

        public async Task<ListSensitiveColumnsResponse> ListSensitiveColumnsAsync(ListSensitiveColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSensitiveColumnsWithOptionsAsync(request, runtime);
        }

        public ListSensitiveColumnsDetailResponse ListSensitiveColumnsDetailWithOptions(ListSensitiveColumnsDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSensitiveColumnsDetailResponse>(DoRPCRequest("ListSensitiveColumnsDetail", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSensitiveColumnsDetailResponse> ListSensitiveColumnsDetailWithOptionsAsync(ListSensitiveColumnsDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSensitiveColumnsDetailResponse>(await DoRPCRequestAsync("ListSensitiveColumnsDetail", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSensitiveColumnsDetailResponse ListSensitiveColumnsDetail(ListSensitiveColumnsDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSensitiveColumnsDetailWithOptions(request, runtime);
        }

        public async Task<ListSensitiveColumnsDetailResponse> ListSensitiveColumnsDetailAsync(ListSensitiveColumnsDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSensitiveColumnsDetailWithOptionsAsync(request, runtime);
        }

        public ListTablesResponse ListTablesWithOptions(ListTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTablesResponse>(DoRPCRequest("ListTables", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTablesResponse> ListTablesWithOptionsAsync(ListTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTablesResponse>(await DoRPCRequestAsync("ListTables", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTablesResponse ListTables(ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTablesWithOptions(request, runtime);
        }

        public async Task<ListTablesResponse> ListTablesAsync(ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTablesWithOptionsAsync(request, runtime);
        }

        public ListUserPermissionsResponse ListUserPermissionsWithOptions(ListUserPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserPermissionsResponse>(DoRPCRequest("ListUserPermissions", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserPermissionsResponse> ListUserPermissionsWithOptionsAsync(ListUserPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserPermissionsResponse>(await DoRPCRequestAsync("ListUserPermissions", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserPermissionsResponse ListUserPermissions(ListUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserPermissionsWithOptions(request, runtime);
        }

        public async Task<ListUserPermissionsResponse> ListUserPermissionsAsync(ListUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserPermissionsWithOptionsAsync(request, runtime);
        }

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(DoRPCRequest("ListUsers", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(await DoRPCRequestAsync("ListUsers", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        public ListUserTenantsResponse ListUserTenantsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListUserTenantsResponse>(DoRPCRequest("ListUserTenants", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserTenantsResponse> ListUserTenantsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListUserTenantsResponse>(await DoRPCRequestAsync("ListUserTenants", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserTenantsResponse ListUserTenants()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserTenantsWithOptions(runtime);
        }

        public async Task<ListUserTenantsResponse> ListUserTenantsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserTenantsWithOptionsAsync(runtime);
        }

        public ListWorkFlowNodesResponse ListWorkFlowNodesWithOptions(ListWorkFlowNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListWorkFlowNodesResponse>(DoRPCRequest("ListWorkFlowNodes", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListWorkFlowNodesResponse> ListWorkFlowNodesWithOptionsAsync(ListWorkFlowNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListWorkFlowNodesResponse>(await DoRPCRequestAsync("ListWorkFlowNodes", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListWorkFlowNodesResponse ListWorkFlowNodes(ListWorkFlowNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkFlowNodesWithOptions(request, runtime);
        }

        public async Task<ListWorkFlowNodesResponse> ListWorkFlowNodesAsync(ListWorkFlowNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkFlowNodesWithOptionsAsync(request, runtime);
        }

        public ListWorkFlowTemplatesResponse ListWorkFlowTemplatesWithOptions(ListWorkFlowTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListWorkFlowTemplatesResponse>(DoRPCRequest("ListWorkFlowTemplates", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListWorkFlowTemplatesResponse> ListWorkFlowTemplatesWithOptionsAsync(ListWorkFlowTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListWorkFlowTemplatesResponse>(await DoRPCRequestAsync("ListWorkFlowTemplates", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListWorkFlowTemplatesResponse ListWorkFlowTemplates(ListWorkFlowTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkFlowTemplatesWithOptions(request, runtime);
        }

        public async Task<ListWorkFlowTemplatesResponse> ListWorkFlowTemplatesAsync(ListWorkFlowTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkFlowTemplatesWithOptionsAsync(request, runtime);
        }

        public RegisterInstanceResponse RegisterInstanceWithOptions(RegisterInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterInstanceResponse>(DoRPCRequest("RegisterInstance", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterInstanceResponse> RegisterInstanceWithOptionsAsync(RegisterInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterInstanceResponse>(await DoRPCRequestAsync("RegisterInstance", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterInstanceResponse RegisterInstance(RegisterInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterInstanceWithOptions(request, runtime);
        }

        public async Task<RegisterInstanceResponse> RegisterInstanceAsync(RegisterInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterInstanceWithOptionsAsync(request, runtime);
        }

        public RegisterUserResponse RegisterUserWithOptions(RegisterUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterUserResponse>(DoRPCRequest("RegisterUser", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterUserResponse> RegisterUserWithOptionsAsync(RegisterUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterUserResponse>(await DoRPCRequestAsync("RegisterUser", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterUserResponse RegisterUser(RegisterUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterUserWithOptions(request, runtime);
        }

        public async Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterUserWithOptionsAsync(request, runtime);
        }

        public RevokeUserPermissionResponse RevokeUserPermissionWithOptions(RevokeUserPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeUserPermissionResponse>(DoRPCRequest("RevokeUserPermission", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeUserPermissionResponse> RevokeUserPermissionWithOptionsAsync(RevokeUserPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeUserPermissionResponse>(await DoRPCRequestAsync("RevokeUserPermission", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeUserPermissionResponse RevokeUserPermission(RevokeUserPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeUserPermissionWithOptions(request, runtime);
        }

        public async Task<RevokeUserPermissionResponse> RevokeUserPermissionAsync(RevokeUserPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeUserPermissionWithOptionsAsync(request, runtime);
        }

        public SearchDatabaseResponse SearchDatabaseWithOptions(SearchDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchDatabaseResponse>(DoRPCRequest("SearchDatabase", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchDatabaseResponse> SearchDatabaseWithOptionsAsync(SearchDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchDatabaseResponse>(await DoRPCRequestAsync("SearchDatabase", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchDatabaseResponse SearchDatabase(SearchDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchDatabaseWithOptions(request, runtime);
        }

        public async Task<SearchDatabaseResponse> SearchDatabaseAsync(SearchDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchDatabaseWithOptionsAsync(request, runtime);
        }

        public SearchTableResponse SearchTableWithOptions(SearchTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTableResponse>(DoRPCRequest("SearchTable", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchTableResponse> SearchTableWithOptionsAsync(SearchTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTableResponse>(await DoRPCRequestAsync("SearchTable", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchTableResponse SearchTable(SearchTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchTableWithOptions(request, runtime);
        }

        public async Task<SearchTableResponse> SearchTableAsync(SearchTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchTableWithOptionsAsync(request, runtime);
        }

        public SetOwnersResponse SetOwnersWithOptions(SetOwnersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetOwnersResponse>(DoRPCRequest("SetOwners", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetOwnersResponse> SetOwnersWithOptionsAsync(SetOwnersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetOwnersResponse>(await DoRPCRequestAsync("SetOwners", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetOwnersResponse SetOwners(SetOwnersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetOwnersWithOptions(request, runtime);
        }

        public async Task<SetOwnersResponse> SetOwnersAsync(SetOwnersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetOwnersWithOptionsAsync(request, runtime);
        }

        public SubmitOrderApprovalResponse SubmitOrderApprovalWithOptions(SubmitOrderApprovalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitOrderApprovalResponse>(DoRPCRequest("SubmitOrderApproval", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitOrderApprovalResponse> SubmitOrderApprovalWithOptionsAsync(SubmitOrderApprovalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitOrderApprovalResponse>(await DoRPCRequestAsync("SubmitOrderApproval", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitOrderApprovalResponse SubmitOrderApproval(SubmitOrderApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitOrderApprovalWithOptions(request, runtime);
        }

        public async Task<SubmitOrderApprovalResponse> SubmitOrderApprovalAsync(SubmitOrderApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitOrderApprovalWithOptionsAsync(request, runtime);
        }

        public SyncDatabaseMetaResponse SyncDatabaseMetaWithOptions(SyncDatabaseMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncDatabaseMetaResponse>(DoRPCRequest("SyncDatabaseMeta", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SyncDatabaseMetaResponse> SyncDatabaseMetaWithOptionsAsync(SyncDatabaseMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncDatabaseMetaResponse>(await DoRPCRequestAsync("SyncDatabaseMeta", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SyncDatabaseMetaResponse SyncDatabaseMeta(SyncDatabaseMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncDatabaseMetaWithOptions(request, runtime);
        }

        public async Task<SyncDatabaseMetaResponse> SyncDatabaseMetaAsync(SyncDatabaseMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncDatabaseMetaWithOptionsAsync(request, runtime);
        }

        public SyncInstanceMetaResponse SyncInstanceMetaWithOptions(SyncInstanceMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncInstanceMetaResponse>(DoRPCRequest("SyncInstanceMeta", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SyncInstanceMetaResponse> SyncInstanceMetaWithOptionsAsync(SyncInstanceMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncInstanceMetaResponse>(await DoRPCRequestAsync("SyncInstanceMeta", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SyncInstanceMetaResponse SyncInstanceMeta(SyncInstanceMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncInstanceMetaWithOptions(request, runtime);
        }

        public async Task<SyncInstanceMetaResponse> SyncInstanceMetaAsync(SyncInstanceMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncInstanceMetaWithOptionsAsync(request, runtime);
        }

        public UpdateInstanceResponse UpdateInstanceWithOptions(UpdateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(DoRPCRequest("UpdateInstance", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateInstanceResponse> UpdateInstanceWithOptionsAsync(UpdateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(await DoRPCRequestAsync("UpdateInstance", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceWithOptions(request, runtime);
        }

        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceWithOptionsAsync(request, runtime);
        }

        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserResponse>(DoRPCRequest("UpdateUser", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserResponse>(await DoRPCRequestAsync("UpdateUser", "2018-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserWithOptions(request, runtime);
        }

        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserWithOptionsAsync(request, runtime);
        }

    }
}