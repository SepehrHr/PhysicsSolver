namespace PhysicsSolver
{
    partial class KineticEnergy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KineticEnergy));
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbMassUnit = new ComboBox();
            numK = new NumericUpDown();
            numVelocity = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnCalculate = new Button();
            lblMass = new Label();
            lblVelocity = new Label();
            lblK = new Label();
            numMass = new NumericUpDown();
            cmbVelocityUnit = new ComboBox();
            cmbKUnit = new ComboBox();
            lblResult = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rd1Solid = new RadioButton();
            rd2Solid = new RadioButton();
            splitter1 = new Splitter();
            btnCopy = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVelocity).BeginInit();
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
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculate Kinetic Energy";
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
            tableLayoutPanel1.Controls.Add(numK, 1, 2);
            tableLayoutPanel1.Controls.Add(numVelocity, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(btnCalculate, 0, 3);
            tableLayoutPanel1.Controls.Add(lblMass, 3, 0);
            tableLayoutPanel1.Controls.Add(lblVelocity, 3, 1);
            tableLayoutPanel1.Controls.Add(lblK, 3, 2);
            tableLayoutPanel1.Controls.Add(numMass, 1, 0);
            tableLayoutPanel1.Controls.Add(cmbVelocityUnit, 2, 1);
            tableLayoutPanel1.Controls.Add(cmbKUnit, 2, 2);
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
            // numK
            // 
            numK.Dock = DockStyle.Fill;
            numK.Location = new Point(157, 77);
            numK.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numK.Name = "numK";
            numK.Size = new Size(125, 27);
            numK.TabIndex = 5;
            numK.ThousandsSeparator = true;
            // 
            // numVelocity
            // 
            numVelocity.Dock = DockStyle.Fill;
            numVelocity.Location = new Point(157, 40);
            numVelocity.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numVelocity.Name = "numVelocity";
            numVelocity.Size = new Size(125, 27);
            numVelocity.TabIndex = 3;
            numVelocity.ThousandsSeparator = true;
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
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Velocity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 74);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 0;
            label3.Text = "Kinetic Energy:";
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
            // lblVelocity
            // 
            lblVelocity.AutoSize = true;
            lblVelocity.Location = new Point(349, 37);
            lblVelocity.Name = "lblVelocity";
            lblVelocity.Size = new Size(0, 20);
            lblVelocity.TabIndex = 3;
            // 
            // lblK
            // 
            lblK.AutoSize = true;
            lblK.Location = new Point(349, 74);
            lblK.Name = "lblK";
            lblK.Size = new Size(0, 20);
            lblK.TabIndex = 3;
            // 
            // numMass
            // 
            numMass.Dock = DockStyle.Left;
            numMass.Location = new Point(157, 3);
            numMass.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numMass.Name = "numMass";
            numMass.Size = new Size(124, 27);
            numMass.TabIndex = 1;
            numMass.ThousandsSeparator = true;
            // 
            // cmbVelocityUnit
            // 
            cmbVelocityUnit.Dock = DockStyle.Fill;
            cmbVelocityUnit.FormattingEnabled = true;
            cmbVelocityUnit.Items.AddRange(new object[] { "m/s", "Km/h" });
            cmbVelocityUnit.Location = new Point(288, 40);
            cmbVelocityUnit.Name = "cmbVelocityUnit";
            cmbVelocityUnit.Size = new Size(55, 28);
            cmbVelocityUnit.TabIndex = 4;
            // 
            // cmbKUnit
            // 
            cmbKUnit.Dock = DockStyle.Fill;
            cmbKUnit.FormattingEnabled = true;
            cmbKUnit.Items.AddRange(new object[] { "J", "KJ" });
            cmbKUnit.Location = new Point(288, 77);
            cmbKUnit.Name = "cmbKUnit";
            cmbKUnit.Size = new Size(55, 28);
            cmbKUnit.TabIndex = 6;
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
            flowLayoutPanel1.Controls.Add(splitter1);
            flowLayoutPanel1.Controls.Add(btnCopy);
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
            rd1Solid.Size = new Size(35, 24);
            rd1Solid.TabIndex = 0;
            rd1Solid.TabStop = true;
            rd1Solid.Text = "J";
            rd1Solid.UseVisualStyleBackColor = true;
            // 
            // rd2Solid
            // 
            rd2Solid.AutoSize = true;
            rd2Solid.Location = new Point(44, 3);
            rd2Solid.Name = "rd2Solid";
            rd2Solid.Size = new Size(45, 24);
            rd2Solid.TabIndex = 1;
            rd2Solid.Text = "KJ";
            rd2Solid.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            splitter1.Cursor = Cursors.Arrow;
            splitter1.BackColor = SystemColors.Control;
            splitter1.Location = new Point(95, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 24);
            splitter1.TabIndex = 6;
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
            btnCopy.TabIndex = 5;
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
            pictureBox1.Size = new Size(794, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // KineticEnergy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 297);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KineticEnergy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Physics Solver - Kinetic Energy";
            Load += KineticEnergy_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numK).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVelocity).EndInit();
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
        private NumericUpDown numK;
        private NumericUpDown numVelocity;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnCalculate;
        private Label lblMass;
        private Label lblVelocity;
        private Label lblK;
        private NumericUpDown numMass;
        private ComboBox cmbVelocityUnit;
        private ComboBox cmbKUnit;
        private Label lblResult;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton rd1Solid;
        private RadioButton rd2Solid;
        private PictureBox pictureBox1;
        private Splitter splitter1;
        private Button btnCopy;
    }
}