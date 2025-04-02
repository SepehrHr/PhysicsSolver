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
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.MaximumSize = new Size(465, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(465, 45);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Hi. Please choose type of physics problem that you're going to solve:";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 45);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            groupBox1.Size = new Size(476, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Energy";
            // 
            // btnU
            // 
            btnU.Dock = DockStyle.Fill;
            btnU.Location = new Point(135, 23);
            btnU.Name = "btnU";
            btnU.Size = new Size(198, 62);
            btnU.TabIndex = 1;
            btnU.Text = "Gravitational Energy (U)";
            btnU.UseVisualStyleBackColor = true;
            btnU.Click += btnU_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(3, 23);
            button3.Name = "button3";
            button3.Size = new Size(132, 62);
            button3.TabIndex = 0;
            button3.Text = "Work";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnKinetic
            // 
            btnKinetic.Dock = DockStyle.Right;
            btnKinetic.Location = new Point(333, 23);
            btnKinetic.Name = "btnKinetic";
            btnKinetic.Size = new Size(140, 62);
            btnKinetic.TabIndex = 2;
            btnKinetic.Text = "Kinetic Energy";
            btnKinetic.UseVisualStyleBackColor = true;
            btnKinetic.Click += btnKinetic_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPressure);
            groupBox2.Controls.Add(btnDensity);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(476, 89);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Other";
            // 
            // btnPressure
            // 
            btnPressure.Dock = DockStyle.Right;
            btnPressure.Location = new Point(239, 23);
            btnPressure.Name = "btnPressure";
            btnPressure.Size = new Size(234, 63);
            btnPressure.TabIndex = 1;
            btnPressure.Text = "Pressure";
            btnPressure.UseVisualStyleBackColor = true;
            btnPressure.Click += btnPressure_Click;
            // 
            // btnDensity
            // 
            btnDensity.Dock = DockStyle.Left;
            btnDensity.Location = new Point(3, 23);
            btnDensity.Name = "btnDensity";
            btnDensity.Size = new Size(234, 63);
            btnDensity.TabIndex = 0;
            btnDensity.Text = "Density";
            btnDensity.UseVisualStyleBackColor = true;
            btnDensity.Click += btnDensity_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 97);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(476, 88);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Heat";
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.Location = new Point(239, 23);
            button2.Name = "button2";
            button2.Size = new Size(234, 62);
            button2.TabIndex = 1;
            button2.Text = "Power (Heat)";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(3, 23);
            button1.Name = "button1";
            button1.Size = new Size(234, 62);
            button1.TabIndex = 0;
            button1.Text = "Heat Energy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
        private Button button2;
        private Button button1;
    }
}