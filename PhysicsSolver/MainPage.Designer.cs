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
            btnPresure = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            tableLayoutPanel1.SetColumnSpan(lblWelcome, 2);
            lblWelcome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(3, 0);
            lblWelcome.MaximumSize = new Size(465, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(452, 47);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Hi. Please choose type of physics problem that you're going to solve:";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcome.Visible = false;
            // 
            // btnPresure
            // 
            btnPresure.Location = new Point(232, 155);
            btnPresure.Name = "btnPresure";
            btnPresure.Size = new Size(94, 29);
            btnPresure.TabIndex = 1;
            btnPresure.Text = "Presure";
            btnPresure.UseVisualStyleBackColor = true;
            btnPresure.Click += btnPresure_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblWelcome, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPresure, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(458, 304);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 328);
            Controls.Add(tableLayoutPanel1);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            Load += MainPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Button btnPresure;
        private TableLayoutPanel tableLayoutPanel1;
    }
}