<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="CodEmail.aspx.cs" Inherits="ProjetoUniNove.CodEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                 <p>confirme o Email e o codigo que recebeu por email</p>
            <br />
             Email:<br />
                 <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            Codigo:<br />
            <asp:TextBox ID="txtCod" runat="server"></asp:TextBox>
            <br />

                

            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bntEnviar" runat="server" Text="Enviar" OnClick="bntEnviar_Click" />
            
        </div>
    </form>
</body>
</html>
