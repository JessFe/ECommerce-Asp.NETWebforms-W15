using System;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    // Gestisce la visualizzazione degli articoli nel carrello, permettendo di rimuoverli o svuotare il carrello.
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AggiornaCarrello();
            }
        }

        // Gestisce l'evento click sui pulsanti di rimozione del carrello
        protected void Rimuovi_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int articoloId = Convert.ToInt32(btn.CommandArgument);
            GestCarrello.RimuoviDalCarrello(articoloId);

            AggiornaCarrello(); // Riaggiorna il carrello dopo la rimozione
        }

        // Gestisce l'evento click sul pulsante di svuotamento del carrello
        protected void btnSvuotaCarrello_Click(object sender, EventArgs e)
        {
            GestCarrello.SvuotaCarrello();
            AggiornaCarrello(); // Riaggiorna il carrello dopo lo svuotamento
        }

        // Aggiorna il contenuto visualizzato del carrello
        private void AggiornaCarrello()
        {
            var articoli = GestCarrello.GetArticoli();
            rptCarrello.DataSource = articoli;
            rptCarrello.DataBind();

            // Aggiorna il conteggio degli articoli
            lblNumeroArticoli.Text = $"Items: {articoli.Count.ToString()}";

            // Aggiorna il totale del prezzo
            decimal totaleCarrello = GestCarrello.CalcolaTotale();
            lblTotaleCarrello.Text = $"Checkout: {totaleCarrello:C}";
        }
    }
}