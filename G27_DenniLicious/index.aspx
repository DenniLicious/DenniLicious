<%@ Page Title="Startsida" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="G27_DenniLicious.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="menu-wrap">
            <nav class="menu">
        <ul class="clearfix">
            <li><a href="index.aspx">Hem</a></li>
            <li>
                <a href="#">Välj användare <span class="arrow">&#9660;</span></a>
 
                <ul class="sub-menu" id="dropdown" runat="server">
                    <li><a href="#">Admin</a></li>
                    <li><a href="#">Anställd</a></li>
                    <li><a href="nyanstalld.aspx">Nyanställd</a></li>
                </ul>
            </li>
            <li>
            <asp:DropDownList ID="DropDownList1" runat="server"> <%--CssClass="menu-wrap">--%>

            </asp:DropDownList>
            </li>
            <li>
            <asp:Button ID="LoggaInKnapp" runat="server" Text="Logga in" OnClick="LoggaInKnapp_Click"/>

            </li>
        </ul>
            </nav>
        </div>
    <h1>Välkommen till Kompetensportalen</h1>
            <br />
            <h3>För att komma åt det anpassade innehållet på Kompetensportalen måste du välja användar-typ. 
                När du har valt användare får du tillgång till det testet som du ska genomföra.
                Lite mer info om vad Kompetensportalen är och hur du använder den.</h3>
</asp:Content>
