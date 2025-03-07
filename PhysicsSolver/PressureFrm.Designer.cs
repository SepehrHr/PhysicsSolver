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
            tabControl1.SuspendLayout();
            tabSolid.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPressureSolid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numForce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tabSolid.Text = "Solids";
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
            lblResultSolid.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            tabFluid.Location = new Point(4, 29);
            tabFluid.Name = "tabFluid";
            tabFluid.Padding = new Padding(3);
            tabFluid.Size = new Size(792, 264);
            tabFluid.TabIndex = 1;
            tabFluid.Text = "Fliuds";
            tabFluid.UseVisualStyleBackColor = true;
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
    }
}