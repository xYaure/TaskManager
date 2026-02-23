using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Services
{
    public class ProjectService
    {
        private readonly AppData _AppData;
        private int nextId;

        public ProjectService(AppData appData)
        {
            _AppData = appData;
            nextId = _AppData.Projects.Count == 0 ? 1 : _AppData.Projects.Max(p => p.Id) + 1;
        }

        public IReadOnlyList<Project> GetAll()
        {
            return _AppData.Projects.AsReadOnly();
        }

        public Project GetById(int? id)
        {
            Project? project = _AppData.Projects.Find(p => p.Id == id);

            return project ?? throw new KeyNotFoundException($"Project with Id {id} not found.");
        }

        public void Add(Project project)
        {
            project.Id = nextId++;

            _AppData.Projects.Add(project);
            OnProjectChanged();
        }

        public void Update(Project project)
        {
            if (project == null)
                throw new ArgumentNullException(nameof(project));

            var existingProject = GetById(project.Id);

            bool isModified = false;

            if (existingProject.Name != project.Name || existingProject.Description != project.Description)
            {
                isModified = true;
                existingProject.Name = project.Name;
                existingProject.Description = project.Description;

                existingProject.UpdatedAt = DateTime.UtcNow;

                OnProjectChanged();
            }
            else return; // Nie ma zmian, więc nie aktualizujemy i nie wywołujemy zdarzenia


            // Zapisujemy już znormalizowane wartości (spójnie z porównaniem)
        }

        public void Delete(int id)
        {
            var project = _AppData.Projects.Find(p => p.Id == id);
            if (project == null)
                return;

            _AppData.Projects.Remove(project);
            OnProjectChanged();
        }

        public event EventHandler? ProjectChanged;
        public void OnProjectChanged()
        {
            ProjectChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
