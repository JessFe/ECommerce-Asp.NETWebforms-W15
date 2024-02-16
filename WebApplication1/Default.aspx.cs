using System;
using System.Collections.Generic;
using System.Web.UI;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Articolo> articoli = Articoli.GetArticoli();

                lvArticoli.DataSource = articoli;
                lvArticoli.DataBind();
            }
        }
    }
}