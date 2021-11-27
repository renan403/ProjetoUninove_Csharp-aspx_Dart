using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoUniNove
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["email"] = null; // inicializando sessoes 
            Session["imc"] = null;

        }


        protected async void BtnVer_Click(object sender, EventArgs e)//Entrar para tela Logado
        {
            Data data = new Data();
            bool result = await data.LoginUser(Request["txtEmail"], Request["txtSenha"], "1"); // verificando se o usuario existe e se esta ativo 1 == true
            if (result)
            {

                string respEmail = Request["txtEmail"]; // Pegando informação do input igual faz com textBox
                Session.Add("email", respEmail); // Criando sessao para utilizar mais para frente
                string statu = await data.RetornaStatus(respEmail,"2");//Puxar informação do json que retorna do banco status do primeiro acesso

                

                try
                {
                    if (statu == "0")// status 0 significa False
                    {
                        Response.Redirect("PrimeiroAcesso.aspx");
                    }else if (statu == "1") // status 1 significa True
                    {
                        Response.Redirect("Logado.aspx");
                    }
                }
                catch (Exception )
                {

                   // MessageBox.Show($"{exc}"); //há um pequeno erro que acontece ainda estou tratando
                }
            }
            else
            {
                lblError.Text = "Cadastro não encontrado"; // retornar resposta em vermelho para o usuario no lbl
                lblError.Visible = true;
            }

        }
        protected void LinkButton1_Click(object sender, EventArgs e)// Entrar para recuperar senha
        {
            Response.Redirect("TelaRecSenha.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)//Entrar para cadastro
        {
            Response.Redirect("Cadastro.aspx");
        }



    }

}