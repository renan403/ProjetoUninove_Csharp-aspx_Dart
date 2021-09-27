using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Windows.Forms;

namespace ProjetoUniNove
{
    public partial class testes : System.Web.UI.Page
    {
        //private string codigo;
        //private string email;

        protected void Page_Load(object sender, EventArgs e)
        {
           // codigo = (string)Session["codigo"];
            //email = (string)Session["email"];

        }
     

        protected async void Unnamed1_Click(object sender, EventArgs e)
        {
            bool result;
            Data data = new Data();
            result = await data.ValidaCod("466532", "admin@admin.com");
            if (result)
            {
                MessageBox.Show("cod encontrado");
            }
            else
            {
                MessageBox.Show("nao encontrado");
            }

        }
        
    }
}