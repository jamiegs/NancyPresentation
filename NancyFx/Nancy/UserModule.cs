using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace Nancy
{
    public class UserModule : NancyModule
    {
        public UserModule()
        {
            Get["/user"] = param =>
                {
                    return new User();
                }
        }
    }
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
