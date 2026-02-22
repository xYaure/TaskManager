using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Models;

namespace TaskManager.Data
{
    public class AppData
    {
        private int _nextProjectId = 1;
        public List<Project> Projects { get; set; }
        public List<Models.Task> Tasks { get; set; }
    
        public AppData()
        {
            Projects = new List<Project>();
            Tasks = new List<Models.Task>();
        }

        public void AddProject(Project project)
        {
            project.Id = _nextProjectId++;
            Projects.Add(project);
        }

        public void AddTask(Models.Task task)
        {
            Tasks.Add(task);
        }

        public void UpdateProject(Project project)
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
