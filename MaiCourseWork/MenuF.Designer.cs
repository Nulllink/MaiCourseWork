﻿namespace MaiCourseWork
{
    partial class MenuF
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSignOut = new System.Windows.Forms.Button();
            this.LAcName = new System.Windows.Forms.Label();
            this.CbDbMode = new System.Windows.Forms.CheckBox();
            this.BtnPurch = new System.Windows.Forms.Button();
            this.BtnSells = new System.Windows.Forms.Button();
            this.BtnStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(119, 148);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BtnSignOut
            // 
            this.BtnSignOut.Location = new System.Drawing.Point(243, 12);
            this.BtnSignOut.Name = "BtnSignOut";
            this.BtnSignOut.Size = new System.Drawing.Size(75, 23);
            this.BtnSignOut.TabIndex = 1;
            this.BtnSignOut.Text = "Sign out";
            this.BtnSignOut.UseVisualStyleBackColor = true;
            this.BtnSignOut.Click += new System.EventHandler(this.SignOutBtn_Click);
            // 
            // LAcName
            // 
            this.LAcName.AutoSize = true;
            this.LAcName.Location = new System.Drawing.Point(161, 17);
            this.LAcName.Name = "LAcName";
            this.LAcName.Size = new System.Drawing.Size(48, 13);
            this.LAcName.TabIndex = 2;
            this.LAcName.Text = "AcName";
            // 
            // CbDbMode
            // 
            this.CbDbMode.AutoSize = true;
            this.CbDbMode.Location = new System.Drawing.Point(13, 17);
            this.CbDbMode.Name = "CbDbMode";
            this.CbDbMode.Size = new System.Drawing.Size(70, 17);
            this.CbDbMode.TabIndex = 3;
            this.CbDbMode.Text = "DB mode";
            this.CbDbMode.UseVisualStyleBackColor = true;
            this.CbDbMode.Visible = false;
            this.CbDbMode.CheckedChanged += new System.EventHandler(this.CbDbMode_CheckedChanged);
            // 
            // BtnPurch
            // 
            this.BtnPurch.Location = new System.Drawing.Point(22, 55);
            this.BtnPurch.Name = "BtnPurch";
            this.BtnPurch.Size = new System.Drawing.Size(75, 23);
            this.BtnPurch.TabIndex = 4;
            this.BtnPurch.Text = "Закупки";
            this.BtnPurch.UseVisualStyleBackColor = true;
            this.BtnPurch.Click += new System.EventHandler(this.BtnPurch_Click);
            // 
            // BtnSells
            // 
            this.BtnSells.Location = new System.Drawing.Point(119, 55);
            this.BtnSells.Name = "BtnSells";
            this.BtnSells.Size = new System.Drawing.Size(75, 23);
            this.BtnSells.TabIndex = 5;
            this.BtnSells.Text = "Продажи";
            this.BtnSells.UseVisualStyleBackColor = true;
            this.BtnSells.Click += new System.EventHandler(this.BtnSells_Click);
            // 
            // BtnStock
            // 
            this.BtnStock.Location = new System.Drawing.Point(217, 55);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(75, 23);
            this.BtnStock.TabIndex = 6;
            this.BtnStock.Text = "Склад";
            this.BtnStock.UseVisualStyleBackColor = true;
            this.BtnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // MenuF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 196);
            this.Controls.Add(this.BtnStock);
            this.Controls.Add(this.BtnSells);
            this.Controls.Add(this.BtnPurch);
            this.Controls.Add(this.CbDbMode);
            this.Controls.Add(this.LAcName);
            this.Controls.Add(this.BtnSignOut);
            this.Controls.Add(this.BtnExit);
            this.Name = "MenuF";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSignOut;
        private System.Windows.Forms.Label LAcName;
        private System.Windows.Forms.CheckBox CbDbMode;
        private System.Windows.Forms.Button BtnPurch;
        private System.Windows.Forms.Button BtnSells;
        private System.Windows.Forms.Button BtnStock;
    }
}