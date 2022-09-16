using LibraryData;
using System;

namespace Decodifica.Data
{
    public class TabCampiTableAdapter
    {
        public static TabCampiDataTable Select(int connectionType)
        {
            //Creazione dell'oggetto di tipo App
            App objMyApp = (App)App.Current;

            // Chiamata della TabCampiDataTable pre la creazione d'un ogggetto di tipo objCampi
            TabCampiDataTable objCampi = new TabCampiDataTable();

            // Verifica quale connezione prendere, se = 0 prende LocalDB se > di  0 prende RemoteDB
            if (connectionType == 0)
            {
                //Seleziono le causali e escludo i record anullati logicamente; 
                SQLiteTableAdapter objAdapter = new SQLiteTableAdapter(objMyApp.LocalDB.Connection);
                objAdapter.Fill(objCampi, string.Format("SELECT * FROM {0}", objCampi.TableName));
            }
            else if (connectionType > 0)
            {
                //Seleziono le causali e escludo i record anullati logicamente; 
                SQLClientTableAdapter objAdapter = new SQLClientTableAdapter(objMyApp.RemoteDB[connectionType].Connection);
                objAdapter.Fill(objCampi, string.Format("SELECT * FROM {0}", objCampi.TableName));
            }
            else
            {
                throw new Exception("Il valore di connectionType non va bene! Verrifica i parametri di connezione.");
            }

            return objCampi;
        }


        public static TabCampiDataTable SelectColumn(int connectionType)
        {
            //Creazione dell'oggetto di tipo App
            App objMyApp = (App)App.Current;

            // Chiamata della TabCampiDataTable pre la creazione d'un ogggetto di tipo objCampi
            TabCampiDataTable objCampi = new TabCampiDataTable();

            // Verifica quale connezione prendere, se = 0 prende LocalDB se > di  0 prende RemoteDB
            if (connectionType == 0)
            {
                //Seleziono le causali e escludo i record anullati logicamente; 
                SQLiteTableAdapter objAdapter = new SQLiteTableAdapter(objMyApp.LocalDB.Connection);
                objAdapter.Fill(objCampi, string.Format("SELECT * FROM TabCampi WHERE TACodCfg = 'DBC'"));
            }
            else if (connectionType > 0)
            {
                //Seleziono le causali e escludo i record anullati logicamente; 
                SQLClientTableAdapter objAdapter = new SQLClientTableAdapter(objMyApp.RemoteDB[connectionType].Connection);
                objAdapter.Fill(objCampi, string.Format("SELECT * FROM TabCampi WHERE TACodCfg = 'DBC' "));
            }
            else
            {
                throw new Exception("Il valore di connectionType non va bene! Verrifica i parametri di connezione.");
            }

            return objCampi;
        }

        //public static TabCampiDataTable SelectTaQryFind(int connectionType,string strCausale, string strTAOggetto)
        //{
        //    App objMyApp = (App)App.Current;
        //    TabCausaliDataTable objTabCausale = TabCausaliTableAdapter.SelectByCode(connectionType, strCausale);
        //    TabCampiDataTable objTabCampi = new TabCampiDataTable();

        //    if(connectionType == 0)
        //    {
        //        SQLiteTableAdapter objAdapter = new SQLiteTableAdapter(objMyApp.LocalDB.Connection);
        //        objAdapter.Fill(objTabCampi, string.Format("SELECT * FROM TabCampi WHERE TACodCfg = '{0}' AND TAOggetto = '{1}'", objTabCausale[0].TCConfig,strTAOggetto));

        //    }
        //    else if (connectionType > 0)
        //    {
        //        SQLClientTableAdapter objAdapter = new SQLClientTableAdapter(objMyApp.RemoteDB[connectionType].Connection);
        //        objAdapter.Fill(objTabCampi, string.Format("SELECT * FROM TabCampi WHERE TACodCfg = '{0}' AND TAOggetto = '{1}'", objTabCausale[0].TCConfig, strTAOggetto));
        //    }
        //    else
        //    {
        //        throw new Exception("Il valore di connectionType non va bene! Verrifica i parametri di connezione.");
        //    }
        //    return objTabCampi;
        //}


        /// <summary> 
        /// Seleziona solo le righe dalla tabella Campi in base al paramtro
        /// </summary>
        /// <param name="connectionType"></param>
        /// <param name="strTACodCfg"></param>
        /// <returns></returns>
        public static TabCampiDataTable SelectByCod(int connectionType, string strTACodCfg)
        {

            //Creazione dell'oggetto di tipo App
            App objMyApp = (App)App.Current;

            // Chiamata della TabCampiDataTable pre la creazione d'un ogggetto di tipo objCampi
            TabCampiDataTable objCampi = new TabCampiDataTable();

            // Verifica quale connezione prendere, se = 0 prende LocalDB se > di  0 prende RemoteDB
            if (connectionType == 0)
            {
                //Seleziono le causali e escludo i record anullati logicamente; 
                SQLiteTableAdapter objAdapter = new SQLiteTableAdapter(objMyApp.LocalDB.Connection);
                objAdapter.Fill(objCampi, string.Format("SELECT * FROM {0} WHERE TACodCfg = '{1}'", objCampi.TableName, strTACodCfg));
            }
            else if (connectionType > 0)
            {
                //Seleziono le causali e escludo i record anullati logicamente; 
                SQLClientTableAdapter objAdapter = new SQLClientTableAdapter(objMyApp.RemoteDB[connectionType].Connection);
                objAdapter.Fill(objCampi, string.Format("SELECT * FROM {0} WHERE TACodCfg = '{1}'", objCampi.TableName, strTACodCfg));
            }
            else
            {
                throw new Exception("Il valore di connectionType non va bene! Verrifica i parametri di connezione.");
            }

            return objCampi;
        }

        public static void CreateTable()
        {
            App objMyApp = (App)App.Current;//crea oggetto di tipo App

            TabCampiDataTable objCampi = new TabCampiDataTable(); // crea oggetto di tipo ArticoloDataTable
            SQLiteTableAdapter objAdapter = new SQLiteTableAdapter(objMyApp.LocalDB.Connection);//Crea oggetto di tipo SQLiteTableAdapter prendendo il parametro di connessione

            var strCMD = objAdapter.CreateIfNotExists(objCampi); // crea la query sulla base di ogetto di tipo ArticoloDataTable

            var objCMD = objMyApp.LocalDB.Connection.CreateCommand(); // Crea un oggetto di tipo commando


            objCMD.CommandText = strCMD; //Esegue il commando prendendo la query creata in base al oggetto di tipo ArticoloDataTable
            objCMD.ExecuteNonQuery(); // Esecuzione della query 
        }


        public static void InsertValueTA()
        {
            App objMyApp = (App)App.Current;

            var strCMD = "DELETE FROM TabCampi; INSERT INTO TabCampi (TACodCfg,TAOggetto,TATestoEt,TAObblig,TADecod,TADefVal,TAMinLng,TAMaxLng,TAFlgDiv,TAFCopyN,TADaTyp,TAQryFind,TAQryDecod,TARegExp,TACodCnn) VALUES" +
                                                                    "('810','txtC1','Ubic. partenza',1,1,''     ,0,2,0,0,0,'SELECT TO2Cod AS Codice, TO2Des AS Descrizione FROM TabC2 WHERE TO2CodC1= ''@txtM1'' AND TO2Cod LIKE ''@MyCode%'' ORDER BY TO2Cod','SELECT TO2ID FROM TabC2 WHERE TO2CodC1= ''@txtM1'' AND TO2Cod= ''@MyCode''','',0)," +
                                                                    "('810','txtC2','Ubic. arrivo'  ,1,1,''     ,0,2,0,0,0,'SELECT TO2Cod AS Codice, TO2Des AS Descrizione FROM TabC2 WHERE TO2CodC1= ''@txtM2'' AND TO2Cod LIKE ''@MyCode%'' ORDER BY TO2Cod','SELECT TO2ID FROM TabC2 WHERE TO2CodC1= ''@txtM2'' AND TO2Cod= ''@MyCode''','',0)," +
                                                                    "('810','txtCodArt','Articolo'  ,1,1,''     ,0,0,0,0,0,'SELECT Cod_articolo as Codice, Descrizione FROM Articolo WHERE Cod_articolo LIKE ''@MyCode%''  ',' SELECT Descrizione,UM FROM Articolo WHERE Cod_articolo = ''@MyCode'' ', '^([A-Z0-9]{0,})\\Z' ,0)," +
                                                                    "('810','txtDtRif','Data'       ,1,0,''     ,7,10,0,1,1,'','','',0)," +
                                                                    "('810','txtM1','Mag. partenza' ,1,1,''     ,2,0,0,1,0,'SELECT TO1Cod AS Codice, TO1Des AS Descrizione FROM TabC1 WHERE TO1Cod LIKE ''@MyCode%'' ORDER BY TO1Cod','SELECT TO1ID FROM TabC1 WHERE TO1Cod= ''@MyCode''','',0)," +
                                                                    "('810','txtM2','Mag. arrivo'   ,1,1,''     ,0,2,0,1,0,'SELECT TO1Cod AS Codice, TO1Des AS Descrizione FROM TabC1 WHERE TO1Cod LIKE ''@MyCode%'' ORDER BY TO1Cod','SELECT TO1ID FROM TabC1 WHERE TO1Cod= ''@MyCode''','',0)," +
                                                                    "('810','txtNrDoc',''           ,0,0,''     ,0,10,0,0,0,'','','',0)," +
                                                                    "('810','txtNrLotto','Lotto'    ,1,0,''     ,3,12,0,0,0,'','','^([A-Z]{1,5})([0-9]{1,6})\\Z',0)," +
                                                                    "('810','txtQta','Quantità'     ,1,0,''     ,0,0,0,0,2,'','','',0),"+
                                                                    
                                                                    "('817','txtCodArt','Articolo'          ,1  ,1  ,''         ,0,0,0,0,0,'SELECT Cod_articolo as Codice, Descrizione FROM Articolo WHERE Cod_articolo LIKE ''@MyCode%''  ',' SELECT Descrizione,UM FROM Articolo WHERE Cod_articolo = ''@MyCode'' ', '^([A-Z0-9]{0,})\\Z' ,0)," +
                                                                    "('817','txtQta','Quantità'             ,1  ,0  ,''         ,0,0,0,0,2,'','','',0),"+
                                                                    "('817','txtM1','Mag. partenza'         ,1  ,1  ,''         ,2,0,0,1,0,'SELECT TO1Cod AS Codice, TO1Des AS Descrizione FROM TabC1 WHERE TO1Cod LIKE ''@MyCode%'' ORDER BY TO1Cod','SELECT TO1ID FROM TabC1 WHERE TO1Cod= ''@MyCode''','',0)," +
                                                                    "('817','txtM2','Mag. arrivo'           ,1  ,1  ,''         ,0,2,0,1,0,'SELECT TO1Cod AS Codice, TO1Des AS Descrizione FROM TabC1 WHERE TO1Cod LIKE ''@MyCode%'' ORDER BY TO1Cod','SELECT TO1ID FROM TabC1 WHERE TO1Cod= ''@MyCode''','',0)," +
                                                                    "('817','txtC1','Ubic. partenza'        ,1  ,1  ,''         ,0,2,0,0,0,'SELECT TO2Cod AS Codice, TO2Des AS Descrizione FROM TabC2 WHERE TO2CodC1= ''@txtM1'' AND TO2Cod LIKE ''@MyCode%'' ORDER BY TO2Cod','SELECT TO2ID FROM TabC2 WHERE TO2CodC1= ''@txtM1'' AND TO2Cod= ''@MyCode''','',0)," +
                                                                    "('817','txtC2','Ubic. arrivo'          ,1  ,1  ,''         ,0,2,0,0,0,'SELECT TO2Cod AS Codice, TO2Des AS Descrizione FROM TabC2 WHERE TO2CodC1= ''@txtM2'' AND TO2Cod LIKE ''@MyCode%'' ORDER BY TO2Cod','SELECT TO2ID FROM TabC2 WHERE TO2CodC1= ''@txtM2'' AND TO2Cod= ''@MyCode''','',0)," +
                                                                    "('817','txtL1','Liv. partenza'         ,'1','0',''         ,'3','0','0','0','0','','','','0')," +
                                                                    "('817','txtL2','Liv. arrivo'           ,'1','0',''         ,'0','5','0','0','0','','','','0')," +
                                                                    "('817','txtNrLotto','Lotto'            ,1  ,0  ,''         ,3,12,0,0,0,'','','^([A-Z]{1,5})([0-9]{1,6})\\Z',0)," +
                                                                    "('817','txtDtLotto','Data Lotto'       ,'1','0',''  ,'0','0','0','0','1','','','','0')," +
                                                                    "('817','txtNrDoc','Numero Documento'   ,0  ,0  ,''         ,0,10,0,0,0,'','','',0)," +
                                                                    "('817','txtNrSerie','Numero Serie'     ,'1','0',''         ,'3','12','0','0','0','','','','0')," +
                                                                    "('817','txtDtRif','Data'               ,1  ,0  ,'<ToDay>'  ,7,10,0,1,1,'','','',0)," +

                                                                    "('INV','txtC1'     ,'Ubicazione','1','1',''       ,'0','0' ,'0','1','0','SELECT TO2Cod AS Codice, TO2Des AS Descrizione FROM TabC2 WHERE TO2CodC1=''@txtM1'' AND TO2Cod LIKE ''@MyCode%'' ORDER BY TO2Cod','SELECT TO2ID FROM TabC2 WHERE TO2CodC1=''@txtM1'' AND TO2Cod= ''@MyCode''','','0')," +
                                                                    "('INV','txtCodArt' ,'Articolo'  ,'1','1',''       ,'0','0' ,'0','0','0','SELECT Cod_articolo AS Codice, Descrizione FROM Articolo WHERE Cod_articolo LIKE ''@MyCode%'' AND (Annullato Is Null OR Annullato=0) ORDER BY Cod_articolo','SELECT * FROM Articolo WHERE Cod_articolo=''@MyCode'' AND (Annullato Is Null OR Annullato=0) ','','1')," +
"('INV',     'txtDtRif'  ,'Data'      ,'1','0','<ToDay>','7','10','0','1','1','','','','0')," +
"('INV',     'txtM1'     ,'Magazzino' ,'1','1',''       ,'0','0' ,'0','1','0','SELECT TO1Cod AS Codice, TO1Des AS Descrizione FROM TabC1 WHERE TO1Cod LIKE ''@MyCode%'' ORDER BY TO1Cod','SELECT TO1ID FROM TabC1 WHERE TO1Cod= ''@MyCode''','','0')," +

"('INV',    'txtNrLotto',      'Lotto',              '1','0','',       '5','10','0','0','0','','','','0')," +
 "('INV',   'txtQta',          'Quantita',           '1','0','1',      '0','0' ,'0','0','2','','','','0')," +

"('DBC',    'Descrizione',    '1-Descrizione',       '0','0','0',      '0','0' ,'0','0','2','','','','0')," +
"('DBC',    'UM',             '2-Unità di misura',   '0','0','0',      '0','0' ,'0','0','2','','','','0')," +
"('DBC',    'ARPrezzo',       '3-Prezzo',            '1','0','1',      '0','0' ,'0','0','2','','','','0')";

            var objCMD = objMyApp.LocalDB.Connection.CreateCommand();
            objCMD.CommandText = strCMD;
            //objCMD.ExecuteNonQuery();
            objCMD.ExecuteReader();
        }

        public static void DropTable()
        {
            App objMyApp = (App)App.Current;
            var objCMD = objMyApp.LocalDB.Connection.CreateCommand();
            string strCMD = "DROP TABLE TabCampi";
            objCMD.CommandText = strCMD;
            objCMD.ExecuteReader();
        }
    }
}
