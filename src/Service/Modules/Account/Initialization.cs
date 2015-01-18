using System.Collections.Generic;
using System.Linq;
using MongoRepository;
using Nancy;
using Service.Models;

namespace Service.Modules.Account
{
    /// <summary>
    /// init the
    /// - default permission
    /// - default role
    /// </summary>
    public class Initialization : NancyModule
    {
        public Initialization()
            : base("account/initialization")
        {
            
            var shopPermission = new Dictionary<string, Dictionary<string, string[]>>
            {
                {
                    "shop", new Dictionary<string, string[]>
                    {
                        {"brand", new[] {"create", "update", "delete"} },
                        {"category", new[] {"create", "update", "delete"} }
                    }
                },
                {
                    "office", new Dictionary<string, string[]>
                    {
                        {"pages", new[] {"create", "update", "delete"} },
                        {"form", new[] {"create", "update", "delete"} }
                    }
                    
                }
            };

            Post["/addPermissions"] = _ =>
            {
                var defaultPermission = new MongoRepository<Permission>();

                //defaultPermission.Add(new DefaultPermission
                //{
                //    Permissions = new Dictionary<string, Dictionary<string, string[]>>(shopPermission)
                //});


                return new
                {
                    date = defaultPermission
                        .AsQueryable()
                        .Last()
                        .Permissions
                };

            };
        }
    }
}
