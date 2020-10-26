namespace MaiCourseWork
{
    partial class LogIn
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInbtn = new System.Windows.Forms.Button();
            this.RemMeChB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(27, 53);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(283, 20);
            this.NameTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(27, 110);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(283, 20);
            this.PassTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // LogInbtn
            // 
            this.LogInbtn.Location = new System.Drawing.Point(242, 151);
            this.LogInbtn.Name = "LogInbtn";
            this.LogInbtn.Size = new System.Drawing.Size(75, 23);
            this.LogInbtn.TabIndex = 4;
            this.LogInbtn.Text = "Log In";
            this.LogInbtn.UseVisualStyleBackColor = true;
            this.LogInbtn.Click += new System.EventHandler(this.LogInbtn_Click);
            // 
            // RemMeChB
            // 
            this.RemMeChB.AutoSize = true;
            this.RemMeChB.Location = new System.Drawing.Point(27, 151);
            this.RemMeChB.Name = "RemMeChB";
            this.RemMeChB.Size = new System.Drawing.Size(95, 17);
            this.RemMeChB.TabIndex = 5;
            this.RemMeChB.Text = "Remember Me";
            this.RemMeChB.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 188);
            this.Controls.Add(this.RemMeChB);
            this.Controls.Add(this.LogInbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTB);
            this.Name = "LogIn";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogInbtn;
        private System.Windows.Forms.CheckBox RemMeChB;
    }
}

