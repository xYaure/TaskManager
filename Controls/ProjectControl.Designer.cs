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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txtProjectName = new TextBox();
            label2 = new Label();
            rtbProjectDescription = new RichTextBox();
            btnProjectModifier = new Button();
            label3 = new Label();
            label4 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtProjectName);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(rtbProjectDescription);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1012, 277);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 0;
            label1.Text = "Nazwa projektu";
            // 
            // txtProjectName
            // 
            txtProjectName.Font = new Font("Segoe UI", 10F);
            txtProjectName.Location = new Point(3, 35);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(150, 34);
            txtProjectName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(3, 72);
            label2.Name = "label2";
            label2.Size = new Size(52, 28);
            label2.TabIndex = 2;
            label2.Text = "Opis";
            // 
            // rtbProjectDescription
            // 
            rtbProjectDescription.Location = new Point(3, 103);
            rtbProjectDescription.Name = "rtbProjectDescription";
            rtbProjectDescription.Size = new Size(1006, 170);
            rtbProjectDescription.TabIndex = 3;
            rtbProjectDescription.Text = "";
            // 
            // btnProjectModifier
            // 
            btnProjectModifier.Location = new Point(897, 700);
            btnProjectModifier.Name = "btnProjectModifier";
            btnProjectModifier.Size = new Size(112, 34);
            btnProjectModifier.TabIndex = 1;
            btnProjectModifier.Text = "Edytuj";
            btnProjectModifier.UseVisualStyleBackColor = true;
            btnProjectModifier.Click += btnProjectModifier_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 333);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(370, 444);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // ProjectControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnProjectModifier);
            Controls.Add(flowLayoutPanel1);
            Name = "ProjectControl";
            Size = new Size(1012, 737);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnProjectModifier;
        private Label label1;
        private TextBox txtProjectName;
        private Label label2;
        private RichTextBox rtbProjectDescription;
        private Label label3;
        private Label label4;
    }
}
