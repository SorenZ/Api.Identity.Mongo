using System.Collections.Generic;

namespace Service.Model
{
    /// <summary>
    /// holds and shows selectable permission
    /// provides :
    ///     - App:
    ///         - [Modules]
    ///             - [Actions]
    /// </summary>
    public class PermissionHierarchy
    {
        public List<App> Permission { get; set; }
    }
    

    public class App
    {
        public string Name { get; set; }
        public List<Module> Modules { get; set; }
    }

    public class Module
    {
        public string Name { get; set; }
        public List<string> Actions { get; set; }
    }

    
}