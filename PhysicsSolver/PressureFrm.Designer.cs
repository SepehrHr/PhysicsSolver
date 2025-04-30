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
            cmbForceUnit = new ComboBox();
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
            cmbAreaUnit = new ComboBox();
            cmbPressureUnitSolid = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rd1Solid = new RadioButton();
            rd2Solid = new RadioButton();
            rd3Solid = new RadioButton();
            splitter1 = new Splitter();
            btnCopy = new Button();
            lblResultSolid = new Label();
            pictureBox1 = new PictureBox();
            tabFluid = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            cmbPressureUnitFliud = new ComboBox();
            numPressureFliud = new NumericUpDown();
            cmbRhoUnit = new ComboBox();
            numHeight = new NumericUpDown();
            numG = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCalculateFliuds = new Button();
            lblRho = new Label();
            lblG = new Label();
            lblHeight = new Label();
            numRho = new NumericUpDown();
            cmbGUnit = new ComboBox();
            cmbHeightUnit = new ComboBox();
            lblResultFliuds = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            rd1Fliud = new RadioButton();
            rd2Fliud = new RadioButton();
            rd3Fliud = new RadioButton();
            splitter2 = new Splitter();
            button2 = new Button();
            label11 = new Label();
            lblPressureFliuds = new Label();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            tabSolid.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPressureSolid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numForce).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabFluid.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPressureFliud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRho).BeginInit();
            flowLayoutPanel2.SuspendLayout();
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
            tabSolid.Text = "فشار در جامدات";
            tabSolid.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.5122F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5853653F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.804878F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.5121956F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.5853653F));
            tableLayoutPanel1.Controls.Add(cmbForceUnit, 2, 0);
            tableLayoutPanel1.Controls.Add(numPressureSolid, 1, 2);
            tableLayoutPanel1.Controls.Add(numArea, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(CalculateSolids, 0, 3);
            tableLayoutPanel1.Controls.Add(lblForceResult, 3, 0);
            tableLayoutPanel1.Controls.Add(lblAreaResult, 3, 1);
            tableLayoutPanel1.Controls.Add(lblPressureSolidResult, 3, 2);
            tableLayoutPanel1.Controls.Add(numForce, 1, 0);
            tableLayoutPanel1.Controls.Add(cmbAreaUnit, 2, 1);
            tableLayoutPanel1.Controls.Add(cmbPressureUnitSolid, 2, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 4, 0);
            tableLayoutPanel1.Controls.Add(lblResultSolid, 4, 1);
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
            // cmbForceUnit
            // 
            cmbForceUnit.Dock = DockStyle.Fill;
            cmbForceUnit.Enabled = false;
            cmbForceUnit.FormattingEnabled = true;
            cmbForceUnit.Items.AddRange(new object[] { "N" });
            cmbForceUnit.Location = new Point(286, 3);
            cmbForceUnit.Name = "cmbForceUnit";
            cmbForceUnit.Size = new Size(55, 28);
            cmbForceUnit.TabIndex = 1;
            // 
            // numPressureSolid
            // 
            numPressureSolid.DecimalPlaces = 2;
            numPressureSolid.Dock = DockStyle.Fill;
            numPressureSolid.Location = new Point(156, 71);
            numPressureSolid.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numPressureSolid.Name = "numPressureSolid";
            numPressureSolid.Size = new Size(124, 27);
            numPressureSolid.TabIndex = 4;
            numPressureSolid.ThousandsSeparator = true;
            // 
            // numArea
            // 
            numArea.DecimalPlaces = 2;
            numArea.Dock = DockStyle.Fill;
            numArea.Location = new Point(156, 37);
            numArea.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numArea.Name = "numArea";
            numArea.Size = new Size(124, 27);
            numArea.TabIndex = 2;
            numArea.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 0;
            label2.Text = "نیرو (F):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 34);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "مساحت (A):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 68);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 0;
            label3.Text = "فشار (P):";
            // 
            // CalculateSolids
            // 
            tableLayoutPanel1.SetColumnSpan(CalculateSolids, 5);
            CalculateSolids.Dock = DockStyle.Fill;
            CalculateSolids.Location = new Point(80, 105);
            CalculateSolids.Margin = new Padding(80, 3, 80, 3);
            CalculateSolids.Name = "CalculateSolids";
            CalculateSolids.Size = new Size(626, 28);
            CalculateSolids.TabIndex = 6;
            CalculateSolids.Text = "محاسبه";
            CalculateSolids.UseVisualStyleBackColor = true;
            CalculateSolids.Click += CalculateSolids_Click;
            // 
            // lblForceResult
            // 
            lblForceResult.AutoSize = true;
            lblForceResult.Location = new Point(347, 0);
            lblForceResult.Name = "lblForceResult";
            lblForceResult.Size = new Size(0, 20);
            lblForceResult.TabIndex = 3;
            // 
            // lblAreaResult
            // 
            lblAreaResult.AutoSize = true;
            lblAreaResult.Location = new Point(347, 34);
            lblAreaResult.Name = "lblAreaResult";
            lblAreaResult.Size = new Size(0, 20);
            lblAreaResult.TabIndex = 3;
            // 
            // lblPressureSolidResult
            // 
            lblPressureSolidResult.AutoSize = true;
            lblPressureSolidResult.Location = new Point(347, 68);
            lblPressureSolidResult.Name = "lblPressureSolidResult";
            lblPressureSolidResult.Size = new Size(0, 20);
            lblPressureSolidResult.TabIndex = 3;
            // 
            // numForce
            // 
            numForce.DecimalPlaces = 2;
            numForce.Dock = DockStyle.Left;
            numForce.Location = new Point(156, 3);
            numForce.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numForce.Name = "numForce";
            numForce.Size = new Size(124, 27);
            numForce.TabIndex = 0;
            numForce.ThousandsSeparator = true;
            // 
            // cmbAreaUnit
            // 
            cmbAreaUnit.Dock = DockStyle.Fill;
            cmbAreaUnit.FormattingEnabled = true;
            cmbAreaUnit.Items.AddRange(new object[] { "m²", "cm²" });
            cmbAreaUnit.Location = new Point(286, 37);
            cmbAreaUnit.Name = "cmbAreaUnit";
            cmbAreaUnit.Size = new Size(55, 28);
            cmbAreaUnit.TabIndex = 3;
            // 
            // cmbPressureUnitSolid
            // 
            cmbPressureUnitSolid.Dock = DockStyle.Fill;
            cmbPressureUnitSolid.FormattingEnabled = true;
            cmbPressureUnitSolid.Items.AddRange(new object[] { "Pa", "atm" });
            cmbPressureUnitSolid.Location = new Point(286, 71);
            cmbPressureUnitSolid.Name = "cmbPressureUnitSolid";
            cmbPressureUnitSolid.Size = new Size(55, 28);
            cmbPressureUnitSolid.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(rd1Solid);
            flowLayoutPanel1.Controls.Add(rd2Solid);
            flowLayoutPanel1.Controls.Add(rd3Solid);
            flowLayoutPanel1.Controls.Add(splitter1);
            flowLayoutPanel1.Controls.Add(btnCopy);
            flowLayoutPanel1.Location = new Point(500, 3);
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
            rd1Solid.Size = new Size(75, 24);
            rd1Solid.TabIndex = 0;
            rd1Solid.TabStop = true;
            rd1Solid.Text = "SI واحد";
            rd1Solid.UseVisualStyleBackColor = true;
            // 
            // rd2Solid
            // 
            rd2Solid.AutoSize = true;
            rd2Solid.Location = new Point(84, 3);
            rd2Solid.Name = "rd2Solid";
            rd2Solid.Size = new Size(56, 24);
            rd2Solid.TabIndex = 1;
            rd2Solid.Text = "atm";
            rd2Solid.UseVisualStyleBackColor = true;
            // 
            // rd3Solid
            // 
            rd3Solid.AutoSize = true;
            rd3Solid.Location = new Point(146, 3);
            rd3Solid.Name = "rd3Solid";
            rd3Solid.Size = new Size(70, 24);
            rd3Solid.TabIndex = 2;
            rd3Solid.Text = "cmHg";
            rd3Solid.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(222, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 24);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // btnCopy
            // 
            btnCopy.BackgroundImage = (Image)resources.GetObject("btnCopy.BackgroundImage");
            btnCopy.BackgroundImageLayout = ImageLayout.Zoom;
            btnCopy.Dock = DockStyle.Right;
            btnCopy.Location = new Point(232, 3);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(24, 24);
            btnCopy.TabIndex = 4;
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // lblResultSolid
            // 
            lblResultSolid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResultSolid.AutoSize = true;
            lblResultSolid.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultSolid.Location = new Point(500, 34);
            lblResultSolid.Name = "lblResultSolid";
            tableLayoutPanel1.SetRowSpan(lblResultSolid, 2);
            lblResultSolid.Size = new Size(283, 68);
            lblResultSolid.TabIndex = 9;
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
            tabFluid.Text = "فشار در شاره ها";
            tabFluid.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0930824F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.2291164F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.785203F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.09308F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.7995224F));
            tableLayoutPanel2.Controls.Add(cmbPressureUnitFliud, 2, 3);
            tableLayoutPanel2.Controls.Add(numPressureFliud, 1, 3);
            tableLayoutPanel2.Controls.Add(cmbRhoUnit, 2, 0);
            tableLayoutPanel2.Controls.Add(numHeight, 1, 2);
            tableLayoutPanel2.Controls.Add(numG, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(btnCalculateFliuds, 0, 4);
            tableLayoutPanel2.Controls.Add(lblRho, 3, 0);
            tableLayoutPanel2.Controls.Add(lblG, 3, 1);
            tableLayoutPanel2.Controls.Add(lblHeight, 3, 2);
            tableLayoutPanel2.Controls.Add(numRho, 1, 0);
            tableLayoutPanel2.Controls.Add(cmbGUnit, 2, 1);
            tableLayoutPanel2.Controls.Add(cmbHeightUnit, 2, 2);
            tableLayoutPanel2.Controls.Add(lblResultFliuds, 4, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 4, 0);
            tableLayoutPanel2.Controls.Add(label11, 0, 3);
            tableLayoutPanel2.Controls.Add(lblPressureFliuds, 3, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 97);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(786, 164);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // cmbPressureUnitFliud
            // 
            cmbPressureUnitFliud.Dock = DockStyle.Fill;
            cmbPressureUnitFliud.FormattingEnabled = true;
            cmbPressureUnitFliud.Items.AddRange(new object[] { "Pa", "atm" });
            cmbPressureUnitFliud.Location = new Point(280, 99);
            cmbPressureUnitFliud.Name = "cmbPressureUnitFliud";
            cmbPressureUnitFliud.Size = new Size(70, 28);
            cmbPressureUnitFliud.TabIndex = 7;
            // 
            // numPressureFliud
            // 
            numPressureFliud.DecimalPlaces = 2;
            numPressureFliud.Dock = DockStyle.Fill;
            numPressureFliud.Location = new Point(153, 99);
            numPressureFliud.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numPressureFliud.Name = "numPressureFliud";
            numPressureFliud.Size = new Size(121, 27);
            numPressureFliud.TabIndex = 6;
            numPressureFliud.ThousandsSeparator = true;
            // 
            // cmbRhoUnit
            // 
            cmbRhoUnit.Dock = DockStyle.Fill;
            cmbRhoUnit.FormattingEnabled = true;
            cmbRhoUnit.Items.AddRange(new object[] { "Kg/m³", "g/cm³" });
            cmbRhoUnit.Location = new Point(280, 3);
            cmbRhoUnit.Name = "cmbRhoUnit";
            cmbRhoUnit.Size = new Size(70, 28);
            cmbRhoUnit.TabIndex = 1;
            // 
            // numHeight
            // 
            numHeight.DecimalPlaces = 2;
            numHeight.Dock = DockStyle.Fill;
            numHeight.Location = new Point(153, 67);
            numHeight.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(121, 27);
            numHeight.TabIndex = 4;
            numHeight.ThousandsSeparator = true;
            // 
            // numG
            // 
            numG.DecimalPlaces = 2;
            numG.Dock = DockStyle.Fill;
            numG.Location = new Point(153, 35);
            numG.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numG.Name = "numG";
            numG.Size = new Size(121, 27);
            numG.TabIndex = 2;
            numG.ThousandsSeparator = true;
            numG.Value = new decimal(new int[] { 98, 0, 0, 65536 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 0;
            label4.Text = "چگالی (ρ):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 32);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 0;
            label5.Text = "شتاب گرانش (g):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 64);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 0;
            label6.Text = "ارتفاع (h):";
            // 
            // btnCalculateFliuds
            // 
            tableLayoutPanel2.SetColumnSpan(btnCalculateFliuds, 5);
            btnCalculateFliuds.Dock = DockStyle.Fill;
            btnCalculateFliuds.Location = new Point(80, 131);
            btnCalculateFliuds.Margin = new Padding(80, 3, 80, 3);
            btnCalculateFliuds.Name = "btnCalculateFliuds";
            btnCalculateFliuds.Size = new Size(626, 30);
            btnCalculateFliuds.TabIndex = 8;
            btnCalculateFliuds.Text = "محاسبه";
            btnCalculateFliuds.UseVisualStyleBackColor = true;
            btnCalculateFliuds.Click += btnCalculateFliuds_Click;
            // 
            // lblRho
            // 
            lblRho.AutoSize = true;
            lblRho.Location = new Point(356, 0);
            lblRho.Name = "lblRho";
            lblRho.Size = new Size(0, 20);
            lblRho.TabIndex = 3;
            // 
            // lblG
            // 
            lblG.AutoSize = true;
            lblG.Location = new Point(356, 32);
            lblG.Name = "lblG";
            lblG.Size = new Size(0, 20);
            lblG.TabIndex = 3;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(356, 64);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(0, 20);
            lblHeight.TabIndex = 3;
            // 
            // numRho
            // 
            numRho.DecimalPlaces = 2;
            numRho.Dock = DockStyle.Left;
            numRho.Location = new Point(153, 3);
            numRho.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numRho.Name = "numRho";
            numRho.Size = new Size(121, 27);
            numRho.TabIndex = 0;
            numRho.ThousandsSeparator = true;
            // 
            // cmbGUnit
            // 
            cmbGUnit.Dock = DockStyle.Fill;
            cmbGUnit.Enabled = false;
            cmbGUnit.FormattingEnabled = true;
            cmbGUnit.Items.AddRange(new object[] { "m/s²" });
            cmbGUnit.Location = new Point(280, 35);
            cmbGUnit.Name = "cmbGUnit";
            cmbGUnit.Size = new Size(70, 28);
            cmbGUnit.TabIndex = 3;
            // 
            // cmbHeightUnit
            // 
            cmbHeightUnit.Dock = DockStyle.Fill;
            cmbHeightUnit.FormattingEnabled = true;
            cmbHeightUnit.Items.AddRange(new object[] { "m", "cm" });
            cmbHeightUnit.Location = new Point(280, 67);
            cmbHeightUnit.Name = "cmbHeightUnit";
            cmbHeightUnit.Size = new Size(70, 28);
            cmbHeightUnit.TabIndex = 5;
            // 
            // lblResultFliuds
            // 
            lblResultFliuds.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResultFliuds.AutoSize = true;
            lblResultFliuds.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultFliuds.Location = new Point(506, 32);
            lblResultFliuds.Name = "lblResultFliuds";
            tableLayoutPanel2.SetRowSpan(lblResultFliuds, 3);
            lblResultFliuds.Size = new Size(277, 96);
            lblResultFliuds.TabIndex = 7;
            lblResultFliuds.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(rd1Fliud);
            flowLayoutPanel2.Controls.Add(rd2Fliud);
            flowLayoutPanel2.Controls.Add(rd3Fliud);
            flowLayoutPanel2.Controls.Add(splitter2);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Location = new Point(506, 3);
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
            rd1Fliud.Size = new Size(75, 24);
            rd1Fliud.TabIndex = 0;
            rd1Fliud.TabStop = true;
            rd1Fliud.Text = "SI واحد";
            rd1Fliud.UseVisualStyleBackColor = true;
            // 
            // rd2Fliud
            // 
            rd2Fliud.AutoSize = true;
            rd2Fliud.Location = new Point(84, 3);
            rd2Fliud.Name = "rd2Fliud";
            rd2Fliud.Size = new Size(56, 24);
            rd2Fliud.TabIndex = 0;
            rd2Fliud.Text = "atm";
            rd2Fliud.UseVisualStyleBackColor = true;
            // 
            // rd3Fliud
            // 
            rd3Fliud.AutoSize = true;
            rd3Fliud.Location = new Point(146, 3);
            rd3Fliud.Name = "rd3Fliud";
            rd3Fliud.Size = new Size(70, 24);
            rd3Fliud.TabIndex = 0;
            rd3Fliud.Text = "cmHg";
            rd3Fliud.UseVisualStyleBackColor = true;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(222, 3);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 24);
            splitter2.TabIndex = 6;
            splitter2.TabStop = false;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Dock = DockStyle.Right;
            button2.Location = new Point(232, 3);
            button2.Name = "button2";
            button2.Size = new Size(24, 24);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 96);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 0;
            label11.Text = "فشار (P):";
            // 
            // lblPressureFliuds
            // 
            lblPressureFliuds.AutoSize = true;
            lblPressureFliuds.Location = new Point(356, 96);
            lblPressureFliuds.Name = "lblPressureFliuds";
            lblPressureFliuds.Size = new Size(0, 20);
            lblPressureFliuds.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(786, 94);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PressureFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Physics Solver - فشار";
            Load += PressureFrm_Load;
            tabControl1.ResumeLayout(false);
            tabSolid.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPressureSolid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)numForce).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabFluid.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPressureFliud).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numG).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRho).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabSolid;
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
        private ComboBox cmbForceUnit;
        private ComboBox cmbAreaUnit;
        private ComboBox cmbPressureUnitSolid;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton rd1Solid;
        private RadioButton rd2Solid;
        private RadioButton rd3Solid;
        private TabPage tabFluid;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cmbRhoUnit;
        private NumericUpDown numHeight;
        private NumericUpDown numG;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCalculateFliuds;
        private Label lblRho;
        private Label lblG;
        private Label lblHeight;
        private NumericUpDown numRho;
        private ComboBox cmbGUnit;
        private ComboBox cmbHeightUnit;
        private Label lblResultFliuds;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton rd1Fliud;
        private RadioButton rd2Fliud;
        private PictureBox pictureBox2;
        private Label label11;
        private ComboBox cmbPressureUnitFliud;
        private NumericUpDown numPressureFliud;
        private Label lblPressureFliuds;
        private RadioButton rd3Fliud;
        private Button btnCopy;
        private Button button2;
        private Splitter splitter1;
        private Splitter splitter2;
    }
}