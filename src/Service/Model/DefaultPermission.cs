using System.Collections.Generic;

namespace Service.Model
{
    public class DefaultPermission
    {
        public Dictionary<string, Dictionary<string, string[]>> Permission { get; set; }
    }
}
