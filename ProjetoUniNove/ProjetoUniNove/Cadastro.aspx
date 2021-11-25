<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="ProjetoUniNove.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro</title>
    <link rel="shortcut icon" type="imagex/png" href="img\mr-robot.ico"/>
    <link  rel="stylesheet" href="css\estilo.css" />
  
</head>
<body>
    <br />
   
    
            <h1 style="height: 54px">Otc Health</h1>
       
        <form id="form1" runat="server">
            
                <h2>Nome</h2>
                
                     
                    
                    <input id="txtNomeCad" type="text" placeholder="Digite seu nome.." runat="server"/>
                
                <h2>E-mail</h2>           
                   <input id="txtEmailCad" type="email" placeholder="Digite seu Email.." runat="server"/>

                <h2>Senha</h2>
                    <input id="txtSenhaCad" type="password" placeholder="Digite sua senha.." runat="server"/>

                <h2>Confirmar senha</h2>
                    <input id="txtConfSenhaCad" type="password" placeholder="Confirme a senha.." runat="server"/>

                
                 <asp:Label ID="lblError" runat="server" Text="msgError" ForeColor="Red" Visible="False"></asp:Label>
                
                
                 <asp:Button ID="btnCad" runat="server" OnClick="btnCad_Click" Text="Cadastrar" BackColor="#FF7A00" BorderStyle="None" Font-Italic="False" Font-Names="Stencil" Font-Size="Medium" Height="25px" Width="150px" />
               
        </form>
   

</body>
</html>
