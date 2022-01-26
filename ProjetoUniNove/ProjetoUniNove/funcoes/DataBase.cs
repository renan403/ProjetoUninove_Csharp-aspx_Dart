using System;
using System.Data.SqlClient;
using System.Linq;

namespace ProjetoUniNove // por questão de praticidade esse banco foi trocado pelo firebase
{
    public class DataBase
    {
        String mensagem = string.Empty;
        public bool tem = false;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String email, String senha)
        {
            cmd.CommandText = "select * FROM [ProjetoUninove].[dbo].[cliente] where email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = ("Erro ao Conectar no Banco de Dados");
                throw;
            }

            return tem;
        }
        public String cadastrar(String nome, String email, String senha, String cod)
        {
            tem = false;
            cmd.CommandText = "INSERT INTO [ProjetoUninove].[dbo].[cliente] (nome, email, senha,codigo) VALUES(@nome, @email, @senha,@cod) ; ";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@cod", cod);

            try
            {

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = ("cadastrado com sucesso");
                tem = true;
            }
            catch (SqlException)
            {
                this.mensagem = ("Erro ao inserir no Banco de Dados");
            }

            return mensagem;
        }
    }
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"*sua conexão*";

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
