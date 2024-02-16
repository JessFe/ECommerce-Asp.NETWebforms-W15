using System;

namespace WebApplication1
{
    public partial class Dettaglio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int articoloId = Convert.ToInt32(Request.QueryString["id"]);
                // Utilizza il repository per ottenere l'articolo specifico
                Articolo articolo = Articoli.GetArticoloById(articoloId);

                if (articolo != null)
                {
                    imgArticolo.Src = articolo.ImmaginePath;
                    lblNome.InnerText = articolo.Nome;
                    lblDescrizione.InnerText = articolo.Descrizione;
                    lblPrezzo.InnerText = $"Prezzo: {articolo.Prezzo:C}";
                }
            }
        }

        protected void btnAggiungiCarrello_Click(object sender, EventArgs e)
        {
            int articoloId = Convert.ToInt32(Request.QueryString["id"]);
            // Utilizza il repository per ottenere l'articolo specifico
            Articolo articolo = Articoli.GetArticoloById(articoloId);
            if (articolo != null)
            {
                GestCarrello.AggiungiAlCarrello(articolo);
                Response.Redirect("Carrello.aspx");
            }
        }
    }
}