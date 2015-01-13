using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson.Serialization.Attributes;
using MongoRepository;

namespace Service.Models
{
    public class User : Entity
    {
        public User()
        {
            this.RoleIds = new List<string>();
            this.Ancestors = new List<string>();
            this.Children = new List<string>();
        }

        public string EMail { get; set; }
        public string FriendlyName { get; set; }
        public bool IsActive { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        
        /// <summary>
        /// determine the user is from control panel (admin) or (site)
        /// </summary>
        public bool IsAdmin { get; set; }
        public UserProfile Profile { get; set; }
        public UserImage Image { get; set; }
        
        public IList<string> RoleIds { get; set; }

        [BsonIgnore]
        public IQueryable<Role> Roles
        {
            get
            {
                return new MongoRepository<Role>()
                    .Where(q => this.RoleIds.Contains(q.Id));
            }
        }

        public Dictionary<string, Dictionary<string, string[]>> ExtraPermissions { get; set; }
        
        public string Parent { get; set; }
        public IList<string> Ancestors { get; set; }
        public IList<string> Children { get; set; }
        
    }

    public class UserImage
    {
        public string Id  { get; set; }
        public string Url { get; set; }
    }

    public class UserProfile
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public UserGender Gender { get; set; }
        public bool EmailConformed { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConformed { get; set; }

        public List<Tuple<string, string>> EMails { get; set; }
        public List<Tuple<string, string>> PhonNumbers { get; set; }
        public List<Tuple<string, string>> Address { get; set; }
        public List<Tuple<string, string>> ItemValues { get; set; }

    }

    public enum UserGender
    {
        Male,
        Female
    }

}
