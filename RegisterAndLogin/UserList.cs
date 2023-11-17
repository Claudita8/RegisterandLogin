using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RegisterAndLogin
{
    public class UserList
    {
        public List<User> Users;

        public UserList()
        {
            Users = new List<User>();
        }
        public UserList Add(User user)
        {
            Users.Add(user);
            return this;
        }
        public UserList Remove(User user)
        {
            Users.Remove(user);
            return this;
        }
        public User SearchByName(string name)
        {
            return Users.FirstOrDefault(x => x.Username == name);
        }
        public void SaveOnDisk()
        {
            var jsonPath = System.Configuration.ConfigurationManager.AppSettings["jsonPath"];
            string jsonString = JsonConvert.SerializeObject(Users);
            File.WriteAllText($"{jsonPath}/users.json", jsonString);
        }
        public List<User> LoadFromDisk()
        {
            var jsonPath = System.Configuration.ConfigurationManager.AppSettings["jsonPath"];
            if (!File.Exists($"{jsonPath}/users.json"))
            {
                return Users;
            }
            string jsonString = File.ReadAllText($"{jsonPath}/users.json");
            return JsonConvert.DeserializeObject<List<User>>(jsonString);
        }
    }
}
