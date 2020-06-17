﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Epi.Web.SurveyManager.Client.SurveyManagerServiceV2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SurveyManagerServiceV2.IManagerServiceV2")]
    public interface IManagerServiceV2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/PublishSurvey", ReplyAction="http://tempuri.org/IManagerService/PublishSurveyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/PublishSurveyCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.PublishResponse PublishSurvey(Epi.Web.Common.Message.PublishRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetSurveyInfo", ReplyAction="http://tempuri.org/IManagerService/GetSurveyInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetSurveyInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyInfoResponse GetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetOrganization", ReplyAction="http://tempuri.org/IManagerService/GetOrganizationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetOrganizationCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse GetOrganization(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetOrganizationInfo", ReplyAction="http://tempuri.org/IManagerService/GetOrganizationInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetOrganizationInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse GetOrganizationInfo(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetOrganizationNames", ReplyAction="http://tempuri.org/IManagerService/GetOrganizationNamesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetOrganizationNamesCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse GetOrganizationNames(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetOrganizationByKey", ReplyAction="http://tempuri.org/IManagerService/GetOrganizationByKeyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetOrganizationByKeyCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse GetOrganizationByKey(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/SetSurveyInfo", ReplyAction="http://tempuri.org/IManagerService/SetSurveyInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/SetSurveyInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyInfoResponse SetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetSurveyAnswer", ReplyAction="http://tempuri.org/IManagerService/GetSurveyAnswerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetSurveyAnswerCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/SetOrganization", ReplyAction="http://tempuri.org/IManagerService/SetOrganizationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/SetOrganizationCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse SetOrganization(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/UpdateOrganizationInfo", ReplyAction="http://tempuri.org/IManagerService/UpdateOrganizationInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/UpdateOrganizationInfoCustomFaultExceptionFaul" +
            "t", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse UpdateOrganizationInfo(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/IsValidOrgKey", ReplyAction="http://tempuri.org/IManagerService/IsValidOrgKeyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/IsValidOrgKeyCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        bool IsValidOrgKey(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/RePublishSurvey", ReplyAction="http://tempuri.org/IManagerService/RePublishSurveyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/RePublishSurveyCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.PublishResponse RePublishSurvey(Epi.Web.Common.Message.PublishRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV2/SetSurveyAnswer", ReplyAction="http://tempuri.org/IManagerServiceV2/SetSurveyAnswerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV2/SetSurveyAnswerCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.PreFilledAnswerResponse SetSurveyAnswer(Epi.Web.Common.Message.PreFilledAnswerRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV2/GetSurveyControlList", ReplyAction="http://tempuri.org/IManagerServiceV2/GetSurveyControlListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV2/GetSurveyControlListCustomFaultExceptionFaul" +
            "t", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyControlsResponse GetSurveyControlList(Epi.Web.Common.Message.SurveyControlsRequest pRequestMessage);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IManagerServiceV2Channel : Epi.Web.SurveyManager.Client.SurveyManagerServiceV2.IManagerServiceV2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ManagerServiceV2Client : System.ServiceModel.ClientBase<Epi.Web.SurveyManager.Client.SurveyManagerServiceV2.IManagerServiceV2>, Epi.Web.SurveyManager.Client.SurveyManagerServiceV2.IManagerServiceV2 {
        
        public ManagerServiceV2Client() {
        }
        
        public ManagerServiceV2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ManagerServiceV2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagerServiceV2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagerServiceV2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Epi.Web.Common.Message.PublishResponse PublishSurvey(Epi.Web.Common.Message.PublishRequest pRequestMessage) {
            return base.Channel.PublishSurvey(pRequestMessage);
        }
        
        public Epi.Web.Common.Message.SurveyInfoResponse GetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.GetSurveyInfo(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationResponse GetOrganization(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.GetOrganization(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationResponse GetOrganizationInfo(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.GetOrganizationInfo(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationResponse GetOrganizationNames(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.GetOrganizationNames(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationResponse GetOrganizationByKey(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.GetOrganizationByKey(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyInfoResponse SetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.SetSurveyInfo(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetSurveyAnswer(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationResponse SetOrganization(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.SetOrganization(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationResponse UpdateOrganizationInfo(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.UpdateOrganizationInfo(pRequest);
        }
        
        public bool IsValidOrgKey(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.IsValidOrgKey(pRequest);
        }
        
        public Epi.Web.Common.Message.PublishResponse RePublishSurvey(Epi.Web.Common.Message.PublishRequest pRequestMessage) {
            return base.Channel.RePublishSurvey(pRequestMessage);
        }
        
        public Epi.Web.Common.Message.PreFilledAnswerResponse SetSurveyAnswer(Epi.Web.Common.Message.PreFilledAnswerRequest pRequestMessage) {
            return base.Channel.SetSurveyAnswer(pRequestMessage);
        }
        
        public Epi.Web.Common.Message.SurveyControlsResponse GetSurveyControlList(Epi.Web.Common.Message.SurveyControlsRequest pRequestMessage) {
            return base.Channel.GetSurveyControlList(pRequestMessage);
        }
    }
}
