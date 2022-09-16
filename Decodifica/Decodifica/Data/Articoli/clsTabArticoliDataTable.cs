using System;
using System.Collections;
using System.Data;

namespace Decodifica.Data
{
    public class ArticoloDataTable : DataTable, IEnumerable
    {
        private DataColumn columnCod_articolo;

        private DataColumn columncod_parte;

        private DataColumn columnDescrizione; // 1

        private DataColumn columnRaggr1;

        private DataColumn columnRaggr2;

        private DataColumn columnRaggr3;

        private DataColumn columnRaggr4;

        private DataColumn columnRaggr5;

        private DataColumn columnAnnullato;

        private DataColumn columnCod_classe;

        private DataColumn columnARPeso;

        private DataColumn columnUM;           // 2

        private DataColumn columnARPrezzo;

        private DataColumn columnARUMPeso;

        private DataColumn columnARTipo;

        private DataColumn columnARCSTD;

        public ArticoloDataTable() : base()
        {
            TableName = "Articolo";
            BeginInit();
            InitClass();
            EndInit();
        }

        internal ArticoloDataTable(DataTable table) : base()
        {
            TableName = table.TableName;
            if (table.CaseSensitive != table.DataSet.CaseSensitive)
            {
                CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() ?? "") != (table.DataSet.Locale.ToString() ?? ""))
            {
                Locale = table.Locale;
            }
            if ((table.Namespace ?? "") != (table.DataSet.Namespace ?? ""))
            {
                Namespace = table.Namespace;
            }
            Prefix = table.Prefix;
            MinimumCapacity = table.MinimumCapacity;
        }


        public DataColumn Cod_articoloColumn
        {
            get
            {
                return columnCod_articolo;
            }
        }


        public DataColumn cod_parteColumn
        {
            get
            {
                return columncod_parte;
            }
        }


        public DataColumn DescrizioneColumn
        {
            get
            {
                return columnDescrizione;
            }
        }


        public DataColumn Raggr1Column
        {
            get
            {
                return columnRaggr1;
            }
        }


        public DataColumn Raggr2Column
        {
            get
            {
                return columnRaggr2;
            }
        }


        public DataColumn Raggr3Column
        {
            get
            {
                return columnRaggr3;
            }
        }


        public DataColumn Raggr4Column
        {
            get
            {
                return columnRaggr4;
            }
        }


        public DataColumn Raggr5Column
        {
            get
            {
                return columnRaggr5;
            }
        }


        public DataColumn AnnullatoColumn
        {
            get
            {
                return columnAnnullato;
            }
        }


        public DataColumn Cod_classeColumn
        {
            get
            {
                return columnCod_classe;
            }
        }


        public DataColumn ARPesoColumn
        {
            get
            {
                return columnARPeso;
            }
        }


        public DataColumn UMColumn
        {
            get
            {
                return columnUM;
            }
        }


        public DataColumn ARPrezzoColumn
        {
            get
            {
                return columnARPrezzo;
            }
        }


        public DataColumn ARUMPesoColumn
        {
            get
            {
                return columnARUMPeso;
            }
        }


        public DataColumn ARTipoColumn
        {
            get
            {
                return columnARTipo;
            }
        }


        public DataColumn ARCSTDColumn
        {
            get
            {
                return columnARCSTD;
            }
        }


        public int Count
        {
            get
            {
                return Rows.Count;
            }
        }


        public ArticoloRow this[int index]
        {
            get
            {
                return (ArticoloRow)Rows[index];
            }
        }

        //public event ArticoloRowChangeEventHandler ArticoloRowChanging;

        //public event ArticoloRowChangeEventHandler ArticoloRowChanged;

        //public event ArticoloRowChangeEventHandler ArticoloRowDeleting;

        //public event ArticoloRowChangeEventHandler ArticoloRowDeleted;


        public void AddArticoloRow(ArticoloRow row)
        {
            Rows.Add(row);
        }


        public ArticoloRow AddArticoloRow(string Cod_articolo, string cod_parte, string Descrizione, string Raggr1, string Raggr2, string Raggr3, string Raggr4, string Raggr5, bool Annullato, string Cod_classe, decimal ARPeso, string UM, decimal ARPrezzo, string ARUMPeso, string ARTipo, decimal ARCSTD)
        {
            ArticoloRow rowArticoloRow = (ArticoloRow)NewRow();
            var columnValuesArray = new object[] { Cod_articolo, cod_parte, Descrizione, Raggr1, Raggr2, Raggr3, Raggr4, Raggr5, Annullato, Cod_classe, ARPeso, UM, ARPrezzo, ARUMPeso, ARTipo, ARCSTD };
            rowArticoloRow.ItemArray = columnValuesArray;
            Rows.Add(rowArticoloRow);
            return rowArticoloRow;
        }


        public ArticoloRow FindByCod_articolo(string Cod_articolo)
        {
            return (ArticoloRow)Rows.Find(new object[] { Cod_articolo });
        }


        public virtual IEnumerator GetEnumerator()
        {
            return Rows.GetEnumerator();
        }


        public override DataTable Clone()
        {
            ArticoloDataTable cln = (ArticoloDataTable)base.Clone();
            cln.InitVars();
            return cln;
        }


        protected override DataTable CreateInstance()
        {
            return new ArticoloDataTable();
        }


        internal void InitVars()
        {
            columnCod_articolo = Columns["Cod_articolo"];
            columncod_parte = Columns["cod_parte"];
            columnDescrizione = Columns["Descrizione"];
            columnRaggr1 = Columns["Raggr1"];
            columnRaggr2 = Columns["Raggr2"];
            columnRaggr3 = Columns["Raggr3"];
            columnRaggr4 = Columns["Raggr4"];
            columnRaggr5 = Columns["Raggr5"];
            columnAnnullato = Columns["Annullato"];
            columnCod_classe = Columns["Cod_classe"];
            columnARPeso = Columns["ARPeso"];
            columnUM = Columns["UM"];
            columnARPrezzo = Columns["ARPrezzo"];
            columnARUMPeso = Columns["ARUMPeso"];
            columnARTipo = Columns["ARTipo"];
            columnARCSTD = Columns["ARCSTD"];
        }


        private void InitClass()
        {
            columnCod_articolo = new DataColumn("Cod_articolo", typeof(string), null, MappingType.Element);
            Columns.Add(columnCod_articolo);
            columncod_parte = new DataColumn("cod_parte", typeof(string), null, MappingType.Element);
            Columns.Add(columncod_parte);
            columnDescrizione = new DataColumn("Descrizione", typeof(string), null, MappingType.Element);
            Columns.Add(columnDescrizione);
            columnRaggr1 = new DataColumn("Raggr1", typeof(string), null, MappingType.Element);
            Columns.Add(columnRaggr1);
            columnRaggr2 = new DataColumn("Raggr2", typeof(string), null, MappingType.Element);
            Columns.Add(columnRaggr2);
            columnRaggr3 = new DataColumn("Raggr3", typeof(string), null, MappingType.Element);
            Columns.Add(columnRaggr3);
            columnRaggr4 = new DataColumn("Raggr4", typeof(string), null, MappingType.Element);
            Columns.Add(columnRaggr4);
            columnRaggr5 = new DataColumn("Raggr5", typeof(string), null, MappingType.Element);
            Columns.Add(columnRaggr5);
            columnAnnullato = new DataColumn("Annullato", typeof(bool), null, MappingType.Element);
            Columns.Add(columnAnnullato);
            columnCod_classe = new DataColumn("Cod_classe", typeof(string), null, MappingType.Element);
            Columns.Add(columnCod_classe);
            columnARPeso = new DataColumn("ARPeso", typeof(decimal), null, MappingType.Element);
            Columns.Add(columnARPeso);
            columnUM = new DataColumn("UM", typeof(string), null, MappingType.Element);
            Columns.Add(columnUM);
            columnARPrezzo = new DataColumn("ARPrezzo", typeof(decimal), null, MappingType.Element);
            Columns.Add(columnARPrezzo);
            columnARUMPeso = new DataColumn("ARUMPeso", typeof(string), null, MappingType.Element);
            Columns.Add(columnARUMPeso);
            columnARTipo = new DataColumn("ARTipo", typeof(string), null, MappingType.Element);
            Columns.Add(columnARTipo);
            columnARCSTD = new DataColumn("ARCSTD", typeof(decimal), null, MappingType.Element);
            Columns.Add(columnARCSTD);
            //Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { columnCod_articolo }, true));
            columnCod_articolo.AllowDBNull = false;
            columnCod_articolo.Unique = true;
            columnCod_articolo.MaxLength = 50;//Aggiunto da me
        }


        public ArticoloRow NewArticoloRow()
        {
            return (ArticoloRow)NewRow();
        }


        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new ArticoloRow(builder);
        }


        protected override Type GetRowType()
        {
            return typeof(ArticoloRow);
        }


        //protected override void OnRowChanged(DataRowChangeEventArgs e)
        //{
        //    base.OnRowChanged(e);
        //    if (ArticoloRowChanged is not null)
        //    {
        //        ArticoloRowChanged?.Invoke(this, new ArticoloRowChangeEvent((ArticoloRow)e.Row, e.Action));
        //    }
        //}


        //protected override void OnRowChanging(DataRowChangeEventArgs e)
        //{
        //    base.OnRowChanging(e);
        //    if (ArticoloRowChanging is not null)
        //    {
        //        ArticoloRowChanging?.Invoke(this, new ArticoloRowChangeEvent((ArticoloRow)e.Row, e.Action));
        //    }
        //}


        //protected override void OnRowDeleted(DataRowChangeEventArgs e)
        //{
        //    base.OnRowDeleted(e);
        //    if (ArticoloRowDeleted is not null)
        //    {
        //        ArticoloRowDeleted?.Invoke(this, new ArticoloRowChangeEvent((ArticoloRow)e.Row, e.Action));
        //    }
        //}


        //protected override void OnRowDeleting(DataRowChangeEventArgs e)
        //{
        //    base.OnRowDeleting(e);
        //    if (ArticoloRowDeleting is not null)
        //    {
        //        ArticoloRowDeleting?.Invoke(this, new ArticoloRowChangeEvent((ArticoloRow)e.Row, e.Action));
        //    }
        //}


        public void RemoveArticoloRow(ArticoloRow row)
        {
            Rows.Remove(row);
        }


        //public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs)
        //{
        //    var type = new System.Xml.Schema.XmlSchemaComplexType();
        //    var sequence = new System.Xml.Schema.XmlSchemaSequence();
        //    var ds = new dstArtic();
        //    var any1 = new System.Xml.Schema.XmlSchemaAny();
        //    any1.Namespace = "http://www.w3.org/2001/XMLSchema";
        //    any1.MinOccurs = new decimal(0);
        //    any1.MaxOccurs = decimal.MaxValue;
        //    any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
        //    sequence.Items.Add(any1);
        //    var any2 = new System.Xml.Schema.XmlSchemaAny();
        //    any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        //    any2.MinOccurs = new decimal(1);
        //    any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
        //    sequence.Items.Add(any2);
        //    var attribute1 = new System.Xml.Schema.XmlSchemaAttribute();
        //    attribute1.Name = "namespace";
        //    attribute1.FixedValue = ds.Namespace;
        //    type.Attributes.Add(attribute1);
        //    var attribute2 = new System.Xml.Schema.XmlSchemaAttribute();
        //    attribute2.Name = "tableTypeName";
        //    attribute2.FixedValue = "ArticoloDataTable";
        //    type.Attributes.Add(attribute2);
        //    type.Particle = sequence;
        //    var dsSchema = ds.GetSchemaSerializable();
        //    if (xs.Contains(dsSchema.TargetNamespace))
        //    {
        //        var s1 = new MemoryStream();
        //        var s2 = new MemoryStream();
        //        try
        //        {
        //            System.Xml.Schema.XmlSchema schema = null;
        //            dsSchema.Write(s1);
        //            var schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
        //            while (schemas.MoveNext())
        //            {
        //                schema = (System.Xml.Schema.XmlSchema)schemas.Current;
        //                s2.SetLength(0L);
        //                schema.Write(s2);
        //                if (s1.Length == s2.Length)
        //                {
        //                    s1.Position = 0L;
        //                    s2.Position = 0L;

        //                    while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
        //                    {


        //                    }
        //                    if (s1.Position == s1.Length)
        //                    {
        //                        return type;
        //                    }
        //                }

        //            }
        //        }
        //        finally
        //        {
        //            if (s1 is not null)
        //            {
        //                s1.Close();
        //            }
        //            if (s2 is not null)
        //            {
        //                s2.Close();
        //            }
        //        }
        //    }
        //    xs.Add(dsSchema);
        //    return type;
        //}
    }
}
