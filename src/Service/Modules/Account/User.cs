using System.Linq;
using MongoRepository;
using Nancy;
using Nancy.ModelBinding;
using Service.Models;

namespace Service.Modules.Account
{
    public class User : NancyModule
    {
        public User() : base("account/user")
        {
            var userRepo = new MongoRepository<Models.User>();

            Get["/getById"] = _ =>
            {
                return userRepo.GetById(this.Request.Query.id);
            };

            var user = new Models.User
            {
                EMail = "soren@SAM.ir",
                FriendlyName = "Soren",
                IsActive = true,
                PasswordHash = Alamut.Security.PasswordHash.CreateHash("hamed"),
                IsAdmin = true,
                Image = new UserImage {Id = "", Url = ""},
                RoleIds = new[] { "54b5011d5f2d13057c0a8895" },

            };

            Post["/create"] = _ =>
            {
                userRepo.Add(user);

                return userRepo.Last();
            };
        }
    }
}
