namespace PhysicsSolver
{
    partial class Density
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Density));
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbMassUnit = new ComboBox();
            numRho = new NumericUpDown();
            numVolume = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnCalculate = new Button();
            lblMass = new Label();
            lblVolume = new Label();
            lblRho = new Label();
            numMass = new NumericUpDown();
            cmbVolumeUnit = new ComboBox();
            cmbRhoUnit = new ComboBox();
            lblResult = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rd1Solid = new RadioButton();
            rd2Solid = new RadioButton();
            rd3Solid = new RadioButton();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMass).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 297);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculate Density";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.5122F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5853653F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.804878F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.5121956F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.5853653F));
            tableLayoutPanel1.Controls.Add(cmbMassUnit, 2, 0);
            tableLayoutPanel1.Controls.Add(numRho, 1, 2);
            tableLayoutPanel1.Controls.Add(numVolume, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(btnCalculate, 0, 3);
            tableLayoutPanel1.Controls.Add(lblMass, 3, 0);
            tableLayoutPanel1.Controls.Add(lblVolume, 3, 1);
            tableLayoutPanel1.Controls.Add(lblRho, 3, 2);
            tableLayoutPanel1.Controls.Add(numMass, 1, 0);
            tableLayoutPanel1.Controls.Add(cmbVolumeUnit, 2, 1);
            tableLayoutPanel1.Controls.Add(cmbRhoUnit, 2, 2);
            tableLayoutPanel1.Controls.Add(lblResult, 4, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 145);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(794, 149);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // cmbMassUnit
            // 
            cmbMassUnit.Dock = DockStyle.Fill;
            cmbMassUnit.FormattingEnabled = true;
            cmbMassUnit.Items.AddRange(new object[] { "Kg", "g" });
            cmbMassUnit.Location = new Point(288, 3);
            cmbMassUnit.Name = "cmbMassUnit";
            cmbMassUnit.Size = new Size(55, 28);
            cmbMassUnit.TabIndex = 2;
            // 
            // numRho
            // 
            numRho.Dock = DockStyle.Fill;
            numRho.Location = new Point(157, 77);
            numRho.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numRho.Name = "numRho";
            numRho.Size = new Size(125, 27);
            numRho.TabIndex = 5;
            numRho.ThousandsSeparator = true;
            // 
            // numVolume
            // 
            numVolume.Dock = DockStyle.Fill;
            numVolume.Location = new Point(157, 40);
            numVolume.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numVolume.Name = "numVolume";
            numVolume.Size = new Size(125, 27);
            numVolume.TabIndex = 3;
            numVolume.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 0;
            label2.Text = "mass:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Volume:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 74);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 0;
            label3.Text = "ρ (Density):";
            // 
            // btnCalculate
            // 
            tableLayoutPanel1.SetColumnSpan(btnCalculate, 5);
            btnCalculate.Dock = DockStyle.Fill;
            btnCalculate.Location = new Point(80, 114);
            btnCalculate.Margin = new Padding(80, 3, 80, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(634, 32);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblMass
            // 
            lblMass.AutoSize = true;
            lblMass.Location = new Point(349, 0);
            lblMass.Name = "lblMass";
            lblMass.Size = new Size(0, 20);
            lblMass.TabIndex = 3;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Location = new Point(349, 37);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(0, 20);
            lblVolume.TabIndex = 3;
            // 
            // lblRho
            // 
            lblRho.AutoSize = true;
            lblRho.Location = new Point(349, 74);
            lblRho.Name = "lblRho";
            lblRho.Size = new Size(0, 20);
            lblRho.TabIndex = 3;
            // 
            // numMass
            // 
            numMass.Dock = DockStyle.Left;
            numMass.Location = new Point(157, 3);
            numMass.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numMass.Name = "numMass";
            numMass.Size = new Size(124, 27);
            numMass.TabIndex = 1;
            numMass.ThousandsSeparator = true;
            // 
            // cmbVolumeUnit
            // 
            cmbVolumeUnit.Dock = DockStyle.Fill;
            cmbVolumeUnit.FormattingEnabled = true;
            cmbVolumeUnit.Items.AddRange(new object[] { "m³", "L", "cm³" });
            cmbVolumeUnit.Location = new Point(288, 40);
            cmbVolumeUnit.Name = "cmbVolumeUnit";
            cmbVolumeUnit.Size = new Size(55, 28);
            cmbVolumeUnit.TabIndex = 4;
            // 
            // cmbRhoUnit
            // 
            cmbRhoUnit.Dock = DockStyle.Fill;
            cmbRhoUnit.FormattingEnabled = true;
            cmbRhoUnit.Items.AddRange(new object[] { "Kg/m³", "g/L", "g/cm³" });
            cmbRhoUnit.Location = new Point(288, 77);
            cmbRhoUnit.Name = "cmbRhoUnit";
            cmbRhoUnit.Size = new Size(55, 28);
            cmbRhoUnit.TabIndex = 6;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(503, 37);
            lblResult.Name = "lblResult";
            tableLayoutPanel1.SetRowSpan(lblResult, 2);
            lblResult.Size = new Size(288, 74);
            lblResult.TabIndex = 9;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(rd1Solid);
            flowLayoutPanel1.Controls.Add(rd2Solid);
            flowLayoutPanel1.Controls.Add(rd3Solid);
            flowLayoutPanel1.Location = new Point(503, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(283, 28);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // rd1Solid
            // 
            rd1Solid.AutoSize = true;
            rd1Solid.Checked = true;
            rd1Solid.Location = new Point(3, 3);
            rd1Solid.Name = "rd1Solid";
            rd1Solid.Size = new Size(130, 24);
            rd1Solid.TabIndex = 0;
            rd1Solid.TabStop = true;
            rd1Solid.Text = "Kg/m³ (SI Unit)";
            rd1Solid.UseVisualStyleBackColor = true;
            // 
            // rd2Solid
            // 
            rd2Solid.AutoSize = true;
            rd2Solid.Location = new Point(139, 3);
            rd2Solid.Name = "rd2Solid";
            rd2Solid.Size = new Size(52, 24);
            rd2Solid.TabIndex = 1;
            rd2Solid.Text = "g/L";
            rd2Solid.UseVisualStyleBackColor = true;
            // 
            // rd3Solid
            // 
            rd3Solid.AutoSize = true;
            rd3Solid.Location = new Point(197, 3);
            rd3Solid.Name = "rd3Solid";
            rd3Solid.Size = new Size(71, 24);
            rd3Solid.TabIndex = 2;
            rd3Solid.Text = "g/cm³";
            rd3Solid.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Density
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 297);
            Controls.Add(groupBox1);
            Name = "Density";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Density";
            Load += Density_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRho).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMass).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cmbMassUnit;
        private NumericUpDown numRho;
        private NumericUpDown numVolume;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnCalculate;
        private Label lblMass;
        private Label lblVolume;
        private Label lblRho;
        private NumericUpDown numMass;
        private ComboBox cmbVolumeUnit;
        private ComboBox cmbRhoUnit;
        private Label lblResult;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton rd1Solid;
        private RadioButton rd2Solid;
        private RadioButton rd3Solid;
        private PictureBox pictureBox1;
    }
}