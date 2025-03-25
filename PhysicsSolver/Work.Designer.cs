namespace PhysicsSolver
{
    partial class Work
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Work));
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            cmbWorkUnit = new ComboBox();
            numWork = new NumericUpDown();
            cmbForceUnit = new ComboBox();
            numAlpha = new NumericUpDown();
            numDistance = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCalculateFliuds = new Button();
            lblForce = new Label();
            lblDistance = new Label();
            lblAlpha = new Label();
            numForce = new NumericUpDown();
            cmbDistanceUnit = new ComboBox();
            cmbAlphaUnit = new ComboBox();
            lblResult = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            rd1Fliud = new RadioButton();
            rd2Fliud = new RadioButton();
            splitter1 = new Splitter();
            btnCopy = new Button();
            label11 = new Label();
            lblWork = new Label();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAlpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numForce).BeginInit();
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
            groupBox1.Size = new Size(800, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculate Work";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0930824F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.2291164F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.785203F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.09308F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.7995224F));
            tableLayoutPanel2.Controls.Add(cmbWorkUnit, 2, 3);
            tableLayoutPanel2.Controls.Add(numWork, 1, 3);
            tableLayoutPanel2.Controls.Add(cmbForceUnit, 2, 0);
            tableLayoutPanel2.Controls.Add(numAlpha, 1, 2);
            tableLayoutPanel2.Controls.Add(numDistance, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(btnCalculateFliuds, 0, 4);
            tableLayoutPanel2.Controls.Add(lblForce, 3, 0);
            tableLayoutPanel2.Controls.Add(lblDistance, 3, 1);
            tableLayoutPanel2.Controls.Add(lblAlpha, 3, 2);
            tableLayoutPanel2.Controls.Add(numForce, 1, 0);
            tableLayoutPanel2.Controls.Add(cmbDistanceUnit, 2, 1);
            tableLayoutPanel2.Controls.Add(cmbAlphaUnit, 2, 2);
            tableLayoutPanel2.Controls.Add(lblResult, 4, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 4, 0);
            tableLayoutPanel2.Controls.Add(label11, 0, 3);
            tableLayoutPanel2.Controls.Add(lblWork, 3, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 112);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(794, 169);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // cmbWorkUnit
            // 
            cmbWorkUnit.Dock = DockStyle.Fill;
            cmbWorkUnit.FormattingEnabled = true;
            cmbWorkUnit.Items.AddRange(new object[] { "J", "KJ" });
            cmbWorkUnit.Location = new Point(282, 102);
            cmbWorkUnit.Name = "cmbWorkUnit";
            cmbWorkUnit.Size = new Size(71, 28);
            cmbWorkUnit.TabIndex = 7;
            // 
            // numWork
            // 
            numWork.Dock = DockStyle.Fill;
            numWork.Location = new Point(154, 102);
            numWork.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numWork.Name = "numWork";
            numWork.Size = new Size(122, 27);
            numWork.TabIndex = 6;
            numWork.ThousandsSeparator = true;
            // 
            // cmbForceUnit
            // 
            cmbForceUnit.Dock = DockStyle.Fill;
            cmbForceUnit.Enabled = false;
            cmbForceUnit.FormattingEnabled = true;
            cmbForceUnit.Items.AddRange(new object[] { "N" });
            cmbForceUnit.Location = new Point(282, 3);
            cmbForceUnit.Name = "cmbForceUnit";
            cmbForceUnit.Size = new Size(71, 28);
            cmbForceUnit.TabIndex = 1;
            // 
            // numAlpha
            // 
            numAlpha.Dock = DockStyle.Fill;
            numAlpha.Location = new Point(154, 69);
            numAlpha.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numAlpha.Name = "numAlpha";
            numAlpha.Size = new Size(122, 27);
            numAlpha.TabIndex = 4;
            numAlpha.ThousandsSeparator = true;
            // 
            // numDistance
            // 
            numDistance.Dock = DockStyle.Fill;
            numDistance.Location = new Point(154, 36);
            numDistance.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(122, 27);
            numDistance.TabIndex = 2;
            numDistance.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 0;
            label4.Text = "Force:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 33);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 0;
            label5.Text = "distance:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 66);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 0;
            label6.Text = "α (Force Angle):";
            // 
            // btnCalculateFliuds
            // 
            tableLayoutPanel2.SetColumnSpan(btnCalculateFliuds, 5);
            btnCalculateFliuds.Dock = DockStyle.Fill;
            btnCalculateFliuds.Location = new Point(80, 135);
            btnCalculateFliuds.Margin = new Padding(80, 3, 80, 3);
            btnCalculateFliuds.Name = "btnCalculateFliuds";
            btnCalculateFliuds.Size = new Size(634, 31);
            btnCalculateFliuds.TabIndex = 8;
            btnCalculateFliuds.Text = "Calculate";
            btnCalculateFliuds.UseVisualStyleBackColor = true;
            btnCalculateFliuds.Click += btnCalculateFliuds_Click;
            // 
            // lblForce
            // 
            lblForce.AutoSize = true;
            lblForce.Location = new Point(359, 0);
            lblForce.Name = "lblForce";
            lblForce.Size = new Size(0, 20);
            lblForce.TabIndex = 3;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(359, 33);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(0, 20);
            lblDistance.TabIndex = 3;
            // 
            // lblAlpha
            // 
            lblAlpha.AutoSize = true;
            lblAlpha.Location = new Point(359, 66);
            lblAlpha.Name = "lblAlpha";
            lblAlpha.Size = new Size(0, 20);
            lblAlpha.TabIndex = 3;
            // 
            // numForce
            // 
            numForce.Dock = DockStyle.Left;
            numForce.Location = new Point(154, 3);
            numForce.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numForce.Name = "numForce";
            numForce.Size = new Size(121, 27);
            numForce.TabIndex = 0;
            numForce.ThousandsSeparator = true;
            // 
            // cmbDistanceUnit
            // 
            cmbDistanceUnit.Dock = DockStyle.Fill;
            cmbDistanceUnit.FormattingEnabled = true;
            cmbDistanceUnit.Items.AddRange(new object[] { "m", "cm" });
            cmbDistanceUnit.Location = new Point(282, 36);
            cmbDistanceUnit.Name = "cmbDistanceUnit";
            cmbDistanceUnit.Size = new Size(71, 28);
            cmbDistanceUnit.TabIndex = 3;
            // 
            // cmbAlphaUnit
            // 
            cmbAlphaUnit.Dock = DockStyle.Fill;
            cmbAlphaUnit.Enabled = false;
            cmbAlphaUnit.FormattingEnabled = true;
            cmbAlphaUnit.Items.AddRange(new object[] { "°" });
            cmbAlphaUnit.Location = new Point(282, 69);
            cmbAlphaUnit.Name = "cmbAlphaUnit";
            cmbAlphaUnit.Size = new Size(71, 28);
            cmbAlphaUnit.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(510, 33);
            lblResult.Name = "lblResult";
            tableLayoutPanel2.SetRowSpan(lblResult, 3);
            lblResult.Size = new Size(281, 99);
            lblResult.TabIndex = 7;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(rd1Fliud);
            flowLayoutPanel2.Controls.Add(rd2Fliud);
            flowLayoutPanel2.Controls.Add(splitter1);
            flowLayoutPanel2.Controls.Add(btnCopy);
            flowLayoutPanel2.Location = new Point(510, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(277, 26);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // rd1Fliud
            // 
            rd1Fliud.AutoSize = true;
            rd1Fliud.Checked = true;
            rd1Fliud.Location = new Point(3, 3);
            rd1Fliud.Name = "rd1Fliud";
            rd1Fliud.Size = new Size(35, 24);
            rd1Fliud.TabIndex = 0;
            rd1Fliud.TabStop = true;
            rd1Fliud.Text = "J";
            rd1Fliud.UseVisualStyleBackColor = true;
            // 
            // rd2Fliud
            // 
            rd2Fliud.AutoSize = true;
            rd2Fliud.Location = new Point(44, 3);
            rd2Fliud.Name = "rd2Fliud";
            rd2Fliud.Size = new Size(45, 24);
            rd2Fliud.TabIndex = 0;
            rd2Fliud.Text = "KJ";
            rd2Fliud.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            splitter1.Cursor = Cursors.Arrow;
            splitter1.Location = new Point(95, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 24);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // btnCopy
            // 
            btnCopy.BackgroundImage = (Image)resources.GetObject("btnCopy.BackgroundImage");
            btnCopy.BackgroundImageLayout = ImageLayout.Zoom;
            btnCopy.Dock = DockStyle.Right;
            btnCopy.Location = new Point(105, 3);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(24, 24);
            btnCopy.TabIndex = 6;
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 99);
            label11.Name = "label11";
            label11.Size = new Size(46, 20);
            label11.TabIndex = 0;
            label11.Text = "Work:";
            // 
            // lblWork
            // 
            lblWork.AutoSize = true;
            lblWork.Location = new Point(359, 99);
            lblWork.Name = "lblWork";
            lblWork.Size = new Size(0, 20);
            lblWork.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(794, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Work
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 284);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Work";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Physics Solver - Work";
            Load += Work_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAlpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numForce).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cmbWorkUnit;
        private NumericUpDown numWork;
        private ComboBox cmbForceUnit;
        private NumericUpDown numAlpha;
        private NumericUpDown numDistance;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCalculateFliuds;
        private Label lblForce;
        private Label lblDistance;
        private Label lblAlpha;
        private NumericUpDown numForce;
        private ComboBox cmbDistanceUnit;
        private ComboBox cmbAlphaUnit;
        private Label lblResult;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton rd1Fliud;
        private RadioButton rd2Fliud;
        private Label label11;
        private Label lblWork;
        private Splitter splitter1;
        private Button btnCopy;
    }
}