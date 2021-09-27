using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

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
            bool result = await data.LoginUser(txtEmail.Text,txtSenha.Text,true);
            if (result)
            {
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