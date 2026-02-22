using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Models
{
    public class Project
    {
        private static int _nextId = 1;
        public int Id { get; set; }   
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Project (string name, string description = "")
        {
            Id = _nextId++;
            Name = name;
            Description = description;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
