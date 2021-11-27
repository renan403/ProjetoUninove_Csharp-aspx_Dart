using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProjetoUniNove
{
    public partial class Logado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*string email = (string)Session["email"];
            if (email == "" || email == null)
            {
                Response.Redirect("Cadastro.aspx");
            }
             Data data = new Data();
             string NomeUser = await data.RetornaStatus("admin@admin.com", "1");
             */

        }

        protected async void BtnExercicios_Click(object sender, EventArgs e)
        {

            Data data = new Data();

            string retorno = await data.RetornaImc((string)Session["email"]);
            
            //string email = (string)Session["email"];
            float imc =float.Parse(retorno);
     
            if (imc < 18.5)
            {
                Response.Redirect("Exercicio1.aspx");
            }
            else if (imc >= 18.5 || imc <= 24.9)
            {
                Response.Redirect("Exercicio2.aspx");
            }
            else if (imc >= 25.0 || imc <= 29.9) 
            {
                Response.Redirect("Exercicio3.aspx");
            }
            else if (imc >= 30.0 || imc <= 34.9) 
            {
                Response.Redirect("Exercicio4.aspx");
            }
            else if (imc >= 35.0 || imc <= 39.9)
            {
                Response.Redirect("Exercicio5.aspx");
            }
            else
            {
                Response.Redirect("Exercicio6.aspx");
            }




        }

        protected void BtnPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("Perfil.aspx");
        }

        protected void BtnDietas_Click(object sender, EventArgs e)
        { Funcoes f = new Funcoes();
            List<string> result = f.RetornaRestriPeso("-Moi_MkcruKaI7J0D1Tj");
            Restricoes r = new Restricoes();  
            string celiaca = result[1],
                   constipacao = result[2],
                   dispi = result[3],
                   semRestr = result[4],
                   diabete = result[5],
                   intoLac = result[6];
            
                Session.Add("celiaca", celiaca);
                Session.Add("constipacao", constipacao);         
                Session.Add("deslipidemia", dispi);         
                Session.Add("SemRestria", semRestr);          
                Session.Add("diabete", diabete);            
                Session.Add("IntoLac", intoLac);           
                             
                Response.Redirect("Restricoes.aspx");      
        }
    }
}