﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace Log4netEditor {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class dsADOParameters : DataSet {
        
        private ParametersDataTable tableParameters;
        
        public dsADOParameters() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsADOParameters(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Parameters"] != null)) {
                    this.Tables.Add(new ParametersDataTable(ds.Tables["Parameters"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ParametersDataTable Parameters {
            get {
                return this.tableParameters;
            }
        }
        
        public override DataSet Clone() {
            dsADOParameters cln = ((dsADOParameters)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["Parameters"] != null)) {
                this.Tables.Add(new ParametersDataTable(ds.Tables["Parameters"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableParameters = ((ParametersDataTable)(this.Tables["Parameters"]));
            if ((this.tableParameters != null)) {
                this.tableParameters.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsADOParameters";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/dsADOParameters.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableParameters = new ParametersDataTable();
            this.Tables.Add(this.tableParameters);
        }
        
        private bool ShouldSerializeParameters() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void ParametersRowChangeEventHandler(object sender, ParametersRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ParametersDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnparameterName;
            
            private DataColumn columndbType;
            
            private DataColumn columnlayout;
            
            private DataColumn columnconversionPattern;
            
            private DataColumn columnsize;
            
            internal ParametersDataTable() : 
                    base("Parameters") {
                this.InitClass();
            }
            
            internal ParametersDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn parameterNameColumn {
                get {
                    return this.columnparameterName;
                }
            }
            
            internal DataColumn dbTypeColumn {
                get {
                    return this.columndbType;
                }
            }
            
            internal DataColumn layoutColumn {
                get {
                    return this.columnlayout;
                }
            }
            
            internal DataColumn conversionPatternColumn {
                get {
                    return this.columnconversionPattern;
                }
            }
            
            internal DataColumn sizeColumn {
                get {
                    return this.columnsize;
                }
            }
            
            public ParametersRow this[int index] {
                get {
                    return ((ParametersRow)(this.Rows[index]));
                }
            }
            
            public event ParametersRowChangeEventHandler ParametersRowChanged;
            
            public event ParametersRowChangeEventHandler ParametersRowChanging;
            
            public event ParametersRowChangeEventHandler ParametersRowDeleted;
            
            public event ParametersRowChangeEventHandler ParametersRowDeleting;
            
            public void AddParametersRow(ParametersRow row) {
                this.Rows.Add(row);
            }
            
            public ParametersRow AddParametersRow(string parameterName, string dbType, string layout, string conversionPattern, int size) {
                ParametersRow rowParametersRow = ((ParametersRow)(this.NewRow()));
                rowParametersRow.ItemArray = new object[] {
                        parameterName,
                        dbType,
                        layout,
                        conversionPattern,
                        size};
                this.Rows.Add(rowParametersRow);
                return rowParametersRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                ParametersDataTable cln = ((ParametersDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new ParametersDataTable();
            }
            
            internal void InitVars() {
                this.columnparameterName = this.Columns["parameterName"];
                this.columndbType = this.Columns["dbType"];
                this.columnlayout = this.Columns["layout"];
                this.columnconversionPattern = this.Columns["conversionPattern"];
                this.columnsize = this.Columns["size"];
            }
            
            private void InitClass() {
                this.columnparameterName = new DataColumn("parameterName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnparameterName);
                this.columndbType = new DataColumn("dbType", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columndbType);
                this.columnlayout = new DataColumn("layout", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnlayout);
                this.columnconversionPattern = new DataColumn("conversionPattern", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnconversionPattern);
                this.columnsize = new DataColumn("size", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnsize);
                this.columnsize.DefaultValue = 0;
            }
            
            public ParametersRow NewParametersRow() {
                return ((ParametersRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new ParametersRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(ParametersRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ParametersRowChanged != null)) {
                    this.ParametersRowChanged(this, new ParametersRowChangeEvent(((ParametersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ParametersRowChanging != null)) {
                    this.ParametersRowChanging(this, new ParametersRowChangeEvent(((ParametersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ParametersRowDeleted != null)) {
                    this.ParametersRowDeleted(this, new ParametersRowChangeEvent(((ParametersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ParametersRowDeleting != null)) {
                    this.ParametersRowDeleting(this, new ParametersRowChangeEvent(((ParametersRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveParametersRow(ParametersRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ParametersRow : DataRow {
            
            private ParametersDataTable tableParameters;
            
            internal ParametersRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableParameters = ((ParametersDataTable)(this.Table));
            }
            
            public string parameterName {
                get {
                    try {
                        return ((string)(this[this.tableParameters.parameterNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("無法取得值，因為它是 DBNull。", e);
                    }
                }
                set {
                    this[this.tableParameters.parameterNameColumn] = value;
                }
            }
            
            public string dbType {
                get {
                    try {
                        return ((string)(this[this.tableParameters.dbTypeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("無法取得值，因為它是 DBNull。", e);
                    }
                }
                set {
                    this[this.tableParameters.dbTypeColumn] = value;
                }
            }
            
            public string layout {
                get {
                    try {
                        return ((string)(this[this.tableParameters.layoutColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("無法取得值，因為它是 DBNull。", e);
                    }
                }
                set {
                    this[this.tableParameters.layoutColumn] = value;
                }
            }
            
            public string conversionPattern {
                get {
                    if (this.IsconversionPatternNull()) {
                        return null;
                    }
                    else {
                        return ((string)(this[this.tableParameters.conversionPatternColumn]));
                    }
                }
                set {
                    this[this.tableParameters.conversionPatternColumn] = value;
                }
            }
            
            public int size {
                get {
                    try {
                        return ((int)(this[this.tableParameters.sizeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("無法取得值，因為它是 DBNull。", e);
                    }
                }
                set {
                    this[this.tableParameters.sizeColumn] = value;
                }
            }
            
            public bool IsparameterNameNull() {
                return this.IsNull(this.tableParameters.parameterNameColumn);
            }
            
            public void SetparameterNameNull() {
                this[this.tableParameters.parameterNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsdbTypeNull() {
                return this.IsNull(this.tableParameters.dbTypeColumn);
            }
            
            public void SetdbTypeNull() {
                this[this.tableParameters.dbTypeColumn] = System.Convert.DBNull;
            }
            
            public bool IslayoutNull() {
                return this.IsNull(this.tableParameters.layoutColumn);
            }
            
            public void SetlayoutNull() {
                this[this.tableParameters.layoutColumn] = System.Convert.DBNull;
            }
            
            public bool IsconversionPatternNull() {
                return this.IsNull(this.tableParameters.conversionPatternColumn);
            }
            
            public void SetconversionPatternNull() {
                this[this.tableParameters.conversionPatternColumn] = System.Convert.DBNull;
            }
            
            public bool IssizeNull() {
                return this.IsNull(this.tableParameters.sizeColumn);
            }
            
            public void SetsizeNull() {
                this[this.tableParameters.sizeColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ParametersRowChangeEvent : EventArgs {
            
            private ParametersRow eventRow;
            
            private DataRowAction eventAction;
            
            public ParametersRowChangeEvent(ParametersRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public ParametersRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}