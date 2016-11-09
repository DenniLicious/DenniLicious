<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StartaTest.aspx.cs" Inherits="G27_DenniLicious.StartaTest" %>
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
    <h1>Kompetensportalens testsida</h1>
            <asp:Button ID="startaTestKnapp" runat="server" OnClick="startaTestKnapp_Click" />
            <h3>När du trycker på knappen startas ditt aktuella test.</h3>
</asp:Content>
