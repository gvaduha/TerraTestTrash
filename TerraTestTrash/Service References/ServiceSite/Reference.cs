﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.17929
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test_I102.ServiceSite {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceSite.BadReq", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceSite")]
    [System.SerializableAttribute()]
    public partial class ServiceSiteBadReq : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorIntoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsEndField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsIntoOkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberStepField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string formIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string hostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string productCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string productTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string requestField;
        
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
        public string ErrorInto {
            get {
                return this.ErrorIntoField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorIntoField, value) != true)) {
                    this.ErrorIntoField = value;
                    this.RaisePropertyChanged("ErrorInto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsEnd {
            get {
                return this.IsEndField;
            }
            set {
                if ((this.IsEndField.Equals(value) != true)) {
                    this.IsEndField = value;
                    this.RaisePropertyChanged("IsEnd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsIntoOk {
            get {
                return this.IsIntoOkField;
            }
            set {
                if ((this.IsIntoOkField.Equals(value) != true)) {
                    this.IsIntoOkField = value;
                    this.RaisePropertyChanged("IsIntoOk");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumberStep {
            get {
                return this.NumberStepField;
            }
            set {
                if ((this.NumberStepField.Equals(value) != true)) {
                    this.NumberStepField = value;
                    this.RaisePropertyChanged("NumberStep");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                if ((this.dateField.Equals(value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string formID {
            get {
                return this.formIDField;
            }
            set {
                if ((object.ReferenceEquals(this.formIDField, value) != true)) {
                    this.formIDField = value;
                    this.RaisePropertyChanged("formID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string host {
            get {
                return this.hostField;
            }
            set {
                if ((object.ReferenceEquals(this.hostField, value) != true)) {
                    this.hostField = value;
                    this.RaisePropertyChanged("host");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.phoneNumberField, value) != true)) {
                    this.phoneNumberField = value;
                    this.RaisePropertyChanged("phoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string productCode {
            get {
                return this.productCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.productCodeField, value) != true)) {
                    this.productCodeField = value;
                    this.RaisePropertyChanged("productCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string productType {
            get {
                return this.productTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.productTypeField, value) != true)) {
                    this.productTypeField = value;
                    this.RaisePropertyChanged("productType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string request {
            get {
                return this.requestField;
            }
            set {
                if ((object.ReferenceEquals(this.requestField, value) != true)) {
                    this.requestField = value;
                    this.RaisePropertyChanged("request");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceSite.ResulService", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceSite")]
    [System.SerializableAttribute()]
    public partial class ServiceSiteResulService : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public bool IsError {
            get {
                return this.IsErrorField;
            }
            set {
                if ((this.IsErrorField.Equals(value) != true)) {
                    this.IsErrorField = value;
                    this.RaisePropertyChanged("IsError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceSite.Currency", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceSite")]
    [System.SerializableAttribute()]
    public partial class ServiceSiteCurrency : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceBuyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> PriceCBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceSaleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double SumField;
        
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
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PriceBuy {
            get {
                return this.PriceBuyField;
            }
            set {
                if ((this.PriceBuyField.Equals(value) != true)) {
                    this.PriceBuyField = value;
                    this.RaisePropertyChanged("PriceBuy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> PriceCB {
            get {
                return this.PriceCBField;
            }
            set {
                if ((this.PriceCBField.Equals(value) != true)) {
                    this.PriceCBField = value;
                    this.RaisePropertyChanged("PriceCB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PriceSale {
            get {
                return this.PriceSaleField;
            }
            set {
                if ((this.PriceSaleField.Equals(value) != true)) {
                    this.PriceSaleField = value;
                    this.RaisePropertyChanged("PriceSale");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Sum {
            get {
                return this.SumField;
            }
            set {
                if ((this.SumField.Equals(value) != true)) {
                    this.SumField = value;
                    this.RaisePropertyChanged("Sum");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceSite.ServiceSite")]
    public interface ServiceSite {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceSite/BadRequest1", ReplyAction="http://tempuri.org/ServiceSite/BadRequest1Response")]
        bool BadRequest1();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceSite/BadRequest1", ReplyAction="http://tempuri.org/ServiceSite/BadRequest1Response")]
        System.Threading.Tasks.Task<bool> BadRequest1Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceSite/BadRequest", ReplyAction="http://tempuri.org/ServiceSite/BadRequestResponse")]
        bool BadRequest(string password, Test_I102.ServiceSite.ServiceSiteBadReq badReq);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceSite/BadRequest", ReplyAction="http://tempuri.org/ServiceSite/BadRequestResponse")]
        System.Threading.Tasks.Task<bool> BadRequestAsync(string password, Test_I102.ServiceSite.ServiceSiteBadReq badReq);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceSite/SMSSend", ReplyAction="http://tempuri.org/ServiceSite/SMSSendResponse")]
        Test_I102.ServiceSite.ServiceSiteResulService SMSSend(string password, string hostUrl, string phone, string code, string productType, string productCode, string formID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceSite/SMSSend", ReplyAction="http://tempuri.org/ServiceSite/SMSSendResponse")]
        System.Threading.Tasks.Task<Test_I102.ServiceSite.ServiceSiteResulService> SMSSendAsync(string password, string hostUrl, string phone, string code, string productType, string productCode, string formID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceSite/GetCurrency", ReplyAction="http://tempuri.org/ServiceSite/GetCurrencyResponse")]
        Test_I102.ServiceSite.ServiceSiteCurrency[] GetCurrency(string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceSite/GetCurrency", ReplyAction="http://tempuri.org/ServiceSite/GetCurrencyResponse")]
        System.Threading.Tasks.Task<Test_I102.ServiceSite.ServiceSiteCurrency[]> GetCurrencyAsync(string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSiteChannel : Test_I102.ServiceSite.ServiceSite, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSiteClient : System.ServiceModel.ClientBase<Test_I102.ServiceSite.ServiceSite>, Test_I102.ServiceSite.ServiceSite {
        
        public ServiceSiteClient() {
        }
        
        public ServiceSiteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSiteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSiteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSiteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool BadRequest1() {
            return base.Channel.BadRequest1();
        }
        
        public System.Threading.Tasks.Task<bool> BadRequest1Async() {
            return base.Channel.BadRequest1Async();
        }
        
        public bool BadRequest(string password, Test_I102.ServiceSite.ServiceSiteBadReq badReq) {
            return base.Channel.BadRequest(password, badReq);
        }
        
        public System.Threading.Tasks.Task<bool> BadRequestAsync(string password, Test_I102.ServiceSite.ServiceSiteBadReq badReq) {
            return base.Channel.BadRequestAsync(password, badReq);
        }
        
        public Test_I102.ServiceSite.ServiceSiteResulService SMSSend(string password, string hostUrl, string phone, string code, string productType, string productCode, string formID) {
            return base.Channel.SMSSend(password, hostUrl, phone, code, productType, productCode, formID);
        }
        
        public System.Threading.Tasks.Task<Test_I102.ServiceSite.ServiceSiteResulService> SMSSendAsync(string password, string hostUrl, string phone, string code, string productType, string productCode, string formID) {
            return base.Channel.SMSSendAsync(password, hostUrl, phone, code, productType, productCode, formID);
        }
        
        public Test_I102.ServiceSite.ServiceSiteCurrency[] GetCurrency(string password) {
            return base.Channel.GetCurrency(password);
        }
        
        public System.Threading.Tasks.Task<Test_I102.ServiceSite.ServiceSiteCurrency[]> GetCurrencyAsync(string password) {
            return base.Channel.GetCurrencyAsync(password);
        }
    }
}