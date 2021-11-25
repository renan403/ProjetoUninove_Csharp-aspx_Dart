﻿<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="TelaRecSenhaNova.aspx.cs" Inherits="ProjetoUniNove.TelaRecSenhaNova" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Recuperar de Senha</title>
    <link rel="shortcut icon" type="imagex/png" href="img\mr-robot.ico"/>
    <link rel="stylesheet" href="css/estilo.css" />

</head>
<body>
    <form id="form1" runat="server">

        <div>

            Email<br />    
            <input id="txtRecEmail" type="email" placeholder="Digite seu email cadastrado" runat="server"/>
            <br />
            Cod<br />
            
            <input id="txtRecCod" type="text" placeholder="Digite o codigo recebido" runat="server"/>
            <br />
            Senha<br />
            
            <input id="txtRecSenha" type="password" placeholder="Digite sua nova senha.." runat="server"/>
            <br />
            Confirmar Senha<br />
            
            <input id="txtRecConfSenha" type="password" placeholder="Confirme a nova senha.." runat="server"/>
            <br />
            <br />
            <asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar" />
            
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="msgERROR" Visible="False"></asp:Label>
            <br />

        </div>
    </form>
</body>
</html>
