using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;

namespace Service.Modules
{
    public class Account : NancyModule
    {
        public Account() : base("account")
        {
            Get["/get"] = _ => "Hello Account.";
        }
    }
}
