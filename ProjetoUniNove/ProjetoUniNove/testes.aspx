

<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="testes.aspx.cs" Inherits="ProjetoUniNove.testes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   
    <title></title>
   
    <style>
        input{
               border-radius:20px 20px 20px 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ImageButton ID="ImageButton1" runat="server"  ImageUrl="img/jornal.png" />
        <div class="caixa1">
            <asp:Label ID="lblTesteRand" runat="server" Text="resultado"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server" Text="Button" OnClick="Unnamed1_Click" />
            <br />
            <input type="text" id="name1" name="nome" placeholder="Digite seu nome.." runat="server"/>
            <br />
            <br />
            <p> <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></p>

            <br />
            
 
        </div>
    </form>
    
</body>
</html>
