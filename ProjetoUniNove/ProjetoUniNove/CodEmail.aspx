<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="CodEmail.aspx.cs" Inherits="ProjetoUniNove.CodEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Codigo do Email</title>
    <link rel="shortcut icon" type="imagex/png" href="img\mr-robot.ico"/>
    <link rel="stylesheet" href="css\estilo.css" />
    
</head>
<body>
   
        <form id="form1" runat="server">
            
                <p>confirme o Email e o codigo que recebeu por email</p>
                
                <h2>Email:</h2>
                                
                    <input id="txtEmailCodEmail" type="text" placeholder="Digite seu Email.." runat="server"/>
               
                <h2>Codigo:</h2>
                
                    
                    <input id="txtConfCod" type="text" placeholder="Digite o Codigo" runat="server"/>


               
                    <asp:Label ID="lblError" runat="server" Text="MsgError" ForeColor="Red" Font-Bold="True" Visible="False"></asp:Label>
                


                
                    <asp:Button ID="bntEnviar" runat="server" Text="Enviar" OnClick="bntEnviar_Click" BackColor="#FF7A00" BorderStyle="None" Font-Names="Stencil" Font-Size="Medium" Height="28px" Style="margin-bottom: 3px" Width="134px" />
              
        </form>
</body>
</html>
