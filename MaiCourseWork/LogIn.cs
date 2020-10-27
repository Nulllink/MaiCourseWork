using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MaiCourseWork
{
    public partial class FrmLogIn : Form
    {
        int role;
        public FrmLogIn()
        {
            InitializeComponent();
            if (!File.Exists(Program.optionpath))
            {
                Program.OptionFile();
            }
            string[] lines = File.ReadAllLines(Program.optionpath);
            if (bool.Parse(lines[0].Substring(lines[0].IndexOf(':')+1)))
            {
                TbName.Text = lines[1].Remove(lines[1].IndexOf(' '));
                TbPass.Text = lines[1].Substring(lines[1].IndexOf(' ')+1);
                CbRemMe.Checked = true;
            }
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            if (rolegiving())
            {
                checking();
                MenuF mf = new MenuF(role,TbName.Text);
                mf.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Введеный логин или пароль неверен");
            }
        }
        bool rolegiving()
        {
            if(TbName.Text == "root" && TbPass.Text == "root")
            {
                role = 0;
                return true;
            }

            return false;
        }
        void checking()
        {
            if (CbRemMe.Checked)
            {
                string[] lines = File.ReadAllLines(Program.optionpath);
                lines[0] = $"{lines[0].Remove(lines[0].IndexOf(':'))}:{CbRemMe.Checked}";
                if (CbRemMe.Checked)
                {
                    lines[1] = $"{TbName.Text} {TbPass.Text}";
                }
                File.WriteAllLines(Program.optionpath, lines);
            }
        }
    }
}
