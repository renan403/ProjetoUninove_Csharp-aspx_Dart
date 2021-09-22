

<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="testes.aspx.cs" Inherits="ProjetoUniNove.testes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTesteRand" runat="server" Text="resultado"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server" Text="Button" OnClick="Unnamed1_Click" />
        </div>
    </form>
</body>
</html>
