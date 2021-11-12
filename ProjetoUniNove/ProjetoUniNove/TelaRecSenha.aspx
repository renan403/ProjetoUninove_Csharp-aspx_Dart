<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="TelaRecSenha.aspx.cs" Inherits="ProjetoUniNove.TelaRecSenha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Recuperar senha</title>
    <link rel="shortcut icon" type="imagex/png" href="img\mr-robot.ico"/>
    <link rel="stylesheet" href="css/estilo.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Email da sua conta</p>
            Email:
             <input id="txtRecEmail" type="text" placeholder="Digite seu email cadastrado" runat="server"/>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="msgError" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
            <br />
        </div>
    </form>
</body>
</html>
