using System;
using System.Linq;

namespace ProjetoUniNove
{
    public class Controle
    {
        public String mensagem;
        public bool tem;
        public bool acessar(String nome, String cpf)
        {
            DataBase db = new DataBase();
            tem = db.verificarLogin(nome, cpf);
            return tem;
        }
        public String cadastrar(String nome, String email, String senha, String cod)
        {
            DataBase db = new DataBase();
            this.mensagem = db.cadastrar(nome, email, senha, cod);
            if (db.tem)
            {
                this.tem = true;

            }
            return mensagem;
        }
    }
}