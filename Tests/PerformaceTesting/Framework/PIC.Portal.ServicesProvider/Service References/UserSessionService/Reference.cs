﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIC.Portal.ServicesProvider.UserSessionService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserSessionService.IUserSessionService", SessionMode=System.ServiceModel.SessionMode.NotAllowed)]
    public interface IUserSessionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/ExecuteService", ReplyAction="http://tempuri.org/IWCFService/ExecuteServiceResponse")]
        byte[] ExecuteService(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/ExecuteService", ReplyAction="http://tempuri.org/IWCFService/ExecuteServiceResponse")]
        System.Threading.Tasks.Task<byte[]> ExecuteServiceAsync(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/CheckUserSession", ReplyAction="http://tempuri.org/IUserSessionService/CheckUserSessionResponse")]
        bool CheckUserSession(string sessionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/CheckUserSession", ReplyAction="http://tempuri.org/IUserSessionService/CheckUserSessionResponse")]
        System.Threading.Tasks.Task<bool> CheckUserSessionAsync(string sessionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/ReleaseSession", ReplyAction="http://tempuri.org/IUserSessionService/ReleaseSessionResponse")]
        bool ReleaseSession(string sessionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/ReleaseSession", ReplyAction="http://tempuri.org/IUserSessionService/ReleaseSessionResponse")]
        System.Threading.Tasks.Task<bool> ReleaseSessionAsync(string sessionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/AuthenticateUser", ReplyAction="http://tempuri.org/IUserSessionService/AuthenticateUserResponse")]
        string AuthenticateUser(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/AuthenticateUser", ReplyAction="http://tempuri.org/IUserSessionService/AuthenticateUserResponse")]
        System.Threading.Tasks.Task<string> AuthenticateUserAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/SetPrepRelease", ReplyAction="http://tempuri.org/IUserSessionService/SetPrepReleaseResponse")]
        bool SetPrepRelease(string sessionID, PIC.Common.Authentication.LoginTypeEnum logMode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/SetPrepRelease", ReplyAction="http://tempuri.org/IUserSessionService/SetPrepReleaseResponse")]
        System.Threading.Tasks.Task<bool> SetPrepReleaseAsync(string sessionID, PIC.Common.Authentication.LoginTypeEnum logMode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/RefreshSession", ReplyAction="http://tempuri.org/IUserSessionService/RefreshSessionResponse")]
        bool RefreshSession(string sessionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/RefreshSession", ReplyAction="http://tempuri.org/IUserSessionService/RefreshSessionResponse")]
        System.Threading.Tasks.Task<bool> RefreshSessionAsync(string sessionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/GetUserData", ReplyAction="http://tempuri.org/IUserSessionService/GetUserDataResponse")]
        byte[] GetUserData(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/GetUserData", ReplyAction="http://tempuri.org/IUserSessionService/GetUserDataResponse")]
        System.Threading.Tasks.Task<byte[]> GetUserDataAsync(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/GetSystemData", ReplyAction="http://tempuri.org/IUserSessionService/GetSystemDataResponse")]
        byte[] GetSystemData(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSessionService/GetSystemData", ReplyAction="http://tempuri.org/IUserSessionService/GetSystemDataResponse")]
        System.Threading.Tasks.Task<byte[]> GetSystemDataAsync(string msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserSessionServiceChannel : PIC.Portal.ServicesProvider.UserSessionService.IUserSessionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserSessionServiceClient : System.ServiceModel.ClientBase<PIC.Portal.ServicesProvider.UserSessionService.IUserSessionService>, PIC.Portal.ServicesProvider.UserSessionService.IUserSessionService {
        
        public UserSessionServiceClient() {
        }
        
        public UserSessionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserSessionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserSessionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserSessionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public byte[] ExecuteService(string msg) {
            return base.Channel.ExecuteService(msg);
        }
        
        public System.Threading.Tasks.Task<byte[]> ExecuteServiceAsync(string msg) {
            return base.Channel.ExecuteServiceAsync(msg);
        }
        
        public bool CheckUserSession(string sessionID) {
            return base.Channel.CheckUserSession(sessionID);
        }
        
        public System.Threading.Tasks.Task<bool> CheckUserSessionAsync(string sessionID) {
            return base.Channel.CheckUserSessionAsync(sessionID);
        }
        
        public bool ReleaseSession(string sessionID) {
            return base.Channel.ReleaseSession(sessionID);
        }
        
        public System.Threading.Tasks.Task<bool> ReleaseSessionAsync(string sessionID) {
            return base.Channel.ReleaseSessionAsync(sessionID);
        }
        
        public string AuthenticateUser(string message) {
            return base.Channel.AuthenticateUser(message);
        }
        
        public System.Threading.Tasks.Task<string> AuthenticateUserAsync(string message) {
            return base.Channel.AuthenticateUserAsync(message);
        }
        
        public bool SetPrepRelease(string sessionID, PIC.Common.Authentication.LoginTypeEnum logMode) {
            return base.Channel.SetPrepRelease(sessionID, logMode);
        }
        
        public System.Threading.Tasks.Task<bool> SetPrepReleaseAsync(string sessionID, PIC.Common.Authentication.LoginTypeEnum logMode) {
            return base.Channel.SetPrepReleaseAsync(sessionID, logMode);
        }
        
        public bool RefreshSession(string sessionID) {
            return base.Channel.RefreshSession(sessionID);
        }
        
        public System.Threading.Tasks.Task<bool> RefreshSessionAsync(string sessionID) {
            return base.Channel.RefreshSessionAsync(sessionID);
        }
        
        public byte[] GetUserData(string msg) {
            return base.Channel.GetUserData(msg);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetUserDataAsync(string msg) {
            return base.Channel.GetUserDataAsync(msg);
        }
        
        public byte[] GetSystemData(string msg) {
            return base.Channel.GetSystemData(msg);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetSystemDataAsync(string msg) {
            return base.Channel.GetSystemDataAsync(msg);
        }
    }
}