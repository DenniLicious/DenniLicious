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

    <asp:Table ID="adminTabell" runat="server"></asp:Table>

</asp:Content>
