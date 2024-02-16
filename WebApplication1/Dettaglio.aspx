<%@ Page Title="Dettaglio Articolo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="WebApplication1.Dettaglio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="articolo-dettaglio">
        <img id="imgArticolo" runat="server" alt="Immagine Articolo" />
        <h2 id="lblNome" runat="server"></h2>
        <p id="lblDescrizione" runat="server"></p>
        <p id="lblPrezzo" runat="server"></p>
        <button id="btnAggiungiCarrello" runat="server" onserverclick="btnAggiungiCarrello_Click">Aggiungi al Carrello</button>
    </div>
</asp:Content>
