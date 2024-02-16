using System;

namespace WebApplication1
{
    // Gestisce il caricamento della pagina di dettaglio di un singolo articolo.
    public partial class Dettaglio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Ottiene l'ID dell'articolo dalla query string e recupera i dettagli dall'articolo corrispondente
                int articoloId = Convert.ToInt32(Request.QueryString["id"]);
                Articolo articolo = Articoli.GetArticoloById(articoloId);

                if (articolo != null)
                {
                    imgArticolo.Src = articolo.ImmaginePath;
                    lblNome.InnerText = articolo.Nome;
                    lblDescrizione.InnerText = articolo.Descrizione;
                    lblPrezzo.InnerText = $"Price: {articolo.Prezzo:C}";
                }
            }
        }

        protected void btnAggiungiCarrello_Click(object sender, EventArgs e)
        {
            // Aggiunge l'articolo al carrello e reindirizza l'utente alla pagina del carrello
            int articoloId = Convert.ToInt32(Request.QueryString["id"]);
            Articolo articolo = Articoli.GetArticoloById(articoloId);
            if (articolo != null)
            {
                GestCarrello.AggiungiAlCarrello(articolo);
                Response.Redirect("Carrello.aspx");
            }
        }
    }
}