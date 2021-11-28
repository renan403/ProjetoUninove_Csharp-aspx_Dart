<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="PrimeiroAcesso.aspx.cs" Inherits="ProjetoUniNove.PrimeiroAcesso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Primeiro Acesso</title>
    <link rel="stylesheet" href="css/PrimeiroAcesso.css" />
</head>
<body>
    <form id="form1" runat="server">
        <header></header>
        <div>
            <div class="caixa1">
                    <h4>O que é Lorem Ipsum?</h4>
                        <p>Lorem Ipsum é simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para
                         fazer um livro de modelos de tipos. Lorem Ipsum sobreviveu não só a cinco séculos, como também ao salto para a editoração eletrônica, permanecendo essencialmente inalterado. Se popularizou na década de 60, quando
                         a Letraset lançou decalques contendo passagens de Lorem Ipsum, e mais recentemente quando passou a ser integrado a softwares de editoração eletrônica como Aldus PageMaker.</p>
            </div>
                <br />
            <div class="conteudo">
                <div class="caixa2">
                      <h4>Possui alguma desses restrições alimentares?</h4>  
                      <asp:CheckBox ID="checkDiabete" runat="server" />Diabete
                      <br />
                      <asp:CheckBox ID="checkIntoLactose" runat="server" />Intolerancia a lactose ou alergia a leite
                      <br />
                      <asp:CheckBox ID="checkDislipidemia" runat="server" />Dislipidemia
                      <br />
                      <asp:CheckBox ID="checkConstipação" runat="server" />Constipação
                      <br />
                      <asp:CheckBox ID="checkCeliaca" runat="server" />Doença celíaca
                      <br />
                      <asp:CheckBox ID="cbSemRestr" runat="server" />Sem Restrições
            </div>
            </div>
            <br />
            <div class="caixa2">
            <h4>Informe</h4>
            <p>Altura:<input id="txtPrimAltura" type="text" placeholder="Altura exemplo: 1.70 " runat="server"/> <br />
                Peso:&nbsp;<input id="txtPrimPeso" type="text" placeholder="Peso exemplo: 60.80" runat="server"/>
                <asp:Button ID="bntSalvar" runat="server" OnClick="bntSalvar_Click" Text="Salvar" />
            </p>
            
                </div>

        </div>
    </form>
</body>
</html>
