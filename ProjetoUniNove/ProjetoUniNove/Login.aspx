<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjetoUniNove.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tela Login</title>
    <link rel="shortcut icon" type="imagex/png" href="img\download.ico"/>
    <link rel="stylesheet" href="css\Login.css" />
    
</head>
<body>

        <form id="form1" runat="server">
            <header>
            <asp:Label ID="titulo" runat="server" Text="&ltOTC_HEALTH/&gt"></asp:Label>
            </header>
            <div class="caixa">
                <h3>Email</h3>
                <input id="txtEmail" type="text" placeholder="Digite seu Email.." runat="server"/><br />
                <h3>Senha</h3>
                <input id="txtSenha" type="password" placeholder="Digite sua Senha.." runat="server" />
                <br /><br />
                <asp:Label ID="lblError" runat="server" Text="msgError" EnableTheming="True" ForeColor="Red" Visible="False" Font-Bold="True" Font-Italic="False"></asp:Label>
                           
            
            <asp:Button ID="btnEntrar" runat="server" OnClick="BtnEntrar_Click" Text="Entrar" BackColor="orange" BorderColor="#FF7A00" BorderStyle="None" Font-Bold="False" Font-Overline="False" Font-Size="Medium" />
             
            <p>esquece a senha?<asp:LinkButton ID="LinkEscSenha" runat="server" ForeColor="#00FF7F" OnClick="LinkButton1_Click">Clique aqui</asp:LinkButton></p>
            <p>ainda não possui conta?<asp:LinkButton ID="LinkCad" runat="server" ForeColor="#00FF7F" OnClick="LinkButton2_Click">Clique aqui</asp:LinkButton></p>
             </div>

        </form>
    </body>
</html>