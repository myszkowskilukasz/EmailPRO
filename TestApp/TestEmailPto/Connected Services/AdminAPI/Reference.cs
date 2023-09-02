﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEmailPto.AdminAPI {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WcfTestProject")]
    [System.SerializableAttribute()]
    public partial class User : TestEmailPto.AdminAPI.DBObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsActive {
            get {
                return this.IsActiveField;
            }
            set {
                if ((this.IsActiveField.Equals(value) != true)) {
                    this.IsActiveField = value;
                    this.RaisePropertyChanged("IsActive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DBObject", Namespace="http://schemas.datacontract.org/2004/07/WcfTestProject")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestEmailPto.AdminAPI.User))]
    public partial class DBObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdminAPI.IAdminService")]
    public interface IAdminService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAllUsers", ReplyAction="http://tempuri.org/IAdminService/GetAllUsersResponse")]
        TestEmailPto.AdminAPI.User[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAllUsers", ReplyAction="http://tempuri.org/IAdminService/GetAllUsersResponse")]
        System.Threading.Tasks.Task<TestEmailPto.AdminAPI.User[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetUserById", ReplyAction="http://tempuri.org/IAdminService/GetUserByIdResponse")]
        TestEmailPto.AdminAPI.User GetUserById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetUserById", ReplyAction="http://tempuri.org/IAdminService/GetUserByIdResponse")]
        System.Threading.Tasks.Task<TestEmailPto.AdminAPI.User> GetUserByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetUserByUsername", ReplyAction="http://tempuri.org/IAdminService/GetUserByUsernameResponse")]
        TestEmailPto.AdminAPI.User GetUserByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetUserByUsername", ReplyAction="http://tempuri.org/IAdminService/GetUserByUsernameResponse")]
        System.Threading.Tasks.Task<TestEmailPto.AdminAPI.User> GetUserByUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/UpdateUser", ReplyAction="http://tempuri.org/IAdminService/UpdateUserResponse")]
        void UpdateUser(TestEmailPto.AdminAPI.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/UpdateUser", ReplyAction="http://tempuri.org/IAdminService/UpdateUserResponse")]
        System.Threading.Tasks.Task UpdateUserAsync(TestEmailPto.AdminAPI.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/DeleteUser", ReplyAction="http://tempuri.org/IAdminService/DeleteUserResponse")]
        void DeleteUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/DeleteUser", ReplyAction="http://tempuri.org/IAdminService/DeleteUserResponse")]
        System.Threading.Tasks.Task DeleteUserAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdminServiceChannel : TestEmailPto.AdminAPI.IAdminService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminServiceClient : System.ServiceModel.ClientBase<TestEmailPto.AdminAPI.IAdminService>, TestEmailPto.AdminAPI.IAdminService {
        
        public AdminServiceClient() {
        }
        
        public AdminServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestEmailPto.AdminAPI.User[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<TestEmailPto.AdminAPI.User[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
        
        public TestEmailPto.AdminAPI.User GetUserById(int id) {
            return base.Channel.GetUserById(id);
        }
        
        public System.Threading.Tasks.Task<TestEmailPto.AdminAPI.User> GetUserByIdAsync(int id) {
            return base.Channel.GetUserByIdAsync(id);
        }
        
        public TestEmailPto.AdminAPI.User GetUserByUsername(string username) {
            return base.Channel.GetUserByUsername(username);
        }
        
        public System.Threading.Tasks.Task<TestEmailPto.AdminAPI.User> GetUserByUsernameAsync(string username) {
            return base.Channel.GetUserByUsernameAsync(username);
        }
        
        public void UpdateUser(TestEmailPto.AdminAPI.User user) {
            base.Channel.UpdateUser(user);
        }
        
        public System.Threading.Tasks.Task UpdateUserAsync(TestEmailPto.AdminAPI.User user) {
            return base.Channel.UpdateUserAsync(user);
        }
        
        public void DeleteUser(int id) {
            base.Channel.DeleteUser(id);
        }
        
        public System.Threading.Tasks.Task DeleteUserAsync(int id) {
            return base.Channel.DeleteUserAsync(id);
        }
    }
}
