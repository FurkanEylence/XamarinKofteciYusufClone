using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using XamarinKofteciYusufClone.Models;

namespace XamarinKofteciYusufClone.Services
{
    public class UserService
    {
        FirebaseClient client;
        public UserService()
        {
            client = new FirebaseClient("https://xamarinkofteciyusuf-default-rtdb.firebaseio.com/");
        }

        public async Task<bool> IsUserExists(string username)
        {
            var user = (await client.Child("Users").OnceAsync<Customer>())
                .FirstOrDefault(u => u.Object.Name == username);
            return user != null;
        }

        public async Task<bool> RegisterUser(string username, string password)
        {
            if (await IsUserExists(username) == false)
            {
                await client.Child("Users").PostAsync(new Customer() { Name = username, Password = password });
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> LoginUser(string username, string password)
        {
            var user = (await client.Child("Users").OnceAsync<Customer>()).Where(u => u.Object.Name == username)
                .Where(u => u.Object.Password == password).FirstOrDefault();
            return (user!= null);
        }
    }
}
