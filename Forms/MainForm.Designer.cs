namespace TaskManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flpProjectsPanel = new FlowLayoutPanel();
            panelAddProject = new Panel();
            btnAddProject = new Button();
            lvProjectsList = new ListView();
            ProjectId = new ColumnHeader();
            ProjectName = new ColumnHeader();
            cmsProjectManage = new ContextMenuStrip(components);
            emiEditProject = new ToolStripMenuItem();
            emiDeleteProject = new ToolStripMenuItem();
            panelProjectView = new Panel();
            flpProjectsPanel.SuspendLayout();
            panelAddProject.SuspendLayout();
            cmsProjectManage.SuspendLayout();
            SuspendLayout();
            // 
            // flpProjectsPanel
            // 
            flpProjectsPanel.Controls.Add(panelAddProject);
            flpProjectsPanel.Controls.Add(lvProjectsList);
            flpProjectsPanel.Dock = DockStyle.Left;
            flpProjectsPanel.Location = new Point(0, 0);
            flpProjectsPanel.Name = "flpProjectsPanel";
            flpProjectsPanel.Size = new Size(322, 862);
            flpProjectsPanel.TabIndex = 0;
            // 
            // panelAddProject
            // 
            panelAddProject.Controls.Add(btnAddProject);
            panelAddProject.Location = new Point(3, 3);
            panelAddProject.Name = "panelAddProject";
            panelAddProject.Size = new Size(319, 60);
            panelAddProject.TabIndex = 0;
            // 
            // btnAddProject
            // 
            btnAddProject.Location = new Point(9, 9);
            btnAddProject.Name = "btnAddProject";
            btnAddProject.Size = new Size(307, 48);
            btnAddProject.TabIndex = 0;
            btnAddProject.Text = "Dodaj nowy projekt";
            btnAddProject.UseVisualStyleBackColor = true;
            btnAddProject.Click += btnAddProject_Click;
            // 
            // lvProjectsList
            // 
            lvProjectsList.Columns.AddRange(new ColumnHeader[] { ProjectId, ProjectName });
            lvProjectsList.ContextMenuStrip = cmsProjectManage;
            lvProjectsList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvProjectsList.Location = new Point(3, 69);
            lvProjectsList.MultiSelect = false;
            lvProjectsList.Name = "lvProjectsList";
            lvProjectsList.Size = new Size(316, 793);
            lvProjectsList.TabIndex = 1;
            lvProjectsList.UseCompatibleStateImageBehavior = false;
            lvProjectsList.View = View.Details;
            lvProjectsList.Click += ProjectList_Click;
            // 
            // ProjectId
            // 
            ProjectId.Text = "Id";
            // 
            // ProjectName
            // 
            ProjectName.Text = "Nazwa";
            // 
            // cmsProjectManage
            // 
            cmsProjectManage.ImageScalingSize = new Size(24, 24);
            cmsProjectManage.Items.AddRange(new ToolStripItem[] { emiEditProject, emiDeleteProject });
            cmsProjectManage.Name = "cmsProjectManage";
            cmsProjectManage.Size = new Size(134, 68);
            // 
            // emiEditProject
            // 
            emiEditProject.Name = "emiEditProject";
            emiEditProject.Size = new Size(133, 32);
            emiEditProject.Text = "Edytuj";
            emiEditProject.Click += emiEditProject_Click;
            // 
            // emiDeleteProject
            // 
            emiDeleteProject.Name = "emiDeleteProject";
            emiDeleteProject.Size = new Size(133, 32);
            emiDeleteProject.Text = "Usuń";
            emiDeleteProject.Click += emiDeleteProject_Click;
            // 
            // panelProjectView
            // 
            panelProjectView.Dock = DockStyle.Fill;
            panelProjectView.Location = new Point(322, 0);
            panelProjectView.Name = "panelProjectView";
            panelProjectView.Size = new Size(1012, 862);
            panelProjectView.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 862);
            Controls.Add(panelProjectView);
            Controls.Add(flpProjectsPanel);
            Name = "MainForm";
            Text = "Form1";
            flpProjectsPanel.ResumeLayout(false);
            panelAddProject.ResumeLayout(false);
            cmsProjectManage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpProjectsPanel;
        private Panel panelAddProject;
        private Button btnAddProject;
        private ListView lvProjectsList;
        private ColumnHeader ProjectId;
        private ColumnHeader ProjectName;
        private ContextMenuStrip cmsProjectManage;
        private ToolStripMenuItem emiEditProject;
        private ToolStripMenuItem emiDeleteProject;
        private Panel panelProjectView;
    }
}
