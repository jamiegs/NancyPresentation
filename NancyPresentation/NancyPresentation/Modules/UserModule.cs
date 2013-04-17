using Nancy;
using NancyPresentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyPresentation.Modules
{
    public class UserModule : NancyModule
    {

        private UsersModel users = new UsersModel() {
                new UserModel() { Id = 1, FirstName = "Bob", LastName = "Saget" },
                new UserModel() { Id = 2, FirstName = "John", LastName = "Stamos" }
            };

        public UserModule() : base("/Users")
        {
            Get["/"] = _ =>
            {
                return users;
            };

           Get["/{Id}"] = _ => {
                this.Context.Trace.TraceLog.WriteLog(s => s.AppendLine("Users with Id was called"));
                //this.Context.Trace.TraceLog.WriteLog(s => s.AppendLine(“Users path was called”));
                return users.Where(p => p.Id == _.Id).FirstOrDefault();
            };

        }
    }
}
