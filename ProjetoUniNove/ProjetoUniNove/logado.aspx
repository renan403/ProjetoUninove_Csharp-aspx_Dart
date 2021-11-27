<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="Logado.aspx.cs" Inherits="ProjetoUniNove.Logado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="BtnExercicios" runat="server" OnClick="BtnExercicios_Click" Text="exercicios" />
        <br />
        <br />
        <asp:Label ID="lblTeste" runat="server" Text="Label"></asp:Label>
        <br /><br />
        <asp:Button ID="BtnPerfil" runat="server" Text="Perfil" OnClick="BtnPerfil_Click" />
        <br />
        <br />
        <asp:Button ID="BtnDietas" runat="server" Text="Dietas" OnClick="BtnDietas_Click" />
    </form>
</body>
</html>
