namespace PhysicsSolver
{
    partial class Gravitational
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gravitational));
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            cmbUUnit = new ComboBox();
            numU = new NumericUpDown();
            cmbMassUnit = new ComboBox();
            numHeight = new NumericUpDown();
            numG = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCalculateFliuds = new Button();
            lblMass = new Label();
            lblG = new Label();
            lblHeight = new Label();
            numMass = new NumericUpDown();
            cmbGUnit = new ComboBox();
            cmbHeightUnit = new ComboBox();
            lblResult = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            rd1 = new RadioButton();
            rd2 = new RadioButton();
            splitter2 = new Splitter();
            btnCopy = new Button();
            label11 = new Label();
            lblU = new Label();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numG).BeginInit();
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
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculate Gravitational Energy";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.6700249F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.11335F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.06801F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.00252F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.7995224F));
            tableLayoutPanel2.Controls.Add(cmbUUnit, 2, 3);
            tableLayoutPanel2.Controls.Add(numU, 1, 3);
            tableLayoutPanel2.Controls.Add(cmbMassUnit, 2, 0);
            tableLayoutPanel2.Controls.Add(numHeight, 1, 2);
            tableLayoutPanel2.Controls.Add(numG, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(btnCalculateFliuds, 0, 4);
            tableLayoutPanel2.Controls.Add(lblMass, 3, 0);
            tableLayoutPanel2.Controls.Add(lblG, 3, 1);
            tableLayoutPanel2.Controls.Add(lblHeight, 3, 2);
            tableLayoutPanel2.Controls.Add(numMass, 1, 0);
            tableLayoutPanel2.Controls.Add(cmbGUnit, 2, 1);
            tableLayoutPanel2.Controls.Add(cmbHeightUnit, 2, 2);
            tableLayoutPanel2.Controls.Add(lblResult, 4, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 4, 0);
            tableLayoutPanel2.Controls.Add(label11, 0, 3);
            tableLayoutPanel2.Controls.Add(lblU, 3, 3);
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
            // cmbUUnit
            // 
            cmbUUnit.Dock = DockStyle.Fill;
            cmbUUnit.FormattingEnabled = true;
            cmbUUnit.Items.AddRange(new object[] { "J", "KJ" });
            cmbUUnit.Location = new Point(303, 108);
            cmbUUnit.Name = "cmbUUnit";
            cmbUUnit.Size = new Size(66, 28);
            cmbUUnit.TabIndex = 7;
            // 
            // numU
            // 
            numU.DecimalPlaces = 2;
            numU.Dock = DockStyle.Fill;
            numU.Location = new Point(183, 108);
            numU.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numU.Name = "numU";
            numU.Size = new Size(114, 27);
            numU.TabIndex = 6;
            numU.ThousandsSeparator = true;
            // 
            // cmbMassUnit
            // 
            cmbMassUnit.Dock = DockStyle.Fill;
            cmbMassUnit.FormattingEnabled = true;
            cmbMassUnit.Items.AddRange(new object[] { "Kg", "g" });
            cmbMassUnit.Location = new Point(303, 3);
            cmbMassUnit.Name = "cmbMassUnit";
            cmbMassUnit.Size = new Size(66, 28);
            cmbMassUnit.TabIndex = 1;
            // 
            // numHeight
            // 
            numHeight.DecimalPlaces = 2;
            numHeight.Dock = DockStyle.Fill;
            numHeight.Location = new Point(183, 73);
            numHeight.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(114, 27);
            numHeight.TabIndex = 4;
            numHeight.ThousandsSeparator = true;
            // 
            // numG
            // 
            numG.DecimalPlaces = 2;
            numG.Dock = DockStyle.Fill;
            numG.Location = new Point(183, 38);
            numG.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numG.Name = "numG";
            numG.Size = new Size(114, 27);
            numG.TabIndex = 2;
            numG.ThousandsSeparator = true;
            numG.Value = new decimal(new int[] { 98, 0, 0, 65536 });
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
            label5.Size = new Size(81, 20);
            label5.TabIndex = 0;
            label5.Text = "g (Gravity):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 70);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 0;
            label6.Text = "h (Height):";
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
            lblMass.Location = new Point(375, 0);
            lblMass.Name = "lblMass";
            lblMass.Size = new Size(0, 20);
            lblMass.TabIndex = 3;
            // 
            // lblG
            // 
            lblG.AutoSize = true;
            lblG.Location = new Point(375, 35);
            lblG.Name = "lblG";
            lblG.Size = new Size(0, 20);
            lblG.TabIndex = 3;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(375, 70);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(0, 20);
            lblHeight.TabIndex = 3;
            // 
            // numMass
            // 
            numMass.DecimalPlaces = 2;
            numMass.Dock = DockStyle.Left;
            numMass.Location = new Point(183, 3);
            numMass.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numMass.Name = "numMass";
            numMass.Size = new Size(114, 27);
            numMass.TabIndex = 0;
            numMass.ThousandsSeparator = true;
            // 
            // cmbGUnit
            // 
            cmbGUnit.Dock = DockStyle.Fill;
            cmbGUnit.Enabled = false;
            cmbGUnit.FormattingEnabled = true;
            cmbGUnit.Items.AddRange(new object[] { "m/s²" });
            cmbGUnit.Location = new Point(303, 38);
            cmbGUnit.Name = "cmbGUnit";
            cmbGUnit.Size = new Size(66, 28);
            cmbGUnit.TabIndex = 3;
            // 
            // cmbHeightUnit
            // 
            cmbHeightUnit.Dock = DockStyle.Fill;
            cmbHeightUnit.FormattingEnabled = true;
            cmbHeightUnit.Items.AddRange(new object[] { "m", "cm" });
            cmbHeightUnit.Location = new Point(303, 73);
            cmbHeightUnit.Name = "cmbHeightUnit";
            cmbHeightUnit.Size = new Size(66, 28);
            cmbHeightUnit.TabIndex = 5;
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
            label11.Size = new Size(170, 20);
            label11.TabIndex = 0;
            label11.Text = "U (Gravitational Energy):";
            // 
            // lblU
            // 
            lblU.AutoSize = true;
            lblU.Location = new Point(375, 105);
            lblU.Name = "lblU";
            lblU.Size = new Size(0, 20);
            lblU.TabIndex = 11;
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
            // Gravitational
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 297);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Gravitational";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gravitational";
            Load += Gravitational_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numU).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numG).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMass).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cmbUUnit;
        private NumericUpDown numU;
        private ComboBox cmbMassUnit;
        private NumericUpDown numHeight;
        private NumericUpDown numG;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCalculateFliuds;
        private Label lblMass;
        private Label lblG;
        private Label lblHeight;
        private NumericUpDown numMass;
        private ComboBox cmbGUnit;
        private ComboBox cmbHeightUnit;
        private Label lblResult;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton rd1;
        private RadioButton rd2;
        private Splitter splitter2;
        private Button btnCopy;
        private Label label11;
        private Label lblU;
        private PictureBox pictureBox2;
    }
}