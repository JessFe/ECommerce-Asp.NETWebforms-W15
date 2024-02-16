<%@ Page Title="Carrello" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="WebApplication1.Carrello" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Articoli nel Carrello</h2>
    <asp:Repeater ID="rptCarrello" runat="server">
        <ItemTemplate>
            <div class="articolo-carrello">
                <p><%# Eval("Nome") %> - <%# Eval("Prezzo", "{0:C}") %></p>
                <asp:Button runat="server" CommandArgument='<%# Eval("ID") %>' Text="Rimuovi" OnClick="Rimuovi_Click" />
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <p>Totale Carrello: <asp:Label ID="lblTotaleCarrello" runat="server"></asp:Label></p>

    <asp:Button ID="btnSvuotaCarrello" runat="server" Text="Svuota Carrello" OnClick="btnSvuotaCarrello_Click" />
</asp:Content>
