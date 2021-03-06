﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wcf.Client.WcfServices {
    using System.Runtime.Serialization;
    using System;
    using Wcf.Entities;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/Wcf.Entities")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ItemsTotalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime OrderDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.ObjectModel.ObservableCollection<Wcf.Client.WcfServices.OrderItem> OrderItemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderStatusIdField;
        
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
        public System.Guid CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ItemsTotal {
            get {
                return this.ItemsTotalField;
            }
            set {
                if ((this.ItemsTotalField.Equals(value) != true)) {
                    this.ItemsTotalField = value;
                    this.RaisePropertyChanged("ItemsTotal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime OrderDate {
            get {
                return this.OrderDateField;
            }
            set {
                if ((this.OrderDateField.Equals(value) != true)) {
                    this.OrderDateField = value;
                    this.RaisePropertyChanged("OrderDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<Wcf.Client.WcfServices.OrderItem> OrderItems {
            get {
                return this.OrderItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderItemsField, value) != true)) {
                    this.OrderItemsField = value;
                    this.RaisePropertyChanged("OrderItems");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderStatusId {
            get {
                return this.OrderStatusIdField;
            }
            set {
                if ((this.OrderStatusIdField.Equals(value) != true)) {
                    this.OrderStatusIdField = value;
                    this.RaisePropertyChanged("OrderStatusId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderItem", Namespace="http://schemas.datacontract.org/2004/07/Wcf.Entities")]
    [System.SerializableAttribute()]
    public partial class OrderItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long OrderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TotalPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal UnitPriceField;
        
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
        public long Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long OrderId {
            get {
                return this.OrderIdField;
            }
            set {
                if ((this.OrderIdField.Equals(value) != true)) {
                    this.OrderIdField = value;
                    this.RaisePropertyChanged("OrderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TotalPrice {
            get {
                return this.TotalPriceField;
            }
            set {
                if ((this.TotalPriceField.Equals(value) != true)) {
                    this.TotalPriceField = value;
                    this.RaisePropertyChanged("TotalPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal UnitPrice {
            get {
                return this.UnitPriceField;
            }
            set {
                if ((this.UnitPriceField.Equals(value) != true)) {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServices.IWcfService")]
    public interface IWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetOrders", ReplyAction="http://tempuri.org/IWcfService/GetOrdersResponse")]
        System.Collections.ObjectModel.ObservableCollection<Wcf.Client.WcfServices.Order> GetOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetOrders", ReplyAction="http://tempuri.org/IWcfService/GetOrdersResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Wcf.Client.WcfServices.Order>> GetOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/CloseOrder", ReplyAction="http://tempuri.org/IWcfService/CloseOrderResponse")]
        void CloseOrder(Wcf.Client.WcfServices.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/CloseOrder", ReplyAction="http://tempuri.org/IWcfService/CloseOrderResponse")]
        System.Threading.Tasks.Task CloseOrderAsync(Wcf.Client.WcfServices.Order order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfServiceChannel : Wcf.Client.WcfServices.IWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfServiceClient : System.ServiceModel.ClientBase<Wcf.Client.WcfServices.IWcfService>, Wcf.Client.WcfServices.IWcfService {
        
        public WcfServiceClient() {
        }
        
        public WcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.ObjectModel.ObservableCollection<Wcf.Client.WcfServices.Order> GetOrders() {
            return base.Channel.GetOrders();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Wcf.Client.WcfServices.Order>> GetOrdersAsync() {
            return base.Channel.GetOrdersAsync();
        }
        
        public void CloseOrder(Wcf.Client.WcfServices.Order order) {
            base.Channel.CloseOrder(order);
        }
        
        public System.Threading.Tasks.Task CloseOrderAsync(Wcf.Client.WcfServices.Order order) {
            return base.Channel.CloseOrderAsync(order);
        }

        internal void CloseOrder(Entities.Order currentOrder)
        {
            throw new NotImplementedException();
        }
    }
}
