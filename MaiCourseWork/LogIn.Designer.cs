namespace MaiCourseWork
{
    partial class FrmLogIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.TbPass = new System.Windows.Forms.TextBox();
            this.LPassword = new System.Windows.Forms.Label();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.CbRemMe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(27, 53);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(283, 20);
            this.TbName.TabIndex = 0;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(27, 34);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(35, 13);
            this.LName.TabIndex = 1;
            this.LName.Text = "Name";
            // 
            // TbPass
            // 
            this.TbPass.Location = new System.Drawing.Point(27, 110);
            this.TbPass.Name = "TbPass";
            this.TbPass.Size = new System.Drawing.Size(283, 20);
            this.TbPass.TabIndex = 2;
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(27, 94);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(53, 13);
            this.LPassword.TabIndex = 3;
            this.LPassword.Text = "Password";
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Location = new System.Drawing.Point(242, 151);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(75, 23);
            this.BtnLogIn.TabIndex = 4;
            this.BtnLogIn.Text = "Log In";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            this.BtnLogIn.Click += new System.EventHandler(this.LogInbtn_Click);
            // 
            // CbRemMe
            // 
            this.CbRemMe.AutoSize = true;
            this.CbRemMe.Location = new System.Drawing.Point(27, 151);
            this.CbRemMe.Name = "CbRemMe";
            this.CbRemMe.Size = new System.Drawing.Size(95, 17);
            this.CbRemMe.TabIndex = 5;
            this.CbRemMe.Text = "Remember Me";
            this.CbRemMe.UseVisualStyleBackColor = true;
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 188);
            this.Controls.Add(this.CbRemMe);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.TbPass);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.TbName);
            this.Name = "FrmLogIn";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox TbPass;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.CheckBox CbRemMe;
    }
}

