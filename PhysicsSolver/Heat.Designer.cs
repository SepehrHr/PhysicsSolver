namespace PhysicsSolver
{
    partial class Heat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Heat));
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            cmbQUnit = new ComboBox();
            numQ = new NumericUpDown();
            cmbMassUnit = new ComboBox();
            numT = new NumericUpDown();
            numC = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCalculateFliuds = new Button();
            lblMass = new Label();
            lblC = new Label();
            lblDeltaT = new Label();
            numMass = new NumericUpDown();
            cmbCUnit = new ComboBox();
            cmbTUnit = new ComboBox();
            lblResult = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            rd1 = new RadioButton();
            rd2 = new RadioButton();
            splitter2 = new Splitter();
            btnCopy = new Button();
            label11 = new Label();
            lblQ = new Label();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMass).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 297);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculate Gravitational Energy";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.18136F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.4911842F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.2090683F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.9722919F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.7995224F));
            tableLayoutPanel2.Controls.Add(cmbQUnit, 2, 3);
            tableLayoutPanel2.Controls.Add(numQ, 1, 3);
            tableLayoutPanel2.Controls.Add(cmbMassUnit, 2, 0);
            tableLayoutPanel2.Controls.Add(numT, 1, 2);
            tableLayoutPanel2.Controls.Add(numC, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(btnCalculateFliuds, 0, 4);
            tableLayoutPanel2.Controls.Add(lblMass, 3, 0);
            tableLayoutPanel2.Controls.Add(lblC, 3, 1);
            tableLayoutPanel2.Controls.Add(lblDeltaT, 3, 2);
            tableLayoutPanel2.Controls.Add(numMass, 1, 0);
            tableLayoutPanel2.Controls.Add(cmbCUnit, 2, 1);
            tableLayoutPanel2.Controls.Add(cmbTUnit, 2, 2);
            tableLayoutPanel2.Controls.Add(lblResult, 4, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 4, 0);
            tableLayoutPanel2.Controls.Add(label11, 0, 3);
            tableLayoutPanel2.Controls.Add(lblQ, 3, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 117);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(794, 177);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // cmbQUnit
            // 
            cmbQUnit.Dock = DockStyle.Fill;
            cmbQUnit.FormattingEnabled = true;
            cmbQUnit.Items.AddRange(new object[] { "J", "KJ" });
            cmbQUnit.Location = new Point(318, 108);
            cmbQUnit.Name = "cmbQUnit";
            cmbQUnit.Size = new Size(83, 28);
            cmbQUnit.TabIndex = 7;
            // 
            // numQ
            // 
            numQ.DecimalPlaces = 2;
            numQ.Dock = DockStyle.Fill;
            numQ.Location = new Point(195, 108);
            numQ.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numQ.Name = "numQ";
            numQ.Size = new Size(117, 27);
            numQ.TabIndex = 6;
            numQ.ThousandsSeparator = true;
            // 
            // cmbMassUnit
            // 
            cmbMassUnit.Dock = DockStyle.Fill;
            cmbMassUnit.FormattingEnabled = true;
            cmbMassUnit.Items.AddRange(new object[] { "Kg", "g" });
            cmbMassUnit.Location = new Point(318, 3);
            cmbMassUnit.Name = "cmbMassUnit";
            cmbMassUnit.Size = new Size(83, 28);
            cmbMassUnit.TabIndex = 1;
            // 
            // numT
            // 
            numT.DecimalPlaces = 2;
            numT.Dock = DockStyle.Fill;
            numT.Location = new Point(195, 73);
            numT.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numT.Name = "numT";
            numT.Size = new Size(117, 27);
            numT.TabIndex = 4;
            numT.ThousandsSeparator = true;
            // 
            // numC
            // 
            numC.DecimalPlaces = 2;
            numC.Dock = DockStyle.Fill;
            numC.Location = new Point(195, 38);
            numC.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numC.Name = "numC";
            numC.Size = new Size(117, 27);
            numC.TabIndex = 2;
            numC.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 0;
            label4.Text = "mass:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 35);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 0;
            label5.Text = "c (Specific Heat):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 70);
            label6.Name = "label6";
            label6.Size = new Size(182, 20);
            label6.TabIndex = 0;
            label6.Text = "∆T (Temperature Change):";
            // 
            // btnCalculateFliuds
            // 
            tableLayoutPanel2.SetColumnSpan(btnCalculateFliuds, 5);
            btnCalculateFliuds.Dock = DockStyle.Fill;
            btnCalculateFliuds.Location = new Point(80, 143);
            btnCalculateFliuds.Margin = new Padding(80, 3, 80, 3);
            btnCalculateFliuds.Name = "btnCalculateFliuds";
            btnCalculateFliuds.Size = new Size(634, 31);
            btnCalculateFliuds.TabIndex = 8;
            btnCalculateFliuds.Text = "Calculate";
            btnCalculateFliuds.UseVisualStyleBackColor = true;
            btnCalculateFliuds.Click += btnCalculateFliuds_Click;
            // 
            // lblMass
            // 
            lblMass.AutoSize = true;
            lblMass.Location = new Point(407, 0);
            lblMass.Name = "lblMass";
            lblMass.Size = new Size(0, 20);
            lblMass.TabIndex = 3;
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(407, 35);
            lblC.Name = "lblC";
            lblC.Size = new Size(0, 20);
            lblC.TabIndex = 3;
            // 
            // lblDeltaT
            // 
            lblDeltaT.AutoSize = true;
            lblDeltaT.Location = new Point(407, 70);
            lblDeltaT.Name = "lblDeltaT";
            lblDeltaT.Size = new Size(0, 20);
            lblDeltaT.TabIndex = 3;
            // 
            // numMass
            // 
            numMass.DecimalPlaces = 2;
            numMass.Dock = DockStyle.Left;
            numMass.Location = new Point(195, 3);
            numMass.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numMass.Name = "numMass";
            numMass.Size = new Size(114, 27);
            numMass.TabIndex = 0;
            numMass.ThousandsSeparator = true;
            // 
            // cmbCUnit
            // 
            cmbCUnit.Dock = DockStyle.Fill;
            cmbCUnit.Enabled = false;
            cmbCUnit.FormattingEnabled = true;
            cmbCUnit.Items.AddRange(new object[] { "J/Kg∙K" });
            cmbCUnit.Location = new Point(318, 38);
            cmbCUnit.Name = "cmbCUnit";
            cmbCUnit.Size = new Size(83, 28);
            cmbCUnit.TabIndex = 3;
            // 
            // cmbTUnit
            // 
            cmbTUnit.Dock = DockStyle.Fill;
            cmbTUnit.FormattingEnabled = true;
            cmbTUnit.Items.AddRange(new object[] { "°C", "K", "°F" });
            cmbTUnit.Location = new Point(318, 73);
            cmbTUnit.Name = "cmbTUnit";
            cmbTUnit.Size = new Size(83, 28);
            cmbTUnit.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(510, 35);
            lblResult.Name = "lblResult";
            tableLayoutPanel2.SetRowSpan(lblResult, 3);
            lblResult.Size = new Size(281, 105);
            lblResult.TabIndex = 7;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(rd1);
            flowLayoutPanel2.Controls.Add(rd2);
            flowLayoutPanel2.Controls.Add(splitter2);
            flowLayoutPanel2.Controls.Add(btnCopy);
            flowLayoutPanel2.Location = new Point(510, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(277, 26);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // rd1
            // 
            rd1.AutoSize = true;
            rd1.Checked = true;
            rd1.Location = new Point(3, 3);
            rd1.Name = "rd1";
            rd1.Size = new Size(98, 24);
            rd1.TabIndex = 0;
            rd1.TabStop = true;
            rd1.Text = "J (SI Units)";
            rd1.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            rd2.AutoSize = true;
            rd2.Location = new Point(107, 3);
            rd2.Name = "rd2";
            rd2.Size = new Size(45, 24);
            rd2.TabIndex = 0;
            rd2.Text = "KJ";
            rd2.UseVisualStyleBackColor = true;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(158, 3);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 24);
            splitter2.TabIndex = 6;
            splitter2.TabStop = false;
            // 
            // btnCopy
            // 
            btnCopy.BackgroundImage = (Image)resources.GetObject("btnCopy.BackgroundImage");
            btnCopy.BackgroundImageLayout = ImageLayout.Zoom;
            btnCopy.Dock = DockStyle.Right;
            btnCopy.Location = new Point(168, 3);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(24, 24);
            btnCopy.TabIndex = 5;
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 105);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 0;
            label11.Text = "Q (Heat):";
            // 
            // lblQ
            // 
            lblQ.AutoSize = true;
            lblQ.Location = new Point(407, 105);
            lblQ.Name = "lblQ";
            lblQ.Size = new Size(0, 20);
            lblQ.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(794, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Heat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 297);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Heat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Physics Solver - Heat";
            Load += Heat_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQ).EndInit();
            ((System.ComponentModel.ISupportInitialize)numT).EndInit();
            ((System.ComponentModel.ISupportInitialize)numC).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMass).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cmbQUnit;
        private NumericUpDown numQ;
        private ComboBox cmbMassUnit;
        private NumericUpDown numT;
        private NumericUpDown numC;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCalculateFliuds;
        private Label lblMass;
        private Label lblC;
        private Label lblDeltaT;
        private NumericUpDown numMass;
        private ComboBox cmbCUnit;
        private ComboBox cmbTUnit;
        private Label lblResult;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton rd1;
        private RadioButton rd2;
        private Splitter splitter2;
        private Button btnCopy;
        private Label label11;
        private Label lblQ;
        private PictureBox pictureBox2;
    }
}