<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Pagina che visualizza tutti i prodotti, in forma di cards -->
    <main>
        
        <div class="container">

            <asp:ListView ID="lvArticoli" runat="server">
                <LayoutTemplate>
                    <div class="row">
                        <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="col-3 g-3">
                        <div class="card h-100 image-container-flt">
                            <img src='<%# Eval("ImmaginePath") %>' alt="immagine articolo" class="img-fluid card-img-top"/>
                            <div class="card-body d-flex flex-column justify-content-between">  
                                <h5 class="card-title fs-6"><%# Eval("Nome") %></h5>
                                <p class="card-text text-secondary text-opacity-75 fw-semibold font-monospace my-1"> <%# Eval("Prezzo", "{0:C}") %></p>
                                <a href='Dettaglio.aspx?id=<%# Eval("ID") %>' class="btn btn-outline-custom">Details</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>

        </div>        

    </main>

</asp:Content>
