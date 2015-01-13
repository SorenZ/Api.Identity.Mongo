using System.Collections.Generic;
using MongoRepository;

namespace Service.Models
{
    /// <summary>
    /// defined default permissions 
    /// </summary>
    public class Permission : Entity
    {
        public Dictionary<string, Dictionary<string, string[]>> Permissions { get; set; }
    }
}
