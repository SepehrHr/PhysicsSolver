namespace PhysicsSolver
{
    partial class MainPage
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
            lblWelcome = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            btnU = new Button();
            button3 = new Button();
            btnKinetic = new Button();
            groupBox2 = new GroupBox();
            btnPressure = new Button();
            btnDensity = new Button();
            groupBox3 = new GroupBox();
            btnPower = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnQuit = new Button();
            btnAbout = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.MaximumSize = new Size(465, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.RightToLeft = RightToLeft.Yes;
            lblWelcome.Size = new Size(465, 45);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "مسئله ای که میخواهید حل کنید را انتخاب کنید:";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 45);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.328331F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.328331F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.328331F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.0150156F));
            tableLayoutPanel1.Size = new Size(482, 283);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnU);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnKinetic);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(476, 74);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "انرژی (فصل 3 فیزیک دهم)";
            // 
            // btnU
            // 
            btnU.Dock = DockStyle.Fill;
            btnU.Location = new Point(135, 23);
            btnU.Name = "btnU";
            btnU.Size = new Size(198, 48);
            btnU.TabIndex = 1;
            btnU.Text = "انرژی پتانسیل گرانشی";
            btnU.UseVisualStyleBackColor = true;
            btnU.Click += btnU_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(3, 23);
            button3.Name = "button3";
            button3.Size = new Size(132, 48);
            button3.TabIndex = 2;
            button3.Text = "کار";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnKinetic
            // 
            btnKinetic.Dock = DockStyle.Right;
            btnKinetic.Location = new Point(333, 23);
            btnKinetic.Name = "btnKinetic";
            btnKinetic.Size = new Size(140, 48);
            btnKinetic.TabIndex = 0;
            btnKinetic.Text = "انرژی جنبشی";
            btnKinetic.UseVisualStyleBackColor = true;
            btnKinetic.Click += btnKinetic_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPressure);
            groupBox2.Controls.Add(btnDensity);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(476, 74);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "سایر";
            // 
            // btnPressure
            // 
            btnPressure.Dock = DockStyle.Right;
            btnPressure.Location = new Point(239, 23);
            btnPressure.Name = "btnPressure";
            btnPressure.Size = new Size(234, 48);
            btnPressure.TabIndex = 0;
            btnPressure.Text = "فشار";
            btnPressure.UseVisualStyleBackColor = true;
            btnPressure.Click += btnPressure_Click;
            // 
            // btnDensity
            // 
            btnDensity.Dock = DockStyle.Left;
            btnDensity.Location = new Point(3, 23);
            btnDensity.Name = "btnDensity";
            btnDensity.Size = new Size(234, 48);
            btnDensity.TabIndex = 1;
            btnDensity.Text = "چگالی";
            btnDensity.UseVisualStyleBackColor = true;
            btnDensity.Click += btnDensity_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPower);
            groupBox3.Controls.Add(button1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 83);
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = RightToLeft.Yes;
            groupBox3.Size = new Size(476, 74);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "گرما (فصل 4 فیزیک دهم)";
            // 
            // btnPower
            // 
            btnPower.Dock = DockStyle.Right;
            btnPower.Location = new Point(239, 23);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(234, 48);
            btnPower.TabIndex = 0;
            btnPower.Text = "توان گرمایی";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += btnPower_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(3, 23);
            button1.Name = "button1";
            button1.Size = new Size(234, 48);
            button1.TabIndex = 1;
            button1.Text = "انرژی گرمایی";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnQuit);
            flowLayoutPanel1.Controls.Add(btnAbout);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 243);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(476, 37);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(379, 3);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 0;
            btnQuit.Text = "خروج";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(279, 3);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(94, 29);
            btnAbout.TabIndex = 1;
            btnAbout.Text = "درباره برنامه";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 328);
            Controls.Add(lblWelcome);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Physics Solver";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnPressure;
        private Button btnDensity;
        private Button button3;
        private Button btnKinetic;
        private GroupBox groupBox1;
        private Button btnU;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnPower;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnQuit;
        private Button btnAbout;
    }
}