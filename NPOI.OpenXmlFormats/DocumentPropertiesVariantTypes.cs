// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>schemas</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace jp.co.systembase.NPOI.OpenXmlFormats
{

    [Serializable]
    [System.Diagnostics.DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
    public class CT_Variant
    {

        //private object itemField;

        //private ItemChoiceType itemElementNameField;
        //[XmlElement("array", typeof(CT_Array))]
        //[XmlElement("blob", typeof(byte[]), DataType = "base64Binary")]
        //[XmlElement("bool", typeof(bool))]
        //[XmlElement("bstr", typeof(string))]
        //[XmlElement("cf", typeof(CT_Cf))]
        //[XmlElement("clsid", typeof(string))]
        //[XmlElement("cy", typeof(string))]
        //[XmlElement("date", typeof(System.DateTime))]
        //[XmlElement("decimal", typeof(decimal))]
        //[XmlElement("empty", typeof(CT_Empty))]
        //[XmlElement("error", typeof(string))]
        //[XmlElement("filetime", typeof(System.DateTime))]
        //[XmlElement("int", typeof(int))]
        //[XmlElement("null", typeof(CT_Null))]
        //[XmlElement("oblob", typeof(byte[]), DataType = "base64Binary")]
        //[XmlElement("ostorage", typeof(byte[]), DataType = "base64Binary")]
        //[XmlElement("ostream", typeof(byte[]), DataType = "base64Binary")]
        //[XmlElement("storage", typeof(byte[]), DataType = "base64Binary")]
        //[XmlElement("stream", typeof(byte[]), DataType = "base64Binary")]
        //[XmlElement("ui1", typeof(byte))]
        //[XmlElement("ui2", typeof(ushort))]
        //[XmlElement("ui4", typeof(uint))]
        //[XmlElement("ui8", typeof(ulong))]
        //[XmlElement("uint", typeof(uint))]
        ////[XmlElement("variant", typeof(CT_Variant))]
        //[XmlElement("vector", typeof(CT_Vector))]
        //[XmlElement("vstream", typeof(CT_Vstream))]
        //[XmlChoiceIdentifier("ItemElementName")]
        //public object Item
        //{
        //    get
        //    {
        //        return this.itemField;
        //    }
        //    set
        //    {
        //        this.itemField = value;
        //    }
        //}

        //[XmlIgnore]
        //public ItemChoiceType ItemElementName
        //{
        //    get
        //    {
        //        return this.itemElementNameField;
        //    }
        //    set
        //    {
        //        this.itemElementNameField = value;
        //    }
        //}
        private sbyte i1Field = 0;
        private bool i1SpecifiedField = false;
        private short i2Field = 0;
        private bool i2SpecifiedField = false;
        private int i4Field = 0;
        private bool i4SpecifiedField = false;
        private long i8Field = 0;
        private bool i8SpecifiedField = false;
        //[XmlElement]
        //public sbyte i1
        //{
        //    get { return i1Field; }
        //    set { i1Field = value; }
        //}
        //[XmlIgnore]
        //public bool i1Specified
        //{
        //    get { return i1SpecifiedField; }
        //    set { i1SpecifiedField = value; }
        //}
        [XmlElement]
        public short i2
        {
            get { return i2Field; }
            set { i2Field = value; }
        }
        [XmlIgnore]
        public bool i2Specified
        {
            get { return i2SpecifiedField; }
            set { i2SpecifiedField = value; }
        }
        [XmlElement]
        public int i4
        {
            get { return i4Field; }
            set { i4Field = value; }
        }
        [XmlIgnore]
        public bool i4Specified
        {
            get { return i4SpecifiedField; }
            set { i4SpecifiedField = value; }
        }
        [XmlElement]
        public long i8
        {
            get { return i8Field; }
            set { i8Field = value; }
        }
        [XmlIgnore]
        public bool i8Specified
        {
            get { return i8SpecifiedField; }
            set { i8SpecifiedField = value; }
        }
        private string lpstrField = null;
        private string lpwstrField = null;
        private float r4Field = 0;
        private bool r4SpecifiedField = false;
        private double r8Field = 0;
        private bool r8SpecifiedField = false;

        [XmlElement]
        public string lpstr
        {
            get { return lpstrField; }
            set { lpstrField = value; }
        }
        [XmlElement]
        public string lpwstr
        {
            get { return lpwstrField; }
            set { lpwstrField = value; }
        }
        [XmlElement]
        public float r4
        {
            get { return r4Field; }
            set { r4Field = value; }
        }
        [XmlIgnore]
        public bool r4Specified
        {
            get { return r4SpecifiedField; }
            set { r4SpecifiedField = value; }
        }
        [XmlElement]
        public double r8
        {
            get { return r8Field; }
            set { r8Field = value; }
        }
        [XmlIgnore]
        public bool r8Specified
        {
            get { return r8SpecifiedField; }
            set { r8SpecifiedField = value; }
        }
    }


    [Serializable]
    [System.Diagnostics.DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
    public partial class CT_Array
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private int lBoundsField;

        private int uBoundsField;

        private ST_ArrayBaseType baseTypeField;

    
        [XmlElement("bool", typeof(bool))]
        [XmlElement("bstr", typeof(string))]
        [XmlElement("cy", typeof(string))]
        [XmlElement("date", typeof(System.DateTime))]
        [XmlElement("decimal", typeof(decimal))]
        [XmlElement("error", typeof(string))]
        [XmlElement("i1", typeof(sbyte))]
        [XmlElement("i2", typeof(short))]
        [XmlElement("i4", typeof(int))]
        [XmlElement("int", typeof(int))]
        [XmlElement("r4", typeof(float))]
        [XmlElement("r8", typeof(double))]
        [XmlElement("ui1", typeof(byte))]
        [XmlElement("ui2", typeof(ushort))]
        [XmlElement("ui4", typeof(uint))]
        [XmlElement("uint", typeof(uint))]
        [XmlElement("variant", typeof(CT_Variant))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

    
        //[XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

    
        [XmlAttribute]
        public int lBounds
        {
            get
            {
                return this.lBoundsField;
            }
            set
            {
                this.lBoundsField = value;
            }
        }

    
        [XmlAttribute]
        public int uBounds
        {
            get
            {
                return this.uBoundsField;
            }
            set
            {
                this.uBoundsField = value;
            }
        }

    
        [XmlAttribute]
        public ST_ArrayBaseType baseType
        {
            get
            {
                return this.baseTypeField;
            }
            set
            {
                this.baseTypeField = value;
            }
        }
    }
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:bool")]
        @bool,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:bstr")]
        bstr,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:cy")]
        cy,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:date")]
        date,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:decimal")]
        @decimal,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:error")]
        error,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:i1")]
        i1,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:i2")]
        i2,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:i4")]
        i4,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:int")]
        @int,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:r4")]
        r4,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:r8")]
        r8,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui1")]
        ui1,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui2")]
        ui2,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui4")]
        ui4,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:uint")]
        @uint,

        [XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:variant")]
        variant,
    }

    [Serializable]
    [System.Diagnostics.DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]

    public class CT_Vstream
    {

        private string versionField;

        private byte[] valueField;
        [XmlAttribute]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        [XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    [XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", IsNullable = true)]
    public class CT_Null
    {
    }
    [XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", IsNullable = true)]
    public class CT_Empty
    {
    }
    [Serializable]
    [System.Diagnostics.DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
    public class CT_Cf
    {

        private string formatField;

        private byte[] valueField;

        [XmlAttribute]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        [XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    [Serializable]
    [System.Diagnostics.DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
    public class CT_Vector
    {

        private List<object> itemsField;

        private List<ST_VectorBaseType> itemsElementNameField;

        private ST_VectorBaseType baseTypeField;

        private uint sizeField;

        public CT_Vector()
        {
            this.itemsElementNameField = new List<ST_VectorBaseType>();
            this.itemsField = new List<object>();
        }
        [XmlElement("bool", typeof(bool))]
        [XmlElement("bstr", typeof(string))]
        [XmlElement("cf", typeof(CT_Cf))]
        [XmlElement("clsid", typeof(string))]
        [XmlElement("cy", typeof(string))]
        [XmlElement("date", typeof(System.DateTime))]
        [XmlElement("error", typeof(string))]
        [XmlElement("filetime", typeof(System.DateTime))]
        [XmlElement("i1", typeof(sbyte))]
        [XmlElement("i2", typeof(short))]
        [XmlElement("i4", typeof(int))]
        [XmlElement("i8", typeof(long))]
        [XmlElement("lpstr", typeof(string))]
        [XmlElement("lpwstr", typeof(string))]
        [XmlElement("r4", typeof(float))]
        [XmlElement("r8", typeof(double))]
        [XmlElement("ui1", typeof(byte))]
        [XmlElement("ui2", typeof(ushort))]
        [XmlElement("ui4", typeof(uint))]
        [XmlElement("ui8", typeof(ulong))]
        [XmlElement("variant", typeof(CT_Variant))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField.ToArray();
            }
            set
            {
                if (value != null && value.Length > 0)
                    this.itemsField = new List<object>(value);
                else
                    this.itemsField = new List<object>();
            }
        }
        [XmlIgnore]
        public ST_VectorBaseType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField.ToArray();
            }
            set
            {
                if (value != null && value.Length > 0)
                    this.itemsElementNameField = new List<ST_VectorBaseType>(value);
                else
                    this.itemsElementNameField = new List<ST_VectorBaseType>();
            }
        }
        [XmlAttribute]
        public ST_VectorBaseType baseType
        {
            get
            {
                return this.baseTypeField;
            }
            set
            {
                this.baseTypeField = value;
            }
        }
        [XmlAttribute]
        public uint size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        public int SizeOfVariantArray()
        {
            return SizeOfArray(ST_VectorBaseType.variant);
        }

        public CT_Variant GetVariantArray(int p)
        {
            return GetObjectArray<CT_Variant>(p, ST_VectorBaseType.variant);
        }

        public int SizeOfLpstrArray()
        {
            return SizeOfArray(ST_VectorBaseType.lpstr);
        }

        public string GetLpstrArray(int p)
        {
            return GetObjectArray<string>(p, ST_VectorBaseType.lpstr);
        }

        #region Generic methods for object operation

        private List<T> GetObjectList<T>(ST_VectorBaseType type) where T : class
        {
            lock (this)
            {
                List<T> list = new List<T>();
                for (int i = 0; i < itemsElementNameField.Count; i++)
                {
                    if (itemsElementNameField[i] == type)
                        list.Add(itemsField[i] as T);
                }
                return list;
            }
        }
        private int SizeOfArray(ST_VectorBaseType type)
        {
            lock (this)
            {
                int size = 0;
                for (int i = 0; i < itemsElementNameField.Count; i++)
                {
                    if (itemsElementNameField[i] == type)
                        size++;
                }
                return size;
            }
        }
        private T GetObjectArray<T>(int p, ST_VectorBaseType type) where T : class
        {
            lock (this)
            {
                int pos = GetObjectIndex(type, p);
                if (pos < 0 || pos >= this.itemsField.Count)
                    return null;
                return itemsField[pos] as T;
            }
        }
        private T AddNewObject<T>(ST_VectorBaseType type) where T : class, new()
        {
            T t = new T();
            lock (this)
            {
                this.itemsElementNameField.Add(type);
                this.itemsField.Add(t);
            }
            return t;
        }
        private void SetObject<T>(ST_VectorBaseType type, int p, T obj) where T : class
        {
            lock (this)
            {
                int pos = GetObjectIndex(type, p);
                if (pos < 0 || pos >= this.itemsField.Count)
                    return;
                if (this.itemsField[pos] is T)
                    this.itemsField[pos] = obj;
                else
                    throw new Exception(string.Format(@"object types are difference, itemsField[{0}] is {1}, and parameter obj is {2}",
                        pos, this.itemsField[pos].GetType().Name, typeof(T).Name));
            }
        }
        private int GetObjectIndex(ST_VectorBaseType type, int p)
        {
            int index = -1;
            int pos = 0;
            for (int i = 0; i < itemsElementNameField.Count; i++)
            {
                if (itemsElementNameField[i] == type)
                {
                    if (pos == p)
                    {
                        //return itemsField[p] as T;
                        index = i;
                        break;
                    }
                    else
                        pos++;
                }
            }
            return index;
        }
        private void RemoveObject(ST_VectorBaseType type, int p)
        {
            lock (this)
            {
                int pos = GetObjectIndex(type, p);
                if (pos < 0 || pos >= this.itemsField.Count)
                    return;
                itemsElementNameField.RemoveAt(pos);
                itemsField.RemoveAt(pos);
            }
        }
        #endregion
    }

    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
    public enum ST_VectorBaseType
    {

    
        variant,

    
        i1,

    
        i2,

    
        i4,

    
        i8,

    
        ui1,

    
        ui2,

    
        ui4,

    
        ui8,

    
        r4,

    
        r8,

    
        lpstr,

    
        lpwstr,

    
        bstr,

    
        date,

    
        filetime,

    
        @bool,

    
        cy,

    
        error,

    
        clsid,

    
        cf,
    }


}
