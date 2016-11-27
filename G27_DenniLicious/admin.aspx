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
                På den här sidan kan du som provledare ta fram listor över provdeltagarna.  <br />              
            </p>

    <h3>Visa lista på de personer som ska skriva:</h3>
        <%--Lägger radiobuttons i en group för att få true/false-värde på rb vid tryck--%>
        <asp:RadioButton ID="rbLicensieringstest" runat="server" text="Licensieringstest" GroupName="tester" />
        <asp:RadioButton ID="rbAkutest" runat="server" text="Årlig kunskapsuppdatering" GroupName="tester" /> 
    <br />
    <br />
    <asp:Button ID="btnSkaSkrivaTest" runat="server" Text="Visa personer" OnClick="btnSkaSkrivaTest_Click"/>
    <br />
    <br />
    <asp:ListBox ID="lbPersonerSomSkaSkrivaTest" runat="server" style="width:125px; height: 100px;"></asp:ListBox>
    <br />

    <h3>Välj person som du vill se provresultat-statistik för:</h3>
    <asp:DropDownList ID="ddProvdeltagare" runat="server" OnSelectedIndexChanged="ddProvdeltagare_SelectedIndexChanged"></asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btnResultat" runat="server" Text="Visa statistik" OnClick="btnResultat_Click"/>
    <br />
    <br />
    <asp:Table ID="adminTabell" runat="server" Style="width:80%; margin:auto; border:1px solid;">
        <asp:TableHeaderRow ID="tabellhuvud">
            <%--<asp:TableHeaderCell>Namn</asp:TableHeaderCell>
            <asp:TableHeaderCell>Anställningsform</asp:TableHeaderCell>--%>
            <asp:TableHeaderCell>Test</asp:TableHeaderCell>
            <asp:TableHeaderCell>Test-datum</asp:TableHeaderCell>
            <asp:TableHeaderCell>Produkt-del</asp:TableHeaderCell>
            <asp:TableHeaderCell>Ekonomi-del</asp:TableHeaderCell>
            <asp:TableHeaderCell>Etik-del</asp:TableHeaderCell>
            <asp:TableHeaderCell>Totalt</asp:TableHeaderCell>
            <asp:TableHeaderCell>Resultat</asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell ID ="test"></asp:TableCell>
            <asp:TableCell ID ="datum"></asp:TableCell>
            <asp:TableCell ID ="produkt"></asp:TableCell>
            <asp:TableCell ID ="ekonomi"></asp:TableCell>
            <asp:TableCell ID ="etik"></asp:TableCell>
            <asp:TableCell ID ="totalt"></asp:TableCell>
            <asp:TableCell ID ="resultat"></asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    <h3>Har ett nytt test av Årligt Kunskapsuppdatering(ÅKU) kommit?</h3>
    <p>Tryck då på knappen för att nollställa alla anställdas tidigare provresultat av ÅKU till noll</p>
    <p>Funktionen är endast till för att nollställa de anställdas ÅKU-resultat när ett nytt ÅKU kommit.</p>
    <p> Informationen som försvinner går inte att återställa igen. Använda bara funktionen om du är säker.</p>
    <p> Tryck på första knappen för att sedan kunna använda knappen för att återställa ÅKU. </p>
    <asp:Button ID="aktiveraAkuKnapp" runat="server" Text="Aktivera knapp för nollställning av ÅKU" onClick="aktiveraAkuKnapp_Click"/>
    <asp:Button ID="aterstallAku" runat="server" Text="OBS! NOLLSTÄLL ÅKU" Style="background-color: red" OnClick="aterstallAku_Click"/>

</asp:Content>
