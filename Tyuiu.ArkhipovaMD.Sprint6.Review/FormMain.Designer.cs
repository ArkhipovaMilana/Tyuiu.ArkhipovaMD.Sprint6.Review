namespace Tyuiu.ArkhipovaMD.Sprint6.Review
{
    partial class FormMain
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
            dataGridViewMatrix_AMD = new DataGridView();
            textBoxRows_AMD = new TextBox();
            textBoxRandomStart_AMD = new TextBox();
            textBoxColumns_AMD = new TextBox();
            textBoxRandomEnd_AMD = new TextBox();
            textBoxStart_AMD = new TextBox();
            textBoxEnd_AMD = new TextBox();
            textBoxTargetRow_AMD = new TextBox();
            panelActions_AMD = new Panel();
            buttonGenerateMatrix_AMD = new Button();
            buttonCompile_AMD = new Button();
            labelTargetRow_AMD = new Label();
            labelEnd_AMD = new Label();
            labelStart_AMD = new Label();
            labelRandomEnd_AMD = new Label();
            labelRandomStart_AMD = new Label();
            labelCol_AMD = new Label();
            labelRow_AMD = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_AMD).BeginInit();
            panelActions_AMD.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMatrix_AMD
            // 
            dataGridViewMatrix_AMD.AllowUserToAddRows = false;
            dataGridViewMatrix_AMD.AllowUserToDeleteRows = false;
            dataGridViewMatrix_AMD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMatrix_AMD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMatrix_AMD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_AMD.ColumnHeadersVisible = false;
            dataGridViewMatrix_AMD.Dock = DockStyle.Fill;
            dataGridViewMatrix_AMD.Location = new Point(0, 76);
            dataGridViewMatrix_AMD.Name = "dataGridViewMatrix_AMD";
            dataGridViewMatrix_AMD.ReadOnly = true;
            dataGridViewMatrix_AMD.RowHeadersVisible = false;
            dataGridViewMatrix_AMD.Size = new Size(890, 374);
            dataGridViewMatrix_AMD.TabIndex = 0;
            // 
            // textBoxRows_AMD
            // 
            textBoxRows_AMD.Location = new Point(11, 32);
            textBoxRows_AMD.Name = "textBoxRows_AMD";
            textBoxRows_AMD.Size = new Size(100, 23);
            textBoxRows_AMD.TabIndex = 1;
            textBoxRows_AMD.Text = "4";
            // 
            // textBoxRandomStart_AMD
            // 
            textBoxRandomStart_AMD.Location = new Point(223, 32);
            textBoxRandomStart_AMD.Name = "textBoxRandomStart_AMD";
            textBoxRandomStart_AMD.Size = new Size(100, 23);
            textBoxRandomStart_AMD.TabIndex = 2;
            textBoxRandomStart_AMD.Text = "1";
            // 
            // textBoxColumns_AMD
            // 
            textBoxColumns_AMD.Location = new Point(117, 32);
            textBoxColumns_AMD.Name = "textBoxColumns_AMD";
            textBoxColumns_AMD.Size = new Size(100, 23);
            textBoxColumns_AMD.TabIndex = 3;
            textBoxColumns_AMD.Text = "5";
            // 
            // textBoxRandomEnd_AMD
            // 
            textBoxRandomEnd_AMD.Location = new Point(328, 32);
            textBoxRandomEnd_AMD.Name = "textBoxRandomEnd_AMD";
            textBoxRandomEnd_AMD.Size = new Size(100, 23);
            textBoxRandomEnd_AMD.TabIndex = 4;
            textBoxRandomEnd_AMD.Text = "100";
            // 
            // textBoxStart_AMD
            // 
            textBoxStart_AMD.Location = new Point(434, 32);
            textBoxStart_AMD.Name = "textBoxStart_AMD";
            textBoxStart_AMD.Size = new Size(100, 23);
            textBoxStart_AMD.TabIndex = 5;
            textBoxStart_AMD.Text = "2";
            // 
            // textBoxEnd_AMD
            // 
            textBoxEnd_AMD.Location = new Point(540, 32);
            textBoxEnd_AMD.Name = "textBoxEnd_AMD";
            textBoxEnd_AMD.Size = new Size(100, 23);
            textBoxEnd_AMD.TabIndex = 6;
            textBoxEnd_AMD.Text = "4";
            // 
            // textBoxTargetRow_AMD
            // 
            textBoxTargetRow_AMD.Location = new Point(646, 32);
            textBoxTargetRow_AMD.Name = "textBoxTargetRow_AMD";
            textBoxTargetRow_AMD.Size = new Size(100, 23);
            textBoxTargetRow_AMD.TabIndex = 7;
            textBoxTargetRow_AMD.Text = "3";
            // 
            // panelActions_AMD
            // 
            panelActions_AMD.BackColor = SystemColors.ActiveCaption;
            panelActions_AMD.BackgroundImageLayout = ImageLayout.Center;
            panelActions_AMD.Controls.Add(buttonGenerateMatrix_AMD);
            panelActions_AMD.Controls.Add(buttonCompile_AMD);
            panelActions_AMD.Controls.Add(labelTargetRow_AMD);
            panelActions_AMD.Controls.Add(labelEnd_AMD);
            panelActions_AMD.Controls.Add(labelStart_AMD);
            panelActions_AMD.Controls.Add(labelRandomEnd_AMD);
            panelActions_AMD.Controls.Add(labelRandomStart_AMD);
            panelActions_AMD.Controls.Add(labelCol_AMD);
            panelActions_AMD.Controls.Add(textBoxRandomStart_AMD);
            panelActions_AMD.Controls.Add(textBoxColumns_AMD);
            panelActions_AMD.Controls.Add(labelRow_AMD);
            panelActions_AMD.Controls.Add(textBoxRandomEnd_AMD);
            panelActions_AMD.Controls.Add(textBoxStart_AMD);
            panelActions_AMD.Controls.Add(textBoxEnd_AMD);
            panelActions_AMD.Controls.Add(textBoxTargetRow_AMD);
            panelActions_AMD.Controls.Add(textBoxRows_AMD);
            panelActions_AMD.Dock = DockStyle.Top;
            panelActions_AMD.Location = new Point(0, 0);
            panelActions_AMD.Name = "panelActions_AMD";
            panelActions_AMD.Size = new Size(890, 76);
            panelActions_AMD.TabIndex = 8;
            // 
            // buttonGenerateMatrix_AMD
            // 
            buttonGenerateMatrix_AMD.Location = new Point(820, 12);
            buttonGenerateMatrix_AMD.Name = "buttonGenerateMatrix_AMD";
            buttonGenerateMatrix_AMD.Size = new Size(62, 56);
            buttonGenerateMatrix_AMD.TabIndex = 16;
            buttonGenerateMatrix_AMD.Text = "Generate";
            buttonGenerateMatrix_AMD.UseVisualStyleBackColor = true;
            buttonGenerateMatrix_AMD.Click += buttonGenerateMatrix_AMD_Click;
            // 
            // buttonCompile_AMD
            // 
            buttonCompile_AMD.Location = new Point(752, 12);
            buttonCompile_AMD.Name = "buttonCompile_AMD";
            buttonCompile_AMD.Size = new Size(62, 56);
            buttonCompile_AMD.TabIndex = 15;
            buttonCompile_AMD.Text = "Compile";
            buttonCompile_AMD.UseVisualStyleBackColor = true;
            buttonCompile_AMD.Click += buttonCompile_AMD_Click;
            // 
            // labelTargetRow_AMD
            // 
            labelTargetRow_AMD.AutoSize = true;
            labelTargetRow_AMD.Location = new Point(646, 14);
            labelTargetRow_AMD.Name = "labelTargetRow_AMD";
            labelTargetRow_AMD.Size = new Size(89, 15);
            labelTargetRow_AMD.TabIndex = 14;
            labelTargetRow_AMD.Text = "Target Row (R) :";
            // 
            // labelEnd_AMD
            // 
            labelEnd_AMD.AutoSize = true;
            labelEnd_AMD.Location = new Point(540, 14);
            labelEnd_AMD.Name = "labelEnd_AMD";
            labelEnd_AMD.Size = new Size(96, 15);
            labelEnd_AMD.TabIndex = 13;
            labelEnd_AMD.Text = "End Position (L) :";
            // 
            // labelStart_AMD
            // 
            labelStart_AMD.AutoSize = true;
            labelStart_AMD.Location = new Point(434, 14);
            labelStart_AMD.Name = "labelStart_AMD";
            labelStart_AMD.Size = new Size(101, 15);
            labelStart_AMD.TabIndex = 12;
            labelStart_AMD.Text = "Start Position (K) :";
            // 
            // labelRandomEnd_AMD
            // 
            labelRandomEnd_AMD.AutoSize = true;
            labelRandomEnd_AMD.Location = new Point(328, 14);
            labelRandomEnd_AMD.Name = "labelRandomEnd_AMD";
            labelRandomEnd_AMD.Size = new Size(107, 15);
            labelRandomEnd_AMD.TabIndex = 11;
            labelRandomEnd_AMD.Text = "Random End (N2) :";
            // 
            // labelRandomStart_AMD
            // 
            labelRandomStart_AMD.AutoSize = true;
            labelRandomStart_AMD.Location = new Point(223, 14);
            labelRandomStart_AMD.Name = "labelRandomStart_AMD";
            labelRandomStart_AMD.Size = new Size(111, 15);
            labelRandomStart_AMD.TabIndex = 10;
            labelRandomStart_AMD.Text = "Random Start (N1) :";
            // 
            // labelCol_AMD
            // 
            labelCol_AMD.AutoSize = true;
            labelCol_AMD.Location = new Point(117, 14);
            labelCol_AMD.Name = "labelCol_AMD";
            labelCol_AMD.Size = new Size(83, 15);
            labelCol_AMD.TabIndex = 9;
            labelCol_AMD.Text = "Columns (M) :";
            // 
            // labelRow_AMD
            // 
            labelRow_AMD.AutoSize = true;
            labelRow_AMD.Location = new Point(11, 14);
            labelRow_AMD.Name = "labelRow_AMD";
            labelRow_AMD.Size = new Size(61, 15);
            labelRow_AMD.TabIndex = 8;
            labelRow_AMD.Text = "Rows (N) :";
            // 
            // FormMain
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 450);
            Controls.Add(dataGridViewMatrix_AMD);
            Controls.Add(panelActions_AMD);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint 6 | Review | Arkhipova M. D.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_AMD).EndInit();
            panelActions_AMD.ResumeLayout(false);
            panelActions_AMD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMatrix_AMD;
        private TextBox textBoxRows_AMD;
        private TextBox textBoxRandomStart_AMD;
        private TextBox textBoxColumns_AMD;
        private TextBox textBoxRandomEnd_AMD;
        private TextBox textBoxStart_AMD;
        private TextBox textBoxEnd_AMD;
        private TextBox textBoxTargetRow_AMD;
        private Panel panelActions_AMD;
        private Label labelTargetRow_AMD;
        private Label labelEnd_AMD;
        private Label labelStart_AMD;
        private Label labelRandomEnd_AMD;
        private Label labelRandomStart_AMD;
        private Label labelCol_AMD;
        private Label labelRow_AMD;
        private Button buttonCompile_AMD;
        private Button buttonGenerateMatrix_AMD;
    }
}
