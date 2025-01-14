// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cams20200606.Models;

namespace AlibabaCloud.SDK.Cams20200606
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cams", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CheckChatappContactsResponse CheckChatappContactsWithOptions(CheckChatappContactsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckChatappContactsShrinkRequest request = new CheckChatappContactsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contacts))
            {
                request.ContactsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contacts, "Contacts", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactsShrink))
            {
                body["Contacts"] = request.ContactsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckChatappContacts",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckChatappContactsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckChatappContactsResponse> CheckChatappContactsWithOptionsAsync(CheckChatappContactsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckChatappContactsShrinkRequest request = new CheckChatappContactsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contacts))
            {
                request.ContactsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contacts, "Contacts", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactsShrink))
            {
                body["Contacts"] = request.ContactsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckChatappContacts",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckChatappContactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckChatappContactsResponse CheckChatappContacts(CheckChatappContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckChatappContactsWithOptions(request, runtime);
        }

        public async Task<CheckChatappContactsResponse> CheckChatappContactsAsync(CheckChatappContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckChatappContactsWithOptionsAsync(request, runtime);
        }

        public CreateChatappTemplateResponse CreateChatappTemplateWithOptions(CreateChatappTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateChatappTemplateShrinkRequest request = new CreateChatappTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Components))
            {
                request.ComponentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Components, "Components", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Example))
            {
                request.ExampleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Example, "Example", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentsShrink))
            {
                body["Components"] = request.ComponentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExampleShrink))
            {
                body["Example"] = request.ExampleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatappTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateChatappTemplateResponse> CreateChatappTemplateWithOptionsAsync(CreateChatappTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateChatappTemplateShrinkRequest request = new CreateChatappTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Components))
            {
                request.ComponentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Components, "Components", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Example))
            {
                request.ExampleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Example, "Example", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentsShrink))
            {
                body["Components"] = request.ComponentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExampleShrink))
            {
                body["Example"] = request.ExampleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatappTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateChatappTemplateResponse CreateChatappTemplate(CreateChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateChatappTemplateWithOptions(request, runtime);
        }

        public async Task<CreateChatappTemplateResponse> CreateChatappTemplateAsync(CreateChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateChatappTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteChatappTemplateResponse DeleteChatappTemplateWithOptions(DeleteChatappTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                query["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChatappTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteChatappTemplateResponse> DeleteChatappTemplateWithOptionsAsync(DeleteChatappTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                query["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChatappTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteChatappTemplateResponse DeleteChatappTemplate(DeleteChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChatappTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteChatappTemplateResponse> DeleteChatappTemplateAsync(DeleteChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChatappTemplateWithOptionsAsync(request, runtime);
        }

        public GetChatappTemplateDetailResponse GetChatappTemplateDetailWithOptions(GetChatappTemplateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                query["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatappTemplateDetail",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatappTemplateDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetChatappTemplateDetailResponse> GetChatappTemplateDetailWithOptionsAsync(GetChatappTemplateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                query["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatappTemplateDetail",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatappTemplateDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetChatappTemplateDetailResponse GetChatappTemplateDetail(GetChatappTemplateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChatappTemplateDetailWithOptions(request, runtime);
        }

        public async Task<GetChatappTemplateDetailResponse> GetChatappTemplateDetailAsync(GetChatappTemplateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChatappTemplateDetailWithOptionsAsync(request, runtime);
        }

        public ListChatappTemplateResponse ListChatappTemplateWithOptions(ListChatappTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListChatappTemplateShrinkRequest request = new ListChatappTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page.ToMap()))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page.ToMap(), "Page", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                query["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                query["Page"] = request.PageShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatappTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListChatappTemplateResponse> ListChatappTemplateWithOptionsAsync(ListChatappTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListChatappTemplateShrinkRequest request = new ListChatappTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page.ToMap()))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page.ToMap(), "Page", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                query["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                query["Page"] = request.PageShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatappTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListChatappTemplateResponse ListChatappTemplate(ListChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChatappTemplateWithOptions(request, runtime);
        }

        public async Task<ListChatappTemplateResponse> ListChatappTemplateAsync(ListChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChatappTemplateWithOptionsAsync(request, runtime);
        }

        public SendChatappMassMessageResponse SendChatappMassMessageWithOptions(SendChatappMassMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendChatappMassMessageShrinkRequest request = new SendChatappMassMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SenderList))
            {
                request.SenderListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SenderList, "SenderList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackContent))
            {
                body["FallBackContent"] = request.FallBackContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackId))
            {
                body["FallBackId"] = request.FallBackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderListShrink))
            {
                body["SenderList"] = request.SenderListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendChatappMassMessage",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendChatappMassMessageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendChatappMassMessageResponse> SendChatappMassMessageWithOptionsAsync(SendChatappMassMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendChatappMassMessageShrinkRequest request = new SendChatappMassMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SenderList))
            {
                request.SenderListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SenderList, "SenderList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackContent))
            {
                body["FallBackContent"] = request.FallBackContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackId))
            {
                body["FallBackId"] = request.FallBackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderListShrink))
            {
                body["SenderList"] = request.SenderListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendChatappMassMessage",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendChatappMassMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendChatappMassMessageResponse SendChatappMassMessage(SendChatappMassMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendChatappMassMessageWithOptions(request, runtime);
        }

        public async Task<SendChatappMassMessageResponse> SendChatappMassMessageAsync(SendChatappMassMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendChatappMassMessageWithOptionsAsync(request, runtime);
        }

        public SendChatappMessageResponse SendChatappMessageWithOptions(SendChatappMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendChatappMessageShrinkRequest request = new SendChatappMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateParams))
            {
                request.TemplateParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateParams, "TemplateParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackContent))
            {
                body["FallBackContent"] = request.FallBackContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackId))
            {
                body["FallBackId"] = request.FallBackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParamsShrink))
            {
                body["TemplateParams"] = request.TemplateParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendChatappMessage",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendChatappMessageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendChatappMessageResponse> SendChatappMessageWithOptionsAsync(SendChatappMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendChatappMessageShrinkRequest request = new SendChatappMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateParams))
            {
                request.TemplateParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateParams, "TemplateParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackContent))
            {
                body["FallBackContent"] = request.FallBackContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackId))
            {
                body["FallBackId"] = request.FallBackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParamsShrink))
            {
                body["TemplateParams"] = request.TemplateParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendChatappMessage",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendChatappMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendChatappMessageResponse SendChatappMessage(SendChatappMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendChatappMessageWithOptions(request, runtime);
        }

        public async Task<SendChatappMessageResponse> SendChatappMessageAsync(SendChatappMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendChatappMessageWithOptionsAsync(request, runtime);
        }

    }
}
