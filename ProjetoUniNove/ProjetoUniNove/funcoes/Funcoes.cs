using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ProjetoUniNove
{
    public class Funcoes
    {
        public double Imc(double peso, double altura)
        {  
            return Math.Round(peso / (Math.Pow(altura,2)),6); } // pega o peso e faz o calculo para retornar o Imc
        public string ConvertBool (bool variavel)
        {
            string convertido;
            if (variavel)
                convertido = "1";
            else
                convertido = "0";

            return convertido;

        }

        //RetornarPeso e Status tem o mesmo objetivo que é tratar o retorno do banco de dados exemplo de retorno
        //{"Ativo":"1","Codigo":"444180","Email":"admin@admin.com","Info":{"Celiaca":"0","Constipacao":"0","Diabete":"0","Dispi":"0","IntoLac":"0","Peso":"20.76","SemRestr":"0"},"Password":"123456","PrimeiroAcess":"1","Username":"renan"}
        //um json 
        public List<string> RetornaRestriPeso(string chave)
        {
            string url = $"https://projetouni9-ae8d8-default-rtdb.firebaseio.com/Usuarios/{chave}/Info/.json";
            var requisicaoWeb = WebRequest.CreateHttp(url);// Pega url
            requisicaoWeb.Method = "GET";                  // Usa o VerboHttp get para pegar a informação
            var resp = requisicaoWeb.GetResponse();        // Pega resposta da url igual o exemplo ali em cima
            var streamDados = resp.GetResponseStream();    // Recebe os dados 
            StreamReader reader = new StreamReader(streamDados); // Lê os dados recebidos
            object objResponse = reader.ReadToEnd();       // Para para os objetos oque ele retornou
            var post = JsonConvert.DeserializeObject<User>(objResponse.ToString()); // Conversão para Json de acordo com os objetos
            string pesoResp = post.Peso // Pega o valor que esta no objeto peso
            , celiacaResp = post.Celiaca
            , constResp = post.Constipacao
            , dispResp = post.Dispi
            , semRestriResp = post.SemRestr
            , diabeteResp = post.Diabete
            , intoLacResp = post.IntoLac;

            streamDados.Close();
            resp.Close();
            List<string> listaRetorno = new List<string>() { pesoResp, celiacaResp, constResp, dispResp, semRestriResp, diabeteResp, intoLacResp };
            
            return listaRetorno ;
        }
        public List<string> RetornaInfoConta(string chave)
        {  

            string url = $"https://projetouni9-ae8d8-default-rtdb.firebaseio.com/Usuarios/{chave}/.json";
            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "GET";
            var resp = requisicaoWeb.GetResponse();
            var streamDados = resp.GetResponseStream();
            StreamReader reader = new StreamReader(streamDados);
            object objResponse = reader.ReadToEnd();
            //MessageBox.Show(objResponse.ToString()); 
            var post = JsonConvert.DeserializeObject<User>(objResponse.ToString());
            string emailResp = post.Email
            , usuario = post.Username
            ,primeiroAcesso = post.PrimeiroAcess;
                   
            streamDados.Close();
            resp.Close();
            List<string> retornoStatus = new List<string>() {emailResp, usuario , primeiroAcesso};

            return retornoStatus;
        }
    }
}