using System;
using System.Data;

namespace Decodifica.Data
{
    /// <summary>
    /// Represents strongly named DataRow class.
    /// </summary>
    public partial class ArticoloRow : DataRow
    {

        private ArticoloDataTable tableArticolo;


        internal ArticoloRow(DataRowBuilder rb) : base(rb)
        {
            tableArticolo = (ArticoloDataTable)Table;
        }


        public string Cod_articolo
        {
            get
            {
                return System.Convert.ToString(this[tableArticolo.Cod_articoloColumn]);
            }
            set
            {
                this[tableArticolo.Cod_articoloColumn] = value;
            }
        }


        public string cod_parte
        {
            get
            {
                try
                {
                    return System.Convert.ToString(this[tableArticolo.cod_parteColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'cod_parte' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.cod_parteColumn] = value;
            }
        }


        public string Descrizione
        {
            get
            {
                try
                {
                    return System.Convert.ToString(this[tableArticolo.DescrizioneColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'Descrizione' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.DescrizioneColumn] = value;
            }
        }


        public string Raggr1
        {
            get
            {
                try
                {
                    return System.Convert.ToString(this[tableArticolo.Raggr1Column]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'Raggr1' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.Raggr1Column] = value;
            }
        }


        public string Raggr2
        {
            get
            {
                try
                {
                    return System.Convert.ToString(this[tableArticolo.Raggr2Column]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'Raggr2' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.Raggr2Column] = value;
            }
        }


        public string Raggr3
        {
            get
            {
                try
                {
                    return System.Convert.ToString(this[tableArticolo.Raggr3Column]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'Raggr3' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.Raggr3Column] = value;
            }
        }


        public string Raggr4
        {
            get
            {
                try
                {
                    return System.Convert.ToString(this[tableArticolo.Raggr4Column]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'Raggr4' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.Raggr4Column] = value;
            }
        }


        public string Raggr5
        {
            get
            {
                try
                {
                    return System.Convert.ToString(this[tableArticolo.Raggr5Column]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'Raggr5' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.Raggr5Column] = value;
            }
        }


        public bool Annullato
        {
            get
            {
                try
                {
                    return System.Convert.ToBoolean(this[tableArticolo.AnnullatoColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'Annullato' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.AnnullatoColumn] = value;
            }
        }


        public string Cod_classe
        {
            get
            {
                try
                {
                    return System.Convert.ToString(this[tableArticolo.Cod_classeColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'Cod_classe' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.Cod_classeColumn] = value;
            }
        }


        public decimal ARPeso
        {
            get
            {
                try
                {
                    return System.Convert.ToDecimal(this[tableArticolo.ARPesoColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'ARPeso' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.ARPesoColumn] = value;
            }
        }


        public string UM
        {
            get
            {
                try
                {
                    return System.Convert.ToString(this[tableArticolo.UMColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'UM' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.UMColumn] = value;
            }
        }


        public decimal ARPrezzo
        {
            get
            {
                try
                {
                    return System.Convert.ToDecimal(this[tableArticolo.ARPrezzoColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'ARPrezzo' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.ARPrezzoColumn] = value;
            }
        }


        public string ARUMPeso
        {
            get
            {
                try
                {
                    return System.Convert.ToString(this[tableArticolo.ARUMPesoColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'ARUMPeso' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.ARUMPesoColumn] = value;
            }
        }


        public string ARTipo
        {
            get
            {
                try
                {
                    return System.Convert.ToString(this[tableArticolo.ARTipoColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'ARTipo' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.ARTipoColumn] = value;
            }
        }


        public decimal ARCSTD
        {
            get
            {
                try
                {
                    return System.Convert.ToDecimal(this[tableArticolo.ARCSTDColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'ARCSTD' in table 'Articolo' is DBNull.", e);
                }
            }
            set
            {
                this[tableArticolo.ARCSTDColumn] = value;
            }
        }


        public bool Iscod_parteNull()
        {
            return IsNull(tableArticolo.cod_parteColumn);
        }


        public void Setcod_parteNull()
        {
            this[tableArticolo.cod_parteColumn] = Convert.DBNull;
        }


        public bool IsDescrizioneNull()
        {
            return IsNull(tableArticolo.DescrizioneColumn);
        }


        public void SetDescrizioneNull()
        {
            this[tableArticolo.DescrizioneColumn] = Convert.DBNull;
        }


        public bool IsRaggr1Null()
        {
            return IsNull(tableArticolo.Raggr1Column);
        }


        public void SetRaggr1Null()
        {
            this[tableArticolo.Raggr1Column] = Convert.DBNull;
        }


        public bool IsRaggr2Null()
        {
            return IsNull(tableArticolo.Raggr2Column);
        }


        public void SetRaggr2Null()
        {
            this[tableArticolo.Raggr2Column] = Convert.DBNull;
        }


        public bool IsRaggr3Null()
        {
            return IsNull(tableArticolo.Raggr3Column);
        }


        public void SetRaggr3Null()
        {
            this[tableArticolo.Raggr3Column] = Convert.DBNull;
        }


        public bool IsRaggr4Null()
        {
            return IsNull(tableArticolo.Raggr4Column);
        }


        public void SetRaggr4Null()
        {
            this[tableArticolo.Raggr4Column] = Convert.DBNull;
        }


        public bool IsRaggr5Null()
        {
            return IsNull(tableArticolo.Raggr5Column);
        }


        public void SetRaggr5Null()
        {
            this[tableArticolo.Raggr5Column] = Convert.DBNull;
        }


        public bool IsAnnullatoNull()
        {
            return IsNull(tableArticolo.AnnullatoColumn);
        }


        public void SetAnnullatoNull()
        {
            this[tableArticolo.AnnullatoColumn] = Convert.DBNull;
        }


        public bool IsCod_classeNull()
        {
            return IsNull(tableArticolo.Cod_classeColumn);
        }


        public void SetCod_classeNull()
        {
            this[tableArticolo.Cod_classeColumn] = Convert.DBNull;
        }


        public bool IsARPesoNull()
        {
            return IsNull(tableArticolo.ARPesoColumn);
        }


        public void SetARPesoNull()
        {
            this[tableArticolo.ARPesoColumn] = Convert.DBNull;
        }


        public bool IsUMNull()
        {
            return IsNull(tableArticolo.UMColumn);
        }


        public void SetUMNull()
        {
            this[tableArticolo.UMColumn] = Convert.DBNull;
        }


        public bool IsARPrezzoNull()
        {
            return IsNull(tableArticolo.ARPrezzoColumn);
        }


        public void SetARPrezzoNull()
        {
            this[tableArticolo.ARPrezzoColumn] = Convert.DBNull;
        }


        public bool IsARUMPesoNull()
        {
            return IsNull(tableArticolo.ARUMPesoColumn);
        }


        public void SetARUMPesoNull()
        {
            this[tableArticolo.ARUMPesoColumn] = Convert.DBNull;
        }


        public bool IsARTipoNull()
        {
            return IsNull(tableArticolo.ARTipoColumn);
        }


        public void SetARTipoNull()
        {
            this[tableArticolo.ARTipoColumn] = Convert.DBNull;
        }


        public bool IsARCSTDNull()
        {
            return IsNull(tableArticolo.ARCSTDColumn);
        }


        public void SetARCSTDNull()
        {
            this[tableArticolo.ARCSTDColumn] = Convert.DBNull;
        }
    }
}
