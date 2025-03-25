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
            btnPressure = new Button();
            btnDensity = new Button();
            button3 = new Button();
            btnKinetic = new Button();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnPressure, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDensity, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 3);
            tableLayoutPanel1.Controls.Add(btnKinetic, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 45);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(482, 283);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnPressure
            // 
            btnPressure.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPressure.Location = new Point(3, 3);
            btnPressure.Name = "btnPressure";
            btnPressure.Size = new Size(476, 64);
            btnPressure.TabIndex = 0;
            btnPressure.Text = "Pressure";
            btnPressure.UseVisualStyleBackColor = true;
            btnPressure.Click += btnPressure_Click;
            // 
            // btnDensity
            // 
            btnDensity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDensity.Location = new Point(3, 73);
            btnDensity.Name = "btnDensity";
            btnDensity.Size = new Size(476, 64);
            btnDensity.TabIndex = 1;
            btnDensity.Text = "Density";
            btnDensity.UseVisualStyleBackColor = true;
            btnDensity.Click += btnDensity_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(3, 213);
            button3.Name = "button3";
            button3.Size = new Size(476, 67);
            button3.TabIndex = 3;
            button3.Text = "Work";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnKinetic
            // 
            btnKinetic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnKinetic.Location = new Point(3, 143);
            btnKinetic.Name = "btnKinetic";
            btnKinetic.Size = new Size(476, 64);
            btnKinetic.TabIndex = 2;
            btnKinetic.Text = "Kinetic Energy";
            btnKinetic.UseVisualStyleBackColor = true;
            btnKinetic.Click += btnKinetic_Click;
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
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnPressure;
        private Button btnDensity;
        private Button button3;
        private Button btnKinetic;
    }
}