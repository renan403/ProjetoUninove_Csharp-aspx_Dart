using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoUniNove
{
    internal class Data
    {
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
        public async Task<bool> LoginUser(string email, string senha, bool ativo)
        {
            var user = (await client.Child("Usuarios").OnceAsync<User>())
                .Where(u => u.Object.Email == email)
                .Where(u => u.Object.Password == senha)
                .Where(u => u.Object.Ativo == ativo)
                .FirstOrDefault();
            return (user != null);
        }
        public async Task<bool> ValidaCod(String cod, String email)
        {
            var user = (await client.Child("Usuarios/").OnceAsync<User>())
                .Where(u => u.Object.Codigo == cod)
                .Where(u => u.Object.Email == email)
                .FirstOrDefault();
            return (user != null);
        }
        public async Task<bool> ValidaUser(string email, String cod)
        {
            var userSenha = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Object.Password;
            var userName = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Object.Username;
            var chave = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Key;

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
        public async Task<bool> DeleteUser(string email, string senha)
        {
            var chave = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Key;
            await client.Child($"Usuarios/{chave}").DeleteAsync();

            return true;
        }
        public async Task<bool> AlterSenha(string email, string senha, string codigo)
        {
            var chave = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Key;

            var userAtivo = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Object.Ativo;
            var userName = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Object.Username;
            await client.Child($"Usuarios/{chave}")
                .PutAsync(new User()
                {
                    Ativo = userAtivo,
                    Username = userName,
                    Password = senha,
                    Email = email,
                    Codigo = codigo,
                });
            return true;



        }
        public async Task<bool> AlterCod(string email, string cod)
        {
            var userSenha = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Object.Password;
            var userName = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Object.Username;
            var chave = (await client.Child("Usuarios").OnceAsync<User>()).Where(u => u.Object.Email == email).FirstOrDefault().Key;
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

    }
}