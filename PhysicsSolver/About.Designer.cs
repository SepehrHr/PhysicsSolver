﻿namespace PhysicsSolver
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linklblGithub = new LinkLabel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(253, 132, 105);
            label1.Location = new Point(134, 17);
            label1.Name = "label1";
            label1.Size = new Size(275, 54);
            label1.TabIndex = 0;
            label1.Text = "Physics Solver";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 99);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(436, 20);
            label2.TabIndex = 1;
            label2.Text = "Physics Solver نرم افزاری برای حل مسائل فیزیک طبق فرمول آنهاست.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 119);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "نسخه: 1.2.7";
            // 
            // linklblGithub
            // 
            linklblGithub.AutoSize = true;
            linklblGithub.LinkArea = new LinkArea(36, 18);
            linklblGithub.LinkColor = Color.FromArgb(13, 110, 253);
            linklblGithub.Location = new Point(78, 197);
            linklblGithub.Name = "linklblGithub";
            linklblGithub.RightToLeft = RightToLeft.Yes;
            linklblGithub.Size = new Size(394, 25);
            linklblGithub.TabIndex = 3;
            linklblGithub.TabStop = true;
            linklblGithub.Text = "طراحی و توسعه توسط: سپهر حکمت راد | مخزن Github برنامه";
            linklblGithub.UseCompatibleTextRendering = true;
            linklblGithub.LinkClicked += linklblGithub_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(12, 81);
            label4.Name = "label4";
            label4.Size = new Size(462, 1);
            label4.TabIndex = 5;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 231);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(linklblGithub);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "درباره برنامه";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linklblGithub;
        private PictureBox pictureBox1;
        private Label label4;
    }
}