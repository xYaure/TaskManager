using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public Task (int projectId, string title, string description)
        {
            Id = Guid.NewGuid();
            ProjectId = projectId;
            Title = title;
            Description = description;
            CreatedDate = DateTime.UtcNow;
        }
    }
}
