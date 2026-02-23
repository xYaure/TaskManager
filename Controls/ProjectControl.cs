using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManager.Data;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager.Controls
{
    public partial class ProjectControl : UserControl
    {
        private readonly Project _Project;
        private readonly ProjectService _ProjectService;
        private bool _IsEditing = false;

        public ProjectControl(int projectId, ProjectService projectService)
        {
            InitializeComponent();
            _ProjectService = projectService;
            _Project = _ProjectService.GetById(projectId);

            txtProjectName.Text = _Project.Name;
            rtbProjectDescription.Text = _Project.Description;
        }

        private void btnProjectModifier_Click(object sender, EventArgs e)
        {
            _IsEditing = !_IsEditing;


            if (!_IsEditing)
            {
                Project p = new Project(txtProjectName.Text, rtbProjectDescription.Text)
                {
                    Id = _Project.Id,
                    CreatedAt = _Project.CreatedAt
                };
                _ProjectService.Update(p);
            }

            UpdateLayout();

        }

        private void UpdateLayout()
        {
            flpProjectHeader.SuspendLayout();


            rtbProjectDescription.Width = flpProjectHeader.ClientSize.Width - 10;
            txtProjectName.Width = flpProjectHeader.ClientSize.Width - 10;

            txtProjectName.BorderStyle = BorderStyle.None;
            rtbProjectDescription.BorderStyle = BorderStyle.None;

            txtProjectName.BackColor = Color.FromName("Menu");
            rtbProjectDescription.BackColor = Color.FromName("Menu");


            if (_IsEditing)
            {
                txtProjectName.ReadOnly = false;
                rtbProjectDescription.ReadOnly = false;

                txtProjectName.BackColor = Color.White;
                rtbProjectDescription.BackColor = Color.White;

                btnProjectModifier.Text = "Zapisz";
            } else
            {
                txtProjectName.ReadOnly = true;
                rtbProjectDescription.ReadOnly = true;
                btnProjectModifier.Text = "Edytuj";
            }

            flpProjectHeader.ResumeLayout();

        }

        private void ProjectControl_Load(object sender, EventArgs e)
        {
            UpdateLayout();
        }
    }
}
