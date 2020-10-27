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
    public partial class Tables : Form
    {
        int table;
        bool mode;
        public Tables(int _table,bool _mode)
        {
            InitializeComponent();

            table = _table;
            mode = _mode;
            DgwData.Columns.Add("index", "Index");
            if (table < 2)
            {
                DgwData.Columns.Add("item", "Item");
                DgwData.Columns.Add("company", "Company");
                DgwData.Columns.Add("amount", "Amount");
            }
            else if (table == 2)
            {
                DgwData.Columns.Add("name", "Name");
                DgwData.Columns.Add("amount", "Amount");
                DgwData.Columns.Add("prise", "Prise");
            }
            data();
        }
        public void data()
        {
            if (mode)//Мод базы данных
            {

            }
            else//мод файла 
            {

            }
        }

        private void TsmiWrite_Click(object sender, EventArgs e)
        {

        }
    }
}
