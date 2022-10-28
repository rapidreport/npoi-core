// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>NPOI.OpenXmlFormats.Dml.Diagram</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace jp.co.systembase.NPOI.OpenXmlFormats.Dml.Diagram
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
    [XmlRoot("dataModel", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
    public partial class CT_DataModel
    {

        private List<CT_Pt> ptLstField;

        private List<CT_Cxn> cxnLstField;

        private CT_BackgroundFormatting bgField;

        private CT_WholeE2oFormatting wholeField;

        private CT_OfficeArtExtensionList extLstField;

        public CT_DataModel()
        {
            this.extLstField = new CT_OfficeArtExtensionList();
            this.wholeField = new CT_WholeE2oFormatting();
            this.bgField = new CT_BackgroundFormatting();
            this.cxnLstField = new List<CT_Cxn>();
            this.ptLstField = new List<CT_Pt>();
        }

        [XmlArray(Order = 0)]
        [XmlArrayItem("pt", IsNullable = false)]
        public List<CT_Pt> ptLst
        {
            get
            {
                return this.ptLstField;
            }
            set
            {
                this.ptLstField = value;
            }
        }

        [XmlArray(Order = 1)]
        [XmlArrayItem("cxn", IsNullable = false)]
        public List<CT_Cxn> cxnLst
        {
            get
            {
                return this.cxnLstField;
            }
            set
            {
                this.cxnLstField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_BackgroundFormatting bg
        {
            get
            {
                return this.bgField;
            }
            set
            {
                this.bgField = value;
            }
        }

        [XmlElement(Order = 3)]
        public CT_WholeE2oFormatting whole
        {
            get
            {
                return this.wholeField;
            }
            set
            {
                this.wholeField = value;
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
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
    public partial class CT_Pt
    {

        private CT_ElemPropSet prSetField;

        private CT_ShapeProperties spPrField;

        private CT_TextBody tField;

        private CT_OfficeArtExtensionList extLstField;

        private string modelIdField;

        private ST_PtType typeField;

        private string cxnIdField;

        public CT_Pt()
        {
            this.extLstField = new CT_OfficeArtExtensionList();
            this.tField = new CT_TextBody();
            this.spPrField = new CT_ShapeProperties();
            this.prSetField = new CT_ElemPropSet();
            this.typeField = ST_PtType.node;
            this.cxnIdField = "0";
        }

        [XmlElement(Order = 0)]
        public CT_ElemPropSet prSet
        {
            get
            {
                return this.prSetField;
            }
            set
            {
                this.prSetField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_ShapeProperties spPr
        {
            get
            {
                return this.spPrField;
            }
            set
            {
                this.spPrField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_TextBody t
        {
            get
            {
                return this.tField;
            }
            set
            {
                this.tField = value;
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
        public string modelId
        {
            get
            {
                return this.modelIdField;
            }
            set
            {
                this.modelIdField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(ST_PtType.node)]
        public ST_PtType type
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
        [DefaultValue("0")]
        public string cxnId
        {
            get
            {
                return this.cxnIdField;
            }
            set
            {
                this.cxnIdField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
    public partial class CT_Cxn
    {

        private CT_OfficeArtExtensionList extLstField;

        private string modelIdField;

        private ST_CxnType typeField;

        private string srcIdField;

        private string destIdField;

        private uint srcOrdField;

        private uint destOrdField;

        private string parTransIdField;

        private string sibTransIdField;

        private string presIdField;

        public CT_Cxn()
        {
            this.typeField = ST_CxnType.parOf;
            this.parTransIdField = "0";
            this.sibTransIdField = "0";
            this.presIdField = "";
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
        public string modelId
        {
            get
            {
                return this.modelIdField;
            }
            set
            {
                this.modelIdField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(ST_CxnType.parOf)]
        public ST_CxnType type
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
        public string srcId
        {
            get
            {
                return this.srcIdField;
            }
            set
            {
                this.srcIdField = value;
            }
        }

        [XmlAttribute]
        public string destId
        {
            get
            {
                return this.destIdField;
            }
            set
            {
                this.destIdField = value;
            }
        }

        [XmlAttribute]
        public uint srcOrd
        {
            get
            {
                return this.srcOrdField;
            }
            set
            {
                this.srcOrdField = value;
            }
        }

        [XmlAttribute]
        public uint destOrd
        {
            get
            {
                return this.destOrdField;
            }
            set
            {
                this.destOrdField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue("0")]
        public string parTransId
        {
            get
            {
                return this.parTransIdField;
            }
            set
            {
                this.parTransIdField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue("0")]
        public string sibTransId
        {
            get
            {
                return this.sibTransIdField;
            }
            set
            {
                this.sibTransIdField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue("")]
        public string presId
        {
            get
            {
                return this.presIdField;
            }
            set
            {
                this.presIdField = value;
            }
        }
    }


    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    public enum ST_CxnType
    {

        /// <remarks/>
        parOf,

        /// <remarks/>
        presOf,

        /// <remarks/>
        presParOf,

        /// <remarks/>
        unknownRelationship,
    }

    


    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    public enum ST_PtType
    {

        /// <remarks/>
        node,

        /// <remarks/>
        asst,

        /// <remarks/>
        doc,

        /// <remarks/>
        pres,

        /// <remarks/>
        parTrans,

        /// <remarks/>
        sibTrans,
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
    public partial class CT_PtList
    {

        private List<CT_Pt> ptField;

        public CT_PtList()
        {
            this.ptField = new List<CT_Pt>();
        }

        [XmlElement("pt", Order = 0)]
        public List<CT_Pt> pt
        {
            get
            {
                return this.ptField;
            }
            set
            {
                this.ptField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
    public partial class CT_CxnList
    {

        private List<CT_Cxn> cxnField;

        public CT_CxnList()
        {
            this.cxnField = new List<CT_Cxn>();
        }

        [XmlElement("cxn", Order = 0)]
        public List<CT_Cxn> cxn
        {
            get
            {
                return this.cxnField;
            }
            set
            {
                this.cxnField = value;
            }
        }
    }
}
