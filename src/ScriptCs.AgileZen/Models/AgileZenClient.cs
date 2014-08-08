using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCs.AgileZen.Models
{
    public class AgileZenClient
    {
        private readonly string _apiKey;

        public AgileZenClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public IEnumerable<Project> ListProjects()
        {
            var projects = new List<Project>();

            projects.Add(
                new Project
                {
                    CreateTime = DateTime.Now,
                    Name = "Test Project",
                    Description = "Test Project Description"
                });

            projects.Add(
                new Project
                {
                    CreateTime = DateTime.Now,
                    Name = "Test Project 2",
                    Description = "Test Project 2 Description"
                });

            return projects;
        }
    }
}
