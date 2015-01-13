using Nancy;
using MongoRepository;


namespace Service.Modules
{
    public class User : NancyModule
    {
        public User() : base("account/user")
        {
            Get["/getById"] = _ =>
            {
                var userRepo = new MongoRepository<Models.User>();

                return userRepo.GetById(this.Request.Query.id);
            };
        }
    }
}
