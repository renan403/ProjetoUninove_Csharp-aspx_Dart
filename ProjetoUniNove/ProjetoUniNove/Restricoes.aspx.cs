using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProjetoUniNove
{
    public partial class Restricoes1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Restricoes r = new Restricoes();
            int contador = 0;          
            string celiaca = (string)Session["celiaca"],
                   constipacao = (string)Session["constipacao"],
                   dispi = (string)Session["deslipidemia"],
                   semRestr = (string)Session["SemRestria"],
                   diabete = (string)Session["diabete"],
                   intoLac = (string)Session["IntoLac"];
            if (celiaca == "1")
            {
                Label1.Text = r.Celiaco();
                contador += 1;
            }
            if (constipacao == "1")
            {
                if (contador == 1)
                {
                    Label2.Text = r.constipacao();
                    contador += 1;
                }
                else
                {
                    Label1.Text = r.constipacao();
                    contador += 1;
                }
                
            }
            if (dispi == "1")
            {
                if (contador == 1)
                {
                    Label2.Text = r.deslipidemia();
                    contador += 1;
                }
                else if(contador == 2)
                {
                    Label3.Text = r.deslipidemia();
                    contador += 1;
                }else
                {
                    Label1.Text = r.deslipidemia();
                    contador += 1;
                }

            }
            if (semRestr == "1")
            {
                Label1.Text = r.SemRestri();
            }
            if (diabete == "1")
            {
                if (contador == 1)
                {
                    Label2.Text = r.Tipo1();
                    contador += 1;
                }
                else if (contador == 2)
                {
                    Label3.Text = r.Tipo1();
                    contador += 1;
                }
                else if(contador == 3)
                {
                    Label4.Text = r.Tipo1();
                    contador += 1;
                }else
                {
                    Label1.Text = r.Tipo1();
                    contador += 1;
                }
            }
            if (intoLac == "1")
            {
                if (contador == 1)
                {
                    Label2.Text = r.IntoLac();
                    contador += 1;
                }
                else if (contador == 2)
                {
                    Label3.Text = r.IntoLac();
                    contador += 1;
                }
                else if (contador == 3)
                {
                    Label4.Text = r.IntoLac();
                    contador += 1;
                }
                else if (contador == 4)
                {
                    Label5.Text = r.IntoLac();
                    contador += 1;
                }else
                {
                    Label1.Text = r.IntoLac();
                    contador += 1;
                }
            }
            
        }
    }
}