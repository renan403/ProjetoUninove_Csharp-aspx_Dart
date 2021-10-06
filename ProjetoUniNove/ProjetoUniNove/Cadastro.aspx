<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="ProjetoUniNove.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro</title>
    <link rel="shortcut icon" type="imagex/png" href="img\mr-robot.ico"/>
    <style>
        html {
            height: 100%;
        }

        body {
            background-color: #2e2c29;
            text-align: left;
            margin: 0;
            padding: 0;
            height: 100%;
        }

        div.titulo {
            text-align: center;
            color: white
        }

        h2 {
            text-align: center;
            color: #ff7a00
        }

        div.alinhar {
            color: orange;
            text-align: center;
            width: 300px;
            height: 23px;
            background-color: #545454;
            border-radius: 30px 30px 30px 30px;
            margin: auto;
        }

        div.borda {
            color: orange;
            text-align: center;
            width: 168px;
            height: 30px;
            background-color: #ff7a00;
            border-radius: 10px 10px 40px 40px;
            margin: auto;
        }

        div.lbl {
            text-align: center
        }

        div.caixa {
            width: 54%;
            height: 80%;
            background-color: black;
            margin-top: 30px;
            margin: auto;
            border-radius: 40px 40px 40px 40px;
        }
    </style>
</head>
<body>
    <br />
    <div class="caixa">
        <div class="titulo">
            <h1 style="height: 54px">Otc Health</h1>
        </div>
        <form id="form1" runat="server">
            <div>
                <h2>Nome</h2>
                <div class="alinhar">
                    <asp:TextBox ID="txtNome" runat="server" BackColor="#545454" BorderStyle="None" Width="282px" Height="19px"></asp:TextBox>
                </div>
                <h2>E-mail</h2>
                <div class="alinhar">
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" BackColor="#545454" BorderStyle="None" Width="281px" Height="19px"></asp:TextBox>
                </div>
                <h2>Senha</h2>
                <div class="alinhar">
                    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" BackColor="#545454" BorderStyle="None" Width="281px" Height="19px"></asp:TextBox>
                </div>
                <h2>Confirmar senha</h2>
                <div class="alinhar">
                    <asp:TextBox ID="txtConfSenha" runat="server" TextMode="Password" BackColor="#545454" BorderStyle="None" Width="281px" Height="19px"></asp:TextBox>
                </div>

                <br />
                <div class="lbl">
                    <asp:Label ID="lblError" runat="server" Text="msgError" ForeColor="Red" Visible="False"></asp:Label>
                </div>
                <br />
                <div class="borda">
                    <asp:Button ID="btnCad" runat="server" OnClick="btnCad_Click" Text="Cadastrar" BackColor="#FF7A00" BorderStyle="None" Font-Italic="False" Font-Names="Stencil" Font-Size="Medium" Height="25px" Width="150px" />
                </div>
            </div>

        </form>
    </div>
</body>
</html>
