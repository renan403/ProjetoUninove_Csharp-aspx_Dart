using System;
using System.Linq;


namespace ProjetoUniNove
{

    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnCad_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int result = rand.Next(000000, 999999);
            bool ativo = false;
            String senha = txtSenha.Text;
            String confSenha = txtConfSenha.Text;
            String nome = txtNome.Text;
            String email = txtEmail.Text;
            String cod = result.ToString();




            if (senha != string.Empty && nome != string.Empty && email != string.Empty)
            {
                if (senha.Length > 20)
                {
                    lblError.Text = "Senha muito Longa";
                    lblError.Visible = true;
                }
                else if (senha.Length < 6)
                {
                    lblError.Text = "Senha muito curta";
                    lblError.Visible = true;
                }
                else
                {

                    if (senha != confSenha)
                    {
                        lblError.Text = "Senhas não confere";
                        lblError.Visible = true;
                    }
                    else
                    {
                        Data data = new Data();
                        bool resultado = await data.RegisterUser(nome, email, senha, cod, ativo);
                        if (resultado)
                        {
                            Email exe = new Email();
                            exe.enviarEmail(email, cod);

                            //Page.Session.Add("email", email);
                            Response.Redirect("CodEmail.aspx");
                        }
                        else
                        {
                            lblError.Text = "Email ja cadastrado";
                            lblError.Visible = true;
                        }
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