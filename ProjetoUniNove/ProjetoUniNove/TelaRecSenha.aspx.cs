using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoUniNove
{
    public partial class TelaRecSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        

        protected  void bntEnviar_Click(object sender, EventArgs e)
        {
         //   Data data = new Data();
         //   String email = "renancporto94@gmail.com";
          //  String cod = txtCod.Text;
          //  Session["codigo"] = cod;
          //  Session["email"] = email;


            Response.Redirect("testes.aspx");


            //bool result = await data.IsUserExists

        }
        
    }
}