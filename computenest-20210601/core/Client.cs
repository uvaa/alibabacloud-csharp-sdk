// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ComputeNest20210601.Models;

namespace AlibabaCloud.SDK.ComputeNest20210601
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("computenest", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ContinueDeployServiceInstanceResponse ContinueDeployServiceInstanceWithOptions(ContinueDeployServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ContinueDeployServiceInstanceResponse>(DoRPCRequest("ContinueDeployServiceInstance", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ContinueDeployServiceInstanceResponse> ContinueDeployServiceInstanceWithOptionsAsync(ContinueDeployServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ContinueDeployServiceInstanceResponse>(await DoRPCRequestAsync("ContinueDeployServiceInstance", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ContinueDeployServiceInstanceResponse ContinueDeployServiceInstance(ContinueDeployServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContinueDeployServiceInstanceWithOptions(request, runtime);
        }

        public async Task<ContinueDeployServiceInstanceResponse> ContinueDeployServiceInstanceAsync(ContinueDeployServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContinueDeployServiceInstanceWithOptionsAsync(request, runtime);
        }

        public CreateServiceInstanceResponse CreateServiceInstanceWithOptions(CreateServiceInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateServiceInstanceShrinkRequest request = new CreateServiceInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceInstanceResponse>(DoRPCRequest("CreateServiceInstance", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateServiceInstanceResponse> CreateServiceInstanceWithOptionsAsync(CreateServiceInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateServiceInstanceShrinkRequest request = new CreateServiceInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceInstanceResponse>(await DoRPCRequestAsync("CreateServiceInstance", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateServiceInstanceResponse CreateServiceInstance(CreateServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceInstanceWithOptions(request, runtime);
        }

        public async Task<CreateServiceInstanceResponse> CreateServiceInstanceAsync(CreateServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteServiceInstancesResponse DeleteServiceInstancesWithOptions(DeleteServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteServiceInstancesResponse>(DoRPCRequest("DeleteServiceInstances", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteServiceInstancesResponse> DeleteServiceInstancesWithOptionsAsync(DeleteServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteServiceInstancesResponse>(await DoRPCRequestAsync("DeleteServiceInstances", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteServiceInstancesResponse DeleteServiceInstances(DeleteServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServiceInstancesWithOptions(request, runtime);
        }

        public async Task<DeleteServiceInstancesResponse> DeleteServiceInstancesAsync(DeleteServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServiceInstancesWithOptionsAsync(request, runtime);
        }

        public DeployServiceInstanceResponse DeployServiceInstanceWithOptions(DeployServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployServiceInstanceResponse>(DoRPCRequest("DeployServiceInstance", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeployServiceInstanceResponse> DeployServiceInstanceWithOptionsAsync(DeployServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployServiceInstanceResponse>(await DoRPCRequestAsync("DeployServiceInstance", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeployServiceInstanceResponse DeployServiceInstance(DeployServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployServiceInstanceWithOptions(request, runtime);
        }

        public async Task<DeployServiceInstanceResponse> DeployServiceInstanceAsync(DeployServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployServiceInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public GetServiceResponse GetServiceWithOptions(GetServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceResponse>(DoRPCRequest("GetService", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetServiceResponse> GetServiceWithOptionsAsync(GetServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceResponse>(await DoRPCRequestAsync("GetService", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetServiceResponse GetService(GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceWithOptions(request, runtime);
        }

        public async Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceWithOptionsAsync(request, runtime);
        }

        public GetServiceInstanceResponse GetServiceInstanceWithOptions(GetServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceInstanceResponse>(DoRPCRequest("GetServiceInstance", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetServiceInstanceResponse> GetServiceInstanceWithOptionsAsync(GetServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceInstanceResponse>(await DoRPCRequestAsync("GetServiceInstance", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetServiceInstanceResponse GetServiceInstance(GetServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceInstanceWithOptions(request, runtime);
        }

        public async Task<GetServiceInstanceResponse> GetServiceInstanceAsync(GetServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceInstanceWithOptionsAsync(request, runtime);
        }

        public ListInuseServicesResponse ListInuseServicesWithOptions(ListInuseServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInuseServicesResponse>(DoRPCRequest("ListInuseServices", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInuseServicesResponse> ListInuseServicesWithOptionsAsync(ListInuseServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInuseServicesResponse>(await DoRPCRequestAsync("ListInuseServices", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInuseServicesResponse ListInuseServices(ListInuseServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInuseServicesWithOptions(request, runtime);
        }

        public async Task<ListInuseServicesResponse> ListInuseServicesAsync(ListInuseServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInuseServicesWithOptionsAsync(request, runtime);
        }

        public ListServiceInstancesResponse ListServiceInstancesWithOptions(ListServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServiceInstancesResponse>(DoRPCRequest("ListServiceInstances", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListServiceInstancesResponse> ListServiceInstancesWithOptionsAsync(ListServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServiceInstancesResponse>(await DoRPCRequestAsync("ListServiceInstances", "2021-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListServiceInstancesResponse ListServiceInstances(ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceInstancesWithOptions(request, runtime);
        }

        public async Task<ListServiceInstancesResponse> ListServiceInstancesAsync(ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceInstancesWithOptionsAsync(request, runtime);
        }

    }
}