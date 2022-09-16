using Decodifica.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Decodifica
{
    public partial class MainPage : ContentPage
    {

        public int m_connectionType = 0;

        private ArticoloDataTable objArticolo = new ArticoloDataTable();

        public MainPage()
        {
            InitializeComponent();

            stkDescrizione.IsVisible = false;
            stkUM.IsVisible = false;
            stkARPrezzo.IsVisible = false;
        }

        private void btnNuovo_Clicked(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {

            txtCodArt.Text = "";

            stkDescrizione.IsVisible = false;
            lblDescrizione.Text = "";

            stkUM.IsVisible = false;
            lblUM.Text = "";

            stkARPrezzo.IsVisible = false;
            lbPrezzo.Text = "";
        }

        private void btnDecodifica_Clicked(object sender, EventArgs e)
        {
            objArticolo = TabArticoloTableAdapter.SelectArticolo(m_connectionType, txtCodArt.Text);
            var objCampi = TabCampiTableAdapter.SelectColumn(m_connectionType);


            try
            {
                //  Verifica se il Codice è uguale al Codice Articolo
                if (txtCodArt.Text == objArticolo[0].Cod_articolo)

                    //  Se il codice è uguale, fa vedere il cotenuto 
                    lblDescrizione.Text = objArticolo[0].Descrizione.ToString();
                lblUM.Text = objArticolo[0].UM.ToString();
                lbPrezzo.Text = objArticolo[0].ARPrezzo.ToString();


                //  Seleziona se il contenuto della colonne TATestoEt = 'DBC'  
                descrizione.Text = objCampi[0].TATestoEt;
                UM.Text = objCampi[1].TATestoEt;
                ARPrezzo.Text = objCampi[2].TATestoEt;

                if (String.IsNullOrEmpty(objArticolo[0].Descrizione))
                    stkDescrizione.IsVisible = false;
                else
                    stkDescrizione.IsVisible = true;

                if (String.IsNullOrEmpty(objArticolo[0].UM))
                    stkUM.IsVisible = false;
                else
                    stkUM.IsVisible = true;

                if (objArticolo[0].ARPrezzo <= 0.00m)
                    stkARPrezzo.IsVisible = false;
                else
                    stkARPrezzo.IsVisible = true;
            }
            catch
            {
                DisplayAlert("Attenzione!", $" Non esisste il codice {txtCodArt.Text}", "Ok");
                ClearData();
            }
        }
    }
}
