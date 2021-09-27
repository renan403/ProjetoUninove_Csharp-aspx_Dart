using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoUniNove
{
    internal class Data
    {
        /*public string email { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string codigo { get; set; }
        */
        FirebaseClient client;
        public Data()
        {
            client = new FirebaseClient("https://projetouni9-ae8d8-default-rtdb.firebaseio.com/");
        }
        public async Task<bool> IsUserExists(string email)
        {
            var user = (await client.Child("Usuarios")
                .OnceAsync<User>())
                .Where(u => u.Object.Email == email)
                .FirstOrDefault();

            return (user != null);
        }
        public async Task<bool> RegisterUser(string name, string email, string senha, string codigo, bool ativo)
        {
            if (await IsUserExists(email) == false)
            {
                await client.Child("Usuarios")
                    .PostAsync(new User()
                    {
                        Username = name,
                        Password = senha,
                        Email = email,
                        Codigo = codigo,
                        Ativo = false,
                    });
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> LoginUser(string email, string senha,bool ativo )
        {
            var user = (await client.Child("Usuarios").OnceAsync<User>())
                .Where(u => u.Object.Email == email)
                .Where(u => u.Object.Password == senha)
                .Where(u => u.Object.Ativo == ativo)
                .FirstOrDefault();
            return (user != null);
        }
        public async Task<bool> ValidaCod(String cod,String email)
        {
            var user = (await client.Child("Usuarios/").OnceAsync<User>())
                .Where(u => u.Object.Codigo == cod)
                .Where(u => u.Object.Email == email)
                .FirstOrDefault();
            return (user != null);
        }
        public async Task<bool> ValidaUser(string email, String cod)
        {
          
                //  List<String> Lista = new List<string>();
                // var userEmail = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Object.Email;
                // Lista.Add(userEmail);
                // var userCod = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Object.Codigo;
                //  Lista.Add(userCod);
                var userSenha = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Object.Password;
                // Lista.Add(userSenha);
                var userName = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Object.Username;
                //  Lista.Add(userName);
                var chave = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Key;
                // Lista.Add(chave);

                await client.Child($"Usuarios/{chave}")
                        .PatchAsync(new User()
                        {
                            Username = userName,
                            Password = userSenha,
                            Email = email,
                            Codigo = cod,
                            Ativo = true,
                        });
                return true;          
        }
        public  async Task<bool> DeleteUser()
        {
            await client.Child("Usuarios").DeleteAsync();

            return true;
        }
       
    }
    
    
}