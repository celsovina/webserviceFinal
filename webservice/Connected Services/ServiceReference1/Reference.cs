﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webservice.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ident del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculoSueldo", ReplyAction="*")]
        webservice.ServiceReference1.CalculoSueldoResponse CalculoSueldo(webservice.ServiceReference1.CalculoSueldoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ident del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Persona", ReplyAction="*")]
        webservice.ServiceReference1.PersonaResponse Persona(webservice.ServiceReference1.PersonaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Domingos del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Devengados", ReplyAction="*")]
        webservice.ServiceReference1.DevengadosResponse Devengados(webservice.ServiceReference1.DevengadosRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Fallas del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Deducciones", ReplyAction="*")]
        webservice.ServiceReference1.DeduccionesResponse Deducciones(webservice.ServiceReference1.DeduccionesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculoSueldoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculoSueldo", Namespace="http://tempuri.org/", Order=0)]
        public webservice.ServiceReference1.CalculoSueldoRequestBody Body;
        
        public CalculoSueldoRequest() {
        }
        
        public CalculoSueldoRequest(webservice.ServiceReference1.CalculoSueldoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculoSueldoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ident;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string apellidos;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string cargo;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int sueldo;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int domingos;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int fallas;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public int horasext;
        
        public CalculoSueldoRequestBody() {
        }
        
        public CalculoSueldoRequestBody(string ident, string nombre, string apellidos, string cargo, int sueldo, int domingos, int fallas, int horasext) {
            this.ident = ident;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.cargo = cargo;
            this.sueldo = sueldo;
            this.domingos = domingos;
            this.fallas = fallas;
            this.horasext = horasext;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculoSueldoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculoSueldoResponse", Namespace="http://tempuri.org/", Order=0)]
        public webservice.ServiceReference1.CalculoSueldoResponseBody Body;
        
        public CalculoSueldoResponse() {
        }
        
        public CalculoSueldoResponse(webservice.ServiceReference1.CalculoSueldoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculoSueldoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public webservice.ServiceReference1.ArrayOfString CalculoSueldoResult;
        
        public CalculoSueldoResponseBody() {
        }
        
        public CalculoSueldoResponseBody(webservice.ServiceReference1.ArrayOfString CalculoSueldoResult) {
            this.CalculoSueldoResult = CalculoSueldoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PersonaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Persona", Namespace="http://tempuri.org/", Order=0)]
        public webservice.ServiceReference1.PersonaRequestBody Body;
        
        public PersonaRequest() {
        }
        
        public PersonaRequest(webservice.ServiceReference1.PersonaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PersonaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ident;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string apellidos;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string cargo;
        
        public PersonaRequestBody() {
        }
        
        public PersonaRequestBody(string ident, string nombre, string apellidos, string cargo) {
            this.ident = ident;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.cargo = cargo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PersonaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PersonaResponse", Namespace="http://tempuri.org/", Order=0)]
        public webservice.ServiceReference1.PersonaResponseBody Body;
        
        public PersonaResponse() {
        }
        
        public PersonaResponse(webservice.ServiceReference1.PersonaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PersonaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public webservice.ServiceReference1.ArrayOfString PersonaResult;
        
        public PersonaResponseBody() {
        }
        
        public PersonaResponseBody(webservice.ServiceReference1.ArrayOfString PersonaResult) {
            this.PersonaResult = PersonaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DevengadosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Devengados", Namespace="http://tempuri.org/", Order=0)]
        public webservice.ServiceReference1.DevengadosRequestBody Body;
        
        public DevengadosRequest() {
        }
        
        public DevengadosRequest(webservice.ServiceReference1.DevengadosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DevengadosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Domingos;
        
        public DevengadosRequestBody() {
        }
        
        public DevengadosRequestBody(string Domingos) {
            this.Domingos = Domingos;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DevengadosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DevengadosResponse", Namespace="http://tempuri.org/", Order=0)]
        public webservice.ServiceReference1.DevengadosResponseBody Body;
        
        public DevengadosResponse() {
        }
        
        public DevengadosResponse(webservice.ServiceReference1.DevengadosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DevengadosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public webservice.ServiceReference1.ArrayOfString DevengadosResult;
        
        public DevengadosResponseBody() {
        }
        
        public DevengadosResponseBody(webservice.ServiceReference1.ArrayOfString DevengadosResult) {
            this.DevengadosResult = DevengadosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeduccionesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Deducciones", Namespace="http://tempuri.org/", Order=0)]
        public webservice.ServiceReference1.DeduccionesRequestBody Body;
        
        public DeduccionesRequest() {
        }
        
        public DeduccionesRequest(webservice.ServiceReference1.DeduccionesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeduccionesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Fallas;
        
        public DeduccionesRequestBody() {
        }
        
        public DeduccionesRequestBody(string Fallas) {
            this.Fallas = Fallas;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeduccionesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeduccionesResponse", Namespace="http://tempuri.org/", Order=0)]
        public webservice.ServiceReference1.DeduccionesResponseBody Body;
        
        public DeduccionesResponse() {
        }
        
        public DeduccionesResponse(webservice.ServiceReference1.DeduccionesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeduccionesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public webservice.ServiceReference1.ArrayOfString DeduccionesResult;
        
        public DeduccionesResponseBody() {
        }
        
        public DeduccionesResponseBody(webservice.ServiceReference1.ArrayOfString DeduccionesResult) {
            this.DeduccionesResult = DeduccionesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : webservice.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<webservice.ServiceReference1.WebService1Soap>, webservice.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        webservice.ServiceReference1.CalculoSueldoResponse webservice.ServiceReference1.WebService1Soap.CalculoSueldo(webservice.ServiceReference1.CalculoSueldoRequest request) {
            return base.Channel.CalculoSueldo(request);
        }
        
        public webservice.ServiceReference1.ArrayOfString CalculoSueldo(string ident, string nombre, string apellidos, string cargo, int sueldo, int domingos, int fallas, int horasext) {
            webservice.ServiceReference1.CalculoSueldoRequest inValue = new webservice.ServiceReference1.CalculoSueldoRequest();
            inValue.Body = new webservice.ServiceReference1.CalculoSueldoRequestBody();
            inValue.Body.ident = ident;
            inValue.Body.nombre = nombre;
            inValue.Body.apellidos = apellidos;
            inValue.Body.cargo = cargo;
            inValue.Body.sueldo = sueldo;
            inValue.Body.domingos = domingos;
            inValue.Body.fallas = fallas;
            inValue.Body.horasext = horasext;
            webservice.ServiceReference1.CalculoSueldoResponse retVal = ((webservice.ServiceReference1.WebService1Soap)(this)).CalculoSueldo(inValue);
            return retVal.Body.CalculoSueldoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        webservice.ServiceReference1.PersonaResponse webservice.ServiceReference1.WebService1Soap.Persona(webservice.ServiceReference1.PersonaRequest request) {
            return base.Channel.Persona(request);
        }
        
        public webservice.ServiceReference1.ArrayOfString Persona(string ident, string nombre, string apellidos, string cargo) {
            webservice.ServiceReference1.PersonaRequest inValue = new webservice.ServiceReference1.PersonaRequest();
            inValue.Body = new webservice.ServiceReference1.PersonaRequestBody();
            inValue.Body.ident = ident;
            inValue.Body.nombre = nombre;
            inValue.Body.apellidos = apellidos;
            inValue.Body.cargo = cargo;
            webservice.ServiceReference1.PersonaResponse retVal = ((webservice.ServiceReference1.WebService1Soap)(this)).Persona(inValue);
            return retVal.Body.PersonaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        webservice.ServiceReference1.DevengadosResponse webservice.ServiceReference1.WebService1Soap.Devengados(webservice.ServiceReference1.DevengadosRequest request) {
            return base.Channel.Devengados(request);
        }
        
        public webservice.ServiceReference1.ArrayOfString Devengados(string Domingos) {
            webservice.ServiceReference1.DevengadosRequest inValue = new webservice.ServiceReference1.DevengadosRequest();
            inValue.Body = new webservice.ServiceReference1.DevengadosRequestBody();
            inValue.Body.Domingos = Domingos;
            webservice.ServiceReference1.DevengadosResponse retVal = ((webservice.ServiceReference1.WebService1Soap)(this)).Devengados(inValue);
            return retVal.Body.DevengadosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        webservice.ServiceReference1.DeduccionesResponse webservice.ServiceReference1.WebService1Soap.Deducciones(webservice.ServiceReference1.DeduccionesRequest request) {
            return base.Channel.Deducciones(request);
        }
        
        public webservice.ServiceReference1.ArrayOfString Deducciones(string Fallas) {
            webservice.ServiceReference1.DeduccionesRequest inValue = new webservice.ServiceReference1.DeduccionesRequest();
            inValue.Body = new webservice.ServiceReference1.DeduccionesRequestBody();
            inValue.Body.Fallas = Fallas;
            webservice.ServiceReference1.DeduccionesResponse retVal = ((webservice.ServiceReference1.WebService1Soap)(this)).Deducciones(inValue);
            return retVal.Body.DeduccionesResult;
        }
    }
}
