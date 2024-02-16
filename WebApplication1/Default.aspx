<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        
        <div class="container">
            <asp:ListView ID="lvArticoli" runat="server">
                <ItemTemplate>
                    <div class="articolo">
                        <img src='<%# Eval("ImmaginePath") %>' alt="immagine articolo" class="articolo-img"/>
                        <h3><%# Eval("Nome") %></h3>
                        <p><%# Eval("Descrizione") %></p>
                        <p>Prezzo: <%# Eval("Prezzo", "{0:C}") %></p>
                        <a href='Dettaglio.aspx?id=<%# Eval("ID") %>' class="dettaglio-link">Dettagli</a>

                    </div>

                </ItemTemplate>

            </asp:ListView>
        </div>
        

    </main>

</asp:Content>
