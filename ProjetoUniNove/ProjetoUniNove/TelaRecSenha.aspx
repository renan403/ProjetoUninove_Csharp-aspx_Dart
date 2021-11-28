<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="TelaRecSenha.aspx.cs" Inherits="ProjetoUniNove.TelaRecSenha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Recuperar senha</title>
    <link rel="shortcut icon" type="imagex/png" href="img\mr-robot.ico"/>
    <link rel="stylesheet" href="css/RecSenha.css" />
</head>
<body>
    <form id="form1" runat="server">
        <header></header>
        <div class="caixa1">
            <p>Email da sua conta</p>
            <p>Email:<input id="txtRecEmail" type="text" placeholder="Digite seu email cadastrado" runat="server"/></p>
            
            <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="msgError" Visible="False"></asp:Label>
            <br />
            <p>Já recebeu Email? <asp:LinkButton ID="LinkPularPag" ForeColor="#00FF7F" runat="server" OnClick="LinkPularPag_Click">Clique aqui</asp:LinkButton></p>
            
            
            
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
            <br />
        </div>
    </form>
</body>
</html>
