using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Models;

namespace TaskManager.Data
{
    public class AppData
    {
        public List<Models.Project> Projects { get; set; }
        public List<Models.Task> Tasks { get; set; }
    
        public AppData()
        {
            Projects = new List<Models.Project>();
            Tasks = new List<Models.Task>();
        }

        public void AddProject(Models.Project project)
        {
            Projects.Add(project);
        }

        public void AddTask(Models.Task task)
        {
            Tasks.Add(task);
        }

        public void UpdateProject(Models.Project project)
        {
            var existingProject = Projects.Find(p => p.Id == project.Id);
            if (existingProject != null)
            {
                existingProject.Name = project.Name;
                existingProject.Description = project.Description;
                existingProject.UpdatedAt = DateTime.UtcNow;
            }
        }

        public void DeleteProject(Project project)
        {
            int projectId = project.Id;

            Projects.RemoveAll(p => p.Id == projectId);
            Tasks.RemoveAll(t => t.ProjectId == projectId);
        }

    }
}
