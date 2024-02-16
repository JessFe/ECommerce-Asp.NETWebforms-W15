using System;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptCarrello.DataSource = GestCarrello.GetArticoli();
                rptCarrello.DataBind();

                // Calcola e visualizza il totale del carrello
                decimal totaleCarrello = GestCarrello.CalcolaTotale();
                lblTotaleCarrello.Text = totaleCarrello.ToString("C");
            }
        }

        protected void Rimuovi_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int articoloId = Convert.ToInt32(btn.CommandArgument);
            GestCarrello.RimuoviDalCarrello(articoloId);

            // Aggiorna il carrello
            rptCarrello.DataSource = GestCarrello.GetArticoli();
            rptCarrello.DataBind();

            // Aggiorna il totale del carrello
            lblTotaleCarrello.Text = GestCarrello.CalcolaTotale().ToString("C");
        }

        protected void btnSvuotaCarrello_Click(object sender, EventArgs e)
        {
            GestCarrello.SvuotaCarrello();

            // Aggiorna il carrello
            rptCarrello.DataSource = null;
            rptCarrello.DataBind();

            // Aggiorna il totale del carrello a zero
            lblTotaleCarrello.Text = "€0,00";
        }
    }
}