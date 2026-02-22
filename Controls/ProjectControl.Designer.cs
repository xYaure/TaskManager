namespace TaskManager.Controls
{
    partial class ProjectControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            flpProjectHeader = new FlowLayoutPanel();
            label1 = new Label();
            txtProjectName = new TextBox();
            label2 = new Label();
            rtbProjectDescription = new RichTextBox();
            btnProjectModifier = new Button();
            flpProjectHeader.SuspendLayout();
            SuspendLayout();
            // 
            // flpProjectHeader
            // 
            flpProjectHeader.Controls.Add(label1);
            flpProjectHeader.Controls.Add(txtProjectName);
            flpProjectHeader.Controls.Add(label2);
            flpProjectHeader.Controls.Add(rtbProjectDescription);
            flpProjectHeader.Dock = DockStyle.Top;
            flpProjectHeader.FlowDirection = FlowDirection.TopDown;
            flpProjectHeader.Location = new Point(0, 0);
            flpProjectHeader.Margin = new Padding(2);
            flpProjectHeader.Name = "flpProjectHeader";
            flpProjectHeader.Size = new Size(708, 177);
            flpProjectHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 0;
            label1.Text = "Nazwa projektu";
            // 
            // txtProjectName
            // 
            txtProjectName.Font = new Font("Segoe UI", 10F);
            txtProjectName.Location = new Point(2, 23);
            txtProjectName.Margin = new Padding(2);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(119, 25);
            txtProjectName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(2, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 19);
            label2.TabIndex = 2;
            label2.Text = "Opis";
            // 
            // rtbProjectDescription
            // 
            rtbProjectDescription.Location = new Point(2, 71);
            rtbProjectDescription.Margin = new Padding(2);
            rtbProjectDescription.Name = "rtbProjectDescription";
            rtbProjectDescription.Size = new Size(429, 104);
            rtbProjectDescription.TabIndex = 3;
            rtbProjectDescription.Text = "";
            // 
            // btnProjectModifier
            // 
            btnProjectModifier.Location = new Point(628, 420);
            btnProjectModifier.Margin = new Padding(2);
            btnProjectModifier.Name = "btnProjectModifier";
            btnProjectModifier.Size = new Size(78, 20);
            btnProjectModifier.TabIndex = 1;
            btnProjectModifier.Text = "Edytuj";
            btnProjectModifier.UseVisualStyleBackColor = true;
            btnProjectModifier.Click += btnProjectModifier_Click;
            // 
            // ProjectControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnProjectModifier);
            Controls.Add(flpProjectHeader);
            Margin = new Padding(2);
            Name = "ProjectControl";
            Size = new Size(708, 442);
            Load += ProjectControl_Load;
            flpProjectHeader.ResumeLayout(false);
            flpProjectHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpProjectHeader;
        private Button btnProjectModifier;
        private Label label1;
        private TextBox txtProjectName;
        private Label label2;
        private RichTextBox rtbProjectDescription;
    }
}
