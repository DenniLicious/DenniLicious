<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AKUtest.aspx.cs" Inherits="G27_DenniLicious.AKUtest" %>
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

    <h1>Kompetensportalens Årliga Kunskapstest (ÅKU)</h1>

            <p>Det årliga kunskapstestet (ÅKU) består av 15 frågor, fördelade över tre delområden.<br />
                De allra flesta frågorna har endast ett svar som är korrekt. Här finns ingen särskild instruktion i uppgiften.<br />
                I vissa testuppgifter är flera svar korrekta. I dessa uppgifter står det tydligt angivet med en hjälptext hur många korrekta svar som ska markeras. <br />
                För att få rätt på uppgiften ska exakt rätt antal svarsalternativ markeras.<br />
                För en korrekt besvarad uppgift får man ett poäng. För en felaktigt besvarad uppgift får man inget rätt (och heller inga minuspoäng).<br />
                Det krävs minst 70 procent rätt totalt samt minst 60 procent rätt inom varje delområde för att bli godkänd. Resultatet redovisas direkt efter avslutat test.</p>

            <p>Lycka till!</p>

    <div id="allafragor" runat="server">
        <div id="div1" runat="server"> </div>
        <div id="f1" runat="server"> </div>
        <div id="h1" runat="server"> </div>
        <asp:Image ID="Image1" runat="server" />
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:CheckBox ID="CheckBox2" runat="server" />
        <asp:CheckBox ID="CheckBox3" runat="server" />
    
        <div id="f2" runat="server"> </div>
        <div id="h2" runat="server"> </div>
        <asp:Image ID="Image2" runat="server" />
        <asp:CheckBox ID="CheckBox4" runat="server" />
        <asp:CheckBox ID="CheckBox5" runat="server" />
        <asp:CheckBox ID="CheckBox6" runat="server" />

        <div id="f3" runat="server"> </div>
        <div id="h3" runat="server"> </div>
        <asp:Image ID="Image3" runat="server" />
        <asp:CheckBox ID="CheckBox7" runat="server" />
        <asp:CheckBox ID="CheckBox8" runat="server" />
        <asp:CheckBox ID="CheckBox9" runat="server" />

        <div id="f4" runat="server"> </div>
        <div id="h4" runat="server"> </div>
        <asp:Image ID="Image4" runat="server" />
        <asp:CheckBox ID="CheckBox10" runat="server" />
        <asp:CheckBox ID="CheckBox11" runat="server" />
        <asp:CheckBox ID="CheckBox12" runat="server" />

        <div id="f5" runat="server"> </div>
        <div id="h5" runat="server"> </div>
        <asp:Image ID="Image5" runat="server" />
        <asp:CheckBox ID="CheckBox13" runat="server" />
        <asp:CheckBox ID="CheckBox14" runat="server" />
        <asp:CheckBox ID="CheckBox15" runat="server" />

        <div id="div2" runat="server"></div>
        <div id="f6" runat="server"> </div>
        <div id="h6" runat="server"> </div>
        <asp:Image ID="Image6" runat="server" />
        <asp:CheckBox ID="CheckBox16" runat="server" />
        <asp:CheckBox ID="CheckBox17" runat="server" />
        <asp:CheckBox ID="CheckBox18" runat="server" />

        <div id="f7" runat="server"> </div>
        <div id="h7" runat="server"> </div>
        <asp:Image ID="Image7" runat="server" />
        <asp:CheckBox ID="CheckBox19" runat="server" />
        <asp:CheckBox ID="CheckBox20" runat="server" />
        <asp:CheckBox ID="CheckBox21" runat="server" />

        <div id="f8" runat="server"> </div>
        <div id="h8" runat="server"> </div>
        <asp:Image ID="Image8" runat="server" />
        <asp:CheckBox ID="CheckBox22" runat="server" />
        <asp:CheckBox ID="CheckBox23" runat="server" />
        <asp:CheckBox ID="CheckBox24" runat="server" />

        <div id="f9" runat="server"> </div>
        <div id="h9" runat="server"> </div>
        <asp:Image ID="Image9" runat="server" />
        <asp:CheckBox ID="CheckBox25" runat="server" />
        <asp:CheckBox ID="CheckBox26" runat="server" />
        <asp:CheckBox ID="CheckBox27" runat="server" />

        <div id="f10" runat="server"> </div>
        <div id="h10" runat="server"> </div>
        <asp:Image ID="Image10" runat="server" />
        <asp:CheckBox ID="CheckBox28" runat="server" />
        <asp:CheckBox ID="CheckBox29" runat="server" />
        <asp:CheckBox ID="CheckBox30" runat="server" />

        <div id="div3" runat="server"></div>
        <div id="f11" runat="server"> </div>
        <div id="h11" runat="server"> </div>
        <asp:Image ID="Image11" runat="server" />
        <asp:CheckBox ID="CheckBox31" runat="server" />
        <asp:CheckBox ID="CheckBox32" runat="server" />
        <asp:CheckBox ID="CheckBox33" runat="server" />

        <div id="f12" runat="server"> </div>
        <div id="h12" runat="server"> </div>
        <asp:Image ID="Image12" runat="server" />
        <asp:CheckBox ID="CheckBox34" runat="server" />
        <asp:CheckBox ID="CheckBox35" runat="server" />
        <asp:CheckBox ID="CheckBox36" runat="server" />

        <div id="f13" runat="server"> </div>
        <div id="h13" runat="server"> </div>
        <asp:Image ID="Image13" runat="server" />
        <asp:CheckBox ID="CheckBox37" runat="server" />
        <asp:CheckBox ID="CheckBox38" runat="server" />
        <asp:CheckBox ID="CheckBox39" runat="server" />

        <div id="f14" runat="server"> </div>
        <div id="h14" runat="server"> </div>
        <asp:Image ID="Image14" runat="server" />
        <asp:CheckBox ID="CheckBox40" runat="server" />
        <asp:CheckBox ID="CheckBox41" runat="server" />
        <asp:CheckBox ID="CheckBox42" runat="server" />

        <div id="f15" runat="server"> </div>
        <div id="h15" runat="server"> </div>
        <asp:Image ID="Image15" runat="server" />
        <asp:CheckBox ID="CheckBox43" runat="server" />
        <asp:CheckBox ID="CheckBox44" runat="server" />
        <asp:CheckBox ID="CheckBox45" runat="server" />
    </div>

    <asp:Button ID="btnSkickaAku" runat="server" Text="Skicka in och rätta årligt kunskapstest" OnClick="btnSkickaAku_Click"/>

    <div id="totalPoang" runat="server"></div>
    <div id="produktPoang" runat="server"></div>
    <div id="ekonomiPoang" runat="server"></div>
    <div id="etikPoang" runat="server"></div>
    <div></div>
    <div id="facit" runat="server">
    <h1>Facit</h1>
    <p>Här visas testets facit, jämför gärna med dina egna svar.</p>
    </div>
</asp:Content>
