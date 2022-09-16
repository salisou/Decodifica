using System;
using System.Data;
using System.Collections;

namespace Decodifica.Data
{
    /// <summary>
    /// Represents the strongly named DataTable class.
    /// </summary>
    public partial class TabCampiDataTable : DataTable, IEnumerable
    {

        /// <summary>Elenca i valori possibili per la configurazione TaDaTyp (tipo di dato)</summary>
        public enum CampiDataTypeEnum
        {
            stringa = 0,
            data = 1,
            numero = 2,
            peso = 3
        }


        private DataColumn columnTACodCfg;

        private DataColumn columnTAOggetto;

        private DataColumn columnTATestoEt;

        private DataColumn columnTAObblig;

        private DataColumn columnTADecod;

        private DataColumn columnTADefVal;

        private DataColumn columnTAMinLng;

        private DataColumn columnTAMaxLng;

        private DataColumn columnTAFlgDiv;

        private DataColumn columnTAFCopyN;

        private DataColumn columnTADaTyp;

        private DataColumn columnTAQryDecod;

        private DataColumn columnTAQryFind;

        private DataColumn columnTARegExp;

        private DataColumn columnTACodCnn;


        public TabCampiDataTable() : base()
        {
            TableName = "TabCampi";
            BeginInit();
            InitClass();
            EndInit();
        }


        internal TabCampiDataTable(DataTable table) : base()
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


        public DataColumn TACodCfgColumn
        {
            get
            {
                return columnTACodCfg;
            }
        }


        public DataColumn TAOggettoColumn
        {
            get
            {
                return columnTAOggetto;
            }
        }


        public DataColumn TATestoEtColumn
        {
            get
            {
                return columnTATestoEt;
            }
        }


        public DataColumn TAObbligColumn
        {
            get
            {
                return columnTAObblig;
            }
        }


        public DataColumn TADecodColumn
        {
            get
            {
                return columnTADecod;
            }
        }


        public DataColumn TADefValColumn
        {
            get
            {
                return columnTADefVal;
            }
        }


        public DataColumn TAMinLngColumn
        {
            get
            {
                return columnTAMinLng;
            }
        }


        public DataColumn TAMaxLngColumn
        {
            get
            {
                return columnTAMaxLng;
            }
        }


        public DataColumn TAFlgDivColumn
        {
            get
            {
                return columnTAFlgDiv;
            }
        }


        public DataColumn TAFCopyNColumn
        {
            get
            {
                return columnTAFCopyN;
            }
        }


        public DataColumn TADaTypColumn
        {
            get
            {
                return columnTADaTyp;
            }
        }


        public DataColumn TAQryDecodColumn
        {
            get
            {
                return columnTAQryDecod;
            }
        }


        public DataColumn TAQryFindColumn
        {
            get
            {
                return columnTAQryFind;
            }
        }


        public DataColumn TARegExpColumn
        {
            get
            {
                return columnTARegExp;
            }
        }


        public DataColumn TACodCnnColumn
        {
            get
            {
                return columnTACodCnn;
            }
        }


        public int Count
        {
            get
            {
                return Rows.Count;
            }
        }


        public TabCampiRow this[int index]
        {
            get
            {
                return (TabCampiRow)Rows[index];
            }
        }

        //public event TabCampiRowChangeEventHandler TabCampiRowChanging;

        //public event TabCampiRowChangeEventHandler TabCampiRowChanged;

        //public event TabCampiRowChangeEventHandler TabCampiRowDeleting;

        //public event TabCampiRowChangeEventHandler TabCampiRowDeleted;


        public void AddTabCampiRow(TabCampiRow row)
        {
            Rows.Add(row);
        }


        public TabCampiRow AddTabCampiRow(string TACodCfg, string TAOggetto, string TATestoEt, bool TAObblig, bool TADecod, string TADefVal, byte TAMinLng, byte TAMaxLng, bool TAFlgDiv, bool TAFCopyN, byte TADaTyp, string TAQryDecod, string TAQryFind, string TARegExp, byte TACodCnn)
        {
            TabCampiRow rowTabCampiRow = (TabCampiRow)NewRow();
            var columnValuesArray = new object[] { TACodCfg, TAOggetto, TATestoEt, TAObblig, TADecod, TADefVal, TAMinLng, TAMaxLng, TAFlgDiv, TAFCopyN, TADaTyp, TAQryDecod, TAQryFind, TARegExp, TACodCnn };
            rowTabCampiRow.ItemArray = columnValuesArray;
            Rows.Add(rowTabCampiRow);
            return rowTabCampiRow;
        }

        /// <summary>
        /// Aggiunge una riga alla tabella con valori di configurazione di default
        /// </summary>
        /// <param name="TACodCfg"></param>
        /// <param name="TAOggetto"></param>
        /// <returns></returns>
        public TabCampiRow AddTabCampiDefault(string TACodCfg, string TAOggetto)
        { 
            return this.AddTabCampiRow(TACodCfg, TAOggetto, string.Empty, false, false, string.Empty,
                    0, 0, false, false, 0, string.Empty, string.Empty, string.Empty, 0);
        }


        public TabCampiRow FindByTACodCfgTAOggetto(string TACodCfg, string TAOggetto)
        {
            return (TabCampiRow)Rows.Find(new object[] { TACodCfg, TAOggetto });
        }


        public virtual IEnumerator GetEnumerator()
        {
            return Rows.GetEnumerator();
        }


        public override DataTable Clone()
        {
            TabCampiDataTable cln = (TabCampiDataTable)base.Clone();
            cln.InitVars();
            return cln;
        }


        protected override DataTable CreateInstance()
        {
            return new TabCampiDataTable();
        }


        internal void InitVars()
        {
            columnTACodCfg = Columns["TACodCfg"];
            columnTAOggetto = Columns["TAOggetto"];
            columnTATestoEt = Columns["TATestoEt"];
            columnTAObblig = Columns["TAObblig"];
            columnTADecod = Columns["TADecod"];
            columnTADefVal = Columns["TADefVal"];
            columnTAMinLng = Columns["TAMinLng"];
            columnTAMaxLng = Columns["TAMaxLng"];
            columnTAFlgDiv = Columns["TAFlgDiv"];
            columnTAFCopyN = Columns["TAFCopyN"];
            columnTADaTyp = Columns["TADaTyp"];
            columnTAQryDecod = Columns["TAQryDecod"];
            columnTAQryFind = Columns["TAQryFind"];
            columnTARegExp = Columns["TARegExp"];
            columnTACodCnn = Columns["TACodCnn"];
        }


        private void InitClass()
        {
            columnTACodCfg = new DataColumn("TACodCfg", typeof(string), null, MappingType.Element);
            Columns.Add(columnTACodCfg);
            columnTAOggetto = new DataColumn("TAOggetto", typeof(string), null, MappingType.Element);
            Columns.Add(columnTAOggetto);
            columnTATestoEt = new DataColumn("TATestoEt", typeof(string), null, MappingType.Element);
            Columns.Add(columnTATestoEt);
            columnTAObblig = new DataColumn("TAObblig", typeof(bool), null, MappingType.Element);
            Columns.Add(columnTAObblig);
            columnTADecod = new DataColumn("TADecod", typeof(bool), null, MappingType.Element);
            Columns.Add(columnTADecod);
            columnTADefVal = new DataColumn("TADefVal", typeof(string), null, MappingType.Element);
            Columns.Add(columnTADefVal);
            columnTAMinLng = new DataColumn("TAMinLng", typeof(byte), null, MappingType.Element);
            Columns.Add(columnTAMinLng);
            columnTAMaxLng = new DataColumn("TAMaxLng", typeof(byte), null, MappingType.Element);
            Columns.Add(columnTAMaxLng);
            columnTAFlgDiv = new DataColumn("TAFlgDiv", typeof(bool), null, MappingType.Element);
            Columns.Add(columnTAFlgDiv);
            columnTAFCopyN = new DataColumn("TAFCopyN", typeof(bool), null, MappingType.Element);
            Columns.Add(columnTAFCopyN);
            columnTADaTyp = new DataColumn("TADaTyp", typeof(byte), null, MappingType.Element);
            Columns.Add(columnTADaTyp);
            columnTAQryDecod = new DataColumn("TAQryDecod", typeof(string), null, MappingType.Element);
            Columns.Add(columnTAQryDecod);
            columnTAQryFind = new DataColumn("TAQryFind", typeof(string), null, MappingType.Element);
            Columns.Add(columnTAQryFind);
            columnTARegExp = new DataColumn("TARegExp", typeof(string), null, MappingType.Element);
            Columns.Add(columnTARegExp);
            columnTACodCnn = new DataColumn("TACodCnn", typeof(byte), null, MappingType.Element);
            Columns.Add(columnTACodCnn);
            Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { columnTACodCfg, columnTAOggetto }, true));
            columnTACodCfg.AllowDBNull = false;
            columnTACodCfg.MaxLength = 3;
            columnTAOggetto.AllowDBNull = false;
            columnTAOggetto.MaxLength = 15;
            columnTATestoEt.MaxLength = 50;
            columnTARegExp.MaxLength = 4000;
            columnTACodCnn.DefaultValue = 0;
        }


        public TabCampiRow NewTabCampiRow()
        {
            return (TabCampiRow)NewRow();
        }


        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new TabCampiRow(builder);
        }


        protected override Type GetRowType()
        {
            return typeof(TabCampiRow);
        }

        public void RemoveTabCampiRow(TabCampiRow row)
        {
            Rows.Remove(row);
        }

    }
}
