﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlViaticosApp.ViaticoWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/ControlViaticosServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Co_TipoViaticoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double Ss_MontoSolicitadoField;
        
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
        public int Co_TipoViatico {
            get {
                return this.Co_TipoViaticoField;
            }
            set {
                if ((this.Co_TipoViaticoField.Equals(value) != true)) {
                    this.Co_TipoViaticoField = value;
                    this.RaisePropertyChanged("Co_TipoViatico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Ss_MontoSolicitado {
            get {
                return this.Ss_MontoSolicitadoField;
            }
            set {
                if ((this.Ss_MontoSolicitadoField.Equals(value) != true)) {
                    this.Ss_MontoSolicitadoField = value;
                    this.RaisePropertyChanged("Ss_MontoSolicitado");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Viatico", Namespace="http://schemas.datacontract.org/2004/07/ControlViaticosServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Viatico : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoEmpleadoSolicitanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoSolicitudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ControlViaticosApp.ViaticoWS.ViaticoDetalle> DetallesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaRetornoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaSalidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaSolicitudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SustentoViajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TotalSolicitadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ControlViaticosApp.ViaticoWS.Ubigeo ubigeoDestinoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ControlViaticosApp.ViaticoWS.Ubigeo ubigeoOrigenField;
        
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
        public int CodigoEmpleadoSolicitante {
            get {
                return this.CodigoEmpleadoSolicitanteField;
            }
            set {
                if ((this.CodigoEmpleadoSolicitanteField.Equals(value) != true)) {
                    this.CodigoEmpleadoSolicitanteField = value;
                    this.RaisePropertyChanged("CodigoEmpleadoSolicitante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodigoSolicitud {
            get {
                return this.CodigoSolicitudField;
            }
            set {
                if ((this.CodigoSolicitudField.Equals(value) != true)) {
                    this.CodigoSolicitudField = value;
                    this.RaisePropertyChanged("CodigoSolicitud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ControlViaticosApp.ViaticoWS.ViaticoDetalle> Detalles {
            get {
                return this.DetallesField;
            }
            set {
                if ((object.ReferenceEquals(this.DetallesField, value) != true)) {
                    this.DetallesField = value;
                    this.RaisePropertyChanged("Detalles");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaRetorno {
            get {
                return this.FechaRetornoField;
            }
            set {
                if ((this.FechaRetornoField.Equals(value) != true)) {
                    this.FechaRetornoField = value;
                    this.RaisePropertyChanged("FechaRetorno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaSalida {
            get {
                return this.FechaSalidaField;
            }
            set {
                if ((this.FechaSalidaField.Equals(value) != true)) {
                    this.FechaSalidaField = value;
                    this.RaisePropertyChanged("FechaSalida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaSolicitud {
            get {
                return this.FechaSolicitudField;
            }
            set {
                if ((this.FechaSolicitudField.Equals(value) != true)) {
                    this.FechaSolicitudField = value;
                    this.RaisePropertyChanged("FechaSolicitud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SustentoViaje {
            get {
                return this.SustentoViajeField;
            }
            set {
                if ((object.ReferenceEquals(this.SustentoViajeField, value) != true)) {
                    this.SustentoViajeField = value;
                    this.RaisePropertyChanged("SustentoViaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TotalSolicitado {
            get {
                return this.TotalSolicitadoField;
            }
            set {
                if ((this.TotalSolicitadoField.Equals(value) != true)) {
                    this.TotalSolicitadoField = value;
                    this.RaisePropertyChanged("TotalSolicitado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ControlViaticosApp.ViaticoWS.Ubigeo ubigeoDestino {
            get {
                return this.ubigeoDestinoField;
            }
            set {
                if ((object.ReferenceEquals(this.ubigeoDestinoField, value) != true)) {
                    this.ubigeoDestinoField = value;
                    this.RaisePropertyChanged("ubigeoDestino");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ControlViaticosApp.ViaticoWS.Ubigeo ubigeoOrigen {
            get {
                return this.ubigeoOrigenField;
            }
            set {
                if ((object.ReferenceEquals(this.ubigeoOrigenField, value) != true)) {
                    this.ubigeoOrigenField = value;
                    this.RaisePropertyChanged("ubigeoOrigen");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ubigeo", Namespace="http://schemas.datacontract.org/2004/07/ControlViaticosServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Ubigeo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoUbigeoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoDescripcionField;
        
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
        public int CodigoUbigeo {
            get {
                return this.CodigoUbigeoField;
            }
            set {
                if ((this.CodigoUbigeoField.Equals(value) != true)) {
                    this.CodigoUbigeoField = value;
                    this.RaisePropertyChanged("CodigoUbigeo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoDescripcion {
            get {
                return this.NoDescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.NoDescripcionField, value) != true)) {
                    this.NoDescripcionField = value;
                    this.RaisePropertyChanged("NoDescripcion");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ViaticoDetalle", Namespace="http://schemas.datacontract.org/2004/07/ControlViaticosServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class ViaticoDetalle : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ControlViaticosApp.ViaticoWS.ViaticoDetallePK PKField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double Ss_MontoSolicitadoField;
        
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
        public ControlViaticosApp.ViaticoWS.ViaticoDetallePK PK {
            get {
                return this.PKField;
            }
            set {
                if ((object.ReferenceEquals(this.PKField, value) != true)) {
                    this.PKField = value;
                    this.RaisePropertyChanged("PK");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Ss_MontoSolicitado {
            get {
                return this.Ss_MontoSolicitadoField;
            }
            set {
                if ((this.Ss_MontoSolicitadoField.Equals(value) != true)) {
                    this.Ss_MontoSolicitadoField = value;
                    this.RaisePropertyChanged("Ss_MontoSolicitado");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ViaticoDetallePK", Namespace="http://schemas.datacontract.org/2004/07/ControlViaticosServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class ViaticoDetallePK : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ControlViaticosApp.ViaticoWS.TipoViatico TipoViaticoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ViaticoField;
        
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
        public ControlViaticosApp.ViaticoWS.TipoViatico TipoViatico {
            get {
                return this.TipoViaticoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoViaticoField, value) != true)) {
                    this.TipoViaticoField = value;
                    this.RaisePropertyChanged("TipoViatico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Viatico {
            get {
                return this.ViaticoField;
            }
            set {
                if ((this.ViaticoField.Equals(value) != true)) {
                    this.ViaticoField = value;
                    this.RaisePropertyChanged("Viatico");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoViatico", Namespace="http://schemas.datacontract.org/2004/07/ControlViaticosServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class TipoViatico : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Co_TipoViaticoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string No_DescripcionField;
        
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
        public int Co_TipoViatico {
            get {
                return this.Co_TipoViaticoField;
            }
            set {
                if ((this.Co_TipoViaticoField.Equals(value) != true)) {
                    this.Co_TipoViaticoField = value;
                    this.RaisePropertyChanged("Co_TipoViatico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string No_Descripcion {
            get {
                return this.No_DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.No_DescripcionField, value) != true)) {
                    this.No_DescripcionField = value;
                    this.RaisePropertyChanged("No_Descripcion");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ValidationException", Namespace="http://schemas.datacontract.org/2004/07/ControlViaticosServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class ValidationException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeErrorField;
        
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
        public int CodigoError {
            get {
                return this.CodigoErrorField;
            }
            set {
                if ((this.CodigoErrorField.Equals(value) != true)) {
                    this.CodigoErrorField = value;
                    this.RaisePropertyChanged("CodigoError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MensajeError {
            get {
                return this.MensajeErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeErrorField, value) != true)) {
                    this.MensajeErrorField = value;
                    this.RaisePropertyChanged("MensajeError");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Tarifario", Namespace="http://schemas.datacontract.org/2004/07/ControlViaticosServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Tarifario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Co_EmpActualizaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Co_TarifaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ControlViaticosApp.ViaticoWS.TipoViatico Co_TipoViaticoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ControlViaticosApp.ViaticoWS.Ubigeo Co_UbigeoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Ss_CostoField;
        
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
        public int Co_EmpActualiza {
            get {
                return this.Co_EmpActualizaField;
            }
            set {
                if ((this.Co_EmpActualizaField.Equals(value) != true)) {
                    this.Co_EmpActualizaField = value;
                    this.RaisePropertyChanged("Co_EmpActualiza");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Co_Tarifa {
            get {
                return this.Co_TarifaField;
            }
            set {
                if ((this.Co_TarifaField.Equals(value) != true)) {
                    this.Co_TarifaField = value;
                    this.RaisePropertyChanged("Co_Tarifa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ControlViaticosApp.ViaticoWS.TipoViatico Co_TipoViatico {
            get {
                return this.Co_TipoViaticoField;
            }
            set {
                if ((object.ReferenceEquals(this.Co_TipoViaticoField, value) != true)) {
                    this.Co_TipoViaticoField = value;
                    this.RaisePropertyChanged("Co_TipoViatico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ControlViaticosApp.ViaticoWS.Ubigeo Co_Ubigeo {
            get {
                return this.Co_UbigeoField;
            }
            set {
                if ((object.ReferenceEquals(this.Co_UbigeoField, value) != true)) {
                    this.Co_UbigeoField = value;
                    this.RaisePropertyChanged("Co_Ubigeo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Ss_Costo {
            get {
                return this.Ss_CostoField;
            }
            set {
                if ((this.Ss_CostoField.Equals(value) != true)) {
                    this.Ss_CostoField = value;
                    this.RaisePropertyChanged("Ss_Costo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ViaticoWS.IViaticos")]
    public interface IViaticos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IViaticos/CrearSolicitud", ReplyAction="http://tempuri.org/IViaticos/CrearSolicitudResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ControlViaticosApp.ViaticoWS.ValidationException), Action="http://tempuri.org/IViaticos/CrearSolicitudValidationExceptionFault", Name="ValidationException", Namespace="http://schemas.datacontract.org/2004/07/ControlViaticosServices.Dominio")]
        ControlViaticosApp.ViaticoWS.Viatico CrearSolicitud(System.DateTime fechaSolicitud, int codigoEmpleadoSolicitante, int codigoUbigeoOrigen, int codigoUbigeoDestino, System.DateTime fechaSalida, System.DateTime fechaRetorno, string sustentoViaje, double totalSolicitado, System.Collections.Generic.List<ControlViaticosApp.ViaticoWS.Item> items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IViaticos/ObtenerSolicitud", ReplyAction="http://tempuri.org/IViaticos/ObtenerSolicitudResponse")]
        ControlViaticosApp.ViaticoWS.Viatico ObtenerSolicitud(int codigoSolicitud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IViaticos/ModificarSolicitud", ReplyAction="http://tempuri.org/IViaticos/ModificarSolicitudResponse")]
        ControlViaticosApp.ViaticoWS.Viatico ModificarSolicitud(int codigoSolicitud, System.DateTime fechaSolicitud, int codigoEmpleadoSolicitante, int codigoUbigeoOrigen, int codigoUbigeoDestino, System.DateTime fechaSalida, System.DateTime fechaRetorno, string sustentoViaje, double totalSolicitado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IViaticos/EliminarSolicitud", ReplyAction="http://tempuri.org/IViaticos/EliminarSolicitudResponse")]
        void EliminarSolicitud(int codigoSolicitud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IViaticos/ListarSolicitudes", ReplyAction="http://tempuri.org/IViaticos/ListarSolicitudesResponse")]
        System.Collections.Generic.List<ControlViaticosApp.ViaticoWS.Viatico> ListarSolicitudes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IViaticos/ListarUbigeos", ReplyAction="http://tempuri.org/IViaticos/ListarUbigeosResponse")]
        System.Collections.Generic.List<ControlViaticosApp.ViaticoWS.Ubigeo> ListarUbigeos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IViaticos/ListarTarifarioContingencia", ReplyAction="http://tempuri.org/IViaticos/ListarTarifarioContingenciaResponse")]
        System.Collections.Generic.List<ControlViaticosApp.ViaticoWS.Tarifario> ListarTarifarioContingencia();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IViaticosChannel : ControlViaticosApp.ViaticoWS.IViaticos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ViaticosClient : System.ServiceModel.ClientBase<ControlViaticosApp.ViaticoWS.IViaticos>, ControlViaticosApp.ViaticoWS.IViaticos {
        
        public ViaticosClient() {
        }
        
        public ViaticosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ViaticosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ViaticosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ViaticosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ControlViaticosApp.ViaticoWS.Viatico CrearSolicitud(System.DateTime fechaSolicitud, int codigoEmpleadoSolicitante, int codigoUbigeoOrigen, int codigoUbigeoDestino, System.DateTime fechaSalida, System.DateTime fechaRetorno, string sustentoViaje, double totalSolicitado, System.Collections.Generic.List<ControlViaticosApp.ViaticoWS.Item> items) {
            return base.Channel.CrearSolicitud(fechaSolicitud, codigoEmpleadoSolicitante, codigoUbigeoOrigen, codigoUbigeoDestino, fechaSalida, fechaRetorno, sustentoViaje, totalSolicitado, items);
        }
        
        public ControlViaticosApp.ViaticoWS.Viatico ObtenerSolicitud(int codigoSolicitud) {
            return base.Channel.ObtenerSolicitud(codigoSolicitud);
        }
        
        public ControlViaticosApp.ViaticoWS.Viatico ModificarSolicitud(int codigoSolicitud, System.DateTime fechaSolicitud, int codigoEmpleadoSolicitante, int codigoUbigeoOrigen, int codigoUbigeoDestino, System.DateTime fechaSalida, System.DateTime fechaRetorno, string sustentoViaje, double totalSolicitado) {
            return base.Channel.ModificarSolicitud(codigoSolicitud, fechaSolicitud, codigoEmpleadoSolicitante, codigoUbigeoOrigen, codigoUbigeoDestino, fechaSalida, fechaRetorno, sustentoViaje, totalSolicitado);
        }
        
        public void EliminarSolicitud(int codigoSolicitud) {
            base.Channel.EliminarSolicitud(codigoSolicitud);
        }
        
        public System.Collections.Generic.List<ControlViaticosApp.ViaticoWS.Viatico> ListarSolicitudes() {
            return base.Channel.ListarSolicitudes();
        }
        
        public System.Collections.Generic.List<ControlViaticosApp.ViaticoWS.Ubigeo> ListarUbigeos() {
            return base.Channel.ListarUbigeos();
        }
        
        public System.Collections.Generic.List<ControlViaticosApp.ViaticoWS.Tarifario> ListarTarifarioContingencia() {
            return base.Channel.ListarTarifarioContingencia();
        }
    }
}
