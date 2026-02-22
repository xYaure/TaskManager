namespace TaskManager.Forms
{
    partial class ProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            rtbDescription = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            btnAddProject = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(38, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(226, 31);
            txtName.TabIndex = 0;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(38, 116);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(226, 144);
            rtbDescription.TabIndex = 1;
            rtbDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 2;
            label1.Text = "Nazwa projektu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 88);
            label2.Name = "label2";
            label2.Size = new Size(226, 25);
            label2.TabIndex = 3;
            label2.Text = "Opis projektu (opcjonalnie)";
            // 
            // btnAddProject
            // 
            btnAddProject.Location = new Point(78, 266);
            btnAddProject.Name = "btnAddProject";
            btnAddProject.Size = new Size(151, 34);
            btnAddProject.TabIndex = 4;
            btnAddProject.Text = "Dodaj";
            btnAddProject.UseVisualStyleBackColor = true;
            btnAddProject.Click += btnAddProject_Click;
            // 
            // AddProjectForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 323);
            Controls.Add(btnAddProject);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbDescription);
            Controls.Add(txtName);
            Name = "AddProjectForm";
            Text = "AddProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private RichTextBox rtbDescription;
        private Label label1;
        private Label label2;
        private Button btnAddProject;
    }
}