<%@ Page Title="Dettaglio Articolo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="WebApplication1.Dettaglio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Pagina che visualizza i dettagli del singolo prodotto e permette di aggiungerlo al carrello -->
 
    <div class="row articolo-dettaglio justify-content-center align-items-center my-4">
        <div class="col-7">
            <h2 id="lblNome" runat="server"></h2>
            <p id="lblDescrizione" runat="server"></p>
            <p id="lblPrezzo" runat="server" class="text-secondary text-opacity-75 fw-semibold font-monospace"></p>
            <button id="btnAggiungiCarrello" runat="server" onserverclick="btnAggiungiCarrello_Click" class="btn btn-outline-custom">Add to Cart</button>
        </div>
        <div class="col-5 col-lg-3">
           <img id="imgArticolo" runat="server" alt="Immagine Articolo" class="rounded rounded-3 w-100" />

        </div>
    </div>
</asp:Content>
