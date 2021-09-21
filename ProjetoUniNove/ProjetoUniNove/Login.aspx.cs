using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProjetoUniNove
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        IFirebaseClient cliente;
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                cliente = new FirebaseClient(ifc);
                if (cliente != null)
                {
                    MessageBox.Show("firebase conectado");
                }
            } 
            catch {
                MessageBox.Show("há um problema com a internet");
            }

        }

        protected void btnVer_Click(object sender, EventArgs e)//Entrar para tela Logado
        {
           
            Controle cont = new Controle();
            
            cont.acessar(txtEmail.Text, txtSenha.Text);
            if (cont.tem)
            {
                Response.Redirect("Logado.aspx");
            }
            else {
                lblError.Text= "login ou senha errado";
                lblError.Visible = true;
            };
                           
        }         
        protected void LinkButton1_Click(object sender, EventArgs e)// Entrar para recuperar senha
        {
            Response.Redirect("TelaRecSenha.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)//Entrar para cadastro
        {
            Response.Redirect("Cadastro.aspx");
        }

        IFirebaseConfig ifc = new FirebaseConfig() // conexão com banco
        {
            AuthSecret = "cMpAqZLOnRIxa3cRl05bnHidcZ1gqyv2pDHixAzB",
            BasePath = "https://projetouni9-ae8d8-default-rtdb.firebaseio.com/"
        };
        
    }
    
}