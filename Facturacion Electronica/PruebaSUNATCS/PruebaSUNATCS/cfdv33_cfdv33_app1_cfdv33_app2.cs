﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// Este código fuente fue generado automáticamente por xsd, Versión=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.sat.gob.mx/cfd/3", IsNullable=false)]
public partial class Impuestos {
    
    private ImpuestosTrasladosTraslado[][] trasladosField;
    
    private ImpuestosRetencionesRetencion[][] retencionesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Traslado", typeof(ImpuestosTrasladosTraslado), IsNullable=false)]
    public ImpuestosTrasladosTraslado[][] Traslados {
        get {
            return this.trasladosField;
        }
        set {
            this.trasladosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", typeof(ImpuestosRetencionesRetencion), IsNullable=false)]
    public ImpuestosRetencionesRetencion[][] Retenciones {
        get {
            return this.retencionesField;
        }
        set {
            this.retencionesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ImpuestosTrasladosTraslado {
    
    private decimal baseField;
    
    private string impuestoField;
    
    private string tipoFactorField;
    
    private decimal tasaOCuotaField;
    
    private bool tasaOCuotaFieldSpecified;
    
    private decimal importeField;
    
    private bool importeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Base {
        get {
            return this.baseField;
        }
        set {
            this.baseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Impuesto {
        get {
            return this.impuestoField;
        }
        set {
            this.impuestoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoFactor {
        get {
            return this.tipoFactorField;
        }
        set {
            this.tipoFactorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TasaOCuota {
        get {
            return this.tasaOCuotaField;
        }
        set {
            this.tasaOCuotaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TasaOCuotaSpecified {
        get {
            return this.tasaOCuotaFieldSpecified;
        }
        set {
            this.tasaOCuotaFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImporteSpecified {
        get {
            return this.importeFieldSpecified;
        }
        set {
            this.importeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ImpuestosRetencionesRetencion {
    
    private decimal baseField;
    
    private string impuestoField;
    
    private string tipoFactorField;
    
    private decimal tasaOCuotaField;
    
    private decimal importeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Base {
        get {
            return this.baseField;
        }
        set {
            this.baseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Impuesto {
        get {
            return this.impuestoField;
        }
        set {
            this.impuestoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoFactor {
        get {
            return this.tipoFactorField;
        }
        set {
            this.tipoFactorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TasaOCuota {
        get {
            return this.tasaOCuotaField;
        }
        set {
            this.tasaOCuotaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.sat.gob.mx/cfd/3", IsNullable=false)]
public partial class InformacionAduanera {
    
    private string numeroPedimentoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumeroPedimento {
        get {
            return this.numeroPedimentoField;
        }
        set {
            this.numeroPedimentoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.sat.gob.mx/cfd/3", IsNullable=false)]
public partial class Comprobante {
    
    private ComprobanteCfdiRelacionados[] cfdiRelacionadosField;
    
    private ComprobanteEmisor[] emisorField;
    
    private ComprobanteReceptor[] receptorField;
    
    private ComprobanteConceptosConcepto[][] conceptosField;
    
    private Impuestos[] impuestosField;
    
    private ComprobanteComplemento[] complementoField;
    
    private ComprobanteAddenda[] addendaField;
    
    private string versionField;
    
    private string serieField;
    
    private string folioField;
    
    private System.DateTime fechaField;
    
    private string selloField;
    
    private string formaPagoField;
    
    private string noCertificadoField;
    
    private string certificadoField;
    
    private string condicionesDePagoField;
    
    private decimal subTotalField;
    
    private decimal descuentoField;
    
    private bool descuentoFieldSpecified;
    
    private string monedaField;
    
    private decimal tipoCambioField;
    
    private bool tipoCambioFieldSpecified;
    
    private decimal totalField;
    
    private string tipoDeComprobanteField;
    
    private string metodoPagoField;
    
    private string lugarExpedicionField;
    
    private string confirmacionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CfdiRelacionados")]
    public ComprobanteCfdiRelacionados[] CfdiRelacionados {
        get {
            return this.cfdiRelacionadosField;
        }
        set {
            this.cfdiRelacionadosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Emisor")]
    public ComprobanteEmisor[] Emisor {
        get {
            return this.emisorField;
        }
        set {
            this.emisorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Receptor")]
    public ComprobanteReceptor[] Receptor {
        get {
            return this.receptorField;
        }
        set {
            this.receptorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Concepto", typeof(ComprobanteConceptosConcepto), IsNullable=false)]
    public ComprobanteConceptosConcepto[][] Conceptos {
        get {
            return this.conceptosField;
        }
        set {
            this.conceptosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Impuestos")]
    public Impuestos[] Impuestos {
        get {
            return this.impuestosField;
        }
        set {
            this.impuestosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Complemento")]
    public ComprobanteComplemento[] Complemento {
        get {
            return this.complementoField;
        }
        set {
            this.complementoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Addenda")]
    public ComprobanteAddenda[] Addenda {
        get {
            return this.addendaField;
        }
        set {
            this.addendaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Serie {
        get {
            return this.serieField;
        }
        set {
            this.serieField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Folio {
        get {
            return this.folioField;
        }
        set {
            this.folioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime Fecha {
        get {
            return this.fechaField;
        }
        set {
            this.fechaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Sello {
        get {
            return this.selloField;
        }
        set {
            this.selloField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FormaPago {
        get {
            return this.formaPagoField;
        }
        set {
            this.formaPagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NoCertificado {
        get {
            return this.noCertificadoField;
        }
        set {
            this.noCertificadoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Certificado {
        get {
            return this.certificadoField;
        }
        set {
            this.certificadoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CondicionesDePago {
        get {
            return this.condicionesDePagoField;
        }
        set {
            this.condicionesDePagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal SubTotal {
        get {
            return this.subTotalField;
        }
        set {
            this.subTotalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Descuento {
        get {
            return this.descuentoField;
        }
        set {
            this.descuentoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DescuentoSpecified {
        get {
            return this.descuentoFieldSpecified;
        }
        set {
            this.descuentoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Moneda {
        get {
            return this.monedaField;
        }
        set {
            this.monedaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TipoCambio {
        get {
            return this.tipoCambioField;
        }
        set {
            this.tipoCambioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TipoCambioSpecified {
        get {
            return this.tipoCambioFieldSpecified;
        }
        set {
            this.tipoCambioFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Total {
        get {
            return this.totalField;
        }
        set {
            this.totalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoDeComprobante {
        get {
            return this.tipoDeComprobanteField;
        }
        set {
            this.tipoDeComprobanteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MetodoPago {
        get {
            return this.metodoPagoField;
        }
        set {
            this.metodoPagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LugarExpedicion {
        get {
            return this.lugarExpedicionField;
        }
        set {
            this.lugarExpedicionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Confirmacion {
        get {
            return this.confirmacionField;
        }
        set {
            this.confirmacionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteCfdiRelacionados {
    
    private ComprobanteCfdiRelacionadosCfdiRelacionado[] cfdiRelacionadoField;
    
    private string tipoRelacionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CfdiRelacionado")]
    public ComprobanteCfdiRelacionadosCfdiRelacionado[] CfdiRelacionado {
        get {
            return this.cfdiRelacionadoField;
        }
        set {
            this.cfdiRelacionadoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoRelacion {
        get {
            return this.tipoRelacionField;
        }
        set {
            this.tipoRelacionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteCfdiRelacionadosCfdiRelacionado {
    
    private string uUIDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UUID {
        get {
            return this.uUIDField;
        }
        set {
            this.uUIDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteEmisor {
    
    private string rfcField;
    
    private string nombreField;
    
    private string regimenFiscalField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Rfc {
        get {
            return this.rfcField;
        }
        set {
            this.rfcField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre {
        get {
            return this.nombreField;
        }
        set {
            this.nombreField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RegimenFiscal {
        get {
            return this.regimenFiscalField;
        }
        set {
            this.regimenFiscalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteReceptor {
    
    private string rfcField;
    
    private string nombreField;
    
    private string residenciaFiscalField;
    
    private string numRegIdTribField;
    
    private string usoCFDIField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Rfc {
        get {
            return this.rfcField;
        }
        set {
            this.rfcField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre {
        get {
            return this.nombreField;
        }
        set {
            this.nombreField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ResidenciaFiscal {
        get {
            return this.residenciaFiscalField;
        }
        set {
            this.residenciaFiscalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumRegIdTrib {
        get {
            return this.numRegIdTribField;
        }
        set {
            this.numRegIdTribField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UsoCFDI {
        get {
            return this.usoCFDIField;
        }
        set {
            this.usoCFDIField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteConceptosConcepto {
    
    private Impuestos[] impuestosField;
    
    private InformacionAduanera[] informacionAduaneraField;
    
    private ComprobanteConceptosConceptoCuentaPredial[] cuentaPredialField;
    
    private ComprobanteConceptosConceptoComplementoConcepto[] complementoConceptoField;
    
    private ComprobanteConceptosConceptoParte[] parteField;
    
    private string claveProdServField;
    
    private string noIdentificacionField;
    
    private decimal cantidadField;
    
    private string claveUnidadField;
    
    private string unidadField;
    
    private string descripcionField;
    
    private decimal valorUnitarioField;
    
    private decimal importeField;
    
    private decimal descuentoField;
    
    private bool descuentoFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Impuestos")]
    public Impuestos[] Impuestos {
        get {
            return this.impuestosField;
        }
        set {
            this.impuestosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera")]
    public InformacionAduanera[] InformacionAduanera {
        get {
            return this.informacionAduaneraField;
        }
        set {
            this.informacionAduaneraField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CuentaPredial")]
    public ComprobanteConceptosConceptoCuentaPredial[] CuentaPredial {
        get {
            return this.cuentaPredialField;
        }
        set {
            this.cuentaPredialField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ComplementoConcepto")]
    public ComprobanteConceptosConceptoComplementoConcepto[] ComplementoConcepto {
        get {
            return this.complementoConceptoField;
        }
        set {
            this.complementoConceptoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Parte")]
    public ComprobanteConceptosConceptoParte[] Parte {
        get {
            return this.parteField;
        }
        set {
            this.parteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ClaveProdServ {
        get {
            return this.claveProdServField;
        }
        set {
            this.claveProdServField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NoIdentificacion {
        get {
            return this.noIdentificacionField;
        }
        set {
            this.noIdentificacionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Cantidad {
        get {
            return this.cantidadField;
        }
        set {
            this.cantidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ClaveUnidad {
        get {
            return this.claveUnidadField;
        }
        set {
            this.claveUnidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Unidad {
        get {
            return this.unidadField;
        }
        set {
            this.unidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Descripcion {
        get {
            return this.descripcionField;
        }
        set {
            this.descripcionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ValorUnitario {
        get {
            return this.valorUnitarioField;
        }
        set {
            this.valorUnitarioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Descuento {
        get {
            return this.descuentoField;
        }
        set {
            this.descuentoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DescuentoSpecified {
        get {
            return this.descuentoFieldSpecified;
        }
        set {
            this.descuentoFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteConceptosConceptoCuentaPredial {
    
    private string numeroField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Numero {
        get {
            return this.numeroField;
        }
        set {
            this.numeroField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteConceptosConceptoComplementoConcepto {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteConceptosConceptoParte {
    
    private InformacionAduanera[] informacionAduaneraField;
    
    private string claveProdServField;
    
    private string noIdentificacionField;
    
    private decimal cantidadField;
    
    private string unidadField;
    
    private string descripcionField;
    
    private decimal valorUnitarioField;
    
    private bool valorUnitarioFieldSpecified;
    
    private decimal importeField;
    
    private bool importeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera")]
    public InformacionAduanera[] InformacionAduanera {
        get {
            return this.informacionAduaneraField;
        }
        set {
            this.informacionAduaneraField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ClaveProdServ {
        get {
            return this.claveProdServField;
        }
        set {
            this.claveProdServField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NoIdentificacion {
        get {
            return this.noIdentificacionField;
        }
        set {
            this.noIdentificacionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Cantidad {
        get {
            return this.cantidadField;
        }
        set {
            this.cantidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Unidad {
        get {
            return this.unidadField;
        }
        set {
            this.unidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Descripcion {
        get {
            return this.descripcionField;
        }
        set {
            this.descripcionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ValorUnitario {
        get {
            return this.valorUnitarioField;
        }
        set {
            this.valorUnitarioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ValorUnitarioSpecified {
        get {
            return this.valorUnitarioFieldSpecified;
        }
        set {
            this.valorUnitarioFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImporteSpecified {
        get {
            return this.importeFieldSpecified;
        }
        set {
            this.importeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteComplemento {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteAddenda {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/3")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.sat.gob.mx/cfd/3", IsNullable=false)]
public partial class NewDataSet {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Comprobante", typeof(Comprobante))]
    [System.Xml.Serialization.XmlElementAttribute("Impuestos", typeof(Impuestos))]
    [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera", typeof(InformacionAduanera))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}
