using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Forms 
{
    public partial class ProjectForm : Form
    {
        private AppData _appData;
        private Project SelectedProject;
        private bool IsEditing;
        public ProjectForm(AppData appData, Project selectedProject, bool isEditing)
        {
            InitializeComponent();
            _appData = appData;
            SelectedProject = selectedProject;
            IsEditing = isEditing;

            // Ustawienie tekstu przycisku i wypełnienie pól, jeśli edytujemy istniejący projekt
            btnAddProject.Text = isEditing ? "Zapisz zmiany" : "Dodaj projekt";
            txtName.Text = isEditing ? selectedProject.Name : "";
            rtbDescription.Text = isEditing ? selectedProject.Description : "";
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Description = rtbDescription.Text;

            // Jeśli dodajemy nowy projekt, sprawdzamy, czy nazwa nie jest pusta
            if (!Name.IsWhiteSpace() && !IsEditing)
            {
                Project newProject = new Project(Name, Description);
                _appData.AddProject(newProject);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            else
                DialogResult = DialogResult.Cancel;

            // Jeśli edytujemy istniejący projekt, aktualizujemy jego dane
            SelectedProject.Name = Name;
            SelectedProject.Description = Description;

            _appData.UpdateProject(SelectedProject);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
