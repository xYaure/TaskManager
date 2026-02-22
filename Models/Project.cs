using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Models
{
    public class Project
    {
        public int Id { get; set; }   
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Project (string name, string description = "")
        {
            Name = name;
            Description = description;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
