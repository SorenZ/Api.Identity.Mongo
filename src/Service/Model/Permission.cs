using System.Collections.Generic;

namespace Service.Model
{
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