using System;
using System.Data;

namespace Decodifica.Data
{
    /// <summary>
    /// Represents strongly named DataRow class.
    /// </summary>
    public partial class TabCampiRow : DataRow
    {

        private TabCampiDataTable tableTabCampi;


        internal TabCampiRow(DataRowBuilder rb) : base(rb)
        {
            tableTabCampi = (TabCampiDataTable)Table;
        }

        public string TACodCfg
        {
            get
            {
                return System.Convert.ToString(this[tableTabCampi.TACodCfgColumn]);
            }
            set
            {
                this[tableTabCampi.TACodCfgColumn] = value;
            }
        }


        public string TAOggetto
        {
            get
            {
                return System.Convert.ToString(this[tableTabCampi.TAOggettoColumn]);
            }
            set
            {
                this[tableTabCampi.TAOggettoColumn] = value;
            }
        }


        public string TATestoEt
        {
            get
            {
                try
                {
                    return System.Convert.ToString(this[tableTabCampi.TATestoEtColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'TATestoEt' in table 'TabCampi' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCampi.TATestoEtColumn] = value;
            }
        }


        public bool TAObblig
        {
            get
            {
                try
                {
                    return System.Convert.ToBoolean(this[tableTabCampi.TAObbligColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'TAObblig' in table 'TabCampi' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCampi.TAObbligColumn] = value;
            }
        }


        public bool TADecod
        {
            get
            {
                try
                {
                    return System.Convert.ToBoolean(this[tableTabCampi.TADecodColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'TADecod' in table 'TabCampi' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCampi.TADecodColumn] = value;
            }
        }


        public string TADefVal
        {
            get
            {
                if (IsTADefValNull())
                {
                    return string.Empty;
                }
                else
                {
                    return System.Convert.ToString(this[tableTabCampi.TADefValColumn]);
                }
            }
            set
            {
                this[tableTabCampi.TADefValColumn] = value;
            }
        }


        public byte TAMinLng
        {
            get
            {
                try
                {
                    return System.Convert.ToByte(this[tableTabCampi.TAMinLngColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'TAMinLng' in table 'TabCampi' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCampi.TAMinLngColumn] = value;
            }
        }


        public byte TAMaxLng
        {
            get
            {
                try
                {
                    return System.Convert.ToByte(this[tableTabCampi.TAMaxLngColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'TAMaxLng' in table 'TabCampi' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCampi.TAMaxLngColumn] = value;
            }
        }


        public bool TAFlgDiv
        {
            get
            {
                try
                {
                    return System.Convert.ToBoolean(this[tableTabCampi.TAFlgDivColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'TAFlgDiv' in table 'TabCampi' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCampi.TAFlgDivColumn] = value;
            }
        }


        public bool TAFCopyN
        {
            get
            {
                try
                {
                    return System.Convert.ToBoolean(this[tableTabCampi.TAFCopyNColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'TAFCopyN' in table 'TabCampi' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCampi.TAFCopyNColumn] = value;
            }
        }


        public byte TADaTyp
        {
            get
            {
                try
                {
                    return System.Convert.ToByte(this[tableTabCampi.TADaTypColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'TADaTyp' in table 'TabCampi' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCampi.TADaTypColumn] = value;
            }
        }


        public string TAQryDecod
        {
            get
            {
                if (IsTAQryDecodNull())
                {
                    return string.Empty;
                }
                else
                {
                    return System.Convert.ToString(this[tableTabCampi.TAQryDecodColumn]);
                }
            }
            set
            {
                this[tableTabCampi.TAQryDecodColumn] = value;
            }
        }


        public string TAQryFind
        {
            get
            {
                if (IsTAQryFindNull())
                {
                    return string.Empty;
                }
                else
                {
                    return System.Convert.ToString(this[tableTabCampi.TAQryFindColumn]);
                }
            }
            set
            {
                this[tableTabCampi.TAQryFindColumn] = value;
            }
        }


        public string TARegExp
        {
            get
            {
                if (IsTARegExpNull())
                {
                    return string.Empty;
                }
                else
                {
                    return System.Convert.ToString(this[tableTabCampi.TARegExpColumn]);
                }
            }
            set
            {
                this[tableTabCampi.TARegExpColumn] = value;
            }
        }


        public byte TACodCnn
        {
            get
            {
                try
                {
                    return System.Convert.ToByte(this[tableTabCampi.TACodCnnColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'TACodCnn' in table 'TabCampi' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCampi.TACodCnnColumn] = value;
            }
        }


        public bool IsTATestoEtNull()
        {
            return IsNull(tableTabCampi.TATestoEtColumn);
        }


        public void SetTATestoEtNull()
        {
            this[tableTabCampi.TATestoEtColumn] = Convert.DBNull;
        }


        public bool IsTAObbligNull()
        {
            return IsNull(tableTabCampi.TAObbligColumn);
        }


        public void SetTAObbligNull()
        {
            this[tableTabCampi.TAObbligColumn] = Convert.DBNull;
        }


        public bool IsTADecodNull()
        {
            return IsNull(tableTabCampi.TADecodColumn);
        }


        public void SetTADecodNull()
        {
            this[tableTabCampi.TADecodColumn] = Convert.DBNull;
        }


        public bool IsTADefValNull()
        {
            return IsNull(tableTabCampi.TADefValColumn);
        }


        public void SetTADefValNull()
        {
            this[tableTabCampi.TADefValColumn] = Convert.DBNull;
        }


        public bool IsTAMinLngNull()
        {
            return IsNull(tableTabCampi.TAMinLngColumn);
        }


        public void SetTAMinLngNull()
        {
            this[tableTabCampi.TAMinLngColumn] = Convert.DBNull;
        }


        public bool IsTAMaxLngNull()
        {
            return IsNull(tableTabCampi.TAMaxLngColumn);
        }


        public void SetTAMaxLngNull()
        {
            this[tableTabCampi.TAMaxLngColumn] = Convert.DBNull;
        }


        public bool IsTAFlgDivNull()
        {
            return IsNull(tableTabCampi.TAFlgDivColumn);
        }


        public void SetTAFlgDivNull()
        {
            this[tableTabCampi.TAFlgDivColumn] = Convert.DBNull;
        }


        public bool IsTAFCopyNNull()
        {
            return IsNull(tableTabCampi.TAFCopyNColumn);
        }


        public void SetTAFCopyNNull()
        {
            this[tableTabCampi.TAFCopyNColumn] = Convert.DBNull;
        }


        public bool IsTADaTypNull()
        {
            return IsNull(tableTabCampi.TADaTypColumn);
        }


        public void SetTADaTypNull()
        {
            this[tableTabCampi.TADaTypColumn] = Convert.DBNull;
        }


        public bool IsTAQryDecodNull()
        {
            return IsNull(tableTabCampi.TAQryDecodColumn);
        }


        public void SetTAQryDecodNull()
        {
            this[tableTabCampi.TAQryDecodColumn] = Convert.DBNull;
        }


        public bool IsTAQryFindNull()
        {
            return IsNull(tableTabCampi.TAQryFindColumn);
        }


        public void SetTAQryFindNull()
        {
            this[tableTabCampi.TAQryFindColumn] = Convert.DBNull;
        }


        public bool IsTARegExpNull()
        {
            return IsNull(tableTabCampi.TARegExpColumn);
        }


        public void SetTARegExpNull()
        {
            this[tableTabCampi.TARegExpColumn] = Convert.DBNull;
        }


        public bool IsTACodCnnNull()
        {
            return IsNull(tableTabCampi.TACodCnnColumn);
        }


        public void SetTACodCnnNull()
        {
            this[tableTabCampi.TACodCnnColumn] = Convert.DBNull;
        }
    }
}
