using System;
using System.Linq;

namespace ProjetoUniNove
{
    public partial class TelaRecSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected async void btnEnviar_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Data data = new Data();
            Email email = new Email();
            int aleat = rand.Next(100000, 999999);
            bool result = await data.IsUserExists(Request["txtRecEmail"]);
            if (result)
            {
                await data.AlterCod(Request["txtRecEmail"], aleat.ToString());
                email.EnviarEmail(Request["txtRecEmail"], aleat.ToString());
                Response.Redirect("TelaRecSenhaNova.aspx");
            }
            else
            {
                lblError.Text = "E-Mail nao encontrado";
                lblError.Visible = true;
            }

        }
    }
}