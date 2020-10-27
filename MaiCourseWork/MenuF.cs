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
    public partial class MenuF : Form
    {
        int role;
        public MenuF(int _role,string _name)
        {
            InitializeComponent();
            role = _role;
            LAcName.Text = _name;
            rolesetings();
        }
        void rolesetings()
        {
            if (role == 0)
            {
                string[] lines = File.ReadAllLines(Program.optionpath);
                if (bool.Parse(lines[2].Substring(lines[2].IndexOf(':') + 1)))
                {
                    CbDbMode.Checked = true;
                }
                else
                {
                    CbDbMode.Checked = false;
                }
                CbDbMode.Visible = true;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Program.lof[0].Close();
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            Program.lof[0].Show();
            Close();
        }

        private void CbDbMode_CheckedChanged(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(Program.optionpath);
            lines[2] = $"{lines[2].Remove(lines[2].IndexOf(':'))}:{CbDbMode.Checked}";
            File.WriteAllLines(Program.optionpath, lines);
        }
    }
}
