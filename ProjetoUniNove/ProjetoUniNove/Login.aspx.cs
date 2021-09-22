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
       /* IFirebaseClient cliente;
        IFirebaseConfig ifc = new FirebaseConfig() // conexão com banco
        {
            AuthSecret = "",
            BasePath = "https://projetouni9-ae8d8-default-rtdb.firebaseio.com/"
        };*/
        protected void Page_Load(object sender, EventArgs e)
        {/*
            try {
                cliente = new FirebaseClient(ifc);
                if (cliente != null)
                {
                    
                }
            } 
            catch {
                MessageBox.Show("há um problema com a internet");
            }*/
        }
        

        protected async void btnVer_Click(object sender, EventArgs e)//Entrar para tela Logado
        {
            Data data = new Data();
            bool result = await data.LoginUser(txtEmail.Text,txtSenha.Text);
            if (result)
            {
                Response.Redirect("logado.aspx");
            }
            else
            {
                lblError.Text = "Cadastro não encontrado";
                lblError.Visible = true;
            }

           /* var data = new Data
            {
                email = txtEmail.Text,   
                senha = txtSenha.Text,
               
            };
            FirebaseResponse response = await cliente.GetAsync("Cliente/" + "renan");
            Data obj = response.ResultAs<Data>();
            lblError.Visible = true;
            lblError.Text = obj.email;
            txtSenha.Text = obj.senha;
            MessageBox.Show("deu certo");
                
          
            Controle cont = new Controle();
            cont.acessar(txtEmail.Text, txtSenha.Text);
            if (cont.tem)
            {
                Response.Redirect("Logado.aspx");
            }
            else {
                lblError.Text= "login ou senha errado";
                lblError.Visible = true;
            };*/
                           
        }         
        protected void LinkButton1_Click(object sender, EventArgs e)// Entrar para recuperar senha
        {
            Response.Redirect("TelaRecSenha.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)//Entrar para cadastro
        {
            Response.Redirect("Cadastro.aspx");
        }

        
        
    }
    
}