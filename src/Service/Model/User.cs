using System;
using System.Collections.Generic;

namespace Service.Model
{
    public class User
    {
        public string Id { get; set; }
        public string EMail { get; set; }
        public string Name { get; set; }
        public bool EmailConformed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConformed { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public UserProfile Profile { get; set; }
        
        public List<UserRole> Roles { get; set; }
        
        public string Parent { get; set; }
        public List<string> Ancestors { get; set; }
        public List<string> Children { get; set; }
        
    }

    public class UserProfile
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public UserGender Gender { get; set; }
        public List<Tuple<string, string>> EMails { get; set; }
        public List<Tuple<string, string>> PhonNumbers { get; set; }

        public List<Tuple<string, string>> Address { get; set; }

        public List<Tuple<string, string>> ItemValues { get; set; }

    }

    public class UserRole
    {
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public bool IsLimitedByTime { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<string> IpRange { get; set; }
        public List<Dictionary<string, Dictionary<string, string[]>>> Permissions { get; set; }
    }

    public enum UserGender
    {
        Male,
        Female
    }

}
