using System;
using System.Linq;

namespace ProjetoUniNove
{
    public partial class CodEmail : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void bntEnviar_Click(object sender, EventArgs e)
        {

            Data data = new Data();
            bool resultado = await data.ValidaCod(txtCod.Text, txtEmail.Text);
            if (resultado)
            {
                bool resp = await data.ValidaUser(txtEmail.Text, txtCod.Text);
                if (resp)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    lblError.Text = "Algo deu errado";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Email ou codigo incorreto";
                lblError.Visible = true;
            }

        }

    }
}