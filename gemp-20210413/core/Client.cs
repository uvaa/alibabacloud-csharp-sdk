// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.GEMP20210413.Models;

namespace AlibabaCloud.SDK.GEMP20210413
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("gemp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ListIncidentTimelinesResponse ListIncidentTimelines(ListIncidentTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIncidentTimelinesWithOptions(request, headers, runtime);
        }

        public async Task<ListIncidentTimelinesResponse> ListIncidentTimelinesAsync(ListIncidentTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIncidentTimelinesWithOptionsAsync(request, headers, runtime);
        }

        public ListIncidentTimelinesResponse ListIncidentTimelinesWithOptions(ListIncidentTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListIncidentTimelinesResponse>(DoROARequest("ListIncidentTimelines", "2021-04-13", "HTTPS", "POST", "AK", "/incident/timeline", "json", req, runtime));
        }

        public async Task<ListIncidentTimelinesResponse> ListIncidentTimelinesWithOptionsAsync(ListIncidentTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListIncidentTimelinesResponse>(await DoROARequestAsync("ListIncidentTimelines", "2021-04-13", "HTTPS", "POST", "AK", "/incident/timeline", "json", req, runtime));
        }

        public UpdateProblemNoticeResponse UpdateProblemNotice(UpdateProblemNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProblemNoticeWithOptions(request, headers, runtime);
        }

        public async Task<UpdateProblemNoticeResponse> UpdateProblemNoticeAsync(UpdateProblemNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProblemNoticeWithOptionsAsync(request, headers, runtime);
        }

        public UpdateProblemNoticeResponse UpdateProblemNoticeWithOptions(UpdateProblemNoticeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateProblemNoticeResponse>(DoROARequest("UpdateProblemNotice", "2021-04-13", "HTTPS", "POST", "AK", "/problem/notify", "json", req, runtime));
        }

        public async Task<UpdateProblemNoticeResponse> UpdateProblemNoticeWithOptionsAsync(UpdateProblemNoticeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateProblemNoticeResponse>(await DoROARequestAsync("UpdateProblemNotice", "2021-04-13", "HTTPS", "POST", "AK", "/problem/notify", "json", req, runtime));
        }

        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUsersWithOptions(request, headers, runtime);
        }

        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUsersWithOptionsAsync(request, headers, runtime);
        }

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamId))
            {
                body["ramId"] = request.RamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListUsersResponse>(DoROARequest("ListUsers", "2021-04-13", "HTTPS", "POST", "AK", "/user/list", "json", req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamId))
            {
                body["ramId"] = request.RamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListUsersResponse>(await DoROARequestAsync("ListUsers", "2021-04-13", "HTTPS", "POST", "AK", "/user/list", "json", req, runtime));
        }

        public ListIntegrationConfigTimelinesResponse ListIntegrationConfigTimelines(ListIntegrationConfigTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIntegrationConfigTimelinesWithOptions(request, headers, runtime);
        }

        public async Task<ListIntegrationConfigTimelinesResponse> ListIntegrationConfigTimelinesAsync(ListIntegrationConfigTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIntegrationConfigTimelinesWithOptionsAsync(request, headers, runtime);
        }

        public ListIntegrationConfigTimelinesResponse ListIntegrationConfigTimelinesWithOptions(ListIntegrationConfigTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListIntegrationConfigTimelinesResponse>(DoROARequest("ListIntegrationConfigTimelines", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/timeline", "json", req, runtime));
        }

        public async Task<ListIntegrationConfigTimelinesResponse> ListIntegrationConfigTimelinesWithOptionsAsync(ListIntegrationConfigTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListIntegrationConfigTimelinesResponse>(await DoROARequestAsync("ListIntegrationConfigTimelines", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/timeline", "json", req, runtime));
        }

        public UpdateIncidentResponse UpdateIncident(UpdateIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIncidentWithOptions(request, headers, runtime);
        }

        public async Task<UpdateIncidentResponse> UpdateIncidentAsync(UpdateIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIncidentWithOptionsAsync(request, headers, runtime);
        }

        public UpdateIncidentResponse UpdateIncidentWithOptions(UpdateIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentTitle))
            {
                body["incidentTitle"] = request.IncidentTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateIncidentResponse>(DoROARequest("UpdateIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/update", "json", req, runtime));
        }

        public async Task<UpdateIncidentResponse> UpdateIncidentWithOptionsAsync(UpdateIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentTitle))
            {
                body["incidentTitle"] = request.IncidentTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateIncidentResponse>(await DoROARequestAsync("UpdateIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/update", "json", req, runtime));
        }

        public GetServiceGroupResponse GetServiceGroup(GetServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceGroupWithOptions(request, headers, runtime);
        }

        public async Task<GetServiceGroupResponse> GetServiceGroupAsync(GetServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        public GetServiceGroupResponse GetServiceGroupWithOptions(GetServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetServiceGroupResponse>(DoROARequest("GetServiceGroup", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/detail", "json", req, runtime));
        }

        public async Task<GetServiceGroupResponse> GetServiceGroupWithOptionsAsync(GetServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetServiceGroupResponse>(await DoROARequestAsync("GetServiceGroup", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/detail", "json", req, runtime));
        }

        public ListRouteRulesResponse ListRouteRules(ListRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRouteRulesWithOptions(request, headers, runtime);
        }

        public async Task<ListRouteRulesResponse> ListRouteRulesAsync(ListRouteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRouteRulesWithOptionsAsync(request, headers, runtime);
        }

        public ListRouteRulesResponse ListRouteRulesWithOptions(ListRouteRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListRouteRulesResponse>(DoROARequest("ListRouteRules", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/list", "json", req, runtime));
        }

        public async Task<ListRouteRulesResponse> ListRouteRulesWithOptionsAsync(ListRouteRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListRouteRulesResponse>(await DoROARequestAsync("ListRouteRules", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/list", "json", req, runtime));
        }

        public DisableSubscriptionResponse DisableSubscription(DisableSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableSubscriptionWithOptions(request, headers, runtime);
        }

        public async Task<DisableSubscriptionResponse> DisableSubscriptionAsync(DisableSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableSubscriptionWithOptionsAsync(request, headers, runtime);
        }

        public DisableSubscriptionResponse DisableSubscriptionWithOptions(DisableSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DisableSubscriptionResponse>(DoROARequest("DisableSubscription", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/doDisable", "json", req, runtime));
        }

        public async Task<DisableSubscriptionResponse> DisableSubscriptionWithOptionsAsync(DisableSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DisableSubscriptionResponse>(await DoROARequestAsync("DisableSubscription", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/doDisable", "json", req, runtime));
        }

        public CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSubscriptionWithOptions(request, headers, runtime);
        }

        public async Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSubscriptionWithOptionsAsync(request, headers, runtime);
        }

        public CreateSubscriptionResponse CreateSubscriptionWithOptions(CreateSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionTitle))
            {
                body["subscriptionTitle"] = request.SubscriptionTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectType))
            {
                body["notifyObjectType"] = request.NotifyObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredType))
            {
                body["expiredType"] = request.ExpiredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeObjectList))
            {
                body["scopeObjectList"] = request.ScopeObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectList))
            {
                body["notifyObjectList"] = request.NotifyObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStrategyList))
            {
                body["notifyStrategyList"] = request.NotifyStrategyList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateSubscriptionResponse>(DoROARequest("CreateSubscription", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/create", "json", req, runtime));
        }

        public async Task<CreateSubscriptionResponse> CreateSubscriptionWithOptionsAsync(CreateSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionTitle))
            {
                body["subscriptionTitle"] = request.SubscriptionTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectType))
            {
                body["notifyObjectType"] = request.NotifyObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredType))
            {
                body["expiredType"] = request.ExpiredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeObjectList))
            {
                body["scopeObjectList"] = request.ScopeObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectList))
            {
                body["notifyObjectList"] = request.NotifyObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStrategyList))
            {
                body["notifyStrategyList"] = request.NotifyStrategyList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateSubscriptionResponse>(await DoROARequestAsync("CreateSubscription", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/create", "json", req, runtime));
        }

        public DeleteIntegrationConfigResponse DeleteIntegrationConfig(DeleteIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIntegrationConfigWithOptions(request, headers, runtime);
        }

        public async Task<DeleteIntegrationConfigResponse> DeleteIntegrationConfigAsync(DeleteIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        public DeleteIntegrationConfigResponse DeleteIntegrationConfigWithOptions(DeleteIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteIntegrationConfigResponse>(DoROARequest("DeleteIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/delete", "json", req, runtime));
        }

        public async Task<DeleteIntegrationConfigResponse> DeleteIntegrationConfigWithOptionsAsync(DeleteIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteIntegrationConfigResponse>(await DoROARequestAsync("DeleteIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/delete", "json", req, runtime));
        }

        public UpdateProblemMeasureResponse UpdateProblemMeasure(UpdateProblemMeasureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProblemMeasureWithOptions(request, headers, runtime);
        }

        public async Task<UpdateProblemMeasureResponse> UpdateProblemMeasureAsync(UpdateProblemMeasureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProblemMeasureWithOptionsAsync(request, headers, runtime);
        }

        public UpdateProblemMeasureResponse UpdateProblemMeasureWithOptions(UpdateProblemMeasureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStandard))
            {
                body["checkStandard"] = request.CheckStandard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUserId))
            {
                body["checkUserId"] = request.CheckUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectorId))
            {
                body["directorId"] = request.DirectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StalkerId))
            {
                body["stalkerId"] = request.StalkerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanFinishTime))
            {
                body["planFinishTime"] = request.PlanFinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeasureId))
            {
                body["measureId"] = request.MeasureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateProblemMeasureResponse>(DoROARequest("UpdateProblemMeasure", "2021-04-13", "HTTPS", "POST", "AK", "/problem/improvement/measure/update", "json", req, runtime));
        }

        public async Task<UpdateProblemMeasureResponse> UpdateProblemMeasureWithOptionsAsync(UpdateProblemMeasureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStandard))
            {
                body["checkStandard"] = request.CheckStandard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUserId))
            {
                body["checkUserId"] = request.CheckUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectorId))
            {
                body["directorId"] = request.DirectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StalkerId))
            {
                body["stalkerId"] = request.StalkerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanFinishTime))
            {
                body["planFinishTime"] = request.PlanFinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeasureId))
            {
                body["measureId"] = request.MeasureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateProblemMeasureResponse>(await DoROARequestAsync("UpdateProblemMeasure", "2021-04-13", "HTTPS", "POST", "AK", "/problem/improvement/measure/update", "json", req, runtime));
        }

        public ListAlertsResponse ListAlerts(ListAlertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAlertsWithOptions(request, headers, runtime);
        }

        public async Task<ListAlertsResponse> ListAlertsAsync(ListAlertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAlertsWithOptionsAsync(request, headers, runtime);
        }

        public ListAlertsResponse ListAlertsWithOptions(ListAlertsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertLevel))
            {
                body["alertLevel"] = request.AlertLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertName))
            {
                body["alertName"] = request.AlertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListAlertsResponse>(DoROARequest("ListAlerts", "2021-04-13", "HTTPS", "POST", "AK", "/alerts/list", "json", req, runtime));
        }

        public async Task<ListAlertsResponse> ListAlertsWithOptionsAsync(ListAlertsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertLevel))
            {
                body["alertLevel"] = request.AlertLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertName))
            {
                body["alertName"] = request.AlertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListAlertsResponse>(await DoROARequestAsync("ListAlerts", "2021-04-13", "HTTPS", "POST", "AK", "/alerts/list", "json", req, runtime));
        }

        public ListProblemSubtotalsResponse ListProblemSubtotals(ListProblemSubtotalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProblemSubtotalsWithOptions(request, headers, runtime);
        }

        public async Task<ListProblemSubtotalsResponse> ListProblemSubtotalsAsync(ListProblemSubtotalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProblemSubtotalsWithOptionsAsync(request, headers, runtime);
        }

        public ListProblemSubtotalsResponse ListProblemSubtotalsWithOptions(ListProblemSubtotalsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListProblemSubtotalsResponse>(DoROARequest("ListProblemSubtotals", "2021-04-13", "HTTPS", "POST", "AK", "/problem/list/subtotal", "json", req, runtime));
        }

        public async Task<ListProblemSubtotalsResponse> ListProblemSubtotalsWithOptionsAsync(ListProblemSubtotalsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListProblemSubtotalsResponse>(await DoROARequestAsync("ListProblemSubtotals", "2021-04-13", "HTTPS", "POST", "AK", "/problem/list/subtotal", "json", req, runtime));
        }

        public GetProblemPreviewResponse GetProblemPreview(GetProblemPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProblemPreviewWithOptions(request, headers, runtime);
        }

        public async Task<GetProblemPreviewResponse> GetProblemPreviewAsync(GetProblemPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProblemPreviewWithOptionsAsync(request, headers, runtime);
        }

        public GetProblemPreviewResponse GetProblemPreviewWithOptions(GetProblemPreviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevel))
            {
                body["problemLevel"] = request.ProblemLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectServiceIds))
            {
                body["effectServiceIds"] = request.EffectServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetProblemPreviewResponse>(DoROARequest("GetProblemPreview", "2021-04-13", "HTTPS", "POST", "AK", "/problem/preview", "json", req, runtime));
        }

        public async Task<GetProblemPreviewResponse> GetProblemPreviewWithOptionsAsync(GetProblemPreviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevel))
            {
                body["problemLevel"] = request.ProblemLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectServiceIds))
            {
                body["effectServiceIds"] = request.EffectServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetProblemPreviewResponse>(await DoROARequestAsync("GetProblemPreview", "2021-04-13", "HTTPS", "POST", "AK", "/problem/preview", "json", req, runtime));
        }

        public CreateRouteRuleResponse CreateRouteRule(CreateRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRouteRuleWithOptions(request, headers, runtime);
        }

        public async Task<CreateRouteRuleResponse> CreateRouteRuleAsync(CreateRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRouteRuleWithOptionsAsync(request, headers, runtime);
        }

        public CreateRouteRuleResponse CreateRouteRuleWithOptions(CreateRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["routeType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectId))
            {
                body["assignObjectId"] = request.AssignObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectType))
            {
                body["assignObjectType"] = request.AssignObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effection))
            {
                body["effection"] = request.Effection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindow))
            {
                body["timeWindow"] = request.TimeWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchCount))
            {
                body["matchCount"] = request.MatchCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindowUnit))
            {
                body["timeWindowUnit"] = request.TimeWindowUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteChildRules))
            {
                body["routeChildRules"] = request.RouteChildRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyChannels))
            {
                body["notifyChannels"] = request.NotifyChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateRouteRuleResponse>(DoROARequest("CreateRouteRule", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/save", "json", req, runtime));
        }

        public async Task<CreateRouteRuleResponse> CreateRouteRuleWithOptionsAsync(CreateRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["routeType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectId))
            {
                body["assignObjectId"] = request.AssignObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectType))
            {
                body["assignObjectType"] = request.AssignObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effection))
            {
                body["effection"] = request.Effection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindow))
            {
                body["timeWindow"] = request.TimeWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchCount))
            {
                body["matchCount"] = request.MatchCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindowUnit))
            {
                body["timeWindowUnit"] = request.TimeWindowUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteChildRules))
            {
                body["routeChildRules"] = request.RouteChildRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyChannels))
            {
                body["notifyChannels"] = request.NotifyChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateRouteRuleResponse>(await DoROARequestAsync("CreateRouteRule", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/save", "json", req, runtime));
        }

        public UpdateProblemTimelineResponse UpdateProblemTimeline(UpdateProblemTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProblemTimelineWithOptions(request, headers, runtime);
        }

        public async Task<UpdateProblemTimelineResponse> UpdateProblemTimelineAsync(UpdateProblemTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProblemTimelineWithOptionsAsync(request, headers, runtime);
        }

        public UpdateProblemTimelineResponse UpdateProblemTimelineWithOptions(UpdateProblemTimelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemTimelineId))
            {
                body["problemTimelineId"] = request.ProblemTimelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyNode))
            {
                body["keyNode"] = request.KeyNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                body["time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateProblemTimelineResponse>(DoROARequest("UpdateProblemTimeline", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/timeline/update", "json", req, runtime));
        }

        public async Task<UpdateProblemTimelineResponse> UpdateProblemTimelineWithOptionsAsync(UpdateProblemTimelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemTimelineId))
            {
                body["problemTimelineId"] = request.ProblemTimelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyNode))
            {
                body["keyNode"] = request.KeyNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                body["time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateProblemTimelineResponse>(await DoROARequestAsync("UpdateProblemTimeline", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/timeline/update", "json", req, runtime));
        }

        public UpdateRouteRuleResponse UpdateRouteRule(UpdateRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRouteRuleWithOptions(request, headers, runtime);
        }

        public async Task<UpdateRouteRuleResponse> UpdateRouteRuleAsync(UpdateRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRouteRuleWithOptionsAsync(request, headers, runtime);
        }

        public UpdateRouteRuleResponse UpdateRouteRuleWithOptions(UpdateRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["routeType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectId))
            {
                body["assignObjectId"] = request.AssignObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectType))
            {
                body["assignObjectType"] = request.AssignObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effection))
            {
                body["effection"] = request.Effection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindow))
            {
                body["timeWindow"] = request.TimeWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindowUnit))
            {
                body["timeWindowUnit"] = request.TimeWindowUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchCount))
            {
                body["matchCount"] = request.MatchCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteChildRules))
            {
                body["routeChildRules"] = request.RouteChildRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyChannels))
            {
                body["notifyChannels"] = request.NotifyChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateRouteRuleResponse>(DoROARequest("UpdateRouteRule", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/edit", "json", req, runtime));
        }

        public async Task<UpdateRouteRuleResponse> UpdateRouteRuleWithOptionsAsync(UpdateRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["routeType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectId))
            {
                body["assignObjectId"] = request.AssignObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignObjectType))
            {
                body["assignObjectType"] = request.AssignObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effection))
            {
                body["effection"] = request.Effection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindow))
            {
                body["timeWindow"] = request.TimeWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeWindowUnit))
            {
                body["timeWindowUnit"] = request.TimeWindowUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchCount))
            {
                body["matchCount"] = request.MatchCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteChildRules))
            {
                body["routeChildRules"] = request.RouteChildRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyChannels))
            {
                body["notifyChannels"] = request.NotifyChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateRouteRuleResponse>(await DoROARequestAsync("UpdateRouteRule", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/edit", "json", req, runtime));
        }

        public DisableRouteRuleResponse DisableRouteRule(DisableRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableRouteRuleWithOptions(request, headers, runtime);
        }

        public async Task<DisableRouteRuleResponse> DisableRouteRuleAsync(DisableRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableRouteRuleWithOptionsAsync(request, headers, runtime);
        }

        public DisableRouteRuleResponse DisableRouteRuleWithOptions(DisableRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DisableRouteRuleResponse>(DoROARequest("DisableRouteRule", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/disable", "json", req, runtime));
        }

        public async Task<DisableRouteRuleResponse> DisableRouteRuleWithOptionsAsync(DisableRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DisableRouteRuleResponse>(await DoROARequestAsync("DisableRouteRule", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/disable", "json", req, runtime));
        }

        public EnableSubscriptionResponse EnableSubscription(EnableSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableSubscriptionWithOptions(request, headers, runtime);
        }

        public async Task<EnableSubscriptionResponse> EnableSubscriptionAsync(EnableSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableSubscriptionWithOptionsAsync(request, headers, runtime);
        }

        public EnableSubscriptionResponse EnableSubscriptionWithOptions(EnableSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<EnableSubscriptionResponse>(DoROARequest("EnableSubscription", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/enable", "json", req, runtime));
        }

        public async Task<EnableSubscriptionResponse> EnableSubscriptionWithOptionsAsync(EnableSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<EnableSubscriptionResponse>(await DoROARequestAsync("EnableSubscription", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/enable", "json", req, runtime));
        }

        public UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSubscriptionWithOptions(request, headers, runtime);
        }

        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSubscriptionWithOptionsAsync(request, headers, runtime);
        }

        public UpdateSubscriptionResponse UpdateSubscriptionWithOptions(UpdateSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionTitle))
            {
                body["subscriptionTitle"] = request.SubscriptionTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectType))
            {
                body["notifyObjectType"] = request.NotifyObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredType))
            {
                body["expiredType"] = request.ExpiredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeObjectList))
            {
                body["scopeObjectList"] = request.ScopeObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectList))
            {
                body["notifyObjectList"] = request.NotifyObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStrategyList))
            {
                body["notifyStrategyList"] = request.NotifyStrategyList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(DoROARequest("UpdateSubscription", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/update", "json", req, runtime));
        }

        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionWithOptionsAsync(UpdateSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionTitle))
            {
                body["subscriptionTitle"] = request.SubscriptionTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectType))
            {
                body["notifyObjectType"] = request.NotifyObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredType))
            {
                body["expiredType"] = request.ExpiredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeObjectList))
            {
                body["scopeObjectList"] = request.ScopeObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectList))
            {
                body["notifyObjectList"] = request.NotifyObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStrategyList))
            {
                body["notifyStrategyList"] = request.NotifyStrategyList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(await DoROARequestAsync("UpdateSubscription", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/update", "json", req, runtime));
        }

        public GetIncidentStatisticsResponse GetIncidentStatistics(GetIncidentStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIncidentStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<GetIncidentStatisticsResponse> GetIncidentStatisticsAsync(GetIncidentStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIncidentStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public GetIncidentStatisticsResponse GetIncidentStatisticsWithOptions(GetIncidentStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetIncidentStatisticsResponse>(DoROARequest("GetIncidentStatistics", "2021-04-13", "HTTPS", "POST", "AK", "/incident/count", "json", req, runtime));
        }

        public async Task<GetIncidentStatisticsResponse> GetIncidentStatisticsWithOptionsAsync(GetIncidentStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetIncidentStatisticsResponse>(await DoROARequestAsync("GetIncidentStatistics", "2021-04-13", "HTTPS", "POST", "AK", "/incident/count", "json", req, runtime));
        }

        public ListSourceEventsResponse ListSourceEvents(ListSourceEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSourceEventsWithOptions(request, headers, runtime);
        }

        public async Task<ListSourceEventsResponse> ListSourceEventsAsync(ListSourceEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSourceEventsWithOptionsAsync(request, headers, runtime);
        }

        public ListSourceEventsResponse ListSourceEventsWithOptions(ListSourceEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRowKey))
            {
                body["startRowKey"] = request.StartRowKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopRowKey))
            {
                body["stopRowKey"] = request.StopRowKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListSourceEventsResponse>(DoROARequest("ListSourceEvents", "2021-04-13", "HTTPS", "POST", "AK", "/events/listOriginalEvent", "json", req, runtime));
        }

        public async Task<ListSourceEventsResponse> ListSourceEventsWithOptionsAsync(ListSourceEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRowKey))
            {
                body["startRowKey"] = request.StartRowKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopRowKey))
            {
                body["stopRowKey"] = request.StopRowKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListSourceEventsResponse>(await DoROARequestAsync("ListSourceEvents", "2021-04-13", "HTTPS", "POST", "AK", "/events/listOriginalEvent", "json", req, runtime));
        }

        public GenerateProblemPictureUploadSignResponse GenerateProblemPictureUploadSign(GenerateProblemPictureUploadSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateProblemPictureUploadSignWithOptions(request, headers, runtime);
        }

        public async Task<GenerateProblemPictureUploadSignResponse> GenerateProblemPictureUploadSignAsync(GenerateProblemPictureUploadSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateProblemPictureUploadSignWithOptionsAsync(request, headers, runtime);
        }

        public GenerateProblemPictureUploadSignResponse GenerateProblemPictureUploadSignWithOptions(GenerateProblemPictureUploadSignRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GenerateProblemPictureUploadSignResponse>(DoROARequest("GenerateProblemPictureUploadSign", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/oss/generatePostPolicy", "json", req, runtime));
        }

        public async Task<GenerateProblemPictureUploadSignResponse> GenerateProblemPictureUploadSignWithOptionsAsync(GenerateProblemPictureUploadSignRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GenerateProblemPictureUploadSignResponse>(await DoROARequestAsync("GenerateProblemPictureUploadSign", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/oss/generatePostPolicy", "json", req, runtime));
        }

        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserWithOptions(request, headers, runtime);
        }

        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserWithOptionsAsync(request, headers, runtime);
        }

        public GetUserResponse GetUserWithOptions(GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetUserResponse>(DoROARequest("GetUser", "2021-04-13", "HTTPS", "POST", "AK", "/user/getUser", "json", req, runtime));
        }

        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetUserResponse>(await DoROARequestAsync("GetUser", "2021-04-13", "HTTPS", "POST", "AK", "/user/getUser", "json", req, runtime));
        }

        public AddProblemServiceGroupResponse AddProblemServiceGroup(AddProblemServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddProblemServiceGroupWithOptions(request, headers, runtime);
        }

        public async Task<AddProblemServiceGroupResponse> AddProblemServiceGroupAsync(AddProblemServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddProblemServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        public AddProblemServiceGroupResponse AddProblemServiceGroupWithOptions(AddProblemServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddProblemServiceGroupResponse>(DoROARequest("AddProblemServiceGroup", "2021-04-13", "HTTPS", "POST", "AK", "/problem/addServiceGroup", "json", req, runtime));
        }

        public async Task<AddProblemServiceGroupResponse> AddProblemServiceGroupWithOptionsAsync(AddProblemServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddProblemServiceGroupResponse>(await DoROARequestAsync("AddProblemServiceGroup", "2021-04-13", "HTTPS", "POST", "AK", "/problem/addServiceGroup", "json", req, runtime));
        }

        public ReplayProblemResponse ReplayProblem(ReplayProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReplayProblemWithOptions(request, headers, runtime);
        }

        public async Task<ReplayProblemResponse> ReplayProblemAsync(ReplayProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReplayProblemWithOptionsAsync(request, headers, runtime);
        }

        public ReplayProblemResponse ReplayProblemWithOptions(ReplayProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplayDutyUserId))
            {
                body["replayDutyUserId"] = request.ReplayDutyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ReplayProblemResponse>(DoROARequest("ReplayProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/replay", "json", req, runtime));
        }

        public async Task<ReplayProblemResponse> ReplayProblemWithOptionsAsync(ReplayProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplayDutyUserId))
            {
                body["replayDutyUserId"] = request.ReplayDutyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ReplayProblemResponse>(await DoROARequestAsync("ReplayProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/replay", "json", req, runtime));
        }

        public GetProblemResponse GetProblem(GetProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProblemWithOptions(request, headers, runtime);
        }

        public async Task<GetProblemResponse> GetProblemAsync(GetProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProblemWithOptionsAsync(request, headers, runtime);
        }

        public GetProblemResponse GetProblemWithOptions(GetProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetProblemResponse>(DoROARequest("GetProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/detail", "json", req, runtime));
        }

        public async Task<GetProblemResponse> GetProblemWithOptionsAsync(GetProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetProblemResponse>(await DoROARequestAsync("GetProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/detail", "json", req, runtime));
        }

        public DeleteProblemResponse DeleteProblem(DeleteProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProblemWithOptions(request, headers, runtime);
        }

        public async Task<DeleteProblemResponse> DeleteProblemAsync(DeleteProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProblemWithOptionsAsync(request, headers, runtime);
        }

        public DeleteProblemResponse DeleteProblemWithOptions(DeleteProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteProblemResponse>(DoROARequest("DeleteProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/delete", "json", req, runtime));
        }

        public async Task<DeleteProblemResponse> DeleteProblemWithOptionsAsync(DeleteProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteProblemResponse>(await DoROARequestAsync("DeleteProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/delete", "json", req, runtime));
        }

        public CreateServiceGroupResponse CreateServiceGroup(CreateServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceGroupWithOptions(request, headers, runtime);
        }

        public async Task<CreateServiceGroupResponse> CreateServiceGroupAsync(CreateServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        public CreateServiceGroupResponse CreateServiceGroupWithOptions(CreateServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupName))
            {
                body["serviceGroupName"] = request.ServiceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWebhook))
            {
                body["enableWebhook"] = request.EnableWebhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["webhookType"] = request.WebhookType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupDescription))
            {
                body["serviceGroupDescription"] = request.ServiceGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookLink))
            {
                body["webhookLink"] = request.WebhookLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateServiceGroupResponse>(DoROARequest("CreateServiceGroup", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/insert", "json", req, runtime));
        }

        public async Task<CreateServiceGroupResponse> CreateServiceGroupWithOptionsAsync(CreateServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupName))
            {
                body["serviceGroupName"] = request.ServiceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWebhook))
            {
                body["enableWebhook"] = request.EnableWebhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["webhookType"] = request.WebhookType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupDescription))
            {
                body["serviceGroupDescription"] = request.ServiceGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookLink))
            {
                body["webhookLink"] = request.WebhookLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateServiceGroupResponse>(await DoROARequestAsync("CreateServiceGroup", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/insert", "json", req, runtime));
        }

        public DeliverIncidentResponse DeliverIncident(DeliverIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeliverIncidentWithOptions(request, headers, runtime);
        }

        public async Task<DeliverIncidentResponse> DeliverIncidentAsync(DeliverIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeliverIncidentWithOptionsAsync(request, headers, runtime);
        }

        public DeliverIncidentResponse DeliverIncidentWithOptions(DeliverIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignUserId))
            {
                body["assignUserId"] = request.AssignUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeliverIncidentResponse>(DoROARequest("DeliverIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/deliver", "json", req, runtime));
        }

        public async Task<DeliverIncidentResponse> DeliverIncidentWithOptionsAsync(DeliverIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignUserId))
            {
                body["assignUserId"] = request.AssignUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeliverIncidentResponse>(await DoROARequestAsync("DeliverIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/deliver", "json", req, runtime));
        }

        public DeleteIncidentResponse DeleteIncident(DeleteIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIncidentWithOptions(request, headers, runtime);
        }

        public async Task<DeleteIncidentResponse> DeleteIncidentAsync(DeleteIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIncidentWithOptionsAsync(request, headers, runtime);
        }

        public DeleteIncidentResponse DeleteIncidentWithOptions(DeleteIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteIncidentResponse>(DoROARequest("DeleteIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/delete", "json", req, runtime));
        }

        public async Task<DeleteIncidentResponse> DeleteIncidentWithOptionsAsync(DeleteIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteIncidentResponse>(await DoROARequestAsync("DeleteIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/delete", "json", req, runtime));
        }

        public ListServicesResponse ListServices(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServicesWithOptions(request, headers, runtime);
        }

        public async Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServicesWithOptionsAsync(request, headers, runtime);
        }

        public ListServicesResponse ListServicesWithOptions(ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListServicesResponse>(DoROARequest("ListServices", "2021-04-13", "HTTPS", "POST", "AK", "/services/list", "json", req, runtime));
        }

        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListServicesResponse>(await DoROARequestAsync("ListServices", "2021-04-13", "HTTPS", "POST", "AK", "/services/list", "json", req, runtime));
        }

        public GetSubscriptionResponse GetSubscription(GetSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSubscriptionWithOptions(request, headers, runtime);
        }

        public async Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSubscriptionWithOptionsAsync(request, headers, runtime);
        }

        public GetSubscriptionResponse GetSubscriptionWithOptions(GetSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetSubscriptionResponse>(DoROARequest("GetSubscription", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/detail", "json", req, runtime));
        }

        public async Task<GetSubscriptionResponse> GetSubscriptionWithOptionsAsync(GetSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetSubscriptionResponse>(await DoROARequestAsync("GetSubscription", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/detail", "json", req, runtime));
        }

        public CreateProblemTimelinesResponse CreateProblemTimelines(CreateProblemTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProblemTimelinesWithOptions(request, headers, runtime);
        }

        public async Task<CreateProblemTimelinesResponse> CreateProblemTimelinesAsync(CreateProblemTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProblemTimelinesWithOptionsAsync(request, headers, runtime);
        }

        public CreateProblemTimelinesResponse CreateProblemTimelinesWithOptions(CreateProblemTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimelineNodes))
            {
                body["timelineNodes"] = request.TimelineNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateProblemTimelinesResponse>(DoROARequest("CreateProblemTimelines", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/timeline/batchCreate", "json", req, runtime));
        }

        public async Task<CreateProblemTimelinesResponse> CreateProblemTimelinesWithOptionsAsync(CreateProblemTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimelineNodes))
            {
                body["timelineNodes"] = request.TimelineNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateProblemTimelinesResponse>(await DoROARequestAsync("CreateProblemTimelines", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/timeline/batchCreate", "json", req, runtime));
        }

        public CreateProblemTimelineResponse CreateProblemTimeline(CreateProblemTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProblemTimelineWithOptions(request, headers, runtime);
        }

        public async Task<CreateProblemTimelineResponse> CreateProblemTimelineAsync(CreateProblemTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProblemTimelineWithOptionsAsync(request, headers, runtime);
        }

        public CreateProblemTimelineResponse CreateProblemTimelineWithOptions(CreateProblemTimelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyNode))
            {
                body["keyNode"] = request.KeyNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                body["time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateProblemTimelineResponse>(DoROARequest("CreateProblemTimeline", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/timeline/create", "json", req, runtime));
        }

        public async Task<CreateProblemTimelineResponse> CreateProblemTimelineWithOptionsAsync(CreateProblemTimelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyNode))
            {
                body["keyNode"] = request.KeyNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                body["time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateProblemTimelineResponse>(await DoROARequestAsync("CreateProblemTimeline", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/timeline/create", "json", req, runtime));
        }

        public CancelProblemResponse CancelProblem(CancelProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelProblemWithOptions(request, headers, runtime);
        }

        public async Task<CancelProblemResponse> CancelProblemAsync(CancelProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelProblemWithOptionsAsync(request, headers, runtime);
        }

        public CancelProblemResponse CancelProblemWithOptions(CancelProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelReasonDescription))
            {
                body["cancelReasonDescription"] = request.CancelReasonDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelReason))
            {
                body["cancelReason"] = request.CancelReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CancelProblemResponse>(DoROARequest("CancelProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/cancel", "json", req, runtime));
        }

        public async Task<CancelProblemResponse> CancelProblemWithOptionsAsync(CancelProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelReasonDescription))
            {
                body["cancelReasonDescription"] = request.CancelReasonDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelReason))
            {
                body["cancelReason"] = request.CancelReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CancelProblemResponse>(await DoROARequestAsync("CancelProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/cancel", "json", req, runtime));
        }

        public UpdateServiceGroupResponse UpdateServiceGroup(UpdateServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceGroupWithOptions(request, headers, runtime);
        }

        public async Task<UpdateServiceGroupResponse> UpdateServiceGroupAsync(UpdateServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        public UpdateServiceGroupResponse UpdateServiceGroupWithOptions(UpdateServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWebhook))
            {
                body["enableWebhook"] = request.EnableWebhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["webhookType"] = request.WebhookType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookLink))
            {
                body["webhookLink"] = request.WebhookLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupName))
            {
                body["serviceGroupName"] = request.ServiceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupDescription))
            {
                body["serviceGroupDescription"] = request.ServiceGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateServiceGroupResponse>(DoROARequest("UpdateServiceGroup", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/modify", "json", req, runtime));
        }

        public async Task<UpdateServiceGroupResponse> UpdateServiceGroupWithOptionsAsync(UpdateServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWebhook))
            {
                body["enableWebhook"] = request.EnableWebhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["webhookType"] = request.WebhookType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookLink))
            {
                body["webhookLink"] = request.WebhookLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupName))
            {
                body["serviceGroupName"] = request.ServiceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupDescription))
            {
                body["serviceGroupDescription"] = request.ServiceGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateServiceGroupResponse>(await DoROARequestAsync("UpdateServiceGroup", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/modify", "json", req, runtime));
        }

        public UpdateIntegrationConfigResponse UpdateIntegrationConfig(UpdateIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIntegrationConfigWithOptions(request, headers, runtime);
        }

        public async Task<UpdateIntegrationConfigResponse> UpdateIntegrationConfigAsync(UpdateIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        public UpdateIntegrationConfigResponse UpdateIntegrationConfigWithOptions(UpdateIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateIntegrationConfigResponse>(DoROARequest("UpdateIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/update", "json", req, runtime));
        }

        public async Task<UpdateIntegrationConfigResponse> UpdateIntegrationConfigWithOptionsAsync(UpdateIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateIntegrationConfigResponse>(await DoROARequestAsync("UpdateIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/update", "json", req, runtime));
        }

        public ListIncidentSubtotalsResponse ListIncidentSubtotals(ListIncidentSubtotalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIncidentSubtotalsWithOptions(request, headers, runtime);
        }

        public async Task<ListIncidentSubtotalsResponse> ListIncidentSubtotalsAsync(ListIncidentSubtotalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIncidentSubtotalsWithOptionsAsync(request, headers, runtime);
        }

        public ListIncidentSubtotalsResponse ListIncidentSubtotalsWithOptions(ListIncidentSubtotalsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListIncidentSubtotalsResponse>(DoROARequest("ListIncidentSubtotals", "2021-04-13", "HTTPS", "POST", "AK", "/incident/list/subtotal", "json", req, runtime));
        }

        public async Task<ListIncidentSubtotalsResponse> ListIncidentSubtotalsWithOptionsAsync(ListIncidentSubtotalsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListIncidentSubtotalsResponse>(await DoROARequestAsync("ListIncidentSubtotals", "2021-04-13", "HTTPS", "POST", "AK", "/incident/list/subtotal", "json", req, runtime));
        }

        public DeleteProblemEffectionServiceResponse DeleteProblemEffectionService(DeleteProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProblemEffectionServiceWithOptions(request, headers, runtime);
        }

        public async Task<DeleteProblemEffectionServiceResponse> DeleteProblemEffectionServiceAsync(DeleteProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProblemEffectionServiceWithOptionsAsync(request, headers, runtime);
        }

        public DeleteProblemEffectionServiceResponse DeleteProblemEffectionServiceWithOptions(DeleteProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectionServiceId))
            {
                body["effectionServiceId"] = request.EffectionServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteProblemEffectionServiceResponse>(DoROARequest("DeleteProblemEffectionService", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/effectionService/delete", "json", req, runtime));
        }

        public async Task<DeleteProblemEffectionServiceResponse> DeleteProblemEffectionServiceWithOptionsAsync(DeleteProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectionServiceId))
            {
                body["effectionServiceId"] = request.EffectionServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteProblemEffectionServiceResponse>(await DoROARequestAsync("DeleteProblemEffectionService", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/effectionService/delete", "json", req, runtime));
        }

        public ListDictionariesResponse ListDictionaries(ListDictionariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDictionariesWithOptions(request, headers, runtime);
        }

        public async Task<ListDictionariesResponse> ListDictionariesAsync(ListDictionariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDictionariesWithOptionsAsync(request, headers, runtime);
        }

        public ListDictionariesResponse ListDictionariesWithOptions(ListDictionariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListDictionariesResponse>(DoROARequest("ListDictionaries", "2021-04-13", "HTTPS", "POST", "AK", "/dict/list", "json", req, runtime));
        }

        public async Task<ListDictionariesResponse> ListDictionariesWithOptionsAsync(ListDictionariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListDictionariesResponse>(await DoROARequestAsync("ListDictionaries", "2021-04-13", "HTTPS", "POST", "AK", "/dict/list", "json", req, runtime));
        }

        public ListIncidentsResponse ListIncidents(ListIncidentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIncidentsWithOptions(request, headers, runtime);
        }

        public async Task<ListIncidentsResponse> ListIncidentsAsync(ListIncidentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIncidentsWithOptionsAsync(request, headers, runtime);
        }

        public ListIncidentsResponse ListIncidentsWithOptions(ListIncidentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationServiceId))
            {
                body["relationServiceId"] = request.RelationServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentStatus))
            {
                body["incidentStatus"] = request.IncidentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Me))
            {
                body["me"] = request.Me;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListIncidentsResponse>(DoROARequest("ListIncidents", "2021-04-13", "HTTPS", "POST", "AK", "/incident/list", "json", req, runtime));
        }

        public async Task<ListIncidentsResponse> ListIncidentsWithOptionsAsync(ListIncidentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationServiceId))
            {
                body["relationServiceId"] = request.RelationServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentStatus))
            {
                body["incidentStatus"] = request.IncidentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Me))
            {
                body["me"] = request.Me;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListIncidentsResponse>(await DoROARequestAsync("ListIncidents", "2021-04-13", "HTTPS", "POST", "AK", "/incident/list", "json", req, runtime));
        }

        public CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceWithOptions(request, headers, runtime);
        }

        public async Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceWithOptionsAsync(request, headers, runtime);
        }

        public CreateServiceResponse CreateServiceWithOptions(CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                body["serviceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateServiceResponse>(DoROARequest("CreateService", "2021-04-13", "HTTPS", "POST", "AK", "/services/save", "json", req, runtime));
        }

        public async Task<CreateServiceResponse> CreateServiceWithOptionsAsync(CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                body["serviceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateServiceResponse>(await DoROARequestAsync("CreateService", "2021-04-13", "HTTPS", "POST", "AK", "/services/save", "json", req, runtime));
        }

        public ConfirmIntegrationConfigResponse ConfirmIntegrationConfig(ConfirmIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConfirmIntegrationConfigWithOptions(request, headers, runtime);
        }

        public async Task<ConfirmIntegrationConfigResponse> ConfirmIntegrationConfigAsync(ConfirmIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConfirmIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        public ConfirmIntegrationConfigResponse ConfirmIntegrationConfigWithOptions(ConfirmIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ConfirmIntegrationConfigResponse>(DoROARequest("ConfirmIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/confirm", "json", req, runtime));
        }

        public async Task<ConfirmIntegrationConfigResponse> ConfirmIntegrationConfigWithOptionsAsync(ConfirmIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ConfirmIntegrationConfigResponse>(await DoROARequestAsync("ConfirmIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/confirm", "json", req, runtime));
        }

        public UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceWithOptions(request, headers, runtime);
        }

        public async Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceWithOptionsAsync(request, headers, runtime);
        }

        public UpdateServiceResponse UpdateServiceWithOptions(UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                body["serviceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateServiceResponse>(DoROARequest("UpdateService", "2021-04-13", "HTTPS", "POST", "AK", "/services/update", "json", req, runtime));
        }

        public async Task<UpdateServiceResponse> UpdateServiceWithOptionsAsync(UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                body["serviceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateServiceResponse>(await DoROARequestAsync("UpdateService", "2021-04-13", "HTTPS", "POST", "AK", "/services/update", "json", req, runtime));
        }

        public ListIncidentDetailTimelinesResponse ListIncidentDetailTimelines(ListIncidentDetailTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIncidentDetailTimelinesWithOptions(request, headers, runtime);
        }

        public async Task<ListIncidentDetailTimelinesResponse> ListIncidentDetailTimelinesAsync(ListIncidentDetailTimelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIncidentDetailTimelinesWithOptionsAsync(request, headers, runtime);
        }

        public ListIncidentDetailTimelinesResponse ListIncidentDetailTimelinesWithOptions(ListIncidentDetailTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListIncidentDetailTimelinesResponse>(DoROARequest("ListIncidentDetailTimelines", "2021-04-13", "HTTPS", "POST", "AK", "/incident/detail/timeline", "json", req, runtime));
        }

        public async Task<ListIncidentDetailTimelinesResponse> ListIncidentDetailTimelinesWithOptionsAsync(ListIncidentDetailTimelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListIncidentDetailTimelinesResponse>(await DoROARequestAsync("ListIncidentDetailTimelines", "2021-04-13", "HTTPS", "POST", "AK", "/incident/detail/timeline", "json", req, runtime));
        }

        public EnableServiceGroupWebhookResponse EnableServiceGroupWebhook(EnableServiceGroupWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableServiceGroupWebhookWithOptions(request, headers, runtime);
        }

        public async Task<EnableServiceGroupWebhookResponse> EnableServiceGroupWebhookAsync(EnableServiceGroupWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableServiceGroupWebhookWithOptionsAsync(request, headers, runtime);
        }

        public EnableServiceGroupWebhookResponse EnableServiceGroupWebhookWithOptions(EnableServiceGroupWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<EnableServiceGroupWebhookResponse>(DoROARequest("EnableServiceGroupWebhook", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/enableWebhook", "json", req, runtime));
        }

        public async Task<EnableServiceGroupWebhookResponse> EnableServiceGroupWebhookWithOptionsAsync(EnableServiceGroupWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<EnableServiceGroupWebhookResponse>(await DoROARequestAsync("EnableServiceGroupWebhook", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/enableWebhook", "json", req, runtime));
        }

        public DeleteSubscriptionResponse DeleteSubscription(DeleteSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSubscriptionWithOptions(request, headers, runtime);
        }

        public async Task<DeleteSubscriptionResponse> DeleteSubscriptionAsync(DeleteSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSubscriptionWithOptionsAsync(request, headers, runtime);
        }

        public DeleteSubscriptionResponse DeleteSubscriptionWithOptions(DeleteSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteSubscriptionResponse>(DoROARequest("DeleteSubscription", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/delete", "json", req, runtime));
        }

        public async Task<DeleteSubscriptionResponse> DeleteSubscriptionWithOptionsAsync(DeleteSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionId))
            {
                body["subscriptionId"] = request.SubscriptionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteSubscriptionResponse>(await DoROARequestAsync("DeleteSubscription", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/delete", "json", req, runtime));
        }

        public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSubscriptionsWithOptions(request, headers, runtime);
        }

        public async Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSubscriptionsWithOptionsAsync(request, headers, runtime);
        }

        public ListSubscriptionsResponse ListSubscriptionsWithOptions(ListSubscriptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionTitle))
            {
                body["subscriptionTitle"] = request.SubscriptionTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeObject))
            {
                body["scopeObject"] = request.ScopeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectType))
            {
                body["notifyObjectType"] = request.NotifyObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObject))
            {
                body["notifyObject"] = request.NotifyObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListSubscriptionsResponse>(DoROARequest("ListSubscriptions", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/list", "json", req, runtime));
        }

        public async Task<ListSubscriptionsResponse> ListSubscriptionsWithOptionsAsync(ListSubscriptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionTitle))
            {
                body["subscriptionTitle"] = request.SubscriptionTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeObject))
            {
                body["scopeObject"] = request.ScopeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObjectType))
            {
                body["notifyObjectType"] = request.NotifyObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyObject))
            {
                body["notifyObject"] = request.NotifyObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListSubscriptionsResponse>(await DoROARequestAsync("ListSubscriptions", "2021-04-13", "HTTPS", "POST", "AK", "/notify/subscription/list", "json", req, runtime));
        }

        public RespondIncidentResponse RespondIncident(RespondIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RespondIncidentWithOptions(request, headers, runtime);
        }

        public async Task<RespondIncidentResponse> RespondIncidentAsync(RespondIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RespondIncidentWithOptionsAsync(request, headers, runtime);
        }

        public RespondIncidentResponse RespondIncidentWithOptions(RespondIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentIds))
            {
                body["incidentIds"] = request.IncidentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RespondIncidentResponse>(DoROARequest("RespondIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/response", "json", req, runtime));
        }

        public async Task<RespondIncidentResponse> RespondIncidentWithOptionsAsync(RespondIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentIds))
            {
                body["incidentIds"] = request.IncidentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RespondIncidentResponse>(await DoROARequestAsync("RespondIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/response", "json", req, runtime));
        }

        public ListProblemTimeLinesResponse ListProblemTimeLines(ListProblemTimeLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProblemTimeLinesWithOptions(request, headers, runtime);
        }

        public async Task<ListProblemTimeLinesResponse> ListProblemTimeLinesAsync(ListProblemTimeLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProblemTimeLinesWithOptionsAsync(request, headers, runtime);
        }

        public ListProblemTimeLinesResponse ListProblemTimeLinesWithOptions(ListProblemTimeLinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListProblemTimeLinesResponse>(DoROARequest("ListProblemTimeLines", "2021-04-13", "HTTPS", "POST", "AK", "/problem/detail/timeLines", "json", req, runtime));
        }

        public async Task<ListProblemTimeLinesResponse> ListProblemTimeLinesWithOptionsAsync(ListProblemTimeLinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListProblemTimeLinesResponse>(await DoROARequestAsync("ListProblemTimeLines", "2021-04-13", "HTTPS", "POST", "AK", "/problem/detail/timeLines", "json", req, runtime));
        }

        public DeleteProblemMeasureResponse DeleteProblemMeasure(DeleteProblemMeasureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProblemMeasureWithOptions(request, headers, runtime);
        }

        public async Task<DeleteProblemMeasureResponse> DeleteProblemMeasureAsync(DeleteProblemMeasureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProblemMeasureWithOptionsAsync(request, headers, runtime);
        }

        public DeleteProblemMeasureResponse DeleteProblemMeasureWithOptions(DeleteProblemMeasureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeasureId))
            {
                body["measureId"] = request.MeasureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteProblemMeasureResponse>(DoROARequest("DeleteProblemMeasure", "2021-04-13", "HTTPS", "POST", "AK", "/problem/improvement/measure/delete", "json", req, runtime));
        }

        public async Task<DeleteProblemMeasureResponse> DeleteProblemMeasureWithOptionsAsync(DeleteProblemMeasureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeasureId))
            {
                body["measureId"] = request.MeasureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteProblemMeasureResponse>(await DoROARequestAsync("DeleteProblemMeasure", "2021-04-13", "HTTPS", "POST", "AK", "/problem/improvement/measure/delete", "json", req, runtime));
        }

        public DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceWithOptions(request, headers, runtime);
        }

        public async Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceWithOptionsAsync(request, headers, runtime);
        }

        public DeleteServiceResponse DeleteServiceWithOptions(DeleteServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteServiceResponse>(DoROARequest("DeleteService", "2021-04-13", "HTTPS", "POST", "AK", "/services/delete", "json", req, runtime));
        }

        public async Task<DeleteServiceResponse> DeleteServiceWithOptionsAsync(DeleteServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteServiceResponse>(await DoROARequestAsync("DeleteService", "2021-04-13", "HTTPS", "POST", "AK", "/services/delete", "json", req, runtime));
        }

        public RecoverProblemResponse RecoverProblem(RecoverProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecoverProblemWithOptions(request, headers, runtime);
        }

        public async Task<RecoverProblemResponse> RecoverProblemAsync(RecoverProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecoverProblemWithOptionsAsync(request, headers, runtime);
        }

        public RecoverProblemResponse RecoverProblemWithOptions(RecoverProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryTime))
            {
                body["recoveryTime"] = request.RecoveryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RecoverProblemResponse>(DoROARequest("RecoverProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/recovery", "json", req, runtime));
        }

        public async Task<RecoverProblemResponse> RecoverProblemWithOptionsAsync(RecoverProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryTime))
            {
                body["recoveryTime"] = request.RecoveryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RecoverProblemResponse>(await DoROARequestAsync("RecoverProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/recovery", "json", req, runtime));
        }

        public ListIntegrationConfigsResponse ListIntegrationConfigs(ListIntegrationConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIntegrationConfigsWithOptions(request, headers, runtime);
        }

        public async Task<ListIntegrationConfigsResponse> ListIntegrationConfigsAsync(ListIntegrationConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIntegrationConfigsWithOptionsAsync(request, headers, runtime);
        }

        public ListIntegrationConfigsResponse ListIntegrationConfigsWithOptions(ListIntegrationConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceName))
            {
                body["monitorSourceName"] = request.MonitorSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListIntegrationConfigsResponse>(DoROARequest("ListIntegrationConfigs", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/list", "json", req, runtime));
        }

        public async Task<ListIntegrationConfigsResponse> ListIntegrationConfigsWithOptionsAsync(ListIntegrationConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceName))
            {
                body["monitorSourceName"] = request.MonitorSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListIntegrationConfigsResponse>(await DoROARequestAsync("ListIntegrationConfigs", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/list", "json", req, runtime));
        }

        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUserWithOptions(request, headers, runtime);
        }

        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUserWithOptionsAsync(request, headers, runtime);
        }

        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteUserResponse>(DoROARequest("DeleteUser", "2021-04-13", "HTTPS", "POST", "AK", "/user/delete", "json", req, runtime));
        }

        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteUserResponse>(await DoROARequestAsync("DeleteUser", "2021-04-13", "HTTPS", "POST", "AK", "/user/delete", "json", req, runtime));
        }

        public UpdateProblemEffectionServiceResponse UpdateProblemEffectionService(UpdateProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProblemEffectionServiceWithOptions(request, headers, runtime);
        }

        public async Task<UpdateProblemEffectionServiceResponse> UpdateProblemEffectionServiceAsync(UpdateProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProblemEffectionServiceWithOptionsAsync(request, headers, runtime);
        }

        public UpdateProblemEffectionServiceResponse UpdateProblemEffectionServiceWithOptions(UpdateProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicUrl))
            {
                body["picUrl"] = request.PicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectionServiceId))
            {
                body["effectionServiceId"] = request.EffectionServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateProblemEffectionServiceResponse>(DoROARequest("UpdateProblemEffectionService", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/effectionService/update", "json", req, runtime));
        }

        public async Task<UpdateProblemEffectionServiceResponse> UpdateProblemEffectionServiceWithOptionsAsync(UpdateProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicUrl))
            {
                body["picUrl"] = request.PicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectionServiceId))
            {
                body["effectionServiceId"] = request.EffectionServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateProblemEffectionServiceResponse>(await DoROARequestAsync("UpdateProblemEffectionService", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/effectionService/update", "json", req, runtime));
        }

        public DeleteServiceGroupResponse DeleteServiceGroup(DeleteServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceGroupWithOptions(request, headers, runtime);
        }

        public async Task<DeleteServiceGroupResponse> DeleteServiceGroupAsync(DeleteServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        public DeleteServiceGroupResponse DeleteServiceGroupWithOptions(DeleteServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteServiceGroupResponse>(DoROARequest("DeleteServiceGroup", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/delete", "json", req, runtime));
        }

        public async Task<DeleteServiceGroupResponse> DeleteServiceGroupWithOptionsAsync(DeleteServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteServiceGroupResponse>(await DoROARequestAsync("DeleteServiceGroup", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/delete", "json", req, runtime));
        }

        public DisableServiceGroupWebhookResponse DisableServiceGroupWebhook(DisableServiceGroupWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableServiceGroupWebhookWithOptions(request, headers, runtime);
        }

        public async Task<DisableServiceGroupWebhookResponse> DisableServiceGroupWebhookAsync(DisableServiceGroupWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableServiceGroupWebhookWithOptionsAsync(request, headers, runtime);
        }

        public DisableServiceGroupWebhookResponse DisableServiceGroupWebhookWithOptions(DisableServiceGroupWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DisableServiceGroupWebhookResponse>(DoROARequest("DisableServiceGroupWebhook", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/disableWebhook", "json", req, runtime));
        }

        public async Task<DisableServiceGroupWebhookResponse> DisableServiceGroupWebhookWithOptionsAsync(DisableServiceGroupWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DisableServiceGroupWebhookResponse>(await DoROARequestAsync("DisableServiceGroupWebhook", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/disableWebhook", "json", req, runtime));
        }

        public RemoveProblemServiceGroupResponse RemoveProblemServiceGroup(RemoveProblemServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveProblemServiceGroupWithOptions(request, headers, runtime);
        }

        public async Task<RemoveProblemServiceGroupResponse> RemoveProblemServiceGroupAsync(RemoveProblemServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveProblemServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        public RemoveProblemServiceGroupResponse RemoveProblemServiceGroupWithOptions(RemoveProblemServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RemoveProblemServiceGroupResponse>(DoROARequest("RemoveProblemServiceGroup", "2021-04-13", "HTTPS", "POST", "AK", "/problem/removeServiceGroup", "json", req, runtime));
        }

        public async Task<RemoveProblemServiceGroupResponse> RemoveProblemServiceGroupWithOptionsAsync(RemoveProblemServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RemoveProblemServiceGroupResponse>(await DoROARequestAsync("RemoveProblemServiceGroup", "2021-04-13", "HTTPS", "POST", "AK", "/problem/removeServiceGroup", "json", req, runtime));
        }

        public GetProblemEffectionServiceResponse GetProblemEffectionService(GetProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProblemEffectionServiceWithOptions(request, headers, runtime);
        }

        public async Task<GetProblemEffectionServiceResponse> GetProblemEffectionServiceAsync(GetProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProblemEffectionServiceWithOptionsAsync(request, headers, runtime);
        }

        public GetProblemEffectionServiceResponse GetProblemEffectionServiceWithOptions(GetProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectionServiceId))
            {
                body["effectionServiceId"] = request.EffectionServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetProblemEffectionServiceResponse>(DoROARequest("GetProblemEffectionService", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/effectionService/detail", "json", req, runtime));
        }

        public async Task<GetProblemEffectionServiceResponse> GetProblemEffectionServiceWithOptionsAsync(GetProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectionServiceId))
            {
                body["effectionServiceId"] = request.EffectionServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetProblemEffectionServiceResponse>(await DoROARequestAsync("GetProblemEffectionService", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/effectionService/detail", "json", req, runtime));
        }

        public ListMonitorSourcesResponse ListMonitorSources(ListMonitorSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMonitorSourcesWithOptions(request, headers, runtime);
        }

        public async Task<ListMonitorSourcesResponse> ListMonitorSourcesAsync(ListMonitorSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMonitorSourcesWithOptionsAsync(request, headers, runtime);
        }

        public ListMonitorSourcesResponse ListMonitorSourcesWithOptions(ListMonitorSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListMonitorSourcesResponse>(DoROARequest("ListMonitorSources", "2021-04-13", "HTTPS", "POST", "AK", "/monitorSource/list", "json", req, runtime));
        }

        public async Task<ListMonitorSourcesResponse> ListMonitorSourcesWithOptionsAsync(ListMonitorSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListMonitorSourcesResponse>(await DoROARequestAsync("ListMonitorSources", "2021-04-13", "HTTPS", "POST", "AK", "/monitorSource/list", "json", req, runtime));
        }

        public GetIncidentResponse GetIncident(GetIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIncidentWithOptions(request, headers, runtime);
        }

        public async Task<GetIncidentResponse> GetIncidentAsync(GetIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIncidentWithOptionsAsync(request, headers, runtime);
        }

        public GetIncidentResponse GetIncidentWithOptions(GetIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetIncidentResponse>(DoROARequest("GetIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/detail", "json", req, runtime));
        }

        public async Task<GetIncidentResponse> GetIncidentWithOptionsAsync(GetIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetIncidentResponse>(await DoROARequestAsync("GetIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/detail", "json", req, runtime));
        }

        public ListProblemsResponse ListProblems(ListProblemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProblemsWithOptions(request, headers, runtime);
        }

        public async Task<ListProblemsResponse> ListProblemsAsync(ListProblemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProblemsWithOptionsAsync(request, headers, runtime);
        }

        public ListProblemsResponse ListProblemsWithOptions(ListProblemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemStatus))
            {
                body["problemStatus"] = request.ProblemStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevel))
            {
                body["problemLevel"] = request.ProblemLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AffectServiceId))
            {
                body["affectServiceId"] = request.AffectServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainHandlerId))
            {
                body["mainHandlerId"] = request.MainHandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeaterId))
            {
                body["repeaterId"] = request.RepeaterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryStartTime))
            {
                body["discoveryStartTime"] = request.DiscoveryStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryEndTime))
            {
                body["discoveryEndTime"] = request.DiscoveryEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreEndTime))
            {
                body["restoreEndTime"] = request.RestoreEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreStartTime))
            {
                body["restoreStartTime"] = request.RestoreStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListProblemsResponse>(DoROARequest("ListProblems", "2021-04-13", "HTTPS", "POST", "AK", "/problem/listProblems", "json", req, runtime));
        }

        public async Task<ListProblemsResponse> ListProblemsWithOptionsAsync(ListProblemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemStatus))
            {
                body["problemStatus"] = request.ProblemStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevel))
            {
                body["problemLevel"] = request.ProblemLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AffectServiceId))
            {
                body["affectServiceId"] = request.AffectServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupId))
            {
                body["serviceGroupId"] = request.ServiceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainHandlerId))
            {
                body["mainHandlerId"] = request.MainHandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeaterId))
            {
                body["repeaterId"] = request.RepeaterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryStartTime))
            {
                body["discoveryStartTime"] = request.DiscoveryStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryEndTime))
            {
                body["discoveryEndTime"] = request.DiscoveryEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreEndTime))
            {
                body["restoreEndTime"] = request.RestoreEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreStartTime))
            {
                body["restoreStartTime"] = request.RestoreStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListProblemsResponse>(await DoROARequestAsync("ListProblems", "2021-04-13", "HTTPS", "POST", "AK", "/problem/listProblems", "json", req, runtime));
        }

        public GenerateProblemPictureLinkResponse GenerateProblemPictureLink(GenerateProblemPictureLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateProblemPictureLinkWithOptions(request, headers, runtime);
        }

        public async Task<GenerateProblemPictureLinkResponse> GenerateProblemPictureLinkAsync(GenerateProblemPictureLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateProblemPictureLinkWithOptionsAsync(request, headers, runtime);
        }

        public GenerateProblemPictureLinkResponse GenerateProblemPictureLinkWithOptions(GenerateProblemPictureLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GenerateProblemPictureLinkResponse>(DoROARequest("GenerateProblemPictureLink", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/oss/getPresignedLink", "json", req, runtime));
        }

        public async Task<GenerateProblemPictureLinkResponse> GenerateProblemPictureLinkWithOptionsAsync(GenerateProblemPictureLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GenerateProblemPictureLinkResponse>(await DoROARequestAsync("GenerateProblemPictureLink", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/oss/getPresignedLink", "json", req, runtime));
        }

        public GetIntegrationConfigResponse GetIntegrationConfig(GetIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIntegrationConfigWithOptions(request, headers, runtime);
        }

        public async Task<GetIntegrationConfigResponse> GetIntegrationConfigAsync(GetIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        public GetIntegrationConfigResponse GetIntegrationConfigWithOptions(GetIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetIntegrationConfigResponse>(DoROARequest("GetIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/detail", "json", req, runtime));
        }

        public async Task<GetIntegrationConfigResponse> GetIntegrationConfigWithOptionsAsync(GetIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetIntegrationConfigResponse>(await DoROARequestAsync("GetIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/detail", "json", req, runtime));
        }

        public ListConfigsResponse ListConfigs(ListConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConfigsWithOptions(request, headers, runtime);
        }

        public async Task<ListConfigsResponse> ListConfigsAsync(ListConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConfigsWithOptionsAsync(request, headers, runtime);
        }

        public ListConfigsResponse ListConfigsWithOptions(ListConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListConfigsResponse>(DoROARequest("ListConfigs", "2021-04-13", "HTTPS", "POST", "AK", "/config/all", "json", req, runtime));
        }

        public async Task<ListConfigsResponse> ListConfigsWithOptionsAsync(ListConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListConfigsResponse>(await DoROARequestAsync("ListConfigs", "2021-04-13", "HTTPS", "POST", "AK", "/config/all", "json", req, runtime));
        }

        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateUserWithOptions(request, headers, runtime);
        }

        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateUserWithOptionsAsync(request, headers, runtime);
        }

        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamId))
            {
                body["ramId"] = request.RamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateUserResponse>(DoROARequest("CreateUser", "2021-04-13", "HTTPS", "POST", "AK", "/user/create", "json", req, runtime));
        }

        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamId))
            {
                body["ramId"] = request.RamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateUserResponse>(await DoROARequestAsync("CreateUser", "2021-04-13", "HTTPS", "POST", "AK", "/user/create", "json", req, runtime));
        }

        public ListUserSerivceGroupsResponse ListUserSerivceGroups(ListUserSerivceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserSerivceGroupsWithOptions(request, headers, runtime);
        }

        public async Task<ListUserSerivceGroupsResponse> ListUserSerivceGroupsAsync(ListUserSerivceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserSerivceGroupsWithOptionsAsync(request, headers, runtime);
        }

        public ListUserSerivceGroupsResponse ListUserSerivceGroupsWithOptions(ListUserSerivceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListUserSerivceGroupsResponse>(DoROARequest("ListUserSerivceGroups", "2021-04-13", "HTTPS", "POST", "AK", "/user/preview/detail", "json", req, runtime));
        }

        public async Task<ListUserSerivceGroupsResponse> ListUserSerivceGroupsWithOptionsAsync(ListUserSerivceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListUserSerivceGroupsResponse>(await DoROARequestAsync("ListUserSerivceGroups", "2021-04-13", "HTTPS", "POST", "AK", "/user/preview/detail", "json", req, runtime));
        }

        public RevokeProblemRecoveryResponse RevokeProblemRecovery(RevokeProblemRecoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RevokeProblemRecoveryWithOptions(request, headers, runtime);
        }

        public async Task<RevokeProblemRecoveryResponse> RevokeProblemRecoveryAsync(RevokeProblemRecoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RevokeProblemRecoveryWithOptionsAsync(request, headers, runtime);
        }

        public RevokeProblemRecoveryResponse RevokeProblemRecoveryWithOptions(RevokeProblemRecoveryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RevokeProblemRecoveryResponse>(DoROARequest("RevokeProblemRecovery", "2021-04-13", "HTTPS", "POST", "AK", "/problem/revoke", "json", req, runtime));
        }

        public async Task<RevokeProblemRecoveryResponse> RevokeProblemRecoveryWithOptionsAsync(RevokeProblemRecoveryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RevokeProblemRecoveryResponse>(await DoROARequestAsync("RevokeProblemRecovery", "2021-04-13", "HTTPS", "POST", "AK", "/problem/revoke", "json", req, runtime));
        }

        public EnableIntegrationConfigResponse EnableIntegrationConfig(EnableIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableIntegrationConfigWithOptions(request, headers, runtime);
        }

        public async Task<EnableIntegrationConfigResponse> EnableIntegrationConfigAsync(EnableIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        public EnableIntegrationConfigResponse EnableIntegrationConfigWithOptions(EnableIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<EnableIntegrationConfigResponse>(DoROARequest("EnableIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/enable", "json", req, runtime));
        }

        public async Task<EnableIntegrationConfigResponse> EnableIntegrationConfigWithOptionsAsync(EnableIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<EnableIntegrationConfigResponse>(await DoROARequestAsync("EnableIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/enable", "json", req, runtime));
        }

        public RefreshIntegrationConfigKeyResponse RefreshIntegrationConfigKey(RefreshIntegrationConfigKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RefreshIntegrationConfigKeyWithOptions(request, headers, runtime);
        }

        public async Task<RefreshIntegrationConfigKeyResponse> RefreshIntegrationConfigKeyAsync(RefreshIntegrationConfigKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RefreshIntegrationConfigKeyWithOptionsAsync(request, headers, runtime);
        }

        public RefreshIntegrationConfigKeyResponse RefreshIntegrationConfigKeyWithOptions(RefreshIntegrationConfigKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RefreshIntegrationConfigKeyResponse>(DoROARequest("RefreshIntegrationConfigKey", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/refreshKey", "json", req, runtime));
        }

        public async Task<RefreshIntegrationConfigKeyResponse> RefreshIntegrationConfigKeyWithOptionsAsync(RefreshIntegrationConfigKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RefreshIntegrationConfigKeyResponse>(await DoROARequestAsync("RefreshIntegrationConfigKey", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/refreshKey", "json", req, runtime));
        }

        public CreateProblemSubtotalResponse CreateProblemSubtotal(CreateProblemSubtotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProblemSubtotalWithOptions(request, headers, runtime);
        }

        public async Task<CreateProblemSubtotalResponse> CreateProblemSubtotalAsync(CreateProblemSubtotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProblemSubtotalWithOptionsAsync(request, headers, runtime);
        }

        public CreateProblemSubtotalResponse CreateProblemSubtotalWithOptions(CreateProblemSubtotalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateProblemSubtotalResponse>(DoROARequest("CreateProblemSubtotal", "2021-04-13", "HTTPS", "POST", "AK", "/problem/save/subtotal", "json", req, runtime));
        }

        public async Task<CreateProblemSubtotalResponse> CreateProblemSubtotalWithOptionsAsync(CreateProblemSubtotalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateProblemSubtotalResponse>(await DoROARequestAsync("CreateProblemSubtotal", "2021-04-13", "HTTPS", "POST", "AK", "/problem/save/subtotal", "json", req, runtime));
        }

        public CreateProblemResponse CreateProblem(CreateProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProblemWithOptions(request, headers, runtime);
        }

        public async Task<CreateProblemResponse> CreateProblemAsync(CreateProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProblemWithOptionsAsync(request, headers, runtime);
        }

        public CreateProblemResponse CreateProblemWithOptions(CreateProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemName))
            {
                body["problemName"] = request.ProblemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemStatus))
            {
                body["problemStatus"] = request.ProblemStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevel))
            {
                body["problemLevel"] = request.ProblemLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressSummary))
            {
                body["progressSummary"] = request.ProgressSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainHandlerId))
            {
                body["mainHandlerId"] = request.MainHandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreliminaryReason))
            {
                body["preliminaryReason"] = request.PreliminaryReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoverTime))
            {
                body["discoverTime"] = request.DiscoverTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryTime))
            {
                body["recoveryTime"] = request.RecoveryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AffectServiceIds))
            {
                body["affectServiceIds"] = request.AffectServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateProblemResponse>(DoROARequest("CreateProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/upgrade", "json", req, runtime));
        }

        public async Task<CreateProblemResponse> CreateProblemWithOptionsAsync(CreateProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemName))
            {
                body["problemName"] = request.ProblemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemStatus))
            {
                body["problemStatus"] = request.ProblemStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemLevel))
            {
                body["problemLevel"] = request.ProblemLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressSummary))
            {
                body["progressSummary"] = request.ProgressSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainHandlerId))
            {
                body["mainHandlerId"] = request.MainHandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreliminaryReason))
            {
                body["preliminaryReason"] = request.PreliminaryReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoverTime))
            {
                body["discoverTime"] = request.DiscoverTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryTime))
            {
                body["recoveryTime"] = request.RecoveryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AffectServiceIds))
            {
                body["affectServiceIds"] = request.AffectServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemNotifyType))
            {
                body["problemNotifyType"] = request.ProblemNotifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateProblemResponse>(await DoROARequestAsync("CreateProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/upgrade", "json", req, runtime));
        }

        public GetProblemImprovementResponse GetProblemImprovement(GetProblemImprovementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProblemImprovementWithOptions(request, headers, runtime);
        }

        public async Task<GetProblemImprovementResponse> GetProblemImprovementAsync(GetProblemImprovementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProblemImprovementWithOptionsAsync(request, headers, runtime);
        }

        public GetProblemImprovementResponse GetProblemImprovementWithOptions(GetProblemImprovementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetProblemImprovementResponse>(DoROARequest("GetProblemImprovement", "2021-04-13", "HTTPS", "POST", "AK", "/problem/improvement/detail", "json", req, runtime));
        }

        public async Task<GetProblemImprovementResponse> GetProblemImprovementWithOptionsAsync(GetProblemImprovementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetProblemImprovementResponse>(await DoROARequestAsync("GetProblemImprovement", "2021-04-13", "HTTPS", "POST", "AK", "/problem/improvement/detail", "json", req, runtime));
        }

        public CreateIncidentSubtotalResponse CreateIncidentSubtotal(CreateIncidentSubtotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIncidentSubtotalWithOptions(request, headers, runtime);
        }

        public async Task<CreateIncidentSubtotalResponse> CreateIncidentSubtotalAsync(CreateIncidentSubtotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIncidentSubtotalWithOptionsAsync(request, headers, runtime);
        }

        public CreateIncidentSubtotalResponse CreateIncidentSubtotalWithOptions(CreateIncidentSubtotalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateIncidentSubtotalResponse>(DoROARequest("CreateIncidentSubtotal", "2021-04-13", "HTTPS", "POST", "AK", "/incident/save/subtotal", "json", req, runtime));
        }

        public async Task<CreateIncidentSubtotalResponse> CreateIncidentSubtotalWithOptionsAsync(CreateIncidentSubtotalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentId))
            {
                body["incidentId"] = request.IncidentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateIncidentSubtotalResponse>(await DoROARequestAsync("CreateIncidentSubtotal", "2021-04-13", "HTTPS", "POST", "AK", "/incident/save/subtotal", "json", req, runtime));
        }

        public DisableIntegrationConfigResponse DisableIntegrationConfig(DisableIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableIntegrationConfigWithOptions(request, headers, runtime);
        }

        public async Task<DisableIntegrationConfigResponse> DisableIntegrationConfigAsync(DisableIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        public DisableIntegrationConfigResponse DisableIntegrationConfigWithOptions(DisableIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DisableIntegrationConfigResponse>(DoROARequest("DisableIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/disable", "json", req, runtime));
        }

        public async Task<DisableIntegrationConfigResponse> DisableIntegrationConfigWithOptionsAsync(DisableIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationConfigId))
            {
                body["integrationConfigId"] = request.IntegrationConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DisableIntegrationConfigResponse>(await DoROARequestAsync("DisableIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/disable", "json", req, runtime));
        }

        public CreateIntegrationConfigResponse CreateIntegrationConfig(CreateIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIntegrationConfigWithOptions(request, headers, runtime);
        }

        public async Task<CreateIntegrationConfigResponse> CreateIntegrationConfigAsync(CreateIntegrationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIntegrationConfigWithOptionsAsync(request, headers, runtime);
        }

        public CreateIntegrationConfigResponse CreateIntegrationConfigWithOptions(CreateIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceId))
            {
                body["monitorSourceId"] = request.MonitorSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateIntegrationConfigResponse>(DoROARequest("CreateIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/create", "json", req, runtime));
        }

        public async Task<CreateIntegrationConfigResponse> CreateIntegrationConfigWithOptionsAsync(CreateIntegrationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceId))
            {
                body["monitorSourceId"] = request.MonitorSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateIntegrationConfigResponse>(await DoROARequestAsync("CreateIntegrationConfig", "2021-04-13", "HTTPS", "POST", "AK", "/integrationConfig/create", "json", req, runtime));
        }

        public CreateProblemEffectionServiceResponse CreateProblemEffectionService(CreateProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProblemEffectionServiceWithOptions(request, headers, runtime);
        }

        public async Task<CreateProblemEffectionServiceResponse> CreateProblemEffectionServiceAsync(CreateProblemEffectionServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProblemEffectionServiceWithOptionsAsync(request, headers, runtime);
        }

        public CreateProblemEffectionServiceResponse CreateProblemEffectionServiceWithOptions(CreateProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureUrl))
            {
                body["pictureUrl"] = request.PictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateProblemEffectionServiceResponse>(DoROARequest("CreateProblemEffectionService", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/effectionService/create", "json", req, runtime));
        }

        public async Task<CreateProblemEffectionServiceResponse> CreateProblemEffectionServiceWithOptionsAsync(CreateProblemEffectionServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureUrl))
            {
                body["pictureUrl"] = request.PictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateProblemEffectionServiceResponse>(await DoROARequestAsync("CreateProblemEffectionService", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/effectionService/create", "json", req, runtime));
        }

        public DeleteProblemTimelineResponse DeleteProblemTimeline(DeleteProblemTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProblemTimelineWithOptions(request, headers, runtime);
        }

        public async Task<DeleteProblemTimelineResponse> DeleteProblemTimelineAsync(DeleteProblemTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProblemTimelineWithOptionsAsync(request, headers, runtime);
        }

        public DeleteProblemTimelineResponse DeleteProblemTimelineWithOptions(DeleteProblemTimelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemTimelineId))
            {
                body["problemTimelineId"] = request.ProblemTimelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteProblemTimelineResponse>(DoROARequest("DeleteProblemTimeline", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/timeline/delete", "json", req, runtime));
        }

        public async Task<DeleteProblemTimelineResponse> DeleteProblemTimelineWithOptionsAsync(DeleteProblemTimelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemTimelineId))
            {
                body["problemTimelineId"] = request.ProblemTimelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteProblemTimelineResponse>(await DoROARequestAsync("DeleteProblemTimeline", "2021-04-13", "HTTPS", "POST", "AK", "/problem/process/timeline/delete", "json", req, runtime));
        }

        public DeleteRouteRuleResponse DeleteRouteRule(DeleteRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRouteRuleWithOptions(request, headers, runtime);
        }

        public async Task<DeleteRouteRuleResponse> DeleteRouteRuleAsync(DeleteRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRouteRuleWithOptionsAsync(request, headers, runtime);
        }

        public DeleteRouteRuleResponse DeleteRouteRuleWithOptions(DeleteRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteRouteRuleResponse>(DoROARequest("DeleteRouteRule", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/delete", "json", req, runtime));
        }

        public async Task<DeleteRouteRuleResponse> DeleteRouteRuleWithOptionsAsync(DeleteRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteRouteRuleResponse>(await DoROARequestAsync("DeleteRouteRule", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/delete", "json", req, runtime));
        }

        public UpdateProblemResponse UpdateProblem(UpdateProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProblemWithOptions(request, headers, runtime);
        }

        public async Task<UpdateProblemResponse> UpdateProblemAsync(UpdateProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProblemWithOptionsAsync(request, headers, runtime);
        }

        public UpdateProblemResponse UpdateProblemWithOptions(UpdateProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemName))
            {
                body["problemName"] = request.ProblemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressSummary))
            {
                body["progressSummary"] = request.ProgressSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreliminaryReason))
            {
                body["preliminaryReason"] = request.PreliminaryReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainHandlerId))
            {
                body["mainHandlerId"] = request.MainHandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Feedback))
            {
                body["feedback"] = request.Feedback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateProblemResponse>(DoROARequest("UpdateProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/update", "json", req, runtime));
        }

        public async Task<UpdateProblemResponse> UpdateProblemWithOptionsAsync(UpdateProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemName))
            {
                body["problemName"] = request.ProblemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgressSummary))
            {
                body["progressSummary"] = request.ProgressSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreliminaryReason))
            {
                body["preliminaryReason"] = request.PreliminaryReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainHandlerId))
            {
                body["mainHandlerId"] = request.MainHandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Feedback))
            {
                body["feedback"] = request.Feedback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroupIds))
            {
                body["serviceGroupIds"] = request.ServiceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateProblemResponse>(await DoROARequestAsync("UpdateProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/update", "json", req, runtime));
        }

        public CreateProblemMeasureResponse CreateProblemMeasure(CreateProblemMeasureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProblemMeasureWithOptions(request, headers, runtime);
        }

        public async Task<CreateProblemMeasureResponse> CreateProblemMeasureAsync(CreateProblemMeasureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProblemMeasureWithOptionsAsync(request, headers, runtime);
        }

        public CreateProblemMeasureResponse CreateProblemMeasureWithOptions(CreateProblemMeasureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStandard))
            {
                body["checkStandard"] = request.CheckStandard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUserId))
            {
                body["checkUserId"] = request.CheckUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanFinishTime))
            {
                body["planFinishTime"] = request.PlanFinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectorId))
            {
                body["directorId"] = request.DirectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StalkerId))
            {
                body["stalkerId"] = request.StalkerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateProblemMeasureResponse>(DoROARequest("CreateProblemMeasure", "2021-04-13", "HTTPS", "POST", "AK", "/problem/improvement/measure/save", "json", req, runtime));
        }

        public async Task<CreateProblemMeasureResponse> CreateProblemMeasureWithOptionsAsync(CreateProblemMeasureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStandard))
            {
                body["checkStandard"] = request.CheckStandard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUserId))
            {
                body["checkUserId"] = request.CheckUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanFinishTime))
            {
                body["planFinishTime"] = request.PlanFinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectorId))
            {
                body["directorId"] = request.DirectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StalkerId))
            {
                body["stalkerId"] = request.StalkerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateProblemMeasureResponse>(await DoROARequestAsync("CreateProblemMeasure", "2021-04-13", "HTTPS", "POST", "AK", "/problem/improvement/measure/save", "json", req, runtime));
        }

        public ListServiceGroupsResponse ListServiceGroups(ListServiceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceGroupsWithOptions(request, headers, runtime);
        }

        public async Task<ListServiceGroupsResponse> ListServiceGroupsAsync(ListServiceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceGroupsWithOptionsAsync(request, headers, runtime);
        }

        public ListServiceGroupsResponse ListServiceGroupsWithOptions(ListServiceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryName))
            {
                body["queryName"] = request.QueryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListServiceGroupsResponse>(DoROARequest("ListServiceGroups", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/list", "json", req, runtime));
        }

        public async Task<ListServiceGroupsResponse> ListServiceGroupsWithOptionsAsync(ListServiceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryName))
            {
                body["queryName"] = request.QueryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListServiceGroupsResponse>(await DoROARequestAsync("ListServiceGroups", "2021-04-13", "HTTPS", "POST", "AK", "/services/group/list", "json", req, runtime));
        }

        public GetRouteRuleResponse GetRouteRule(GetRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRouteRuleWithOptions(request, headers, runtime);
        }

        public async Task<GetRouteRuleResponse> GetRouteRuleAsync(GetRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRouteRuleWithOptionsAsync(request, headers, runtime);
        }

        public GetRouteRuleResponse GetRouteRuleWithOptions(GetRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetRouteRuleResponse>(DoROARequest("GetRouteRule", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/detail", "json", req, runtime));
        }

        public async Task<GetRouteRuleResponse> GetRouteRuleWithOptionsAsync(GetRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetRouteRuleResponse>(await DoROARequestAsync("GetRouteRule", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/detail", "json", req, runtime));
        }

        public EnableRouteRuleResponse EnableRouteRule(EnableRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableRouteRuleWithOptions(request, headers, runtime);
        }

        public async Task<EnableRouteRuleResponse> EnableRouteRuleAsync(EnableRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableRouteRuleWithOptionsAsync(request, headers, runtime);
        }

        public EnableRouteRuleResponse EnableRouteRuleWithOptions(EnableRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<EnableRouteRuleResponse>(DoROARequest("EnableRouteRule", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/enable", "json", req, runtime));
        }

        public async Task<EnableRouteRuleResponse> EnableRouteRuleWithOptionsAsync(EnableRouteRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                body["routeRuleId"] = request.RouteRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<EnableRouteRuleResponse>(await DoROARequestAsync("EnableRouteRule", "2021-04-13", "HTTPS", "POST", "AK", "/routeRule/enable", "json", req, runtime));
        }

        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateUserWithOptions(request, headers, runtime);
        }

        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateUserWithOptionsAsync(request, headers, runtime);
        }

        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamId))
            {
                body["ramId"] = request.RamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateUserResponse>(DoROARequest("UpdateUser", "2021-04-13", "HTTPS", "POST", "AK", "/user/update", "json", req, runtime));
        }

        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamId))
            {
                body["ramId"] = request.RamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateUserResponse>(await DoROARequestAsync("UpdateUser", "2021-04-13", "HTTPS", "POST", "AK", "/user/update", "json", req, runtime));
        }

        public UpdateProblemImprovementResponse UpdateProblemImprovement(UpdateProblemImprovementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProblemImprovementWithOptions(request, headers, runtime);
        }

        public async Task<UpdateProblemImprovementResponse> UpdateProblemImprovementAsync(UpdateProblemImprovementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProblemImprovementWithOptionsAsync(request, headers, runtime);
        }

        public UpdateProblemImprovementResponse UpdateProblemImprovementWithOptions(UpdateProblemImprovementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemReason))
            {
                body["problemReason"] = request.ProblemReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentActivity))
            {
                body["recentActivity"] = request.RecentActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InjectionMode))
            {
                body["injectionMode"] = request.InjectionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMode))
            {
                body["recoveryMode"] = request.RecoveryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoverSource))
            {
                body["discoverSource"] = request.DiscoverSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserReport))
            {
                body["userReport"] = request.UserReport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceName))
            {
                body["monitorSourceName"] = request.MonitorSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationChanges))
            {
                body["relationChanges"] = request.RelationChanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DutyUserId))
            {
                body["dutyUserId"] = request.DutyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplayDutyUserId))
            {
                body["replayDutyUserId"] = request.ReplayDutyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DutyDepartmentName))
            {
                body["dutyDepartmentName"] = request.DutyDepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DutyDepartmentId))
            {
                body["dutyDepartmentId"] = request.DutyDepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateProblemImprovementResponse>(DoROARequest("UpdateProblemImprovement", "2021-04-13", "HTTPS", "POST", "AK", "/problem/improvement/update", "json", req, runtime));
        }

        public async Task<UpdateProblemImprovementResponse> UpdateProblemImprovementWithOptionsAsync(UpdateProblemImprovementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemReason))
            {
                body["problemReason"] = request.ProblemReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentActivity))
            {
                body["recentActivity"] = request.RecentActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InjectionMode))
            {
                body["injectionMode"] = request.InjectionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMode))
            {
                body["recoveryMode"] = request.RecoveryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoverSource))
            {
                body["discoverSource"] = request.DiscoverSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserReport))
            {
                body["userReport"] = request.UserReport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSourceName))
            {
                body["monitorSourceName"] = request.MonitorSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationChanges))
            {
                body["relationChanges"] = request.RelationChanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DutyUserId))
            {
                body["dutyUserId"] = request.DutyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplayDutyUserId))
            {
                body["replayDutyUserId"] = request.ReplayDutyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DutyDepartmentName))
            {
                body["dutyDepartmentName"] = request.DutyDepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DutyDepartmentId))
            {
                body["dutyDepartmentId"] = request.DutyDepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateProblemImprovementResponse>(await DoROARequestAsync("UpdateProblemImprovement", "2021-04-13", "HTTPS", "POST", "AK", "/problem/improvement/update", "json", req, runtime));
        }

        public FinishIncidentResponse FinishIncident(FinishIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FinishIncidentWithOptions(request, headers, runtime);
        }

        public async Task<FinishIncidentResponse> FinishIncidentAsync(FinishIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FinishIncidentWithOptionsAsync(request, headers, runtime);
        }

        public FinishIncidentResponse FinishIncidentWithOptions(FinishIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentIds))
            {
                body["incidentIds"] = request.IncidentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishReason))
            {
                body["incidentFinishReason"] = request.IncidentFinishReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishReasonDescription))
            {
                body["incidentFinishReasonDescription"] = request.IncidentFinishReasonDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishSolution))
            {
                body["incidentFinishSolution"] = request.IncidentFinishSolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishSolutionDescription))
            {
                body["incidentFinishSolutionDescription"] = request.IncidentFinishSolutionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<FinishIncidentResponse>(DoROARequest("FinishIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/finish", "json", req, runtime));
        }

        public async Task<FinishIncidentResponse> FinishIncidentWithOptionsAsync(FinishIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentIds))
            {
                body["incidentIds"] = request.IncidentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishReason))
            {
                body["incidentFinishReason"] = request.IncidentFinishReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishReasonDescription))
            {
                body["incidentFinishReasonDescription"] = request.IncidentFinishReasonDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishSolution))
            {
                body["incidentFinishSolution"] = request.IncidentFinishSolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentFinishSolutionDescription))
            {
                body["incidentFinishSolutionDescription"] = request.IncidentFinishSolutionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<FinishIncidentResponse>(await DoROARequestAsync("FinishIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/finish", "json", req, runtime));
        }

        public GetServiceResponse GetService(GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceWithOptions(request, headers, runtime);
        }

        public async Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceWithOptionsAsync(request, headers, runtime);
        }

        public GetServiceResponse GetServiceWithOptions(GetServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetServiceResponse>(DoROARequest("GetService", "2021-04-13", "HTTPS", "POST", "AK", "/services/detail", "json", req, runtime));
        }

        public async Task<GetServiceResponse> GetServiceWithOptionsAsync(GetServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetServiceResponse>(await DoROARequestAsync("GetService", "2021-04-13", "HTTPS", "POST", "AK", "/services/detail", "json", req, runtime));
        }

        public CreateIncidentResponse CreateIncident(CreateIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIncidentWithOptions(request, headers, runtime);
        }

        public async Task<CreateIncidentResponse> CreateIncidentAsync(CreateIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIncidentWithOptionsAsync(request, headers, runtime);
        }

        public CreateIncidentResponse CreateIncidentWithOptions(CreateIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentTitle))
            {
                body["incidentTitle"] = request.IncidentTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignUserId))
            {
                body["assignUserId"] = request.AssignUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentDescription))
            {
                body["incidentDescription"] = request.IncidentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channels))
            {
                body["channels"] = request.Channels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateIncidentResponse>(DoROARequest("CreateIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/manualSave", "json", req, runtime));
        }

        public async Task<CreateIncidentResponse> CreateIncidentWithOptionsAsync(CreateIncidentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentLevel))
            {
                body["incidentLevel"] = request.IncidentLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedServiceId))
            {
                body["relatedServiceId"] = request.RelatedServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentTitle))
            {
                body["incidentTitle"] = request.IncidentTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignUserId))
            {
                body["assignUserId"] = request.AssignUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentDescription))
            {
                body["incidentDescription"] = request.IncidentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channels))
            {
                body["channels"] = request.Channels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateIncidentResponse>(await DoROARequestAsync("CreateIncident", "2021-04-13", "HTTPS", "POST", "AK", "/incident/manualSave", "json", req, runtime));
        }

        public FinishProblemResponse FinishProblem(FinishProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FinishProblemWithOptions(request, headers, runtime);
        }

        public async Task<FinishProblemResponse> FinishProblemAsync(FinishProblemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FinishProblemWithOptionsAsync(request, headers, runtime);
        }

        public FinishProblemResponse FinishProblemWithOptions(FinishProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<FinishProblemResponse>(DoROARequest("FinishProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/finish", "json", req, runtime));
        }

        public async Task<FinishProblemResponse> FinishProblemWithOptionsAsync(FinishProblemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProblemId))
            {
                body["problemId"] = request.ProblemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<FinishProblemResponse>(await DoROARequestAsync("FinishProblem", "2021-04-13", "HTTPS", "POST", "AK", "/problem/finish", "json", req, runtime));
        }

        public ListSubscriptionServiceGroupsResponse ListSubscriptionServiceGroups(ListSubscriptionServiceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSubscriptionServiceGroupsWithOptions(request, headers, runtime);
        }

        public async Task<ListSubscriptionServiceGroupsResponse> ListSubscriptionServiceGroupsAsync(ListSubscriptionServiceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSubscriptionServiceGroupsWithOptionsAsync(request, headers, runtime);
        }

        public ListSubscriptionServiceGroupsResponse ListSubscriptionServiceGroupsWithOptions(ListSubscriptionServiceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceIds))
            {
                body["serviceIds"] = request.ServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListSubscriptionServiceGroupsResponse>(DoROARequest("ListSubscriptionServiceGroups", "2021-04-13", "HTTPS", "POST", "AK", "/problem/serviceGroup/list", "json", req, runtime));
        }

        public async Task<ListSubscriptionServiceGroupsResponse> ListSubscriptionServiceGroupsWithOptionsAsync(ListSubscriptionServiceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceIds))
            {
                body["serviceIds"] = request.ServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ListSubscriptionServiceGroupsResponse>(await DoROARequestAsync("ListSubscriptionServiceGroups", "2021-04-13", "HTTPS", "POST", "AK", "/problem/serviceGroup/list", "json", req, runtime));
        }

    }
}