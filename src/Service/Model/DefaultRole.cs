using System;
using System.Collections.Generic;

namespace Service.Model
{
    /// <summary>
    /// holds and shows the account system Roles and default permissions
    /// </summary>
    public class DefaultRole
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsLimitedByDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsLimitedInDay { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public List<string> IpRange { get; set; }
        public List<Dictionary<string, Dictionary<string, string[]>>> DefaultPermissions { get; set; }
    }
}