using System;
using System.Linq;

namespace ProjetoUniNove
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected async void btnVer_Click(object sender, EventArgs e)//Entrar para tela Logado
        {
            Data data = new Data();
            bool result = await data.LoginUser(Request["txtEmail"], Request["txtSenha"], "1");
            if (result)
            {
                Response.Flush();
                Response.Redirect("logado.aspx");
            }
            else
            {
                lblError.Text = "Cadastro não encontrado";
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