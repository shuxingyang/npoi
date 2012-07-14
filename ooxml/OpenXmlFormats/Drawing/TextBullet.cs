// ------------------------------------------------------------------------------
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
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TextBulletColorFollowText
    {
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TextBulletSizeFollowText
    {
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TextBulletSizePercent
    {

        private int valField;

        private bool valFieldSpecified;

        [XmlAttribute]
        public int val
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

        [XmlIgnore]
        public bool valSpecified
        {
            get
            {
                return this.valFieldSpecified;
            }
            set
            {
                this.valFieldSpecified = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TextBulletSizePoint
    {

        private int valField;

        private bool valFieldSpecified;

        [XmlAttribute]
        public int val
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

        [XmlIgnore]
        public bool valSpecified
        {
            get
            {
                return this.valFieldSpecified;
            }
            set
            {
                this.valFieldSpecified = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TextBulletTypefaceFollowText
    {
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TextAutonumberBullet
    {

        private ST_TextAutonumberScheme typeField;

        private int startAtField;

        public CT_TextAutonumberBullet()
        {
            this.startAtField = 1;
        }

        [XmlAttribute]
        public ST_TextAutonumberScheme type
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
        [DefaultValue(1)]
        public int startAt
        {
            get
            {
                return this.startAtField;
            }
            set
            {
                this.startAtField = value;
            }
        }
    }


    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_TextAutonumberScheme
    {

        /// <remarks/>
        alphaLcParenBoth,

        /// <remarks/>
        alphaUcParenBoth,

        /// <remarks/>
        alphaLcParenR,

        /// <remarks/>
        alphaUcParenR,

        /// <remarks/>
        alphaLcPeriod,

        /// <remarks/>
        alphaUcPeriod,

        /// <remarks/>
        arabicParenBoth,

        /// <remarks/>
        arabicParenR,

        /// <remarks/>
        arabicPeriod,

        /// <remarks/>
        arabicPlain,

        /// <remarks/>
        romanLcParenBoth,

        /// <remarks/>
        romanUcParenBoth,

        /// <remarks/>
        romanLcParenR,

        /// <remarks/>
        romanUcParenR,

        /// <remarks/>
        romanLcPeriod,

        /// <remarks/>
        romanUcPeriod,

        /// <remarks/>
        circleNumDbPlain,

        /// <remarks/>
        circleNumWdBlackPlain,

        /// <remarks/>
        circleNumWdWhitePlain,

        /// <remarks/>
        arabicDbPeriod,

        /// <remarks/>
        arabicDbPlain,

        /// <remarks/>
        ea1ChsPeriod,

        /// <remarks/>
        ea1ChsPlain,

        /// <remarks/>
        ea1ChtPeriod,

        /// <remarks/>
        ea1ChtPlain,

        /// <remarks/>
        ea1JpnChsDbPeriod,

        /// <remarks/>
        ea1JpnKorPlain,

        /// <remarks/>
        ea1JpnKorPeriod,

        /// <remarks/>
        arabic1Minus,

        /// <remarks/>
        arabic2Minus,

        /// <remarks/>
        hebrew2Minus,

        /// <remarks/>
        thaiAlphaPeriod,

        /// <remarks/>
        thaiAlphaParenR,

        /// <remarks/>
        thaiAlphaParenBoth,

        /// <remarks/>
        thaiNumPeriod,

        /// <remarks/>
        thaiNumParenR,

        /// <remarks/>
        thaiNumParenBoth,

        /// <remarks/>
        hindiAlphaPeriod,

        /// <remarks/>
        hindiNumPeriod,

        /// <remarks/>
        hindiNumParenR,

        /// <remarks/>
        hindiAlpha1Period,
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TextCharBullet
    {

        private string charField;

        [XmlAttribute]
        public string @char
        {
            get
            {
                return this.charField;
            }
            set
            {
                this.charField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TextBlipBullet
    {

        private CT_Blip blipField;

        public CT_TextBlipBullet()
        {
            this.blipField = new CT_Blip();
        }

        [XmlElement(Order = 0)]
        public CT_Blip blip
        {
            get
            {
                return this.blipField;
            }
            set
            {
                this.blipField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TextNoBullet
    {
    }
}
