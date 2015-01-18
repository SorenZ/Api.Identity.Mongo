using System.Collections.Generic;
using System.Linq;
using MongoRepository;
using Nancy;
using Service.Models;

namespace Service.Modules.Account
{
    public class Role : NancyModule
    {
        public Role()
            : base("account/role")
        {
            var shopPermission = new Dictionary<string, Dictionary<string, string[]>>
            {
                {
                    "shop", new Dictionary<string, string[]>
                    {
                        {"brand", new[] {"create", "update", "delete"}},
                        {"category", new[] {"create", "update", "delete"}}
                    }
                },
                {
                    "office", new Dictionary<string, string[]>
                    {
                        {"pages", new[] {"create", "update", "delete"}},
                        {"form", new[] {"create", "update", "delete"}}
                    }
                }
            };

            var role = new Models.Role
            {
                Name = "admin",
                Title = @"مدیریت",
                IsActive = true,
                IsLimitedByDate = false,
                IsLimitedInDay = false,
                IsLimitedInWeek = false,
                IpRange = new[] {"192.168.0.1"},
                Permissions = shopPermission
            };

            Post["/create"] = _ =>
            {
                var roleRepo = new MongoRepository<Models.Role>();


                //roleRepo.Add(role);

                return roleRepo.Last();

                //.Select(s => s.Value)
                //.ToList();

            };

        }
    }
}
