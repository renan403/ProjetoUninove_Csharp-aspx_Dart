<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="TelaRecSenhaNova.aspx.cs" Inherits="ProjetoUniNove.TelaRecSenhaNova" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Recuperar de Senha</title>
    <link rel="shortcut icon" type="imagex/png" href="img\mr-robot.ico"/>

</head>
<body>
    <form id="form1" runat="server">

        <div>

            Email<br />
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
            <br />
            Cod<br />
            <asp:TextBox ID="txtCod" runat="server"></asp:TextBox>
            <br />
            Senha<br />
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            Confirmar Senha<br />
            <asp:TextBox ID="txtConfSenha" runat="server" TextMode="Password"></asp:TextBox>
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
