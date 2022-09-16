using Decodifica.Data;
using LibraryData;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Decodifica
{
    public partial class App : Application
    {
        private DatabaseLDB m_LocalDB;
        private List<DatabaseRMT> m_RemoteDB;


        public DatabaseLDB LocalDB { get { return m_LocalDB; } }
        public List<DatabaseRMT> RemoteDB { get { return m_RemoteDB; } }

        public string connectionType { get; private set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            string strDbLocal = "GsDecod";


            m_LocalDB = new DatabaseLDB(strDbLocal);

            m_RemoteDB = new List<DatabaseRMT>();

            
            m_RemoteDB.Add(new DatabaseRMT("// Add Connection string Database SQL"));

            MainPage = new MainPage();
            m_LocalDB.Open();
        }

        protected override void OnStart()
        {
            //TabArticoloTableAdapter.DropTable();
            TabArticoloTableAdapter.CreateTable();
            TabArticoloTableAdapter.InsertValue();

            //TabCampiTableAdapter.DropTable();
            TabCampiTableAdapter.CreateTable();
            TabCampiTableAdapter.InsertValueTA();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
