using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace Service.Model
{
    public class User
    {
        public string EMail { get; set; }
        public string Name { get; set; }
        public Profile Profile { get; set; }
        
        public List<Role> Roles { get; set; }
        public List<Group> Groups { get; set; }
        public string Parent { get; set; }
        public List<string> Ancestors { get; set; }
        public List<string> Children { get; set; }
        
    }

    public class Profile
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<string> EMails { get; set; }
        public List<Tuple<string, string>> PhonNumbers { get; set; }
        public List<Tuple<string, string>> Address { get; set; }
        
        public List<Tuple<string, string>> ItemValues { get; set; }

    }

    /// <summary>
    /// dual used model :
    /// - holds and shows the accounting system Groups and default permissions
    /// - shows the user's group and applied permissions 
    /// </summary>
    public class Group
    {
        public string Title { get; set; }
        public List<string> Permissions { get; set; }
    }
    
    /// <summary>
    /// dual used mode :
    /// - holds and shows the accounting system Roles and default permissions
    /// - shows the user's role and applied permissions 
    /// </summary>
    public class Role
    {
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public bool IsLimitedByTime { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<string> Permissions { get; set; }
    }

    /// <summary>
    /// holds and shows selectable permission
    /// - in order to system integrity
    /// </summary>
    public class Permission
    {
        public string Title { get; set; }

        /// <summary>
        /// shows in which role list
        /// </summary>
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// shows in which category list
        /// </summary>
        public List<string> GroupIds { get; set; }

    }
}
