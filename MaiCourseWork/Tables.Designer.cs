namespace MaiCourseWork
{
    partial class Tables
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
            this.DgwData = new System.Windows.Forms.DataGridView();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.TsmiWrite = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TslWrite = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DgwData)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgwData
            // 
            this.DgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwData.Location = new System.Drawing.Point(12, 39);
            this.DgwData.Name = "DgwData";
            this.DgwData.Size = new System.Drawing.Size(476, 315);
            this.DgwData.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiWrite});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(500, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // TsmiWrite
            // 
            this.TsmiWrite.Name = "TsmiWrite";
            this.TsmiWrite.Size = new System.Drawing.Size(47, 20);
            this.TsmiWrite.Text = "Write";
            this.TsmiWrite.Click += new System.EventHandler(this.TsmiWrite_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TslWrite});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(500, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TslWrite
            // 
            this.TslWrite.Name = "TslWrite";
            this.TslWrite.Size = new System.Drawing.Size(0, 17);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 382);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DgwData);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Tables";
            this.Text = "Tables";
            ((System.ComponentModel.ISupportInitialize)(this.DgwData)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwData;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TsmiWrite;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TslWrite;
    }
}