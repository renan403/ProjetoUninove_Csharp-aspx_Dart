using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

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
            bool resultado = await data.ValidaCod(txtCod.Text,txtEmail.Text);
            if (resultado)
            {
               // List<string> teste = new List<string>();
                 bool resp = await data.ValidaUser(txtEmail.Text, txtCod.Text);
                 if (resp)
                {
                    Response.Redirect("logado.aspx");
                }
                else
                {
                    MessageBox.Show("Algo deu errado");
                }
            }
            else
            {
                MessageBox.Show("Email ou codigo incorreto");
            }
            
        }
        
    }
}