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
            tableLayoutPanel1 = new TableLayoutPanel();
            flpLeft = new FlowLayoutPanel();
            flpRight = new FlowLayoutPanel();
            flpProjectHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flpProjectHeader
            // 
            flpProjectHeader.Controls.Add(label1);
            flpProjectHeader.Controls.Add(txtProjectName);
            flpProjectHeader.Controls.Add(label2);
            flpProjectHeader.Controls.Add(rtbProjectDescription);
            flpProjectHeader.Controls.Add(btnProjectModifier);
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
            txtProjectName.BackColor = SystemColors.Menu;
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
            rtbProjectDescription.BackColor = SystemColors.Menu;
            rtbProjectDescription.Location = new Point(2, 71);
            rtbProjectDescription.Margin = new Padding(2);
            rtbProjectDescription.Name = "rtbProjectDescription";
            rtbProjectDescription.Size = new Size(429, 104);
            rtbProjectDescription.TabIndex = 3;
            rtbProjectDescription.Text = "";
            // 
            // btnProjectModifier
            // 
            btnProjectModifier.Dock = DockStyle.Right;
            btnProjectModifier.Location = new Point(435, 2);
            btnProjectModifier.Margin = new Padding(2);
            btnProjectModifier.Name = "btnProjectModifier";
            btnProjectModifier.Size = new Size(78, 23);
            btnProjectModifier.TabIndex = 1;
            btnProjectModifier.Text = "Edytuj";
            btnProjectModifier.UseVisualStyleBackColor = true;
            btnProjectModifier.Click += btnProjectModifier_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flpLeft, 0, 0);
            tableLayoutPanel1.Controls.Add(flpRight, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 177);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(708, 265);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // flpLeft
            // 
            flpLeft.AutoScroll = true;
            flpLeft.Dock = DockStyle.Fill;
            flpLeft.Location = new Point(3, 3);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(348, 259);
            flpLeft.TabIndex = 0;
            // 
            // flpRight
            // 
            flpRight.AutoScroll = true;
            flpRight.Dock = DockStyle.Fill;
            flpRight.Location = new Point(357, 3);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(348, 259);
            flpRight.TabIndex = 1;
            // 
            // ProjectControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flpProjectHeader);
            Margin = new Padding(2);
            Name = "ProjectControl";
            Size = new Size(708, 442);
            Load += ProjectControl_Load;
            flpProjectHeader.ResumeLayout(false);
            flpProjectHeader.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpProjectHeader;
        private Button btnProjectModifier;
        private Label label1;
        private TextBox txtProjectName;
        private Label label2;
        private RichTextBox rtbProjectDescription;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpLeft;
        private FlowLayoutPanel flpRight;
    }
}
