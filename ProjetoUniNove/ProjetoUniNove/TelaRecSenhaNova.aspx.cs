using System;
using System.Linq;

namespace ProjetoUniNove
{
    public partial class TelaRecSenhaNova : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Validacoes.ValidaSenha(txtSenha.Text) == string.Empty)
            {
                if (txtConfSenha.Text == txtSenha.Text)
                {
                    Data data = new Data();
                    bool result = await data.AlterSenha(txtEmail.Text, txtSenha.Text, txtCod.Text);
                    if (result)
                    {
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        lblError.Text = "informação errada";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "Senha não confere";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = Validacoes.ValidaSenha(txtSenha.Text);
                lblError.Visible = true;
            }
        }
    }
}


