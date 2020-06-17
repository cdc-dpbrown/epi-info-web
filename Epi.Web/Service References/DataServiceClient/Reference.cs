﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Epi.Web.MVC.DataServiceClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataServiceClient.IDataService")]
    public interface IDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetSurveyInfo", ReplyAction="http://tempuri.org/IDataService/GetSurveyInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetSurveyInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyInfoResponse GetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetSurveyInfo", ReplyAction="http://tempuri.org/IDataService/GetSurveyInfoResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyInfoResponse> GetSurveyInfoAsync(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetCacheDependencyInfo", ReplyAction="http://tempuri.org/IDataService/GetCacheDependencyInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetCacheDependencyInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.CacheDependencyResponse GetCacheDependencyInfo(Epi.Web.Common.Message.CacheDependencyRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetCacheDependencyInfo", ReplyAction="http://tempuri.org/IDataService/GetCacheDependencyInfoResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.CacheDependencyResponse> GetCacheDependencyInfoAsync(Epi.Web.Common.Message.CacheDependencyRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetSurveyAnswer", ReplyAction="http://tempuri.org/IDataService/GetSurveyAnswerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetSurveyAnswerCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetSurveyAnswer", ReplyAction="http://tempuri.org/IDataService/GetSurveyAnswerResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> GetSurveyAnswerAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SetSurveyAnswer", ReplyAction="http://tempuri.org/IDataService/SetSurveyAnswerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/SetSurveyAnswerCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse SetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SetSurveyAnswer", ReplyAction="http://tempuri.org/IDataService/SetSurveyAnswerResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> SetSurveyAnswerAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/PassCodeLogin", ReplyAction="http://tempuri.org/IDataService/PassCodeLoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/PassCodeLoginCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.UserAuthenticationResponse PassCodeLogin(Epi.Web.Common.Message.UserAuthenticationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/PassCodeLogin", ReplyAction="http://tempuri.org/IDataService/PassCodeLoginResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.UserAuthenticationResponse> PassCodeLoginAsync(Epi.Web.Common.Message.UserAuthenticationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SetPassCode", ReplyAction="http://tempuri.org/IDataService/SetPassCodeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/SetPassCodeCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.UserAuthenticationResponse SetPassCode(Epi.Web.Common.Message.UserAuthenticationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SetPassCode", ReplyAction="http://tempuri.org/IDataService/SetPassCodeResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.UserAuthenticationResponse> SetPassCodeAsync(Epi.Web.Common.Message.UserAuthenticationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetAuthenticationResponse", ReplyAction="http://tempuri.org/IDataService/GetAuthenticationResponseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetAuthenticationResponseCustomFaultExceptionFaul" +
            "t", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.UserAuthenticationResponse GetAuthenticationResponse(Epi.Web.Common.Message.UserAuthenticationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetAuthenticationResponse", ReplyAction="http://tempuri.org/IDataService/GetAuthenticationResponseResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.UserAuthenticationResponse> GetAuthenticationResponseAsync(Epi.Web.Common.Message.UserAuthenticationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetFormResponseList", ReplyAction="http://tempuri.org/IDataService/GetFormResponseListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetFormResponseListCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetFormResponseList(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetFormResponseList", ReplyAction="http://tempuri.org/IDataService/GetFormResponseListResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> GetFormResponseListAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetFormChildInfo", ReplyAction="http://tempuri.org/IDataService/GetFormChildInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetFormChildInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyInfoResponse GetFormChildInfo(Epi.Web.Common.Message.SurveyInfoRequest SurveyInfoRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetFormChildInfo", ReplyAction="http://tempuri.org/IDataService/GetFormChildInfoResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyInfoResponse> GetFormChildInfoAsync(Epi.Web.Common.Message.SurveyInfoRequest SurveyInfoRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetFormsHierarchy", ReplyAction="http://tempuri.org/IDataService/GetFormsHierarchyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetFormsHierarchyCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.FormsHierarchyResponse GetFormsHierarchy(Epi.Web.Common.Message.FormsHierarchyRequest FormsHierarchyRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetFormsHierarchy", ReplyAction="http://tempuri.org/IDataService/GetFormsHierarchyResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.FormsHierarchyResponse> GetFormsHierarchyAsync(Epi.Web.Common.Message.FormsHierarchyRequest FormsHierarchyRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetSurveyAnswerHierarchy", ReplyAction="http://tempuri.org/IDataService/GetSurveyAnswerHierarchyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetSurveyAnswerHierarchyCustomFaultExceptionFault" +
            "", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswerHierarchy(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetSurveyAnswerHierarchy", ReplyAction="http://tempuri.org/IDataService/GetSurveyAnswerHierarchyResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> GetSurveyAnswerHierarchyAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetAncestorResponseIdsByChildId", ReplyAction="http://tempuri.org/IDataService/GetAncestorResponseIdsByChildIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetAncestorResponseIdsByChildIdCustomFaultExcepti" +
            "onFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetAncestorResponseIdsByChildId(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetAncestorResponseIdsByChildId", ReplyAction="http://tempuri.org/IDataService/GetAncestorResponseIdsByChildIdResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> GetAncestorResponseIdsByChildIdAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetResponsesByRelatedFormId", ReplyAction="http://tempuri.org/IDataService/GetResponsesByRelatedFormIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetResponsesByRelatedFormIdCustomFaultExceptionFa" +
            "ult", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetResponsesByRelatedFormId(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetResponsesByRelatedFormId", ReplyAction="http://tempuri.org/IDataService/GetResponsesByRelatedFormIdResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> GetResponsesByRelatedFormIdAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/CreateAccount", ReplyAction="http://tempuri.org/IDataService/CreateAccountResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/CreateAccountCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationAccountResponse CreateAccount(Epi.Web.Common.Message.OrganizationAccountRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/CreateAccount", ReplyAction="http://tempuri.org/IDataService/CreateAccountResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationAccountResponse> CreateAccountAsync(Epi.Web.Common.Message.OrganizationAccountRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetStateList", ReplyAction="http://tempuri.org/IDataService/GetStateListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetStateListCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationAccountResponse GetStateList(Epi.Web.Common.Message.OrganizationAccountRequest Request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetStateList", ReplyAction="http://tempuri.org/IDataService/GetStateListResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationAccountResponse> GetStateListAsync(Epi.Web.Common.Message.OrganizationAccountRequest Request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetSurveyControlList", ReplyAction="http://tempuri.org/IDataService/GetSurveyControlListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetSurveyControlListCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyControlsResponse GetSurveyControlList(Epi.Web.Common.Message.SurveyControlsRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetSurveyControlList", ReplyAction="http://tempuri.org/IDataService/GetSurveyControlListResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyControlsResponse> GetSurveyControlListAsync(Epi.Web.Common.Message.SurveyControlsRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetUserOrgId", ReplyAction="http://tempuri.org/IDataService/GetUserOrgIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetUserOrgIdCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationAccountResponse GetUserOrgId(Epi.Web.Common.Message.OrganizationAccountRequest Request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetUserOrgId", ReplyAction="http://tempuri.org/IDataService/GetUserOrgIdResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationAccountResponse> GetUserOrgIdAsync(Epi.Web.Common.Message.OrganizationAccountRequest Request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/HasResponse", ReplyAction="http://tempuri.org/IDataService/HasResponseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/HasResponseCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        bool HasResponse(string SurveyId, string ResponseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/HasResponse", ReplyAction="http://tempuri.org/IDataService/HasResponseResponse")]
        System.Threading.Tasks.Task<bool> HasResponseAsync(string SurveyId, string ResponseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetOrganization", ReplyAction="http://tempuri.org/IDataService/GetOrganizationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetOrganizationCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationAccountResponse GetOrganization(Epi.Web.Common.Message.OrganizationAccountRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetOrganization", ReplyAction="http://tempuri.org/IDataService/GetOrganizationResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationAccountResponse> GetOrganizationAsync(Epi.Web.Common.Message.OrganizationAccountRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetSourceTables", ReplyAction="http://tempuri.org/IDataService/GetSourceTablesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetSourceTablesCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SourceTablesResponse GetSourceTables(Epi.Web.Common.Message.SourceTablesRequest Request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetSourceTables", ReplyAction="http://tempuri.org/IDataService/GetSourceTablesResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SourceTablesResponse> GetSourceTablesAsync(Epi.Web.Common.Message.SourceTablesRequest Request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/UpdateResponseStatus", ReplyAction="http://tempuri.org/IDataService/UpdateResponseStatusResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/UpdateResponseStatusCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        void UpdateResponseStatus(Epi.Web.Common.Message.SurveyAnswerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/UpdateResponseStatus", ReplyAction="http://tempuri.org/IDataService/UpdateResponseStatusResponse")]
        System.Threading.Tasks.Task UpdateResponseStatusAsync(Epi.Web.Common.Message.SurveyAnswerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SetJsonColumn", ReplyAction="http://tempuri.org/IDataService/SetJsonColumnResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/SetJsonColumnCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        bool SetJsonColumn(string json, string responseid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SetJsonColumn", ReplyAction="http://tempuri.org/IDataService/SetJsonColumnResponse")]
        System.Threading.Tasks.Task<bool> SetJsonColumnAsync(string json, string responseid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetSurveyDashboardInfo", ReplyAction="http://tempuri.org/IDataService/GetSurveyDashboardInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IDataService/GetSurveyDashboardInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.DashboardResponse GetSurveyDashboardInfo(string surveyid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetSurveyDashboardInfo", ReplyAction="http://tempuri.org/IDataService/GetSurveyDashboardInfoResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.DashboardResponse> GetSurveyDashboardInfoAsync(string surveyid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataServiceChannel : Epi.Web.MVC.DataServiceClient.IDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceClient : System.ServiceModel.ClientBase<Epi.Web.MVC.DataServiceClient.IDataService>, Epi.Web.MVC.DataServiceClient.IDataService {
        
        public DataServiceClient() {
        }
        
        public DataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Epi.Web.Common.Message.SurveyInfoResponse GetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.GetSurveyInfo(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyInfoResponse> GetSurveyInfoAsync(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.GetSurveyInfoAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.CacheDependencyResponse GetCacheDependencyInfo(Epi.Web.Common.Message.CacheDependencyRequest pRequest) {
            return base.Channel.GetCacheDependencyInfo(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.CacheDependencyResponse> GetCacheDependencyInfoAsync(Epi.Web.Common.Message.CacheDependencyRequest pRequest) {
            return base.Channel.GetCacheDependencyInfoAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetSurveyAnswer(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> GetSurveyAnswerAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetSurveyAnswerAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse SetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.SetSurveyAnswer(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> SetSurveyAnswerAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.SetSurveyAnswerAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.UserAuthenticationResponse PassCodeLogin(Epi.Web.Common.Message.UserAuthenticationRequest pRequest) {
            return base.Channel.PassCodeLogin(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.UserAuthenticationResponse> PassCodeLoginAsync(Epi.Web.Common.Message.UserAuthenticationRequest pRequest) {
            return base.Channel.PassCodeLoginAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.UserAuthenticationResponse SetPassCode(Epi.Web.Common.Message.UserAuthenticationRequest pRequest) {
            return base.Channel.SetPassCode(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.UserAuthenticationResponse> SetPassCodeAsync(Epi.Web.Common.Message.UserAuthenticationRequest pRequest) {
            return base.Channel.SetPassCodeAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.UserAuthenticationResponse GetAuthenticationResponse(Epi.Web.Common.Message.UserAuthenticationRequest pRequest) {
            return base.Channel.GetAuthenticationResponse(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.UserAuthenticationResponse> GetAuthenticationResponseAsync(Epi.Web.Common.Message.UserAuthenticationRequest pRequest) {
            return base.Channel.GetAuthenticationResponseAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse GetFormResponseList(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetFormResponseList(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> GetFormResponseListAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetFormResponseListAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyInfoResponse GetFormChildInfo(Epi.Web.Common.Message.SurveyInfoRequest SurveyInfoRequest) {
            return base.Channel.GetFormChildInfo(SurveyInfoRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyInfoResponse> GetFormChildInfoAsync(Epi.Web.Common.Message.SurveyInfoRequest SurveyInfoRequest) {
            return base.Channel.GetFormChildInfoAsync(SurveyInfoRequest);
        }
        
        public Epi.Web.Common.Message.FormsHierarchyResponse GetFormsHierarchy(Epi.Web.Common.Message.FormsHierarchyRequest FormsHierarchyRequest) {
            return base.Channel.GetFormsHierarchy(FormsHierarchyRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.FormsHierarchyResponse> GetFormsHierarchyAsync(Epi.Web.Common.Message.FormsHierarchyRequest FormsHierarchyRequest) {
            return base.Channel.GetFormsHierarchyAsync(FormsHierarchyRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswerHierarchy(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetSurveyAnswerHierarchy(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> GetSurveyAnswerHierarchyAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetSurveyAnswerHierarchyAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse GetAncestorResponseIdsByChildId(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetAncestorResponseIdsByChildId(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> GetAncestorResponseIdsByChildIdAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetAncestorResponseIdsByChildIdAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse GetResponsesByRelatedFormId(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetResponsesByRelatedFormId(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> GetResponsesByRelatedFormIdAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetResponsesByRelatedFormIdAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationAccountResponse CreateAccount(Epi.Web.Common.Message.OrganizationAccountRequest pRequest) {
            return base.Channel.CreateAccount(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationAccountResponse> CreateAccountAsync(Epi.Web.Common.Message.OrganizationAccountRequest pRequest) {
            return base.Channel.CreateAccountAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationAccountResponse GetStateList(Epi.Web.Common.Message.OrganizationAccountRequest Request) {
            return base.Channel.GetStateList(Request);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationAccountResponse> GetStateListAsync(Epi.Web.Common.Message.OrganizationAccountRequest Request) {
            return base.Channel.GetStateListAsync(Request);
        }
        
        public Epi.Web.Common.Message.SurveyControlsResponse GetSurveyControlList(Epi.Web.Common.Message.SurveyControlsRequest pRequestMessage) {
            return base.Channel.GetSurveyControlList(pRequestMessage);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyControlsResponse> GetSurveyControlListAsync(Epi.Web.Common.Message.SurveyControlsRequest pRequestMessage) {
            return base.Channel.GetSurveyControlListAsync(pRequestMessage);
        }
        
        public Epi.Web.Common.Message.OrganizationAccountResponse GetUserOrgId(Epi.Web.Common.Message.OrganizationAccountRequest Request) {
            return base.Channel.GetUserOrgId(Request);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationAccountResponse> GetUserOrgIdAsync(Epi.Web.Common.Message.OrganizationAccountRequest Request) {
            return base.Channel.GetUserOrgIdAsync(Request);
        }
        
        public bool HasResponse(string SurveyId, string ResponseId) {
            return base.Channel.HasResponse(SurveyId, ResponseId);
        }
        
        public System.Threading.Tasks.Task<bool> HasResponseAsync(string SurveyId, string ResponseId) {
            return base.Channel.HasResponseAsync(SurveyId, ResponseId);
        }
        
        public Epi.Web.Common.Message.OrganizationAccountResponse GetOrganization(Epi.Web.Common.Message.OrganizationAccountRequest request) {
            return base.Channel.GetOrganization(request);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationAccountResponse> GetOrganizationAsync(Epi.Web.Common.Message.OrganizationAccountRequest request) {
            return base.Channel.GetOrganizationAsync(request);
        }
        
        public Epi.Web.Common.Message.SourceTablesResponse GetSourceTables(Epi.Web.Common.Message.SourceTablesRequest Request) {
            return base.Channel.GetSourceTables(Request);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SourceTablesResponse> GetSourceTablesAsync(Epi.Web.Common.Message.SourceTablesRequest Request) {
            return base.Channel.GetSourceTablesAsync(Request);
        }
        
        public void UpdateResponseStatus(Epi.Web.Common.Message.SurveyAnswerRequest request) {
            base.Channel.UpdateResponseStatus(request);
        }
        
        public System.Threading.Tasks.Task UpdateResponseStatusAsync(Epi.Web.Common.Message.SurveyAnswerRequest request) {
            return base.Channel.UpdateResponseStatusAsync(request);
        }
        
        public bool SetJsonColumn(string json, string responseid) {
            return base.Channel.SetJsonColumn(json, responseid);
        }
        
        public System.Threading.Tasks.Task<bool> SetJsonColumnAsync(string json, string responseid) {
            return base.Channel.SetJsonColumnAsync(json, responseid);
        }
        
        public Epi.Web.Common.Message.DashboardResponse GetSurveyDashboardInfo(string surveyid) {
            return base.Channel.GetSurveyDashboardInfo(surveyid);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.DashboardResponse> GetSurveyDashboardInfoAsync(string surveyid) {
            return base.Channel.GetSurveyDashboardInfoAsync(surveyid);
        }
    }
}
