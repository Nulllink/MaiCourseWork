using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiCourseWork
{
    public partial class MenuF : Form
    {
        
        public MenuF(int role)
        {
            InitializeComponent();
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
    }
}
