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
    public partial class LogIn : Form
    {
        public int role;
        public LogIn()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines("Options.txt");
            if (bool.Parse(lines[0].Substring(lines[0].IndexOf(':')+1)))
            {
                NameTB.Text = lines[1].Remove(lines[1].IndexOf(' '));
                PassTB.Text = lines[1].Substring(lines[1].IndexOf(' ')+1);
                RemMeChB.Checked = true;
            }
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            checking();
            rolegiving();
            MenuF mf = new MenuF(role);
            mf.Show();
            Hide();
        }
        void rolegiving()
        {
            if(NameTB.Text == "root")
            {
                role = 0;
            }
        }
        void checking()
        {
            if (RemMeChB.Checked)
            {
                string[] lines = File.ReadAllLines("Options.txt");
                lines[0] = $"{lines[0].Remove(lines[0].IndexOf(':'))}:{RemMeChB.Checked.ToString()}";
                if (RemMeChB.Checked)
                {
                    lines[1] = $"{NameTB.Text} {PassTB.Text}";
                }
                File.WriteAllLines("Options.txt", lines);
            }
        }
    }
}
