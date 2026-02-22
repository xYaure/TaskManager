using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Controls
{
    public partial class ProjectControl : UserControl
    {
        private readonly Project _Project;
        private AppData _AppData;
        private bool _IsEditing = false;

        public ProjectControl(Project project,AppData appData)
        {
            InitializeComponent();
            _Project = appData.Projects.Find(p => p.Id == project.Id);

            txtProjectName.ReadOnly = true;
            rtbProjectDescription.ReadOnly = true;

            txtProjectName.Text = _Project.Name;
            rtbProjectDescription.Text = _Project.Description;

            label3.Text = _Project.CreatedAt.ToString();
            label4.Text = _Project.UpdatedAt.ToString();
            _AppData = appData;
        }

        public void btnProjectModifier_Click(object sender, EventArgs e)
        {
            _IsEditing = _IsEditing ? false : true;

            if (_IsEditing)
            {
                txtProjectName.ReadOnly = false;
                rtbProjectDescription.ReadOnly = false;
                btnProjectModifier.Text = "Zapisz";
                return;
            }

            txtProjectName.ReadOnly = true;
            rtbProjectDescription.ReadOnly = true;
            btnProjectModifier.Text = "Edytuj";

            UpdateProject();

            _AppData.UpdateProject(_Project);
            ProjectChanged?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateProject()
        {
            _Project.Name = txtProjectName.Text;
            _Project.Description = rtbProjectDescription.Text;
            _Project.UpdatedAt = DateTime.UtcNow;

            label4.Text = _Project.UpdatedAt.ToString();
        }

        public event EventHandler ProjectChanged;
    }
}
