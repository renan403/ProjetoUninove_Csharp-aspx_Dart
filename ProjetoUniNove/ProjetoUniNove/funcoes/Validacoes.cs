using System;
using System.Linq;

namespace ProjetoUniNove
{
    public static class Validacoes
    {
        public static String ValidaSenha(string senha)
        {

            if (senha.Length > 20)
            {
                return "Senha muito Longa";
            }
            else if (senha.Length < 6)
            {
                return "Senha muito Curta";
            }
            else if (senha.Length == 0)
            {
                return "Campo senha vazio";
            }
            return string.Empty;
        }

    }
}