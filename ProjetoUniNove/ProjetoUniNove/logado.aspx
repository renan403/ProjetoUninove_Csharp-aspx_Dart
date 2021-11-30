<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="Logado.aspx.cs" Inherits="ProjetoUniNove.Logado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="css\Logado.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <header> <!-- cabeçalho-->
                <asp:Button ID="BtnInicio" runat="server" Text="<OTC_HEALTH/>" />
                <asp:Label ID="lblQuemSomos" runat="server" Text="Quem somos"></asp:Label>
                <asp:Label ID="lblComunidade" runat="server" Text="Comunidade"></asp:Label>
                <asp:Label ID="lblContatos" runat="server" Text="Contatos"></asp:Label>
                <asp:Label ID="lblSuporte" runat="server" Text="Suporte"></asp:Label>
        </header>
  
        
        <input id="txtPesquisa" type="text" placeholder=" 🔍 Barra de pesquisa..." runat="server"/>
          
        <asp:Button ID="BtnNoticias" runat="server" Text="📃 Notícias" />

        <asp:Button ID="BtnProgramacao" runat="server"  Text="📆 Programação" />

        <asp:Button ID="BtnVideos" runat="server"  Text="📹 Vídeos" />

        <asp:Button ID="BtnExercicios" runat="server" OnClick="BtnExercicios_Click" Text="🏋️‍ Seus Exercícios" />
        
        <asp:Button ID="BtnEspecialista" runat="server"  Text="👩‍⚕️Fale com especialistas"/>
        
        
        
        <asp:Button ID="BtnDietas" runat="server" Text="🥗 Suas Dietas" OnClick="BtnDietas_Click" />

        <div class="menu">  <!-- parte roxa -->
            
            <div class="User">
            <asp:Label ID="lblNomeUser" runat="server" Text="Label" ></asp:Label></div><br />

            <img class="imgUser" src="img/Usuario.jpg" alt="Desmontração de Imagem do Usuario"/><br />
            
            <asp:Button ID="BtnPerfil" runat="server" Text=" 👤           Perfil"  />
            <div class="Menu1">
            <asp:Label ID="lblItensSalvo" runat="server" Text="&nbsp;🚩&nbsp;&nbsp;&nbsp;Itens Salvo" ></asp:Label></div><br />
            <div class="Menu2">
            <asp:Label ID="lblProgresso" runat="server" Text="&nbsp;📈&nbsp;Seu Progresso" ></asp:Label></div><br />
            <div class="Menu3">
            <asp:Label ID="lblConfig" runat="server" Text="&nbsp;🛠&nbsp;&nbsp;Configurações" ></asp:Label></div><br />
        
     
        </div>
    
        <footer> <!-- rodapé -->
            
            <img class="img" src="img/facebook1.png" alt="Icone do link do Facebook"/>
            <img class="img" src="img/instagram1.png" alt="Icone do link do Instagram"/>
            <a href="https://wa.me/5511977772222">
            <img class="img" src="img/whatsapp1.png" alt="Icone do link do WhatsApp" /></a>
            <asp:Label ID="infoEmpresa" runat="server" Text="📄 54.616.852/0001 - 37 | 📧 OtcHealth@gmail.com | 📞 (11) 97777-2222"></asp:Label>

        </footer>

    </form>

    
</body>
</html>
