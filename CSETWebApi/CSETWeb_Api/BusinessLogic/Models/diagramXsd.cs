﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace CSETWeb_Api.BusinessLogic.Models {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class mxGraphModel {
        
        private mxGraphModelRoot rootField;
        
        private string dxField;
        
        private string dyField;
        
        private string gridField;
        
        private string gridSizeField;
        
        private string guidesField;
        
        private string tooltipsField;
        
        private string connectField;
        
        private string arrowsField;
        
        private string foldField;
        
        private string pageField;
        
        private string pageScaleField;
        
        private string pageWidthField;
        
        private string pageHeightField;
        
        private string mathField;
        
        private string shadowField;
        
        /// <remarks/>
        public mxGraphModelRoot root {
            get {
                return this.rootField;
            }
            set {
                this.rootField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dx {
            get {
                return this.dxField;
            }
            set {
                this.dxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dy {
            get {
                return this.dyField;
            }
            set {
                this.dyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string grid {
            get {
                return this.gridField;
            }
            set {
                this.gridField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string gridSize {
            get {
                return this.gridSizeField;
            }
            set {
                this.gridSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string guides {
            get {
                return this.guidesField;
            }
            set {
                this.guidesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tooltips {
            get {
                return this.tooltipsField;
            }
            set {
                this.tooltipsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string connect {
            get {
                return this.connectField;
            }
            set {
                this.connectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string arrows {
            get {
                return this.arrowsField;
            }
            set {
                this.arrowsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fold {
            get {
                return this.foldField;
            }
            set {
                this.foldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string page {
            get {
                return this.pageField;
            }
            set {
                this.pageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pageScale {
            get {
                return this.pageScaleField;
            }
            set {
                this.pageScaleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pageWidth {
            get {
                return this.pageWidthField;
            }
            set {
                this.pageWidthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pageHeight {
            get {
                return this.pageHeightField;
            }
            set {
                this.pageHeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string math {
            get {
                return this.mathField;
            }
            set {
                this.mathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string shadow {
            get {
                return this.shadowField;
            }
            set {
                this.shadowField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class mxGraphModelRoot {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mxCell", typeof(mxGraphModelRootMxCell))]
        [System.Xml.Serialization.XmlElementAttribute("object", typeof(mxGraphModelRootObject))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class mxGraphModelRootMxCell {
        
        private mxGraphModelRootMxCellMxGeometry mxGeometryField;
        
        private string idField;
        
        private string valueField;
        
        private string parentField;
        
        private string styleField;
        
        private string sourceField;
        
        private string targetField;
        
        private string edgeField;
        
        private string vertexField;
        
        private string layerNameField;
        
        private string visibleField;
        
        /// <remarks/>
        public mxGraphModelRootMxCellMxGeometry mxGeometry {
            get {
                return this.mxGeometryField;
            }
            set {
                this.mxGeometryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string style {
            get {
                return this.styleField;
            }
            set {
                this.styleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string edge {
            get {
                return this.edgeField;
            }
            set {
                this.edgeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vertex {
            get {
                return this.vertexField;
            }
            set {
                this.vertexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string layerName {
            get {
                return this.layerNameField;
            }
            set {
                this.layerNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string visible {
            get {
                return this.visibleField;
            }
            set {
                this.visibleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class mxGraphModelRootMxCellMxGeometry {
        
        private mxGraphModelRootMxCellMxGeometryMxPoint mxPointField;
        
        private string relativeField;
        
        private string asField;
        
        private string xField;
        
        private string yField;
        
        private decimal widthField;
        
        private bool widthFieldSpecified;
        
        private decimal heightField;
        
        private bool heightFieldSpecified;
        
        /// <remarks/>
        public mxGraphModelRootMxCellMxGeometryMxPoint mxPoint {
            get {
                return this.mxPointField;
            }
            set {
                this.mxPointField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string relative {
            get {
                return this.relativeField;
            }
            set {
                this.relativeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @as {
            get {
                return this.asField;
            }
            set {
                this.asField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified {
            get {
                return this.widthFieldSpecified;
            }
            set {
                this.widthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified {
            get {
                return this.heightFieldSpecified;
            }
            set {
                this.heightFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class mxGraphModelRootMxCellMxGeometryMxPoint {
        
        private string xField;
        
        private string yField;
        
        private string asField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @as {
            get {
                return this.asField;
            }
            set {
                this.asField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class mxGraphModelRootObject {
        
        private mxGraphModelRootObjectMxCell mxCellField;
        
        private string sALField;
        
        private string labelField;
        
        private string internalLabelField;
        
        private string zoneTypeField;
        
        private string zoneField;
        
        private string idField;
        
        private string componentGuidField;
        
        private string hasUniqueQuestionsField;
        
        private string iPAddressField;
        
        private string descriptionField;
        
        private string criticalityField;
        
        private string hostNameField;
        
        private string parentField;
        
        private string securityField;
        
        private string linkTypeField;
        
        private string layerNameField;
        
        private string visibleField;
        
        /// <remarks/>
        public mxGraphModelRootObjectMxCell mxCell {
            get {
                return this.mxCellField;
            }
            set {
                this.mxCellField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SAL {
            get {
                return this.sALField;
            }
            set {
                this.sALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalLabel {
            get {
                return this.internalLabelField;
            }
            set {
                this.internalLabelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zoneType {
            get {
                return this.zoneTypeField;
            }
            set {
                this.zoneTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zone {
            get {
                return this.zoneField;
            }
            set {
                this.zoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ComponentGuid {
            get {
                return this.componentGuidField;
            }
            set {
                this.componentGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HasUniqueQuestions {
            get {
                return this.hasUniqueQuestionsField;
            }
            set {
                this.hasUniqueQuestionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IPAddress {
            get {
                return this.iPAddressField;
            }
            set {
                this.iPAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Criticality {
            get {
                return this.criticalityField;
            }
            set {
                this.criticalityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HostName {
            get {
                return this.hostNameField;
            }
            set {
                this.hostNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Security {
            get {
                return this.securityField;
            }
            set {
                this.securityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LinkType {
            get {
                return this.linkTypeField;
            }
            set {
                this.linkTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string layerName {
            get {
                return this.layerNameField;
            }
            set {
                this.layerNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string visible {
            get {
                return this.visibleField;
            }
            set {
                this.visibleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class mxGraphModelRootObjectMxCell {
        
        private mxGraphModelRootObjectMxCellMxGeometry mxGeometryField;
        
        private string styleField;
        
        private string parentField;
        
        private string vertexField;
        
        /// <remarks/>
        public mxGraphModelRootObjectMxCellMxGeometry mxGeometry {
            get {
                return this.mxGeometryField;
            }
            set {
                this.mxGeometryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string style {
            get {
                return this.styleField;
            }
            set {
                this.styleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vertex {
            get {
                return this.vertexField;
            }
            set {
                this.vertexField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class mxGraphModelRootObjectMxCellMxGeometry {
        
        private string xField;
        
        private string yField;
        
        private string widthField;
        
        private string heightField;
        
        private string asField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @as {
            get {
                return this.asField;
            }
            set {
                this.asField = value;
            }
        }
    }
}
