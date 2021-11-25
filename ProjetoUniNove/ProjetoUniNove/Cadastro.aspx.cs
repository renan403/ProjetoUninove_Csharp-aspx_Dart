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

            String senha = Request["txtSenhaCad"];
            String confSenha = Request["txtConfSenhaCad"]; ;
            String nome = Request["txtNomeCad"];
            String email = Request["txtEmailCad"]; ;
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
                        bool resultado = await data.RegisterUser(nome, email, senha, cod);
                        if (resultado)
                        {
                            Email exe = new Email();
                            exe.EnviarEmail(email, cod);

                            //Page.Session.Add("email", email);
                            try {
                                Response.Redirect("CodEmail.aspx");
                            }
                            catch { }
                            
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