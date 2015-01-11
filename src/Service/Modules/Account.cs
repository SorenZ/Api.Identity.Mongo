using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Nancy;
using Nancy.Json;
using Nancy.ModelBinding;
using Nancy.ModelBinding.DefaultBodyDeserializers;
using Nancy.Responses;
using Service.Model;

namespace Service.Modules
{
    public class Account : NancyModule
    {
        public Account() : base("account")
        {
            Get["/get"] = _ => "Hello Account.";

            Post["/addPermission"] = _ =>
            {
                //var moduleActions = new Dictionary<string, string[]> {{"pages", new[] {"create", "update", "delete"}}};

                var param = this.Bind<PermissionHierarchy>();
                
                var jss = new JavaScriptSerializer();
                var dict = jss.Deserialize<Dictionary<string, Dictionary<string, string[]>>>("");

                //var ps = new Dictionary<string, Dictionary<string, string[]>>
                //{
                //    {
                //        "office", new Dictionary<string, string[]>
                //        {
                //            {"pages", new[] {"create", "update", "delete"} }
                //        }
                //    }
                //};

                //return ps;

                return new
                {
                    dict,
                    count = dict.Count
                };

            };

        }
    }
}
