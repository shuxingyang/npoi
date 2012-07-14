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
    public partial class CT_TextFont
    {

        private string typefaceField;

        private byte[] panoseField;

        private sbyte pitchFamilyField;

        private sbyte charsetField;

        public CT_TextFont()
        {
            this.pitchFamilyField = ((sbyte)(0));
            this.charsetField = ((sbyte)(1));
        }

        [XmlAttribute]
        public string typeface
        {
            get
            {
                return this.typefaceField;
            }
            set
            {
                this.typefaceField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "hexBinary")]
        public byte[] panose
        {
            get
            {
                return this.panoseField;
            }
            set
            {
                this.panoseField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(typeof(sbyte), "0")]
        public sbyte pitchFamily
        {
            get
            {
                return this.pitchFamilyField;
            }
            set
            {
                this.pitchFamilyField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(typeof(sbyte), "1")]
        public sbyte charset
        {
            get
            {
                return this.charsetField;
            }
            set
            {
                this.charsetField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TextUnderlineLineFollowText
    {
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TextUnderlineFillFollowText
    {
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TextUnderlineFillGroupWrapper
    {

        private object itemField;

        [XmlElement("blipFill", typeof(CT_BlipFillProperties), Order = 0)]
        [XmlElement("gradFill", typeof(CT_GradientFillProperties), Order = 0)]
        [XmlElement("grpFill", typeof(CT_GroupFillProperties), Order = 0)]
        [XmlElement("noFill", typeof(CT_NoFillProperties), Order = 0)]
        [XmlElement("pattFill", typeof(CT_PatternFillProperties), Order = 0)]
        [XmlElement("solidFill", typeof(CT_SolidColorFillProperties), Order = 0)]
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
    public partial class CT_TextCharacterProperties
    {

        private CT_LineProperties lnField;

        private CT_NoFillProperties noFillField;

        private CT_SolidColorFillProperties solidFillField;

        private CT_GradientFillProperties gradFillField;

        private CT_BlipFillProperties blipFillField;

        private CT_PatternFillProperties pattFillField;

        private CT_GroupFillProperties grpFillField;

        private CT_EffectList effectLstField;

        private CT_EffectContainer effectDagField;

        private CT_Color highlightField;

        private CT_TextUnderlineLineFollowText uLnTxField;

        private CT_LineProperties uLnField;

        private CT_TextUnderlineFillFollowText uFillTxField;

        private CT_TextUnderlineFillGroupWrapper uFillField;

        private CT_TextFont latinField;

        private CT_TextFont eaField;

        private CT_TextFont csField;

        private CT_TextFont symField;

        private CT_Hyperlink hlinkClickField;

        private CT_Hyperlink hlinkMouseOverField;

        private CT_OfficeArtExtensionList extLstField;

        private bool kumimojiField;

        private bool kumimojiFieldSpecified;

        private string langField;

        private string altLangField;

        private int szField;

        private bool szFieldSpecified;

        private bool bField;

        private bool bFieldSpecified;

        private bool iField;

        private bool iFieldSpecified;

        private ST_TextUnderlineType uField;

        private bool uFieldSpecified;

        private ST_TextStrikeType strikeField;

        private bool strikeFieldSpecified;

        private int kernField;

        private bool kernFieldSpecified;

        private ST_TextCapsType capField;

        private bool capFieldSpecified;

        private int spcField;

        private bool spcFieldSpecified;

        private bool normalizeHField;

        private bool normalizeHFieldSpecified;

        private int baselineField;

        private bool baselineFieldSpecified;

        private bool noProofField;

        private bool noProofFieldSpecified;

        private bool dirtyField;

        private bool errField;

        private bool smtCleanField;

        private uint smtIdField;

        private string bmkField;

        public CT_TextCharacterProperties()
        {
            this.extLstField = new CT_OfficeArtExtensionList();
            this.hlinkMouseOverField = new CT_Hyperlink();
            this.hlinkClickField = new CT_Hyperlink();
            this.symField = new CT_TextFont();
            this.csField = new CT_TextFont();
            this.eaField = new CT_TextFont();
            this.latinField = new CT_TextFont();
            this.uFillField = new CT_TextUnderlineFillGroupWrapper();
            this.uFillTxField = new CT_TextUnderlineFillFollowText();
            this.uLnField = new CT_LineProperties();
            this.uLnTxField = new CT_TextUnderlineLineFollowText();
            this.highlightField = new CT_Color();
            this.effectDagField = new CT_EffectContainer();
            this.effectLstField = new CT_EffectList();
            this.grpFillField = new CT_GroupFillProperties();
            this.pattFillField = new CT_PatternFillProperties();
            this.blipFillField = new CT_BlipFillProperties();
            this.gradFillField = new CT_GradientFillProperties();
            this.solidFillField = new CT_SolidColorFillProperties();
            this.noFillField = new CT_NoFillProperties();
            this.lnField = new CT_LineProperties();
            this.dirtyField = true;
            this.errField = false;
            this.smtCleanField = true;
            this.smtIdField = ((uint)(0));
        }

        [XmlElement(Order = 0)]
        public CT_LineProperties ln
        {
            get
            {
                return this.lnField;
            }
            set
            {
                this.lnField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_NoFillProperties noFill
        {
            get
            {
                return this.noFillField;
            }
            set
            {
                this.noFillField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_SolidColorFillProperties solidFill
        {
            get
            {
                return this.solidFillField;
            }
            set
            {
                this.solidFillField = value;
            }
        }

        [XmlElement(Order = 3)]
        public CT_GradientFillProperties gradFill
        {
            get
            {
                return this.gradFillField;
            }
            set
            {
                this.gradFillField = value;
            }
        }

        [XmlElement(Order = 4)]
        public CT_BlipFillProperties blipFill
        {
            get
            {
                return this.blipFillField;
            }
            set
            {
                this.blipFillField = value;
            }
        }

        [XmlElement(Order = 5)]
        public CT_PatternFillProperties pattFill
        {
            get
            {
                return this.pattFillField;
            }
            set
            {
                this.pattFillField = value;
            }
        }

        [XmlElement(Order = 6)]
        public CT_GroupFillProperties grpFill
        {
            get
            {
                return this.grpFillField;
            }
            set
            {
                this.grpFillField = value;
            }
        }

        [XmlElement(Order = 7)]
        public CT_EffectList effectLst
        {
            get
            {
                return this.effectLstField;
            }
            set
            {
                this.effectLstField = value;
            }
        }

        [XmlElement(Order = 8)]
        public CT_EffectContainer effectDag
        {
            get
            {
                return this.effectDagField;
            }
            set
            {
                this.effectDagField = value;
            }
        }

        [XmlElement(Order = 9)]
        public CT_Color highlight
        {
            get
            {
                return this.highlightField;
            }
            set
            {
                this.highlightField = value;
            }
        }

        [XmlElement(Order = 10)]
        public CT_TextUnderlineLineFollowText uLnTx
        {
            get
            {
                return this.uLnTxField;
            }
            set
            {
                this.uLnTxField = value;
            }
        }

        [XmlElement(Order = 11)]
        public CT_LineProperties uLn
        {
            get
            {
                return this.uLnField;
            }
            set
            {
                this.uLnField = value;
            }
        }

        [XmlElement(Order = 12)]
        public CT_TextUnderlineFillFollowText uFillTx
        {
            get
            {
                return this.uFillTxField;
            }
            set
            {
                this.uFillTxField = value;
            }
        }

        [XmlElement(Order = 13)]
        public CT_TextUnderlineFillGroupWrapper uFill
        {
            get
            {
                return this.uFillField;
            }
            set
            {
                this.uFillField = value;
            }
        }

        [XmlElement(Order = 14)]
        public CT_TextFont latin
        {
            get
            {
                return this.latinField;
            }
            set
            {
                this.latinField = value;
            }
        }

        [XmlElement(Order = 15)]
        public CT_TextFont ea
        {
            get
            {
                return this.eaField;
            }
            set
            {
                this.eaField = value;
            }
        }

        [XmlElement(Order = 16)]
        public CT_TextFont cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        [XmlElement(Order = 17)]
        public CT_TextFont sym
        {
            get
            {
                return this.symField;
            }
            set
            {
                this.symField = value;
            }
        }

        [XmlElement(Order = 18)]
        public CT_Hyperlink hlinkClick
        {
            get
            {
                return this.hlinkClickField;
            }
            set
            {
                this.hlinkClickField = value;
            }
        }

        [XmlElement(Order = 19)]
        public CT_Hyperlink hlinkMouseOver
        {
            get
            {
                return this.hlinkMouseOverField;
            }
            set
            {
                this.hlinkMouseOverField = value;
            }
        }

        [XmlElement(Order = 20)]
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
        public bool kumimoji
        {
            get
            {
                return this.kumimojiField;
            }
            set
            {
                this.kumimojiField = value;
            }
        }

        [XmlIgnore]
        public bool kumimojiSpecified
        {
            get
            {
                return this.kumimojiFieldSpecified;
            }
            set
            {
                this.kumimojiFieldSpecified = value;
            }
        }

        [XmlAttribute]
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
        public string altLang
        {
            get
            {
                return this.altLangField;
            }
            set
            {
                this.altLangField = value;
            }
        }

        [XmlAttribute]
        public int sz
        {
            get
            {
                return this.szField;
            }
            set
            {
                this.szField = value;
            }
        }

        [XmlIgnore]
        public bool szSpecified
        {
            get
            {
                return this.szFieldSpecified;
            }
            set
            {
                this.szFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool b
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }

        [XmlIgnore]
        public bool bSpecified
        {
            get
            {
                return this.bFieldSpecified;
            }
            set
            {
                this.bFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool i
        {
            get
            {
                return this.iField;
            }
            set
            {
                this.iField = value;
            }
        }

        [XmlIgnore]
        public bool iSpecified
        {
            get
            {
                return this.iFieldSpecified;
            }
            set
            {
                this.iFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public ST_TextUnderlineType u
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        [XmlIgnore]
        public bool uSpecified
        {
            get
            {
                return this.uFieldSpecified;
            }
            set
            {
                this.uFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public ST_TextStrikeType strike
        {
            get
            {
                return this.strikeField;
            }
            set
            {
                this.strikeField = value;
            }
        }

        [XmlIgnore]
        public bool strikeSpecified
        {
            get
            {
                return this.strikeFieldSpecified;
            }
            set
            {
                this.strikeFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int kern
        {
            get
            {
                return this.kernField;
            }
            set
            {
                this.kernField = value;
            }
        }

        [XmlIgnore]
        public bool kernSpecified
        {
            get
            {
                return this.kernFieldSpecified;
            }
            set
            {
                this.kernFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public ST_TextCapsType cap
        {
            get
            {
                return this.capField;
            }
            set
            {
                this.capField = value;
            }
        }

        [XmlIgnore]
        public bool capSpecified
        {
            get
            {
                return this.capFieldSpecified;
            }
            set
            {
                this.capFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int spc
        {
            get
            {
                return this.spcField;
            }
            set
            {
                this.spcField = value;
            }
        }

        [XmlIgnore]
        public bool spcSpecified
        {
            get
            {
                return this.spcFieldSpecified;
            }
            set
            {
                this.spcFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool normalizeH
        {
            get
            {
                return this.normalizeHField;
            }
            set
            {
                this.normalizeHField = value;
            }
        }

        [XmlIgnore]
        public bool normalizeHSpecified
        {
            get
            {
                return this.normalizeHFieldSpecified;
            }
            set
            {
                this.normalizeHFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int baseline
        {
            get
            {
                return this.baselineField;
            }
            set
            {
                this.baselineField = value;
            }
        }

        [XmlIgnore]
        public bool baselineSpecified
        {
            get
            {
                return this.baselineFieldSpecified;
            }
            set
            {
                this.baselineFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool noProof
        {
            get
            {
                return this.noProofField;
            }
            set
            {
                this.noProofField = value;
            }
        }

        [XmlIgnore]
        public bool noProofSpecified
        {
            get
            {
                return this.noProofFieldSpecified;
            }
            set
            {
                this.noProofFieldSpecified = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(true)]
        public bool dirty
        {
            get
            {
                return this.dirtyField;
            }
            set
            {
                this.dirtyField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool err
        {
            get
            {
                return this.errField;
            }
            set
            {
                this.errField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(true)]
        public bool smtClean
        {
            get
            {
                return this.smtCleanField;
            }
            set
            {
                this.smtCleanField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(typeof(uint), "0")]
        public uint smtId
        {
            get
            {
                return this.smtIdField;
            }
            set
            {
                this.smtIdField = value;
            }
        }

        [XmlAttribute]
        public string bmk
        {
            get
            {
                return this.bmkField;
            }
            set
            {
                this.bmkField = value;
            }
        }

        public CT_TextFont AddNewLatin()
        {
            throw new NotImplementedException();
        }
    }


    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_TextUnderlineType
    {

        /// <remarks/>
        none,

        /// <remarks/>
        words,

        /// <remarks/>
        sng,

        /// <remarks/>
        dbl,

        /// <remarks/>
        heavy,

        /// <remarks/>
        dotted,

        /// <remarks/>
        dottedHeavy,

        /// <remarks/>
        dash,

        /// <remarks/>
        dashHeavy,

        /// <remarks/>
        dashLong,

        /// <remarks/>
        dashLongHeavy,

        /// <remarks/>
        dotDash,

        /// <remarks/>
        dotDashHeavy,

        /// <remarks/>
        dotDotDash,

        /// <remarks/>
        dotDotDashHeavy,

        /// <remarks/>
        wavy,

        /// <remarks/>
        wavyHeavy,

        /// <remarks/>
        wavyDbl,
    }


    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_TextStrikeType
    {

        /// <remarks/>
        noStrike,

        /// <remarks/>
        sngStrike,

        /// <remarks/>
        dblStrike,
    }


    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_TextCapsType
    {

        /// <remarks/>
        none,

        /// <remarks/>
        small,

        /// <remarks/>
        all,
    }
}
