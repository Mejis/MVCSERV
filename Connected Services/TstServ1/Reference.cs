﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCServis.TstServ1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="B_TBL_HASTANELER", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class B_TBL_HASTANELER : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HKODUField;
        
        private System.Nullable<int> HGRUPIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HADIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HCARIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HSEHIRField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HBOLGEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HADRESField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HDEPARTMAN1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HDEPARTMAN2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HDEPARTMAN3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HYETKILI1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HYETKILI2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HYETKILI3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HTEL1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HTEL2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HTEL3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HEMAIL1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HEMAIL2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HEMAIL3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HFAKS1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HFAKS2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HFAKS3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HCEP1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HCEP2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HCEP3Field;
        
        private System.Nullable<int> HSAVEUSERField;
        
        private System.Nullable<System.DateTime> HSAVEDATEField;
        
        private System.Nullable<int> HEDITUSERField;
        
        private System.Nullable<System.DateTime> HEDITDATEField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string HKODU {
            get {
                return this.HKODUField;
            }
            set {
                if ((object.ReferenceEquals(this.HKODUField, value) != true)) {
                    this.HKODUField = value;
                    this.RaisePropertyChanged("HKODU");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<int> HGRUPID {
            get {
                return this.HGRUPIDField;
            }
            set {
                if ((this.HGRUPIDField.Equals(value) != true)) {
                    this.HGRUPIDField = value;
                    this.RaisePropertyChanged("HGRUPID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string HADI {
            get {
                return this.HADIField;
            }
            set {
                if ((object.ReferenceEquals(this.HADIField, value) != true)) {
                    this.HADIField = value;
                    this.RaisePropertyChanged("HADI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string HCARI {
            get {
                return this.HCARIField;
            }
            set {
                if ((object.ReferenceEquals(this.HCARIField, value) != true)) {
                    this.HCARIField = value;
                    this.RaisePropertyChanged("HCARI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string HSEHIR {
            get {
                return this.HSEHIRField;
            }
            set {
                if ((object.ReferenceEquals(this.HSEHIRField, value) != true)) {
                    this.HSEHIRField = value;
                    this.RaisePropertyChanged("HSEHIR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string HBOLGE {
            get {
                return this.HBOLGEField;
            }
            set {
                if ((object.ReferenceEquals(this.HBOLGEField, value) != true)) {
                    this.HBOLGEField = value;
                    this.RaisePropertyChanged("HBOLGE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string HADRES {
            get {
                return this.HADRESField;
            }
            set {
                if ((object.ReferenceEquals(this.HADRESField, value) != true)) {
                    this.HADRESField = value;
                    this.RaisePropertyChanged("HADRES");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string HDEPARTMAN1 {
            get {
                return this.HDEPARTMAN1Field;
            }
            set {
                if ((object.ReferenceEquals(this.HDEPARTMAN1Field, value) != true)) {
                    this.HDEPARTMAN1Field = value;
                    this.RaisePropertyChanged("HDEPARTMAN1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string HDEPARTMAN2 {
            get {
                return this.HDEPARTMAN2Field;
            }
            set {
                if ((object.ReferenceEquals(this.HDEPARTMAN2Field, value) != true)) {
                    this.HDEPARTMAN2Field = value;
                    this.RaisePropertyChanged("HDEPARTMAN2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string HDEPARTMAN3 {
            get {
                return this.HDEPARTMAN3Field;
            }
            set {
                if ((object.ReferenceEquals(this.HDEPARTMAN3Field, value) != true)) {
                    this.HDEPARTMAN3Field = value;
                    this.RaisePropertyChanged("HDEPARTMAN3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string HYETKILI1 {
            get {
                return this.HYETKILI1Field;
            }
            set {
                if ((object.ReferenceEquals(this.HYETKILI1Field, value) != true)) {
                    this.HYETKILI1Field = value;
                    this.RaisePropertyChanged("HYETKILI1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string HYETKILI2 {
            get {
                return this.HYETKILI2Field;
            }
            set {
                if ((object.ReferenceEquals(this.HYETKILI2Field, value) != true)) {
                    this.HYETKILI2Field = value;
                    this.RaisePropertyChanged("HYETKILI2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public string HYETKILI3 {
            get {
                return this.HYETKILI3Field;
            }
            set {
                if ((object.ReferenceEquals(this.HYETKILI3Field, value) != true)) {
                    this.HYETKILI3Field = value;
                    this.RaisePropertyChanged("HYETKILI3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
        public string HTEL1 {
            get {
                return this.HTEL1Field;
            }
            set {
                if ((object.ReferenceEquals(this.HTEL1Field, value) != true)) {
                    this.HTEL1Field = value;
                    this.RaisePropertyChanged("HTEL1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=15)]
        public string HTEL2 {
            get {
                return this.HTEL2Field;
            }
            set {
                if ((object.ReferenceEquals(this.HTEL2Field, value) != true)) {
                    this.HTEL2Field = value;
                    this.RaisePropertyChanged("HTEL2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=16)]
        public string HTEL3 {
            get {
                return this.HTEL3Field;
            }
            set {
                if ((object.ReferenceEquals(this.HTEL3Field, value) != true)) {
                    this.HTEL3Field = value;
                    this.RaisePropertyChanged("HTEL3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=17)]
        public string HEMAIL1 {
            get {
                return this.HEMAIL1Field;
            }
            set {
                if ((object.ReferenceEquals(this.HEMAIL1Field, value) != true)) {
                    this.HEMAIL1Field = value;
                    this.RaisePropertyChanged("HEMAIL1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=18)]
        public string HEMAIL2 {
            get {
                return this.HEMAIL2Field;
            }
            set {
                if ((object.ReferenceEquals(this.HEMAIL2Field, value) != true)) {
                    this.HEMAIL2Field = value;
                    this.RaisePropertyChanged("HEMAIL2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=19)]
        public string HEMAIL3 {
            get {
                return this.HEMAIL3Field;
            }
            set {
                if ((object.ReferenceEquals(this.HEMAIL3Field, value) != true)) {
                    this.HEMAIL3Field = value;
                    this.RaisePropertyChanged("HEMAIL3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=20)]
        public string HFAKS1 {
            get {
                return this.HFAKS1Field;
            }
            set {
                if ((object.ReferenceEquals(this.HFAKS1Field, value) != true)) {
                    this.HFAKS1Field = value;
                    this.RaisePropertyChanged("HFAKS1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=21)]
        public string HFAKS2 {
            get {
                return this.HFAKS2Field;
            }
            set {
                if ((object.ReferenceEquals(this.HFAKS2Field, value) != true)) {
                    this.HFAKS2Field = value;
                    this.RaisePropertyChanged("HFAKS2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=22)]
        public string HFAKS3 {
            get {
                return this.HFAKS3Field;
            }
            set {
                if ((object.ReferenceEquals(this.HFAKS3Field, value) != true)) {
                    this.HFAKS3Field = value;
                    this.RaisePropertyChanged("HFAKS3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=23)]
        public string HCEP1 {
            get {
                return this.HCEP1Field;
            }
            set {
                if ((object.ReferenceEquals(this.HCEP1Field, value) != true)) {
                    this.HCEP1Field = value;
                    this.RaisePropertyChanged("HCEP1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=24)]
        public string HCEP2 {
            get {
                return this.HCEP2Field;
            }
            set {
                if ((object.ReferenceEquals(this.HCEP2Field, value) != true)) {
                    this.HCEP2Field = value;
                    this.RaisePropertyChanged("HCEP2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=25)]
        public string HCEP3 {
            get {
                return this.HCEP3Field;
            }
            set {
                if ((object.ReferenceEquals(this.HCEP3Field, value) != true)) {
                    this.HCEP3Field = value;
                    this.RaisePropertyChanged("HCEP3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=26)]
        public System.Nullable<int> HSAVEUSER {
            get {
                return this.HSAVEUSERField;
            }
            set {
                if ((this.HSAVEUSERField.Equals(value) != true)) {
                    this.HSAVEUSERField = value;
                    this.RaisePropertyChanged("HSAVEUSER");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=27)]
        public System.Nullable<System.DateTime> HSAVEDATE {
            get {
                return this.HSAVEDATEField;
            }
            set {
                if ((this.HSAVEDATEField.Equals(value) != true)) {
                    this.HSAVEDATEField = value;
                    this.RaisePropertyChanged("HSAVEDATE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=28)]
        public System.Nullable<int> HEDITUSER {
            get {
                return this.HEDITUSERField;
            }
            set {
                if ((this.HEDITUSERField.Equals(value) != true)) {
                    this.HEDITUSERField = value;
                    this.RaisePropertyChanged("HEDITUSER");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=29)]
        public System.Nullable<System.DateTime> HEDITDATE {
            get {
                return this.HEDITDATEField;
            }
            set {
                if ((this.HEDITDATEField.Equals(value) != true)) {
                    this.HEDITDATEField = value;
                    this.RaisePropertyChanged("HEDITDATE");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TstServ1.TestSoap")]
    public interface TestSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        MVCServis.TstServ1.HelloWorldResponse HelloWorld(MVCServis.TstServ1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<MVCServis.TstServ1.HelloWorldResponse> HelloWorldAsync(MVCServis.TstServ1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name hastanelerResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/hastaneler", ReplyAction="*")]
        MVCServis.TstServ1.hastanelerResponse hastaneler(MVCServis.TstServ1.hastanelerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/hastaneler", ReplyAction="*")]
        System.Threading.Tasks.Task<MVCServis.TstServ1.hastanelerResponse> hastanelerAsync(MVCServis.TstServ1.hastanelerRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public MVCServis.TstServ1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(MVCServis.TstServ1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public MVCServis.TstServ1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(MVCServis.TstServ1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class hastanelerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="hastaneler", Namespace="http://tempuri.org/", Order=0)]
        public MVCServis.TstServ1.hastanelerRequestBody Body;
        
        public hastanelerRequest() {
        }
        
        public hastanelerRequest(MVCServis.TstServ1.hastanelerRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class hastanelerRequestBody {
        
        public hastanelerRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class hastanelerResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="hastanelerResponse", Namespace="http://tempuri.org/", Order=0)]
        public MVCServis.TstServ1.hastanelerResponseBody Body;
        
        public hastanelerResponse() {
        }
        
        public hastanelerResponse(MVCServis.TstServ1.hastanelerResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class hastanelerResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Collections.Generic.List<MVCServis.TstServ1.B_TBL_HASTANELER> hastanelerResult;
        
        public hastanelerResponseBody() {
        }
        
        public hastanelerResponseBody(System.Collections.Generic.List<MVCServis.TstServ1.B_TBL_HASTANELER> hastanelerResult) {
            this.hastanelerResult = hastanelerResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TestSoapChannel : MVCServis.TstServ1.TestSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestSoapClient : System.ServiceModel.ClientBase<MVCServis.TstServ1.TestSoap>, MVCServis.TstServ1.TestSoap {
        
        public TestSoapClient() {
        }
        
        public TestSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MVCServis.TstServ1.HelloWorldResponse MVCServis.TstServ1.TestSoap.HelloWorld(MVCServis.TstServ1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            MVCServis.TstServ1.HelloWorldRequest inValue = new MVCServis.TstServ1.HelloWorldRequest();
            inValue.Body = new MVCServis.TstServ1.HelloWorldRequestBody();
            MVCServis.TstServ1.HelloWorldResponse retVal = ((MVCServis.TstServ1.TestSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MVCServis.TstServ1.HelloWorldResponse> MVCServis.TstServ1.TestSoap.HelloWorldAsync(MVCServis.TstServ1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<MVCServis.TstServ1.HelloWorldResponse> HelloWorldAsync() {
            MVCServis.TstServ1.HelloWorldRequest inValue = new MVCServis.TstServ1.HelloWorldRequest();
            inValue.Body = new MVCServis.TstServ1.HelloWorldRequestBody();
            return ((MVCServis.TstServ1.TestSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MVCServis.TstServ1.hastanelerResponse MVCServis.TstServ1.TestSoap.hastaneler(MVCServis.TstServ1.hastanelerRequest request) {
            return base.Channel.hastaneler(request);
        }
        
        public System.Collections.Generic.List<MVCServis.TstServ1.B_TBL_HASTANELER> hastaneler() {
            MVCServis.TstServ1.hastanelerRequest inValue = new MVCServis.TstServ1.hastanelerRequest();
            inValue.Body = new MVCServis.TstServ1.hastanelerRequestBody();
            MVCServis.TstServ1.hastanelerResponse retVal = ((MVCServis.TstServ1.TestSoap)(this)).hastaneler(inValue);
            return retVal.Body.hastanelerResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MVCServis.TstServ1.hastanelerResponse> MVCServis.TstServ1.TestSoap.hastanelerAsync(MVCServis.TstServ1.hastanelerRequest request) {
            return base.Channel.hastanelerAsync(request);
        }
        
        public System.Threading.Tasks.Task<MVCServis.TstServ1.hastanelerResponse> hastanelerAsync() {
            MVCServis.TstServ1.hastanelerRequest inValue = new MVCServis.TstServ1.hastanelerRequest();
            inValue.Body = new MVCServis.TstServ1.hastanelerRequestBody();
            return ((MVCServis.TstServ1.TestSoap)(this)).hastanelerAsync(inValue);
        }
    }
}
