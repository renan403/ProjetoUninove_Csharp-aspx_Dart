using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

            Response.Write(cont.acessar(txtEmail.Text, txtSenha.Text));
            if (cont.tem)
            {
                Response.Redirect("logado.aspx");
                Response.Write("foi");
            }
            else {
                Response.Write("não foi");
            };
                           
        }
    }
}