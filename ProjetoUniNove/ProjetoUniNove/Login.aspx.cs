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

        protected void btnVer_Click(object sender, EventArgs e)
        {
            Controle cont = new Controle();
            
            cont.acessar(txtEmail.Text, txtSenha.Text);
            if (cont.tem)
            {
                Response.Redirect("Logado.aspx");
            }
            else {
                lblError.Text= "login ou senha errado";
                lblError.Visible = true;
            };
                           
        }         
protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("TelaRecSenha.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");
        }
    }
}