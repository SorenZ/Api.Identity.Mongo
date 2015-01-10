using System;
using System.Collections.Generic;

namespace Service.Model
{
    /// <summary>
    /// holds and shows the account system Roles and default permissions
    /// </summary>
    public class Role
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> DefaultPermissions { get; set; }
    }
}