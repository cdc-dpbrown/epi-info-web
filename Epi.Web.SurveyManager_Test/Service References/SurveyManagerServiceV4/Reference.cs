﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Epi.Web.SurveyManager.Client.SurveyManagerServiceV4 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HttpPostedFileBase", Namespace="http://schemas.datacontract.org/2004/07/System.Web")]
    [System.SerializableAttribute()]
    public partial class HttpPostedFileBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SurveyManagerServiceV4.IManagerServiceV4")]
    public interface IManagerServiceV4 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/PublishSurvey", ReplyAction="http://tempuri.org/IManagerService/PublishSurveyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/PublishSurveyCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.PublishResponse PublishSurvey(Epi.Web.Common.Message.PublishRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/PublishSurvey", ReplyAction="http://tempuri.org/IManagerService/PublishSurveyResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.PublishResponse> PublishSurveyAsync(Epi.Web.Common.Message.PublishRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetSurveyInfo", ReplyAction="http://tempuri.org/IManagerService/GetSurveyInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetSurveyInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyInfoResponse GetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetSurveyInfo", ReplyAction="http://tempuri.org/IManagerService/GetSurveyInfoResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyInfoResponse> GetSurveyInfoAsync(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetOrganization", ReplyAction="http://tempuri.org/IManagerService/GetOrganizationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetOrganizationCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse GetOrganization(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetOrganization", ReplyAction="http://tempuri.org/IManagerService/GetOrganizationResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationResponse> GetOrganizationAsync(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetOrganizationInfo", ReplyAction="http://tempuri.org/IManagerService/GetOrganizationInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetOrganizationInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse GetOrganizationInfo(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetOrganizationInfo", ReplyAction="http://tempuri.org/IManagerService/GetOrganizationInfoResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationResponse> GetOrganizationInfoAsync(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetOrganizationNames", ReplyAction="http://tempuri.org/IManagerService/GetOrganizationNamesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetOrganizationNamesCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse GetOrganizationNames(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetOrganizationNames", ReplyAction="http://tempuri.org/IManagerService/GetOrganizationNamesResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationResponse> GetOrganizationNamesAsync(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetOrganizationByKey", ReplyAction="http://tempuri.org/IManagerService/GetOrganizationByKeyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetOrganizationByKeyCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse GetOrganizationByKey(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetOrganizationByKey", ReplyAction="http://tempuri.org/IManagerService/GetOrganizationByKeyResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationResponse> GetOrganizationByKeyAsync(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/SetSurveyInfo", ReplyAction="http://tempuri.org/IManagerService/SetSurveyInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/SetSurveyInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyInfoResponse SetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/SetSurveyInfo", ReplyAction="http://tempuri.org/IManagerService/SetSurveyInfoResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyInfoResponse> SetSurveyInfoAsync(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetSurveyAnswer", ReplyAction="http://tempuri.org/IManagerService/GetSurveyAnswerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetSurveyAnswerCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetSurveyAnswer", ReplyAction="http://tempuri.org/IManagerService/GetSurveyAnswerResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> GetSurveyAnswerAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/SetOrganization", ReplyAction="http://tempuri.org/IManagerService/SetOrganizationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/SetOrganizationCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse SetOrganization(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/SetOrganization", ReplyAction="http://tempuri.org/IManagerService/SetOrganizationResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationResponse> SetOrganizationAsync(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/UpdateOrganizationInfo", ReplyAction="http://tempuri.org/IManagerService/UpdateOrganizationInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/UpdateOrganizationInfoCustomFaultExceptionFaul" +
            "t", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse UpdateOrganizationInfo(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/UpdateOrganizationInfo", ReplyAction="http://tempuri.org/IManagerService/UpdateOrganizationInfoResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationResponse> UpdateOrganizationInfoAsync(Epi.Web.Common.Message.OrganizationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/IsValidOrgKey", ReplyAction="http://tempuri.org/IManagerService/IsValidOrgKeyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/IsValidOrgKeyCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        bool IsValidOrgKey(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/IsValidOrgKey", ReplyAction="http://tempuri.org/IManagerService/IsValidOrgKeyResponse")]
        System.Threading.Tasks.Task<bool> IsValidOrgKeyAsync(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/RePublishSurvey", ReplyAction="http://tempuri.org/IManagerService/RePublishSurveyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/RePublishSurveyCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.PublishResponse RePublishSurvey(Epi.Web.Common.Message.PublishRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/RePublishSurvey", ReplyAction="http://tempuri.org/IManagerService/RePublishSurveyResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.PublishResponse> RePublishSurveyAsync(Epi.Web.Common.Message.PublishRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV2/SetSurveyAnswer", ReplyAction="http://tempuri.org/IManagerServiceV2/SetSurveyAnswerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV2/SetSurveyAnswerCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.PreFilledAnswerResponse SetSurveyAnswer(Epi.Web.Common.Message.PreFilledAnswerRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV2/SetSurveyAnswer", ReplyAction="http://tempuri.org/IManagerServiceV2/SetSurveyAnswerResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.PreFilledAnswerResponse> SetSurveyAnswerAsync(Epi.Web.Common.Message.PreFilledAnswerRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV2/GetSurveyControlList", ReplyAction="http://tempuri.org/IManagerServiceV2/GetSurveyControlListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV2/GetSurveyControlListCustomFaultExceptionFaul" +
            "t", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyControlsResponse GetSurveyControlList(Epi.Web.Common.Message.SurveyControlsRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV2/GetSurveyControlList", ReplyAction="http://tempuri.org/IManagerServiceV2/GetSurveyControlListResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyControlsResponse> GetSurveyControlListAsync(Epi.Web.Common.Message.SurveyControlsRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV3/UpdateRecordStatus", ReplyAction="http://tempuri.org/IManagerServiceV3/UpdateRecordStatusResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV3/UpdateRecordStatusCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        void UpdateRecordStatus(Epi.Web.Common.Message.SurveyAnswerRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV3/UpdateRecordStatus", ReplyAction="http://tempuri.org/IManagerServiceV3/UpdateRecordStatusResponse")]
        System.Threading.Tasks.Task UpdateRecordStatusAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/ValidateOrganization", ReplyAction="http://tempuri.org/IManagerServiceV4/ValidateOrganizationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV4/ValidateOrganizationCustomFaultExceptionFaul" +
            "t", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        bool ValidateOrganization(Epi.Web.Common.Message.OrganizationRequest Request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/ValidateOrganization", ReplyAction="http://tempuri.org/IManagerServiceV4/ValidateOrganizationResponse")]
        System.Threading.Tasks.Task<bool> ValidateOrganizationAsync(Epi.Web.Common.Message.OrganizationRequest Request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/GetAllSurveysByOrgKey", ReplyAction="http://tempuri.org/IManagerServiceV4/GetAllSurveysByOrgKeyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV4/GetAllSurveysByOrgKeyCustomFaultExceptionFau" +
            "lt", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyInfoResponse GetAllSurveysByOrgKey(string OrgKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/GetAllSurveysByOrgKey", ReplyAction="http://tempuri.org/IManagerServiceV4/GetAllSurveysByOrgKeyResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyInfoResponse> GetAllSurveysByOrgKeyAsync(string OrgKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/SetJsonColumn", ReplyAction="http://tempuri.org/IManagerServiceV4/SetJsonColumnResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV4/SetJsonColumnCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        string SetJsonColumn(string[] SurveyIds, string OrgId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/SetJsonColumn", ReplyAction="http://tempuri.org/IManagerServiceV4/SetJsonColumnResponse")]
        System.Threading.Tasks.Task<string> SetJsonColumnAsync(string[] SurveyIds, string OrgId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/SetJsonColumnAll", ReplyAction="http://tempuri.org/IManagerServiceV4/SetJsonColumnAllResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV4/SetJsonColumnAllCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        string SetJsonColumnAll(string AdminKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/SetJsonColumnAll", ReplyAction="http://tempuri.org/IManagerServiceV4/SetJsonColumnAllResponse")]
        System.Threading.Tasks.Task<string> SetJsonColumnAllAsync(string AdminKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/GetLoginToken", ReplyAction="http://tempuri.org/IManagerServiceV4/GetLoginTokenResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV4/GetLoginTokenCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.UserResponse GetLoginToken(Epi.Web.Common.Message.UserRequest UserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/GetLoginToken", ReplyAction="http://tempuri.org/IManagerServiceV4/GetLoginTokenResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.UserResponse> GetLoginTokenAsync(Epi.Web.Common.Message.UserRequest UserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/SetUserInfo", ReplyAction="http://tempuri.org/IManagerServiceV4/SetUserInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV4/SetUserInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        bool SetUserInfo(Epi.Web.Common.Message.UserRequest UserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/SetUserInfo", ReplyAction="http://tempuri.org/IManagerServiceV4/SetUserInfoResponse")]
        System.Threading.Tasks.Task<bool> SetUserInfoAsync(Epi.Web.Common.Message.UserRequest UserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/GetExistingUser", ReplyAction="http://tempuri.org/IManagerServiceV4/GetExistingUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV4/GetExistingUserCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        bool GetExistingUser(Epi.Web.Common.Message.UserRequest UserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/GetExistingUser", ReplyAction="http://tempuri.org/IManagerServiceV4/GetExistingUserResponse")]
        System.Threading.Tasks.Task<bool> GetExistingUserAsync(Epi.Web.Common.Message.UserRequest UserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/GetUserListByOrganization", ReplyAction="http://tempuri.org/IManagerServiceV4/GetUserListByOrganizationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV4/GetUserListByOrganizationCustomFaultExceptio" +
            "nFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.UserResponse GetUserListByOrganization(Epi.Web.Common.Message.UserRequest UserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/GetUserListByOrganization", ReplyAction="http://tempuri.org/IManagerServiceV4/GetUserListByOrganizationResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.UserResponse> GetUserListByOrganizationAsync(Epi.Web.Common.Message.UserRequest UserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/DeleteUser", ReplyAction="http://tempuri.org/IManagerServiceV4/DeleteUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV4/DeleteUserCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        bool DeleteUser(Epi.Web.Common.Message.UserRequest UserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/DeleteUser", ReplyAction="http://tempuri.org/IManagerServiceV4/DeleteUserResponse")]
        System.Threading.Tasks.Task<bool> DeleteUserAsync(Epi.Web.Common.Message.UserRequest UserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/UpdateUserInfo", ReplyAction="http://tempuri.org/IManagerServiceV4/UpdateUserInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV4/UpdateUserInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        bool UpdateUserInfo(Epi.Web.Common.Message.UserRequest UserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/UpdateUserInfo", ReplyAction="http://tempuri.org/IManagerServiceV4/UpdateUserInfoResponse")]
        System.Threading.Tasks.Task<bool> UpdateUserInfoAsync(Epi.Web.Common.Message.UserRequest UserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/GetUserByUserId", ReplyAction="http://tempuri.org/IManagerServiceV4/GetUserByUserIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerServiceV4/GetUserByUserIdCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.UserResponse GetUserByUserId(Epi.Web.Common.Message.UserRequest UserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerServiceV4/GetUserByUserId", ReplyAction="http://tempuri.org/IManagerServiceV4/GetUserByUserIdResponse")]
        System.Threading.Tasks.Task<Epi.Web.Common.Message.UserResponse> GetUserByUserIdAsync(Epi.Web.Common.Message.UserRequest UserInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IManagerServiceV4Channel : Epi.Web.SurveyManager.Client.SurveyManagerServiceV4.IManagerServiceV4, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ManagerServiceV4Client : System.ServiceModel.ClientBase<Epi.Web.SurveyManager.Client.SurveyManagerServiceV4.IManagerServiceV4>, Epi.Web.SurveyManager.Client.SurveyManagerServiceV4.IManagerServiceV4 {
        
        public ManagerServiceV4Client() {
        }
        
        public ManagerServiceV4Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ManagerServiceV4Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagerServiceV4Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagerServiceV4Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Epi.Web.Common.Message.PublishResponse PublishSurvey(Epi.Web.Common.Message.PublishRequest pRequestMessage) {
            return base.Channel.PublishSurvey(pRequestMessage);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.PublishResponse> PublishSurveyAsync(Epi.Web.Common.Message.PublishRequest pRequestMessage) {
            return base.Channel.PublishSurveyAsync(pRequestMessage);
        }
        
        public Epi.Web.Common.Message.SurveyInfoResponse GetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.GetSurveyInfo(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyInfoResponse> GetSurveyInfoAsync(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.GetSurveyInfoAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationResponse GetOrganization(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.GetOrganization(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationResponse> GetOrganizationAsync(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.GetOrganizationAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationResponse GetOrganizationInfo(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.GetOrganizationInfo(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationResponse> GetOrganizationInfoAsync(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.GetOrganizationInfoAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationResponse GetOrganizationNames(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.GetOrganizationNames(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationResponse> GetOrganizationNamesAsync(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.GetOrganizationNamesAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationResponse GetOrganizationByKey(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.GetOrganizationByKey(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationResponse> GetOrganizationByKeyAsync(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.GetOrganizationByKeyAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyInfoResponse SetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.SetSurveyInfo(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyInfoResponse> SetSurveyInfoAsync(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.SetSurveyInfoAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetSurveyAnswer(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyAnswerResponse> GetSurveyAnswerAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetSurveyAnswerAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationResponse SetOrganization(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.SetOrganization(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationResponse> SetOrganizationAsync(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.SetOrganizationAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.OrganizationResponse UpdateOrganizationInfo(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.UpdateOrganizationInfo(pRequest);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.OrganizationResponse> UpdateOrganizationInfoAsync(Epi.Web.Common.Message.OrganizationRequest pRequest) {
            return base.Channel.UpdateOrganizationInfoAsync(pRequest);
        }
        
        public bool IsValidOrgKey(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.IsValidOrgKey(pRequest);
        }
        
        public System.Threading.Tasks.Task<bool> IsValidOrgKeyAsync(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.IsValidOrgKeyAsync(pRequest);
        }
        
        public Epi.Web.Common.Message.PublishResponse RePublishSurvey(Epi.Web.Common.Message.PublishRequest pRequestMessage) {
            return base.Channel.RePublishSurvey(pRequestMessage);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.PublishResponse> RePublishSurveyAsync(Epi.Web.Common.Message.PublishRequest pRequestMessage) {
            return base.Channel.RePublishSurveyAsync(pRequestMessage);
        }
        
        public Epi.Web.Common.Message.PreFilledAnswerResponse SetSurveyAnswer(Epi.Web.Common.Message.PreFilledAnswerRequest pRequestMessage) {
            return base.Channel.SetSurveyAnswer(pRequestMessage);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.PreFilledAnswerResponse> SetSurveyAnswerAsync(Epi.Web.Common.Message.PreFilledAnswerRequest pRequestMessage) {
            return base.Channel.SetSurveyAnswerAsync(pRequestMessage);
        }
        
        public Epi.Web.Common.Message.SurveyControlsResponse GetSurveyControlList(Epi.Web.Common.Message.SurveyControlsRequest pRequestMessage) {
            return base.Channel.GetSurveyControlList(pRequestMessage);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyControlsResponse> GetSurveyControlListAsync(Epi.Web.Common.Message.SurveyControlsRequest pRequestMessage) {
            return base.Channel.GetSurveyControlListAsync(pRequestMessage);
        }
        
        public void UpdateRecordStatus(Epi.Web.Common.Message.SurveyAnswerRequest pRequestMessage) {
            base.Channel.UpdateRecordStatus(pRequestMessage);
        }
        
        public System.Threading.Tasks.Task UpdateRecordStatusAsync(Epi.Web.Common.Message.SurveyAnswerRequest pRequestMessage) {
            return base.Channel.UpdateRecordStatusAsync(pRequestMessage);
        }
        
        public bool ValidateOrganization(Epi.Web.Common.Message.OrganizationRequest Request) {
            return base.Channel.ValidateOrganization(Request);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateOrganizationAsync(Epi.Web.Common.Message.OrganizationRequest Request) {
            return base.Channel.ValidateOrganizationAsync(Request);
        }
        
        public Epi.Web.Common.Message.SurveyInfoResponse GetAllSurveysByOrgKey(string OrgKey) {
            return base.Channel.GetAllSurveysByOrgKey(OrgKey);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.SurveyInfoResponse> GetAllSurveysByOrgKeyAsync(string OrgKey) {
            return base.Channel.GetAllSurveysByOrgKeyAsync(OrgKey);
        }
        
        public string SetJsonColumn(string[] SurveyIds, string OrgId) {
            return base.Channel.SetJsonColumn(SurveyIds, OrgId);
        }
        
        public System.Threading.Tasks.Task<string> SetJsonColumnAsync(string[] SurveyIds, string OrgId) {
            return base.Channel.SetJsonColumnAsync(SurveyIds, OrgId);
        }
        
        public string SetJsonColumnAll(string AdminKey) {
            return base.Channel.SetJsonColumnAll(AdminKey);
        }
        
        public System.Threading.Tasks.Task<string> SetJsonColumnAllAsync(string AdminKey) {
            return base.Channel.SetJsonColumnAllAsync(AdminKey);
        }
        
        public Epi.Web.Common.Message.UserResponse GetLoginToken(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.GetLoginToken(UserInfo);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.UserResponse> GetLoginTokenAsync(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.GetLoginTokenAsync(UserInfo);
        }
        
        public bool SetUserInfo(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.SetUserInfo(UserInfo);
        }
        
        public System.Threading.Tasks.Task<bool> SetUserInfoAsync(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.SetUserInfoAsync(UserInfo);
        }
        
        public bool GetExistingUser(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.GetExistingUser(UserInfo);
        }
        
        public System.Threading.Tasks.Task<bool> GetExistingUserAsync(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.GetExistingUserAsync(UserInfo);
        }
        
        public Epi.Web.Common.Message.UserResponse GetUserListByOrganization(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.GetUserListByOrganization(UserInfo);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.UserResponse> GetUserListByOrganizationAsync(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.GetUserListByOrganizationAsync(UserInfo);
        }
        
        public bool DeleteUser(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.DeleteUser(UserInfo);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteUserAsync(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.DeleteUserAsync(UserInfo);
        }
        
        public bool UpdateUserInfo(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.UpdateUserInfo(UserInfo);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserInfoAsync(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.UpdateUserInfoAsync(UserInfo);
        }
        
        public Epi.Web.Common.Message.UserResponse GetUserByUserId(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.GetUserByUserId(UserInfo);
        }
        
        public System.Threading.Tasks.Task<Epi.Web.Common.Message.UserResponse> GetUserByUserIdAsync(Epi.Web.Common.Message.UserRequest UserInfo) {
            return base.Channel.GetUserByUserIdAsync(UserInfo);
        }
    }
}
