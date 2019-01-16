using KoffieMachineDomain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.Factory
{
    public class UserFactory
    {
        public Dictionary<string, User> Users { get; }
        public IEnumerable<string> Usernames => Users.Keys;

        public UserFactory()
        {
            Users = new Dictionary<string, User>
            {
                ["Arjen"] = new User(5.0),
                ["Bert"] = new User(3.5),
                ["Chris"] = new User(7.0),
                ["Daan"] = new User()
            };

        }

        public User GetUser(string name)
        {
            return Users[name];
        }
    }
}
