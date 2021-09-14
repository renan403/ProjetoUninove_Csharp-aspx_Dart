using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjetoUniNove
{ //String db;
  // db = System.Configuration.ConfigurationManager.ConnectionStrings
    public class DataBase
    {
        String mensagem = "";
        public bool tem = false;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String nome, String cpf)
        {
            cmd.CommandText = "select * FROM [ProjetoUninove].[dbo].[cliente] where nome = @nome and cpf = @cpf";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = ("Erro ao Conectar no Banco de Dados");
                throw;
            }

            return tem;
        }
    }
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"Data Source = renan; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
           // con.ConnectionString = @"Server=RENAN;Database=ProjetoUninove;User Id=RENAN\renancporto;Password='';";
        }
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
    
}