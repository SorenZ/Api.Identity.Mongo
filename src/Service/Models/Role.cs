using System;
using System.Collections.Generic;
using MongoRepository;

namespace Service.Models
{
    /// <summary>
    /// holds and shows the account system Roles and default permissions
    /// </summary>
    public class Role : Entity
    {
        public Role()
        {
            this.WeekLimitations = new List<WeekLimitation>();
            this.IpRange = new List<string>();
        }

        public string Name { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        
        /// <summary>
        /// determine whether thd role is limited by in an interval date or not
        /// </summary>
        public bool IsLimitedByDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// determine whether the role is limited in an interval of time in the day or not
        /// </summary>
        public bool IsLimitedInDay { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public bool IsLimitedInWeek { get; set; }
        public IList<WeekLimitation> WeekLimitations { get; set; }

        public IList<string> IpRange { get; set; }
        public Dictionary<string, Dictionary<string, string[]>> Permissions { get; set; }
    }

    public class WeekLimitation
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}