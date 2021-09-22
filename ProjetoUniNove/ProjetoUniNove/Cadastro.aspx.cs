using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace ProjetoUniNove
{
    
    public partial class Cadastro : System.Web.UI.Page
    {
        /*IFirebaseClient cliente;
        IFirebaseConfig ifc = new FirebaseConfig() // conexão com banco
        {
            AuthSecret = "cMpAqZLOnRIxa3cRl05bnHidcZ1gqyv2pDHixAzB",
            BasePath = "https://projetouni9-ae8d8-default-rtdb.firebaseio.com/"
        };*/
        protected void Page_Load(object sender, EventArgs e)
        {
           /* try
            {
                cliente = new FirebaseClient(ifc);
                if (cliente != null)
                {
                 
                }
            }
            catch
            {
                MessageBox.Show("há um problema com a internet");
            }*/
        }

        protected async void btnCad_Click(object sender, EventArgs e)
        {

              String senha = txtSenha.Text;
              String confSenha = txtConfSenha.Text;
              String nome = txtNome.Text;
              String email = txtEmail.Text;
              Random rand = new Random();
              int result = rand.Next(000000,999999);
              String cod = result.ToString();


              if (senha != "" && nome != "" && email != "")
              {
                  if (senha != confSenha)
                  {
                      lblError.Text = "Senhas não confere";
                      lblError.Visible = true;
                  }
                  else
                  {/*
                    var data = new Data
                    {
                        email = txtEmail.Text,
                        nome = txtNome.Text,
                        senha = txtSenha.Text,
                        codigo = cod,
                    };
                    SetResponse response = await cliente.SetAsync("Cliente/" + nome, data);
                    Data resultado = response.ResultAs<Data>();
                    MessageBox.Show("Informação inserida com sucesso", resultado.email);*/

                    Data data = new Data();
                    bool resultado =await data.RegisterUser(nome, email, senha, cod);

                     if (resultado)
                    {
                        Email exe = new Email();
                        exe.enviarEmail(email, cod);
                        Response.Redirect("CodEmail.aspx");
                    }
                    else
                    {
                        lblError.Text = "Email ja cadastrado";
                        lblError.Visible=true;
                    }

                   

                    /*
                      Controle contr = new Controle();
                      String mensagem = contr.cadastrar(nome,email,senha,cod);
                      if (contr.tem)
                      {
                          Controle cont = new Controle();
                          cont.cadastrar(nome, email, senha,cod);


                      }
                      else
                      {
                          MessageBox.Show(contr.mensagem);

                      }*/

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