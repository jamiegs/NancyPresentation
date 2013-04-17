using Nancy;
using NancyPresentation.Models;
using System.Linq;

namespace NancyPresentation.Modules
{
    public class UserModule : NancyModule
    {
        // This would be replaced with a your data repository.
        private readonly UsersModel _users = new UsersModel() {
                new UserModel() { Id = 1, FirstName = "Bob", LastName = "Saget" },
                new UserModel() { Id = 2, FirstName = "John", LastName = "Stamos" },
                new UserModel() { Id = 2, FirstName = "Dave", LastName = "Coulier" }
            };

        public UserModule() : base("/Users")
        {
            
            Get["/"] = _ => _users;

            Get["/{Id}"] = _ => _users.FirstOrDefault(p => p.Id == _.Id);

        }
    }
}
