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
        
    <div id="allafragor" runat="server">
        <div id="div1" runat="server"></div>
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

        <div id="div2" runat="server"></div>
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

        <div id="f16" runat="server"> </div>
        <div id="h16" runat="server"> </div>
        <asp:Image ID="Image16" runat="server" />
        <asp:CheckBox ID="CheckBox46" runat="server" />
        <asp:CheckBox ID="CheckBox47" runat="server" />
        <asp:CheckBox ID="CheckBox48" runat="server" />

        <div id="div3" runat="server"></div>
        <div id="f17" runat="server"> </div>
        <div id="h17" runat="server"> </div>
        <asp:Image ID="Image17" runat="server" />
        <asp:CheckBox ID="CheckBox49" runat="server" />
        <asp:CheckBox ID="CheckBox50" runat="server" />
        <asp:CheckBox ID="CheckBox51" runat="server" />

        <div id="f18" runat="server"> </div>
        <div id="h18" runat="server"> </div>
        <asp:Image ID="Image18" runat="server" />
        <asp:CheckBox ID="CheckBox52" runat="server" />
        <asp:CheckBox ID="CheckBox53" runat="server" />
        <asp:CheckBox ID="CheckBox54" runat="server" />

        <div id="f19" runat="server"> </div>
        <div id="h19" runat="server"> </div>
        <asp:Image ID="Image19" runat="server" />
        <asp:CheckBox ID="CheckBox55" runat="server" />
        <asp:CheckBox ID="CheckBox56" runat="server" />
        <asp:CheckBox ID="CheckBox57" runat="server" />

        <div id="f20" runat="server"> </div>
        <div id="h20" runat="server"> </div>
        <asp:Image ID="Image20" runat="server" />
        <asp:CheckBox ID="CheckBox58" runat="server" />
        <asp:CheckBox ID="CheckBox59" runat="server" />
        <asp:CheckBox ID="CheckBox60" runat="server" />

        <div id="f21" runat="server"> </div>
        <div id="h21" runat="server"> </div>
        <asp:Image ID="Image21" runat="server" />
        <asp:CheckBox ID="CheckBox61" runat="server" />
        <asp:CheckBox ID="CheckBox62" runat="server" />
        <asp:CheckBox ID="CheckBox63" runat="server" />

        <div id="f22" runat="server"> </div>
        <div id="h22" runat="server"> </div>
        <asp:Image ID="Image22" runat="server" />
        <asp:CheckBox ID="CheckBox64" runat="server" />
        <asp:CheckBox ID="CheckBox65" runat="server" />
        <asp:CheckBox ID="CheckBox66" runat="server" />

        <div id="f23" runat="server"> </div>
        <div id="h23" runat="server"> </div>
        <asp:Image ID="Image23" runat="server" />
        <asp:CheckBox ID="CheckBox67" runat="server" />
        <asp:CheckBox ID="CheckBox68" runat="server" />
        <asp:CheckBox ID="CheckBox69" runat="server" />

        <div id="f24" runat="server"> </div>
        <div id="h24" runat="server"> </div>
        <asp:Image ID="Image24" runat="server" />
        <asp:CheckBox ID="CheckBox70" runat="server" />
        <asp:CheckBox ID="CheckBox71" runat="server" />
        <asp:CheckBox ID="CheckBox72" runat="server" />

        <div id="f25" runat="server"> </div>
        <div id="h25" runat="server"> </div>
        <asp:Image ID="Image25" runat="server" />
        <asp:CheckBox ID="CheckBox73" runat="server" />
        <asp:CheckBox ID="CheckBox74" runat="server" />
        <asp:CheckBox ID="CheckBox75" runat="server" />
    </div>

    <asp:Button ID="btnSkickaLic" runat="server" Text="Skicka in och rätta licensieringstestet" OnClick="btnSkickaLic_Click" />

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
