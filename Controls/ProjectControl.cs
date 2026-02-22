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
        private readonly AppData _AppData;
        private bool _IsEditing = false;
        public event EventHandler ProjectChanged;

        public ProjectControl(int projectId, AppData appData)
        {
            InitializeComponent();
            _Project = appData.Projects.Find(p => p.Id == projectId);

            _AppData = appData;
            this.Tag = _Project.Id;

        }

        private void btnProjectModifier_Click(object sender, EventArgs e)
        {
            _IsEditing = _IsEditing ? false : true;
            
            _AppData.UpdateProject(_Project);
            ProjectChanged?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateLayout()
        {
            txtProjectName.ReadOnly = true;
            rtbProjectDescription.ReadOnly = true;
            btnProjectModifier.Text = "Edytuj";

            txtProjectName.Text = _Project.Name;
            rtbProjectDescription.Text = _Project.Description;

            rtbProjectDescription.Width = flpProjectHeader.ClientSize.Width - 10;
            txtProjectName.Width = flpProjectHeader.ClientSize.Width - 10;

            txtProjectName.BorderStyle = BorderStyle.None;
            rtbProjectDescription.BorderStyle = BorderStyle.None;

            if (_IsEditing)
            {
                txtProjectName.ReadOnly = false;
                rtbProjectDescription.ReadOnly = false;

                btnProjectModifier.Text = "Zapisz";
            }

        }

        private void ProjectControl_Load(object sender, EventArgs e)
        {
            UpdateLayout();
        }
    }
}
