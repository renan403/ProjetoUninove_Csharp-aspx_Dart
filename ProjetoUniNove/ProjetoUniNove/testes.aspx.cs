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
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ProjetoUniNove
{
    public partial class testes : System.Web.UI.Page
    {
        

        //private string codigo;
        //private string email;

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }


        protected   void Unnamed1_Click(object sender, EventArgs e)
        {
            // Restricoes res = new Restricoes();
            //Label1.Text= res.deslipidemia();

            // Data d = new Data();
            //await d.DeleteUser("admin@admin.com");

            Funcoes f = new Funcoes();
            List<string> result = f.RetornaRestriPeso("-Moi_MkcruKaI7J0D1Tj");

            string peso = result[0],
                   celiaca = result[1],
                   constipacao = result[2],
                   dispi = result[3],
                   semRestr = result[4],
                   diabete = result[5],
                   intoLac = result[6];


        }
        
    }
}