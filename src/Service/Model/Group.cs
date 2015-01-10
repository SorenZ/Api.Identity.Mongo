using System.Collections.Generic;

namespace Service.Model
{
    /// <summary>
    /// holds and shows the account system Groups and default permissions
    /// </summary>
    public class Group
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> DefaultPermissions { get; set; }
    }
}