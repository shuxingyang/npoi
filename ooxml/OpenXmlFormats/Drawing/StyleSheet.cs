﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>NPOI.OpenXmlFormats.Dml</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace NPOI.OpenXmlFormats.Dml
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot("themeManager", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class CT_EmptyElement
    {
    }

    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_ColorMapping
    {

        private CT_OfficeArtExtensionList extLstField;

        private ST_ColorSchemeIndex bg1Field;

        private ST_ColorSchemeIndex tx1Field;

        private ST_ColorSchemeIndex bg2Field;

        private ST_ColorSchemeIndex tx2Field;

        private ST_ColorSchemeIndex accent1Field;

        private ST_ColorSchemeIndex accent2Field;

        private ST_ColorSchemeIndex accent3Field;

        private ST_ColorSchemeIndex accent4Field;

        private ST_ColorSchemeIndex accent5Field;

        private ST_ColorSchemeIndex accent6Field;

        private ST_ColorSchemeIndex hlinkField;

        private ST_ColorSchemeIndex folHlinkField;

        public CT_ColorMapping()
        {
            this.extLstField = new CT_OfficeArtExtensionList();
        }

        [XmlElement(Order = 0)]
        public CT_OfficeArtExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        [XmlAttribute]
        public ST_ColorSchemeIndex bg1
        {
            get
            {
                return this.bg1Field;
            }
            set
            {
                this.bg1Field = value;
            }
        }

        [XmlAttribute]
        public ST_ColorSchemeIndex tx1
        {
            get
            {
                return this.tx1Field;
            }
            set
            {
                this.tx1Field = value;
            }
        }

        [XmlAttribute]
        public ST_ColorSchemeIndex bg2
        {
            get
            {
                return this.bg2Field;
            }
            set
            {
                this.bg2Field = value;
            }
        }

        [XmlAttribute]
        public ST_ColorSchemeIndex tx2
        {
            get
            {
                return this.tx2Field;
            }
            set
            {
                this.tx2Field = value;
            }
        }

        [XmlAttribute]
        public ST_ColorSchemeIndex accent1
        {
            get
            {
                return this.accent1Field;
            }
            set
            {
                this.accent1Field = value;
            }
        }

        [XmlAttribute]
        public ST_ColorSchemeIndex accent2
        {
            get
            {
                return this.accent2Field;
            }
            set
            {
                this.accent2Field = value;
            }
        }

        [XmlAttribute]
        public ST_ColorSchemeIndex accent3
        {
            get
            {
                return this.accent3Field;
            }
            set
            {
                this.accent3Field = value;
            }
        }

        [XmlAttribute]
        public ST_ColorSchemeIndex accent4
        {
            get
            {
                return this.accent4Field;
            }
            set
            {
                this.accent4Field = value;
            }
        }

        [XmlAttribute]
        public ST_ColorSchemeIndex accent5
        {
            get
            {
                return this.accent5Field;
            }
            set
            {
                this.accent5Field = value;
            }
        }

        [XmlAttribute]
        public ST_ColorSchemeIndex accent6
        {
            get
            {
                return this.accent6Field;
            }
            set
            {
                this.accent6Field = value;
            }
        }

        [XmlAttribute]
        public ST_ColorSchemeIndex hlink
        {
            get
            {
                return this.hlinkField;
            }
            set
            {
                this.hlinkField = value;
            }
        }

        [XmlAttribute]
        public ST_ColorSchemeIndex folHlink
        {
            get
            {
                return this.folHlinkField;
            }
            set
            {
                this.folHlinkField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_ColorMappingOverride
    {

        private object itemField;

        [XmlElement("masterClrMapping", typeof(CT_EmptyElement), Order = 0)]
        [XmlElement("overrideClrMapping", typeof(CT_ColorMapping), Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_ColorSchemeAndMapping
    {

        private CT_ColorScheme clrSchemeField;

        private CT_ColorMapping clrMapField;

        public CT_ColorSchemeAndMapping()
        {
            this.clrMapField = new CT_ColorMapping();
            this.clrSchemeField = new CT_ColorScheme();
        }

        [XmlElement(Order = 0)]
        public CT_ColorScheme clrScheme
        {
            get
            {
                return this.clrSchemeField;
            }
            set
            {
                this.clrSchemeField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_ColorMapping clrMap
        {
            get
            {
                return this.clrMapField;
            }
            set
            {
                this.clrMapField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_ColorSchemeList
    {

        private List<CT_ColorSchemeAndMapping> extraClrSchemeField;

        public CT_ColorSchemeList()
        {
            this.extraClrSchemeField = new List<CT_ColorSchemeAndMapping>();
        }

        [XmlElement("extraClrScheme", Order = 0)]
        public List<CT_ColorSchemeAndMapping> extraClrScheme
        {
            get
            {
                return this.extraClrSchemeField;
            }
            set
            {
                this.extraClrSchemeField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot("theme", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class CT_OfficeStyleSheet
    {

        private CT_BaseStyles themeElementsField;

        private CT_ObjectStyleDefaults objectDefaultsField;

        private List<CT_ColorSchemeAndMapping> extraClrSchemeLstField;

        private List<CT_CustomColor> custClrLstField;

        private CT_OfficeArtExtensionList extLstField;

        private string nameField;

        public CT_OfficeStyleSheet()
        {
            this.extLstField = new CT_OfficeArtExtensionList();
            this.custClrLstField = new List<CT_CustomColor>();
            this.extraClrSchemeLstField = new List<CT_ColorSchemeAndMapping>();
            this.objectDefaultsField = new CT_ObjectStyleDefaults();
            this.themeElementsField = new CT_BaseStyles();
            this.nameField = "";
        }

        //[XmlElement(Order = 0)]
        [XmlIgnore] // TODO
        public CT_BaseStyles themeElements
        {
            get
            {
                return this.themeElementsField;
            }
            set
            {
                this.themeElementsField = value;
            }
        }

        //[XmlElement(Order = 1)]
        [XmlIgnore] // TODO
        public CT_ObjectStyleDefaults objectDefaults
        {
            get
            {
                return this.objectDefaultsField;
            }
            set
            {
                this.objectDefaultsField = value;
            }
        }

        //[System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        //[System.Xml.Serialization.XmlArrayItemAttribute("extraClrScheme", IsNullable = false)]
        [XmlIgnore] // TODO
        public List<CT_ColorSchemeAndMapping> extraClrSchemeLst
        {
            get
            {
                return this.extraClrSchemeLstField;
            }
            set
            {
                this.extraClrSchemeLstField = value;
            }
        }

        //[System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        //[System.Xml.Serialization.XmlArrayItemAttribute("custClr", IsNullable = false)]
        [XmlIgnore] // TODO
        public List<CT_CustomColor> custClrLst
        {
            get
            {
                return this.custClrLstField;
            }
            set
            {
                this.custClrLstField = value;
            }
        }

        //[XmlElement(Order = 4)]
        [XmlIgnore] // TODO
        public CT_OfficeArtExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue("")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot("themeOverride", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class CT_BaseStylesOverride
    {

        private CT_ColorScheme clrSchemeField;

        private CT_FontScheme fontSchemeField;

        private CT_StyleMatrix fmtSchemeField;

        public CT_BaseStylesOverride()
        {
            this.fmtSchemeField = new CT_StyleMatrix();
            this.fontSchemeField = new CT_FontScheme();
            this.clrSchemeField = new CT_ColorScheme();
        }

        [XmlElement(Order = 0)]
        public CT_ColorScheme clrScheme
        {
            get
            {
                return this.clrSchemeField;
            }
            set
            {
                this.clrSchemeField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_FontScheme fontScheme
        {
            get
            {
                return this.fontSchemeField;
            }
            set
            {
                this.fontSchemeField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_StyleMatrix fmtScheme
        {
            get
            {
                return this.fmtSchemeField;
            }
            set
            {
                this.fmtSchemeField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_ClipboardStyleSheet
    {

        private CT_BaseStyles themeElementsField;

        private CT_ColorMapping clrMapField;

        public CT_ClipboardStyleSheet()
        {
            this.clrMapField = new CT_ColorMapping();
            this.themeElementsField = new CT_BaseStyles();
        }

        [XmlElement(Order = 0)]
        public CT_BaseStyles themeElements
        {
            get
            {
                return this.themeElementsField;
            }
            set
            {
                this.themeElementsField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_ColorMapping clrMap
        {
            get
            {
                return this.clrMapField;
            }
            set
            {
                this.clrMapField = value;
            }
        }
    }
}
