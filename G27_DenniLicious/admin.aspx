<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="G27_DenniLicious.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="menu-wrap">
            <nav class="menu">
        <ul class="clearfix">
            <li><a href="LoggaUt.aspx">Logga ut</a></li>
        </ul>
            </nav>
        </div>
    <h1>Kompetensportalens Administrations-del</h1>

            <p>Du är inloggad som provledare. <br />
                Det innebär att du har ansvar för att följa upp medarbetares resultat på Licensierings- och Årligt kunskapstest. <br />
                På den här sidan kan du som provledare ta fram listor över provdeltagarna. Du har tillgång att se: <br />
                
                1. Vilka bland personalen som ska skriva licensieringstestet respektive göra ÅKU. <br />
                2. Senaste provtillfället (om det finns ett sådant) för varje person <br />
                3. Senaste provresultatet för varje person <br />
                4. Visa om personen är godkänd eller underkänd vid senaste provtillfället 

            </p>


</asp:Content>
