<%@ Page Title="Carrello" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="WebApplication1.Carrello" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Pagina carrello che visualizza tutti i prodotti aggiunti, nr articoli, prezzo totale -->
    <!--   qui si può rimuovere il singolo prodotto oppure svuotare l'intero carrello -->

    <h2>Your Cart</h2>

    <asp:Repeater ID="rptCarrello" runat="server">
        <ItemTemplate>

            <div class="row articolo-carrello">
                <div class="col-5 border-bottom border-warning my-2">
                    <p class="fw-semibold"><%# Eval("Nome") %></p>
                </div>

                <div class="col-2 border-bottom border-warning small my-2">
                    <p class=""><%# Eval("Prezzo", "{0:C}") %></p>
                </div>

                <div class="col-1 border-bottom border-warning text-end my-2">
                    <asp:Button runat="server" CommandArgument='<%# Eval("ID") %>' Text="❌" OnClick="Rimuovi_Click" class="btn btn-outline-danger btn-sm"/>
                </div>                
                
            </div>

        </ItemTemplate>
    </asp:Repeater>

    <div class="row mt-3">
        <div class="col-8 text-end">
            <asp:Label ID="lblNumeroArticoli" runat="server" CssClass="d-block small my-2"></asp:Label>
            <asp:Label ID="lblTotaleCarrello" runat="server" CssClass="d-block small my-2"></asp:Label>
            <asp:Button ID="btnSvuotaCarrello" runat="server" Text="Clear Cart" OnClick="btnSvuotaCarrello_Click" CssClass="btn btn-outline-danger btn-sm" />
        </div>


    </div>
    

    
</asp:Content>
