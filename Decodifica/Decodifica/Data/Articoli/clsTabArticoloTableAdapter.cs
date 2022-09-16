
using LibraryData;
using System;

namespace Decodifica.Data
{
    public class TabArticoloTableAdapter
    {


        public static void CreateTable()
        {
            App objMyApp = (App)App.Current;//crea oggetto di tipo App

            ArticoloDataTable objArticolo = new ArticoloDataTable(); // crea oggetto di tipo ArticoloDataTable
            SQLiteTableAdapter objAdapter = new SQLiteTableAdapter(objMyApp.LocalDB.Connection);//Crea oggetto di tipo SQLiteTableAdapter prendendo il parametro di connessione

            var strCMD = objAdapter.CreateIfNotExists(objArticolo); // crea la query sulla base di ogetto di tipo ArticoloDataTable

            var objCMD = objMyApp.LocalDB.Connection.CreateCommand(); // Crea un oggetto di tipo commando


            objCMD.CommandText = strCMD; //Esegue il commando prendendo la query creata in base al oggetto di tipo ArticoloDataTable
            objCMD.ExecuteNonQuery(); // Esecuzione della query 
        }



        public static ArticoloDataTable Select(int connectionType)
        {
            //Creazione dell'oggetto di tipo App
            App objMyApp = (App)App.Current;

            // Chiamata della BilanciaParamsDataTable pre la creazione d'un ogggetto di tipo objBilanciaParams
            ArticoloDataTable objArticolo = new ArticoloDataTable();

            // Verifica quale connezione prendere, se = 0 prende LocalDB se > di  0 prende RemoteDB
            if (connectionType == 0)
            {
                //Seleziono le Bilancia e escludo i record
                SQLiteTableAdapter objAdapter = new SQLiteTableAdapter(objMyApp.LocalDB.Connection);
                objAdapter.Fill(objArticolo, string.Format("SELECT * FROM {0}", objArticolo.TableName));
            }
            else if (connectionType > 0)
            {
                //Seleziono le causali e escludo i record; 
                SQLClientTableAdapter objAdapter = new SQLClientTableAdapter(objMyApp.RemoteDB[connectionType].Connection);
                objAdapter.Fill(objArticolo, string.Format("SELECT * FROM {0}", objArticolo.TableName));
            }
            else
            {
                throw new Exception("Il valore di connectionType non va bene! Verrifica i parametri di connezione.");
            }

            return objArticolo;
        }


       

        //Inserimento dei valori fissi
        public static void InsertValue()
        {
            App objMyApp = (App)App.Current;
            ArticoloDataTable objArticolo = new ArticoloDataTable();
            var strCMD = string.Format("DELETE FROM Articolo; INSERT INTO {0} (Cod_Articolo,Descrizione,UM, ARPrezzo) VALUES " +
                "('8012345000012',      'Antico Tavolato Rovere 14mm 070 0800 / . Rustica',   'PC', '1.000')," +
                "('8012345000005',      'Antico Tavolato Rovere 14mm 070 0700 / . Rustica',   'PC', '20.00')," +
                "('8012345156580',      'Super Ready Rovere 10mm 4mm 090 0610',               'PC', '0.00')," +
                "('8012345156573',      'Super Ready Rovere 10mm 4mm 090 0610',               'PC', '40.00')," +
                "('8012345134489',      'Pav.Tradizionale Afrormosia 10mm 065 0325',          'PC', '0.00')," +
                "('8012345157174',      'Plancia Business Rovere 15mm 3mm 190 1860 / . Invi', 'PC', '6.000')," +
                "('8012345202300',      'Pav.Tradizionale Teak Asia 15mm 080 0980',           'PC', '0.00')," +
                "('8012345130757',      'Doghe Toscane Noce Europeo 15mm 4mm 200 2200',       'PC', '80.00')," +
                "('8012345130290',      'Doghe Toscane Noce Europeo 15mm 4mm 200 1800',       'PC', '90.00')," +
                "('8012345130306',      'Doghe Toscane Noce Europeo 15mm 4mm 200 1500',       'PC', '0.00')," +
                "('8012345186181',      'Doghe Toscane Noce Europeo 15mm 4mm 200 1700',       'PC', '1200')," +
                "('8012345186143',      'Pavimento Prefinito Rovere 09mm 3mm 070 0490',       'PC', '13.00')," +


                "('8012345000425',	'',		                                                   '', 	    '1.00')," +
                "('8012345000432',	'Antico Tavolato Rovere 14mm 110 0800 / . . Oliato',	   'PC', 	'0.00')," +
                "('8012345000449',	'',		                                                   'PC', 	'1.000')," +
                "('8012345000456',	'Antico Tavolato Rovere 14mm 110 0800 / . (M) Sbian',		'', 	'0.00')," +
                "('8012345000524',	'Antico Tavolato Rovere 14mm 110 1200 / . . Vernici',		'', 	'0.00')"

                , objArticolo.TableName);

            var objCMD = objMyApp.LocalDB.Connection.CreateCommand();
            objCMD.CommandText = strCMD;

            //objCMD.ExecuteNonQuery();
            objCMD.ExecuteReader();
        }

        public static ArticoloDataTable SelectArticolo(int connectionType, string strCod_Articolo)
        {
            App objMyApp = (App)App.Current;
            ArticoloDataTable objArticolo = new ArticoloDataTable();

            // Verifica quale connezione prendere, se = 0 prende LocalDB se > di  0 prende RemoteDB
            if (connectionType == 0)
            {
                SQLiteTableAdapter objAdapter = new SQLiteTableAdapter(objMyApp.LocalDB.Connection);
                objAdapter.Fill(objArticolo, string.Format(
                    "SELECT * FROM Articolo WHERE Cod_articolo =" + SQLClientTableAdapter.ToSqlStr(strCod_Articolo)));

            }
            else if (connectionType > 0)
            {
                SQLClientTableAdapter objAdapter = new SQLClientTableAdapter(objMyApp.RemoteDB[connectionType].Connection);

                objAdapter.Fill(objArticolo, string.Format(
                "SELECT * FROM Articolo WHERE Cod_articolo =" + SQLClientTableAdapter.ToSqlStr(strCod_Articolo)));
            }
            else
            {
                throw new Exception("Il valore di connectionType non va bene! Verrifica i parametri di connezione.");
            }
            return objArticolo;
        }

        public static void DropTable()
        {
            App objMyApp = (App)App.Current;
            var objCMD = objMyApp.LocalDB.Connection.CreateCommand();
            string strCMD = "DROP TABLE Articolo";
            objCMD.CommandText = strCMD;
            objCMD.ExecuteReader();
        }
    }
}
