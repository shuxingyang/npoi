// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>NPOI.OpenXmlFormats.Dml.Diagram</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace NPOI.OpenXmlFormats.Dml.Diagram
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
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    [XmlRoot("styleDef", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
    public partial class CT_StyleDefinition
    {

        private List<CT_SDName> titleField;

        private List<CT_SDDescription> descField;

        private List<CT_SDCategory> catLstField;

        private CT_Scene3D scene3dField;

        private List<CT_StyleLabel> styleLblField;

        private CT_OfficeArtExtensionList extLstField;

        private string uniqueIdField;

        private string minVerField;

        public CT_StyleDefinition()
        {
            this.extLstField = new CT_OfficeArtExtensionList();
            this.styleLblField = new List<CT_StyleLabel>();
            this.scene3dField = new CT_Scene3D();
            this.catLstField = new List<CT_SDCategory>();
            this.descField = new List<CT_SDDescription>();
            this.titleField = new List<CT_SDName>();
            this.uniqueIdField = "";
            this.minVerField = "http://schemas.openxmlformats.org/drawingml/2006/diagram";
        }

        [XmlElement("title", Order = 0)]
        public List<CT_SDName> title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        [XmlElement("desc", Order = 1)]
        public List<CT_SDDescription> desc
        {
            get
            {
                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("cat", IsNullable = false)]
        public List<CT_SDCategory> catLst
        {
            get
            {
                return this.catLstField;
            }
            set
            {
                this.catLstField = value;
            }
        }

        [XmlElement(Order = 3)]
        public CT_Scene3D scene3d
        {
            get
            {
                return this.scene3dField;
            }
            set
            {
                this.scene3dField = value;
            }
        }

        [XmlElement("styleLbl", Order = 4)]
        public List<CT_StyleLabel> styleLbl
        {
            get
            {
                return this.styleLblField;
            }
            set
            {
                this.styleLblField = value;
            }
        }

        [XmlElement(Order = 5)]
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
        public string uniqueId
        {
            get
            {
                return this.uniqueIdField;
            }
            set
            {
                this.uniqueIdField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue("http://schemas.openxmlformats.org/drawingml/2006/diagram")]
        public string minVer
        {
            get
            {
                return this.minVerField;
            }
            set
            {
                this.minVerField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
    public partial class CT_SDName
    {

        private string langField;

        private string valField;

        public CT_SDName()
        {
            this.langField = "";
        }

        [XmlAttribute]
        [DefaultValue("")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        [XmlAttribute]
        public string val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
    public partial class CT_TextProps
    {

        private CT_Shape3D sp3dField;

        private CT_FlatText flatTxField;

        public CT_TextProps()
        {
            this.sp3dField = new CT_Shape3D();
        }

        [XmlElement(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", Order = 0)]
        public CT_Shape3D sp3d
        {
            get
            {
                return this.sp3dField;
            }
            set
            {
                this.sp3dField = value;
            }
        }

        [XmlElement(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", Order = 1)]
        public CT_FlatText flatTx
        {
            get
            {
                return this.flatTxField;
            }
            set
            {
                this.flatTxField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
    public partial class CT_StyleLabel
    {

        private CT_Scene3D scene3dField;

        private CT_Shape3D sp3dField;

        private CT_TextProps txPrField;

        private CT_ShapeStyle styleField;

        private CT_OfficeArtExtensionList extLstField;

        private string nameField;

        public CT_StyleLabel()
        {
            this.txPrField = new CT_TextProps();
            this.scene3dField = new CT_Scene3D();
        }

        [XmlElement(Order = 0)]
        public CT_Scene3D scene3d
        {
            get
            {
                return this.scene3dField;
            }
            set
            {
                this.scene3dField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_Shape3D sp3d
        {
            get
            {
                return this.sp3dField;
            }
            set
            {
                this.sp3dField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_TextProps txPr
        {
            get
            {
                return this.txPrField;
            }
            set
            {
                this.txPrField = value;
            }
        }

        [XmlElement(Order = 3)]
        public CT_ShapeStyle style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }

        [XmlElement(Order = 4)]
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
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
    public partial class CT_SDCategory
    {

        private string typeField;

        private uint priField;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        [XmlAttribute]
        public uint pri
        {
            get
            {
                return this.priField;
            }
            set
            {
                this.priField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
    public partial class CT_SDDescription
    {

        private string langField;

        private string valField;

        public CT_SDDescription()
        {
            this.langField = "";
        }

        [XmlAttribute]
        [DefaultValue("")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        [XmlAttribute]
        public string val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    [XmlRoot("styleDefHdr", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
    public partial class CT_StyleDefinitionHeader
    {

        private List<CT_SDName> titleField;

        private List<CT_SDDescription> descField;

        private List<CT_SDCategory> catLstField;

        private CT_OfficeArtExtensionList extLstField;

        private string uniqueIdField;

        private string minVerField;

        private int resIdField;

        public CT_StyleDefinitionHeader()
        {
            this.catLstField = new List<CT_SDCategory>();
            this.descField = new List<CT_SDDescription>();
            this.titleField = new List<CT_SDName>();
            this.minVerField = "http://schemas.openxmlformats.org/drawingml/2006/diagram";
            this.resIdField = 0;
        }

        [XmlElement("title", Order = 0)]
        public List<CT_SDName> title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        [XmlElement("desc", Order = 1)]
        public List<CT_SDDescription> desc
        {
            get
            {
                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("cat", IsNullable = false)]
        public List<CT_SDCategory> catLst
        {
            get
            {
                return this.catLstField;
            }
            set
            {
                this.catLstField = value;
            }
        }

        [XmlElement(Order = 3)]
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
        public string uniqueId
        {
            get
            {
                return this.uniqueIdField;
            }
            set
            {
                this.uniqueIdField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue("http://schemas.openxmlformats.org/drawingml/2006/diagram")]
        public string minVer
        {
            get
            {
                return this.minVerField;
            }
            set
            {
                this.minVerField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(0)]
        public int resId
        {
            get
            {
                return this.resIdField;
            }
            set
            {
                this.resIdField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    [XmlRoot("styleDefHdrLst", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
    public partial class CT_StyleDefinitionHeaderLst
    {

        private List<CT_StyleDefinitionHeader> styleDefHdrField;

        public CT_StyleDefinitionHeaderLst()
        {
            this.styleDefHdrField = new List<CT_StyleDefinitionHeader>();
        }

        [XmlElement("styleDefHdr", Order = 0)]
        public List<CT_StyleDefinitionHeader> styleDefHdr
        {
            get
            {
                return this.styleDefHdrField;
            }
            set
            {
                this.styleDefHdrField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
    public partial class CT_SDCategories
    {

        private List<CT_SDCategory> catField;

        public CT_SDCategories()
        {
            this.catField = new List<CT_SDCategory>();
        }

        [XmlElement("cat", Order = 0)]
        public List<CT_SDCategory> cat
        {
            get
            {
                return this.catField;
            }
            set
            {
                this.catField = value;
            }
        }
    }
}
