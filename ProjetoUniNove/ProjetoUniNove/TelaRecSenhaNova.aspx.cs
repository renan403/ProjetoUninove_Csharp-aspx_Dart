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
            Data data = new Data();
            bool resultado = await data.IsUserExists(Request["txtRecEmail"]);
            if (resultado)
            {
                if (Validacoes.ValidaSenha(Request["txtRecSenha"]) == string.Empty)
                {
                    if (Request["txtRecConfSenha"] == Request["txtRecSenha"])
                    {

                        bool result = await data.AlterSenha(Request["txtRecEmail"], Request["txtRecSenha"], Request["txtRecCod"]);
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
                    lblError.Text = Validacoes.ValidaSenha(Request["txtRecSenha"]);
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Email não encontrado";
                lblError.Visible = true;
            }
            
        }
    }
}


