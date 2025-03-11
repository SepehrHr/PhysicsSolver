namespace PhysicsSolver
{
    partial class PressureFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PressureFrm));
            tabControl1 = new TabControl();
            tabSolid = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            numPressureSolid = new NumericUpDown();
            numArea = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            CalculateSolids = new Button();
            lblForceResult = new Label();
            lblAreaResult = new Label();
            lblPressureSolidResult = new Label();
            numForce = new NumericUpDown();
            lblResultSolid = new Label();
            pictureBox1 = new PictureBox();
            tabFluid = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            numericUpDown3 = new NumericUpDown();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            tabSolid.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPressureSolid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numForce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabFluid.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabSolid);
            tabControl1.Controls.Add(tabFluid);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 297);
            tabControl1.TabIndex = 0;
            // 
            // tabSolid
            // 
            tabSolid.Controls.Add(tableLayoutPanel1);
            tabSolid.Controls.Add(pictureBox1);
            tabSolid.Location = new Point(4, 29);
            tabSolid.Name = "tabSolid";
            tabSolid.Padding = new Padding(3);
            tabSolid.Size = new Size(792, 264);
            tabSolid.TabIndex = 0;
            tabSolid.Text = "Pressure in Solids";
            tabSolid.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(numPressureSolid, 1, 2);
            tableLayoutPanel1.Controls.Add(numArea, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(CalculateSolids, 0, 3);
            tableLayoutPanel1.Controls.Add(lblForceResult, 2, 0);
            tableLayoutPanel1.Controls.Add(lblAreaResult, 2, 1);
            tableLayoutPanel1.Controls.Add(lblPressureSolidResult, 2, 2);
            tableLayoutPanel1.Controls.Add(numForce, 1, 0);
            tableLayoutPanel1.Controls.Add(lblResultSolid, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 125);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(786, 136);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // numPressureSolid
            // 
            numPressureSolid.Dock = DockStyle.Fill;
            numPressureSolid.Location = new Point(160, 71);
            numPressureSolid.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numPressureSolid.Name = "numPressureSolid";
            numPressureSolid.Size = new Size(190, 27);
            numPressureSolid.TabIndex = 6;
            numPressureSolid.ThousandsSeparator = true;
            // 
            // numArea
            // 
            numArea.Dock = DockStyle.Fill;
            numArea.Location = new Point(160, 37);
            numArea.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numArea.Name = "numArea";
            numArea.Size = new Size(190, 27);
            numArea.TabIndex = 5;
            numArea.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Force (N):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 34);
            label1.Name = "label1";
            label1.Size = new Size(99, 34);
            label1.TabIndex = 0;
            label1.Text = "Area (Square meters):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 68);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 0;
            label3.Text = "Pressure (Pa):";
            // 
            // CalculateSolids
            // 
            tableLayoutPanel1.SetColumnSpan(CalculateSolids, 4);
            CalculateSolids.Dock = DockStyle.Fill;
            CalculateSolids.Location = new Point(70, 105);
            CalculateSolids.Margin = new Padding(70, 3, 70, 3);
            CalculateSolids.Name = "CalculateSolids";
            CalculateSolids.Size = new Size(646, 28);
            CalculateSolids.TabIndex = 2;
            CalculateSolids.Text = "Calculate";
            CalculateSolids.UseVisualStyleBackColor = true;
            CalculateSolids.Click += CalculateSolids_Click;
            // 
            // lblForceResult
            // 
            lblForceResult.AutoSize = true;
            lblForceResult.Location = new Point(356, 0);
            lblForceResult.Name = "lblForceResult";
            lblForceResult.Size = new Size(0, 20);
            lblForceResult.TabIndex = 3;
            // 
            // lblAreaResult
            // 
            lblAreaResult.AutoSize = true;
            lblAreaResult.Location = new Point(356, 34);
            lblAreaResult.Name = "lblAreaResult";
            lblAreaResult.Size = new Size(0, 20);
            lblAreaResult.TabIndex = 3;
            // 
            // lblPressureSolidResult
            // 
            lblPressureSolidResult.AutoSize = true;
            lblPressureSolidResult.Location = new Point(356, 68);
            lblPressureSolidResult.Name = "lblPressureSolidResult";
            lblPressureSolidResult.Size = new Size(0, 20);
            lblPressureSolidResult.TabIndex = 3;
            // 
            // numForce
            // 
            numForce.Dock = DockStyle.Fill;
            numForce.Location = new Point(160, 3);
            numForce.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numForce.Name = "numForce";
            numForce.Size = new Size(190, 27);
            numForce.TabIndex = 4;
            numForce.ThousandsSeparator = true;
            // 
            // lblResultSolid
            // 
            lblResultSolid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResultSolid.AutoSize = true;
            lblResultSolid.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultSolid.Location = new Point(513, 0);
            lblResultSolid.Name = "lblResultSolid";
            tableLayoutPanel1.SetRowSpan(lblResultSolid, 3);
            lblResultSolid.Size = new Size(270, 102);
            lblResultSolid.TabIndex = 7;
            lblResultSolid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(786, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabFluid
            // 
            tabFluid.Controls.Add(tableLayoutPanel2);
            tabFluid.Controls.Add(pictureBox2);
            tabFluid.Location = new Point(4, 29);
            tabFluid.Name = "tabFluid";
            tabFluid.Padding = new Padding(3);
            tabFluid.Size = new Size(792, 264);
            tabFluid.TabIndex = 1;
            tabFluid.Text = "Pressure in Fliuds";
            tabFluid.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(numericUpDown1, 1, 2);
            tableLayoutPanel2.Controls.Add(numericUpDown2, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(button1, 0, 3);
            tableLayoutPanel2.Controls.Add(label7, 2, 0);
            tableLayoutPanel2.Controls.Add(label8, 2, 1);
            tableLayoutPanel2.Controls.Add(label9, 2, 2);
            tableLayoutPanel2.Controls.Add(numericUpDown3, 1, 0);
            tableLayoutPanel2.Controls.Add(label10, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 125);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(786, 136);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Location = new Point(160, 71);
            numericUpDown1.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(190, 27);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Dock = DockStyle.Fill;
            numericUpDown2.Location = new Point(160, 37);
            numericUpDown2.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(190, 27);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.ThousandsSeparator = true;
            numericUpDown2.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 0;
            label4.Text = "ρ (Density):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 34);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 0;
            label5.Text = "Gravity (m/s2):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 68);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 0;
            label6.Text = "height (m):";
            // 
            // button1
            // 
            tableLayoutPanel2.SetColumnSpan(button1, 4);
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(70, 105);
            button1.Margin = new Padding(70, 3, 70, 3);
            button1.Name = "button1";
            button1.Size = new Size(646, 28);
            button1.TabIndex = 2;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(356, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 34);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(356, 68);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 3;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Dock = DockStyle.Fill;
            numericUpDown3.Location = new Point(160, 3);
            numericUpDown3.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(190, 27);
            numericUpDown3.TabIndex = 4;
            numericUpDown3.ThousandsSeparator = true;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(513, 0);
            label10.Name = "label10";
            tableLayoutPanel2.SetRowSpan(label10, 3);
            label10.Size = new Size(270, 102);
            label10.TabIndex = 7;
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(786, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // PressureFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 297);
            Controls.Add(tabControl1);
            Name = "PressureFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PressureFrm";
            Load += PressureFrm_Load;
            tabControl1.ResumeLayout(false);
            tabSolid.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPressureSolid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)numForce).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabFluid.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabSolid;
        private TabPage tabFluid;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button CalculateSolids;
        private Label lblForceResult;
        private Label lblAreaResult;
        private Label lblPressureSolidResult;
        private NumericUpDown numForce;
        private NumericUpDown numPressureSolid;
        private NumericUpDown numArea;
        private Label lblResultSolid;
        private TableLayoutPanel tableLayoutPanel2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown numericUpDown3;
        private Label label10;
        private PictureBox pictureBox2;
    }
}