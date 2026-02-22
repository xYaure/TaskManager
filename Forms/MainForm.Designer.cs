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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            cmsProjectManage.Size = new Size(241, 101);
            // 
            // emiEditProject
            // 
            emiEditProject.Name = "emiEditProject";
            emiEditProject.Size = new Size(240, 32);
            emiEditProject.Text = "Edytuj";
            emiEditProject.Click += emiEditProject_Click;
            // 
            // emiDeleteProject
            // 
            emiDeleteProject.Name = "emiDeleteProject";
            emiDeleteProject.Size = new Size(240, 32);
            emiDeleteProject.Text = "Usuń";
            emiDeleteProject.Click += emiDeleteProject_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(508, 38);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 108);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 166);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(516, 243);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 862);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flpProjectsPanel);
            Name = "MainForm";
            Text = "Form1";
            flpProjectsPanel.ResumeLayout(false);
            panelAddProject.ResumeLayout(false);
            cmsProjectManage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
