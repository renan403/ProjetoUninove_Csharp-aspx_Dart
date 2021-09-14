using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoUniNove
{
    public class Controle
    {
        public bool tem;
        public bool acessar(String nome, String cpf)
        {
            DataBase db = new DataBase();
            tem = db.verificarLogin(nome, cpf);
            return tem;
        }
    }
}