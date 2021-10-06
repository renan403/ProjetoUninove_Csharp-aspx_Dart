<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="CodEmail.aspx.cs" Inherits="ProjetoUniNove.CodEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Codigo do Email</title>
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

        div.alinhar {
            color: orange;
            text-align: center;
            width: 300px;
            height: 23px;
            background-color: #545454;
            border-radius: 30px 30px 30px 30px;
            margin: auto;
        }

        h2 {
            text-align: center;
            color: #ff7a00
        }

        div.caixa {
            width: 54%;
            height: 80%;
            background-color: black;
            margin-top: 30px;
            margin: auto;
            border-radius: 40px 40px 40px 40px;
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
    </style>
</head>
<body>
    <div class="caixa">
        <form id="form1" runat="server">
            <div>
                <p>confirme o Email e o codigo que recebeu por email</p>
                <br />
                <h2>Email:</h2>
                <br />
                <div class="alinhar">
                    <asp:TextBox ID="txtEmail" runat="server" BackColor="#545454" BorderStyle="None" Height="21px" Width="275px"></asp:TextBox>
                </div>
                <br />
                <h2>Codigo:</h2>
                <br />
                <div class="alinhar">
                    <asp:TextBox ID="txtCod" runat="server" BackColor="#545454" BorderStyle="None" Height="21px" Style="margin-left: 0px" Width="275px"></asp:TextBox>
                </div>
                <br />


                <div style="margin-left: 44%">
                    <asp:Label ID="lblError" runat="server" Text="MsgError" ForeColor="Red" Font-Bold="True" Visible="False"></asp:Label>
                </div>


                <br />
                <br />
                <div class="borda">
                    <asp:Button ID="bntEnviar" runat="server" Text="Enviar" OnClick="bntEnviar_Click" BackColor="#FF7A00" BorderStyle="None" Font-Names="Stencil" Font-Size="Medium" Height="28px" Style="margin-bottom: 3px" Width="134px" />
                </div>
            </div>
        </form>
    </div>
</body>
</html>
