using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProjetoUniNove
{
    
    public partial class Cadastro : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCad_Click(object sender, EventArgs e)
        {
            
                    String senha = txtSenha.Text;
            String confSenha = txtConfSenha.Text;
            String nome = txtNome.Text;
            String email = txtEmail.Text;
            Random rand = new Random();
            int resultado = rand.Next(000000,999999);
            String cod = resultado.ToString();
           




            if (senha != "" && nome != "" && email != "")
            {
                if (senha != confSenha)
                {
                    lblError.Text = "Senhas não confere";
                    lblError.Visible = true;
                }
                else
                {
                    Controle contr = new Controle();

                    String mensagem = contr.cadastrar(nome,email,senha,cod);
                    if (contr.tem)
                    {
                        Controle cont = new Controle();
                        cont.cadastrar(nome, email, senha,cod);

                        Email exe = new Email();
                        exe.enviarEmail(email, cod);

                        MessageBox.Show(mensagem, "cadastro", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        
                        Response.Redirect("CodEmail.aspx");

                    }
                    else
                    {
                        MessageBox.Show(contr.mensagem);

                    }
                    
                }
            }
            else 
            {      
                    lblError.Text = "dados em branco";
                    lblError.Visible = true;              
            }

        }
    }
}