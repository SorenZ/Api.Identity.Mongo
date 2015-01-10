using System;
using System.Collections.Generic;

namespace Service.Model
{
    public class User
    {
        public string EMail { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public UserProfile Profile { get; set; }
        
        public List<UserRole> Roles { get; set; }
        public List<UserGroup> Groups { get; set; }
        
        public string Parent { get; set; }
        public List<string> Ancestors { get; set; }
        public List<string> Children { get; set; }
        
    }

    public class UserProfile
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<string> EMails { get; set; }
        public List<Tuple<string, string>> PhonNumbers { get; set; }
        public List<Tuple<string, string>> Address { get; set; }

        public List<Tuple<string, string>> ItemValues { get; set; }

    }

    
    public class UserGroup
    {
        public string Title { get; set; }
        public List<string> Permissions { get; set; }
    }


    public class UserRole
    {
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public bool IsLimitedByTime { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<string> Permissions { get; set; }
    }
}
