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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void Unnamed1_Click(object sender, EventArgs e)
        {
            bool result;
            Data data = new Data();
            result = await data.IsUserExists("renanc@gmail.com");
            if (result)
            {
                MessageBox.Show("email encontrado");
            }
        }
        
    }
}