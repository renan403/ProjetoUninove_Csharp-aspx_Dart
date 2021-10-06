<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjetoUniNove.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tela Login</title>
    <link rel="shortcut icon" type="imagex/png" href="img\download.ico"/>
    <style>
        html {
            height: 100%;
        }

        body {
            background-color: #CFCFCF;
            text-align: left;
            margin: 0;
            padding: 0;
            height: 100%;
        }

        div.titulo {
            text-align: center;
            margin-top: 55px;
            color: black
        }

        div.alinhar {
            color: orange;
            text-align: center;
            width: 300px;
            height: 23px;
            background-color: white;
            border-radius: 30px 30px 30px 30px;
            margin: auto;
        }

        div.borda {
            color: green;
            text-align: center;
            width: 168px;
            height: 30px;
            background-color: orange;
            border-radius: 10px 10px 40px 40px;
            margin: auto;
        }

        p {
            color: black;
            text-align: center;
        }

        h2 {
            text-align: center;
            color: orange
        }

        div.caixa {
            width: 60%;
            height: 80%;
            background-color: #828282;
            margin-top: 30px;
            margin: auto;
            border-radius: 40px 40px 40px 40px;
        }
    </style>
</head>
<body>
    <div class="caixa">

        <div class="titulo">
            <br />
            <h1 style="height: 54px">Otc Health</h1>
        </div>

        <form id="form1" runat="server">

            <h2>Email</h2>
            <div class="alinhar">
                <asp:TextBox ID="txtEmail" runat="server" Style="margin-top: 0px" Width="279px" BackColor="white" BorderStyle="None" Height="20px" TextMode="Email"></asp:TextBox>
            </div>
            <div>
                <br />
                <h2>Senha</h2>
                <div class="alinhar">
                    <asp:TextBox ID="txtSenha" runat="server" Style="margin-top: 0px" Width="279px" BackColor="white" BorderStyle="None" Height="20px" TextMode="Password"></asp:TextBox>
                </div>
            </div>
            <p>
                esquece a senha?
          <asp:LinkButton ID="LinkEscSenha" runat="server" ForeColor="#00FF7F" OnClick="LinkButton1_Click">Clique aqui</asp:LinkButton>

            </p>
            <div style="margin-left: 41%">
                <asp:Label ID="lblError" runat="server" Text="msgError" EnableTheming="True" ForeColor="Red" Visible="False" Font-Bold="True" Font-Italic="False"></asp:Label>
            </div>
            <br />
            <br />

            <div class="borda">

                <asp:Button ID="btnVer" runat="server" OnClick="btnVer_Click" Text="Entrar" BackColor="orange" BorderColor="#FF7A00" BorderStyle="None" Font-Bold="False" Font-Names="Stencil" Font-Overline="False" Font-Size="Medium" />
            </div>
            <br />
            <br />
            <p style="margin-bottom: 20px">
                ainda não possui conta?
            <asp:LinkButton ID="LinkCad" runat="server" ForeColor="#00FF7F" OnClick="LinkButton2_Click">Clique aqui</asp:LinkButton>
            </p>
        </form>
    </div> 
</body>
</html>