<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Licensieringstest.aspx.cs" Inherits="G27_DenniLicious.Licensieringstest" %>
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
    <h1>Kompetensportalens Licensieringstest</h1>

            <p>Licensieringstestet består av 25 frågor, fördelade över tre delområden.<br />
                De allra flesta frågorna har endast ett svar som är korrekt. Här finns ingen särskild instruktion i uppgiften.<br />
                I vissa testuppgifter är flera svar korrekta. I dessa uppgifter står det tydligt angivet med en hjälptext hur många korrekta svar som ska markeras. <br />
                För att få rätt på uppgiften ska exakt rätt antal svarsalternativ markeras.<br />
                För en korrekt besvarad uppgift får man ett poäng. För en felaktigt besvarad uppgift får man inget rätt (och heller inga minuspoäng).<br />
                Det krävs minst 70 procent rätt totalt samt minst 60 procent rätt inom varje delområde för att bli godkänd. Resultatet redovisas direkt efter avslutat test.</p>

            <p>Lycka till!</p>
    <div id="allafragor" runat="server"></div>
    <div id="alternativen" runat="server"></div>
    <div id="rattasvaret" runat="server"></div>
    <asp:Button ID="btnSkickaLic" runat="server" Text="Skicka in och rätta licensieringstestet" OnClick="btnSkickaLic_Click" />
</asp:Content>
