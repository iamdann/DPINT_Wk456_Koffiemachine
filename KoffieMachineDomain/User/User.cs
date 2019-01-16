using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.Users
{
    public class User
    {
        public double Balance { get; set; }

        public User(double balance = 500)
        {
            Balance = balance;
        }
    }
}
