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

            flpLeft.AllowDrop = true;
            flpRight.AllowDrop = true;

            flpRight.DragEnter += Flp_DragEnter;
            flpLeft.DragEnter += Flp_DragEnter;

            flpRight.DragDrop += FlpRight_DragDrop;
            flpLeft.DragDrop += FlpLeft_DragDrop;

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

        private void Flp_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data != null && e.Data.GetDataPresent(typeof(Control)))
                ? DragDropEffects.Move
                : DragDropEffects.None;

            System.Diagnostics.Debug.WriteLine("DragEnter fired");
        }

        private void FlpRight_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null) return;

            var ctrl = e.Data.GetData(typeof(Control)) as Control;
            if (ctrl == null) return;

            // jeśli już w prawym, nic nie rób
            if (ctrl.Parent == flpRight) return;

            // usuń ze starego rodzica i dodaj do nowego
            var oldParent = ctrl.Parent as FlowLayoutPanel;
            oldParent?.Controls.Remove(ctrl);
            flpRight.Controls.Add(ctrl);
        }

        private void FlpLeft_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null) return;

            var ctrl = e.Data.GetData(typeof(TaskControl)) as TaskControl;
            if (ctrl == null) return;

            if (ctrl.Parent == flpLeft) return;

            var oldParent = ctrl.Parent as FlowLayoutPanel;
            oldParent?.Controls.Remove(ctrl);
            flpLeft.Controls.Add(ctrl);
        }

        private void Flp_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data != null && e.Data.GetDataPresent(typeof(TaskControl)))
                ? DragDropEffects.Move
                : DragDropEffects.None;
        }

        private void ProjectControl_Load(object sender, EventArgs e)
        {
            UpdateLayout();
            flpLeft.Controls.Add(new TaskControl(1, "Zrobić UI listy"));
            flpLeft.Controls.Add(new TaskControl(2, "Dodać zapis JSON"));
            flpLeft.Controls.Add(new TaskControl(3, "Naprawić UpdatedAt"));

            flpLeft.AllowDrop = true;
            flpRight.AllowDrop = true;

            flpLeft.DragEnter += Flp_DragEnter;
            flpRight.DragEnter += Flp_DragEnter;

            flpLeft.DragOver += Flp_DragOver;
            flpRight.DragOver += Flp_DragOver;

            flpLeft.DragDrop += FlpLeft_DragDrop;
            flpRight.DragDrop += FlpRight_DragDrop;

        }
    }
}
