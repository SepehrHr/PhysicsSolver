namespace PhysicsSolver
{
    partial class Power
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Power));
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbQUnit = new ComboBox();
            numPower = new NumericUpDown();
            numTime = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnCalculate = new Button();
            lblQ = new Label();
            lblTime = new Label();
            lblPower = new Label();
            numQ = new NumericUpDown();
            cmbTimeUnit = new ComboBox();
            cmbPowerUnit = new ComboBox();
            lblResult = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rd1Solid = new RadioButton();
            rd2Solid = new RadioButton();
            btnCopy = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQ).BeginInit();
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
            groupBox1.Size = new Size(682, 297);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "محاسبه توان گرمایی";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.7287331F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.76942F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9467459F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.9053259F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.4216957F));
            tableLayoutPanel1.Controls.Add(cmbQUnit, 2, 0);
            tableLayoutPanel1.Controls.Add(numPower, 1, 2);
            tableLayoutPanel1.Controls.Add(numTime, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(btnCalculate, 0, 3);
            tableLayoutPanel1.Controls.Add(lblQ, 3, 0);
            tableLayoutPanel1.Controls.Add(lblTime, 3, 1);
            tableLayoutPanel1.Controls.Add(lblPower, 3, 2);
            tableLayoutPanel1.Controls.Add(numQ, 1, 0);
            tableLayoutPanel1.Controls.Add(cmbTimeUnit, 2, 1);
            tableLayoutPanel1.Controls.Add(cmbPowerUnit, 2, 2);
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
            tableLayoutPanel1.Size = new Size(676, 149);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // cmbQUnit
            // 
            cmbQUnit.Dock = DockStyle.Fill;
            cmbQUnit.FormattingEnabled = true;
            cmbQUnit.Items.AddRange(new object[] { "J", "KJ" });
            cmbQUnit.Location = new Point(249, 3);
            cmbQUnit.Name = "cmbQUnit";
            cmbQUnit.Size = new Size(68, 28);
            cmbQUnit.TabIndex = 2;
            // 
            // numPower
            // 
            numPower.DecimalPlaces = 2;
            numPower.Dock = DockStyle.Fill;
            numPower.Location = new Point(136, 77);
            numPower.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numPower.Name = "numPower";
            numPower.Size = new Size(107, 27);
            numPower.TabIndex = 5;
            numPower.ThousandsSeparator = true;
            // 
            // numTime
            // 
            numTime.DecimalPlaces = 2;
            numTime.Dock = DockStyle.Fill;
            numTime.Location = new Point(136, 40);
            numTime.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numTime.Name = "numTime";
            numTime.Size = new Size(107, 27);
            numTime.TabIndex = 3;
            numTime.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 0;
            label2.Text = "انرژی گرمایی (Q):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "زمان (t):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 74);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 0;
            label3.Text = "توان گرمایی (P):";
            // 
            // btnCalculate
            // 
            tableLayoutPanel1.SetColumnSpan(btnCalculate, 5);
            btnCalculate.Dock = DockStyle.Fill;
            btnCalculate.Location = new Point(80, 114);
            btnCalculate.Margin = new Padding(80, 3, 80, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(516, 32);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "محاسبه";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblQ
            // 
            lblQ.AutoSize = true;
            lblQ.Location = new Point(323, 0);
            lblQ.Name = "lblQ";
            lblQ.Size = new Size(0, 20);
            lblQ.TabIndex = 3;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(323, 37);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 20);
            lblTime.TabIndex = 3;
            // 
            // lblPower
            // 
            lblPower.AutoSize = true;
            lblPower.Location = new Point(323, 74);
            lblPower.Name = "lblPower";
            lblPower.Size = new Size(0, 20);
            lblPower.TabIndex = 3;
            // 
            // numQ
            // 
            numQ.DecimalPlaces = 2;
            numQ.Dock = DockStyle.Left;
            numQ.Location = new Point(136, 3);
            numQ.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numQ.Name = "numQ";
            numQ.Size = new Size(107, 27);
            numQ.TabIndex = 1;
            numQ.ThousandsSeparator = true;
            // 
            // cmbTimeUnit
            // 
            cmbTimeUnit.Dock = DockStyle.Fill;
            cmbTimeUnit.FormattingEnabled = true;
            cmbTimeUnit.Items.AddRange(new object[] { "s", "min" });
            cmbTimeUnit.Location = new Point(249, 40);
            cmbTimeUnit.Name = "cmbTimeUnit";
            cmbTimeUnit.Size = new Size(68, 28);
            cmbTimeUnit.TabIndex = 4;
            // 
            // cmbPowerUnit
            // 
            cmbPowerUnit.Dock = DockStyle.Fill;
            cmbPowerUnit.FormattingEnabled = true;
            cmbPowerUnit.Items.AddRange(new object[] { "Watt", "hp" });
            cmbPowerUnit.Location = new Point(249, 77);
            cmbPowerUnit.Name = "cmbPowerUnit";
            cmbPowerUnit.Size = new Size(68, 28);
            cmbPowerUnit.TabIndex = 6;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(417, 37);
            lblResult.Name = "lblResult";
            tableLayoutPanel1.SetRowSpan(lblResult, 2);
            lblResult.Size = new Size(256, 74);
            lblResult.TabIndex = 9;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(rd1Solid);
            flowLayoutPanel1.Controls.Add(rd2Solid);
            flowLayoutPanel1.Controls.Add(btnCopy);
            flowLayoutPanel1.Location = new Point(417, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(256, 28);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // rd1Solid
            // 
            rd1Solid.AutoSize = true;
            rd1Solid.Checked = true;
            rd1Solid.Location = new Point(3, 3);
            rd1Solid.Name = "rd1Solid";
            rd1Solid.Size = new Size(120, 24);
            rd1Solid.TabIndex = 0;
            rd1Solid.TabStop = true;
            rd1Solid.Text = "Watt (SI واحد)";
            rd1Solid.UseVisualStyleBackColor = true;
            // 
            // rd2Solid
            // 
            rd2Solid.AutoSize = true;
            rd2Solid.Location = new Point(129, 3);
            rd2Solid.Name = "rd2Solid";
            rd2Solid.Size = new Size(47, 24);
            rd2Solid.TabIndex = 1;
            rd2Solid.Text = "hp";
            rd2Solid.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            btnCopy.BackgroundImage = (Image)resources.GetObject("btnCopy.BackgroundImage");
            btnCopy.BackgroundImageLayout = ImageLayout.Zoom;
            btnCopy.Dock = DockStyle.Right;
            btnCopy.Location = new Point(182, 3);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(24, 24);
            btnCopy.TabIndex = 6;
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(676, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Power
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 297);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Power";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Physics Solver - توان";
            Load += Power_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPower).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQ).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cmbQUnit;
        private NumericUpDown numPower;
        private NumericUpDown numTime;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnCalculate;
        private Label lblQ;
        private Label lblTime;
        private Label lblPower;
        private NumericUpDown numQ;
        private ComboBox cmbTimeUnit;
        private ComboBox cmbPowerUnit;
        private Label lblResult;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton rd1Solid;
        private RadioButton rd2Solid;
        private Button btnCopy;
        private PictureBox pictureBox1;
    }
}