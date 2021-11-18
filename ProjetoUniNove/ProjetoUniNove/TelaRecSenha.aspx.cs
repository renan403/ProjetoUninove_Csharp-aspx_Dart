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
            Random rand = new Random(); // classe para dar um numero aleatorio 
            Data data = new Data();
            Email email = new Email(); // classe para utilizar o envio do email 
            int aleat = rand.Next(100000, 999999); // gera um numero aleatorio de 100000 a 999999 para inserir em cod
            bool result = await data.IsUserExists(Request["txtRecEmail"]);
            if (result)
            {
                await data.AlterCod(Request["txtRecEmail"], aleat.ToString());
                email.EnviarEmail(Request["txtRecEmail"], aleat.ToString());
                Response.Redirect("TelaRecSenhaNova.aspx");
            }
            else
            {
                lblError.Text = "E-Mail não encontrado";
                lblError.Visible = true;
            }

        }

        protected void LinkPularPag_Click(object sender, EventArgs e)
        {
            Response.Redirect("TelaRecSenhaNova.aspx");
        }
    }
}