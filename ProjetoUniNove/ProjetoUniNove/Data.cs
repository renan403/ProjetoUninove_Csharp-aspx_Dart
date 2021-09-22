using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public async Task<bool> RegisterUser(string name, string email, string senha,  string codigo)
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
                    });
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> LoginUser(string name, string senha)
        {
            var user = (await client.Child("Usuarios").OnceAsync<User>())
                .Where(u => u.Object.Username == name)
                .Where(u => u.Object.Password == senha)
                .FirstOrDefault();
            return (user != null);
        }
    }
    
}