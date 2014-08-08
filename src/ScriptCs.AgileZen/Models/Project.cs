using System;

namespace ScriptCs.AgileZen.Models
{
    public class Project : AgileZenModel
    {
        public DateTime CreateTime { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}
