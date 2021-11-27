using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProjetoUniNove
{
    public partial class PrimeiroAcesso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected async void bntSalvar_Click(object sender, EventArgs e)
        {
            int con = 0;
            Funcoes funcao = new Funcoes();
            
            Data data = new Data();
            await data.PrimeiroAcesso("admin@admin.com");// ativa o cadastro do user
            
            bool semRestr = cbSemRestr.Checked; // retorna True se foi marcado;
            string semRestricao = funcao.ConvertBool(semRestr); // pega o valor acima e converte para 0 ou 1

            bool diabete = checkDiabete.Checked;
            string diabet = funcao.ConvertBool(diabete);

            bool intoLac = checkIntoLactose.Checked;
            string IntoletanteLactose = funcao.ConvertBool(intoLac);

            bool dispi = checkDislipidemia.Checked;
            string dislipidemia = funcao.ConvertBool(dispi);

            bool constipacao = checkConstipação.Checked;
            string constipa = funcao.ConvertBool(constipacao);

            bool celiaca = checkCeliaca.Checked;
            string celiac = funcao.ConvertBool(celiaca);


            if (diabet == "1" || IntoletanteLactose == "1" || dislipidemia == "1" || constipa == "1" || celiac == "1")
            {
                con += 1;
            }
            if(semRestricao == "1")
            {
                con += 1;
            }
            if (con == 1) { 
                double altura = 0, peso = 0;
                try
                {
                    altura = double.Parse(Request["txtPrimAltura"]);
                    peso = double.Parse(Request["txtPrimPeso"]);
                }
                catch (Exception)
                {

                }
                finally
                {

                    if (altura != 0)
                    {
                        if (peso != 0)
                        {
                            string resultado = String.Format(@"{0:.00\.00}", funcao.Imc(peso, altura));//recebe e transforma o valor double
                            string peso_tratado = resultado.Replace(",", "");// tira a virgula que fica na frente 
                            await data.Adiciona("admin@admin.com", $"{peso_tratado}", semRestricao, diabet, IntoletanteLactose, dislipidemia, constipa, celiac);
                            Response.Redirect("logado.aspx");
                        }
                        else
                        {
                            MessageBox.Show("peso não pode ser ZERO");
                        }
                    }
                    else
                    {
                        MessageBox.Show("altura não pode ser ZERO");
                    }


                }
            }
            else
            {
                MessageBox.Show("sem restrição não pode esta marcado com outras restriçoes");
            }

        }
    }
}