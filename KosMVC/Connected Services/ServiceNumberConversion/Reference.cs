﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceNumberConversion
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.dataaccess.com/webservicesserver/", ConfigurationName="ServiceNumberConversion.NumberConversionSoapType")]
    public interface NumberConversionSoapType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceNumberConversion.NumberToWordsResponse> NumberToWordsAsync(ServiceNumberConversion.NumberToWordsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceNumberConversion.NumberToDollarsResponse> NumberToDollarsAsync(ServiceNumberConversion.NumberToDollarsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NumberToWordsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NumberToWords", Namespace="http://www.dataaccess.com/webservicesserver/", Order=0)]
        public ServiceNumberConversion.NumberToWordsRequestBody Body;
        
        public NumberToWordsRequest()
        {
        }
        
        public NumberToWordsRequest(ServiceNumberConversion.NumberToWordsRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.dataaccess.com/webservicesserver/")]
    public partial class NumberToWordsRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public ulong ubiNum;
        
        public NumberToWordsRequestBody()
        {
        }
        
        public NumberToWordsRequestBody(ulong ubiNum)
        {
            this.ubiNum = ubiNum;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NumberToWordsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NumberToWordsResponse", Namespace="http://www.dataaccess.com/webservicesserver/", Order=0)]
        public ServiceNumberConversion.NumberToWordsResponseBody Body;
        
        public NumberToWordsResponse()
        {
        }
        
        public NumberToWordsResponse(ServiceNumberConversion.NumberToWordsResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.dataaccess.com/webservicesserver/")]
    public partial class NumberToWordsResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NumberToWordsResult;
        
        public NumberToWordsResponseBody()
        {
        }
        
        public NumberToWordsResponseBody(string NumberToWordsResult)
        {
            this.NumberToWordsResult = NumberToWordsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NumberToDollarsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NumberToDollars", Namespace="http://www.dataaccess.com/webservicesserver/", Order=0)]
        public ServiceNumberConversion.NumberToDollarsRequestBody Body;
        
        public NumberToDollarsRequest()
        {
        }
        
        public NumberToDollarsRequest(ServiceNumberConversion.NumberToDollarsRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.dataaccess.com/webservicesserver/")]
    public partial class NumberToDollarsRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public decimal dNum;
        
        public NumberToDollarsRequestBody()
        {
        }
        
        public NumberToDollarsRequestBody(decimal dNum)
        {
            this.dNum = dNum;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NumberToDollarsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NumberToDollarsResponse", Namespace="http://www.dataaccess.com/webservicesserver/", Order=0)]
        public ServiceNumberConversion.NumberToDollarsResponseBody Body;
        
        public NumberToDollarsResponse()
        {
        }
        
        public NumberToDollarsResponse(ServiceNumberConversion.NumberToDollarsResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.dataaccess.com/webservicesserver/")]
    public partial class NumberToDollarsResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NumberToDollarsResult;
        
        public NumberToDollarsResponseBody()
        {
        }
        
        public NumberToDollarsResponseBody(string NumberToDollarsResult)
        {
            this.NumberToDollarsResult = NumberToDollarsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface NumberConversionSoapTypeChannel : ServiceNumberConversion.NumberConversionSoapType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class NumberConversionSoapTypeClient : System.ServiceModel.ClientBase<ServiceNumberConversion.NumberConversionSoapType>, ServiceNumberConversion.NumberConversionSoapType
    {
        
        /// <summary>
        /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
        /// </summary>
        /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
        /// <param name="clientCredentials">Учетные данные клиента.</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public NumberConversionSoapTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(NumberConversionSoapTypeClient.GetBindingForEndpoint(endpointConfiguration), NumberConversionSoapTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NumberConversionSoapTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(NumberConversionSoapTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NumberConversionSoapTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(NumberConversionSoapTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NumberConversionSoapTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceNumberConversion.NumberToWordsResponse> ServiceNumberConversion.NumberConversionSoapType.NumberToWordsAsync(ServiceNumberConversion.NumberToWordsRequest request)
        {
            return base.Channel.NumberToWordsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceNumberConversion.NumberToWordsResponse> NumberToWordsAsync(ulong ubiNum)
        {
            ServiceNumberConversion.NumberToWordsRequest inValue = new ServiceNumberConversion.NumberToWordsRequest();
            inValue.Body = new ServiceNumberConversion.NumberToWordsRequestBody();
            inValue.Body.ubiNum = ubiNum;
            return ((ServiceNumberConversion.NumberConversionSoapType)(this)).NumberToWordsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceNumberConversion.NumberToDollarsResponse> ServiceNumberConversion.NumberConversionSoapType.NumberToDollarsAsync(ServiceNumberConversion.NumberToDollarsRequest request)
        {
            return base.Channel.NumberToDollarsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceNumberConversion.NumberToDollarsResponse> NumberToDollarsAsync(decimal dNum)
        {
            ServiceNumberConversion.NumberToDollarsRequest inValue = new ServiceNumberConversion.NumberToDollarsRequest();
            inValue.Body = new ServiceNumberConversion.NumberToDollarsRequestBody();
            inValue.Body.dNum = dNum;
            return ((ServiceNumberConversion.NumberConversionSoapType)(this)).NumberToDollarsAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NumberConversionSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.NumberConversionSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NumberConversionSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://www.dataaccess.com/webservicesserver/NumberConversion.wso");
            }
            if ((endpointConfiguration == EndpointConfiguration.NumberConversionSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://www.dataaccess.com/webservicesserver/NumberConversion.wso");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            NumberConversionSoap,
            
            NumberConversionSoap12,
        }
    }
}
