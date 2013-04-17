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
            Get["/user"] = _ =>
                {
                    return new UserModel() { FirstName = "Jamie", LastName = "Snell" };
                };
        }
    }

    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
