using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Models;

namespace TaskManager.Data
{
    public class AppData
    {
        public List<Project> Projects { get; set; }
        public List<Models.Task> Tasks { get; set; }
    
        public AppData()
        {
            Projects = new List<Project>();
            Tasks = new List<Models.Task>();
        }
    }
}
