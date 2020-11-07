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
    public partial class Tables : Form
    {
        int table;
        bool mode;
        public Tables(int _table, bool _mode)
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
                //заполнение таблицы данными из файла
                switch (table)
                {
                    case 0:
                        if (File.Exists("Purchase.txt"))
                        {
                            string[] filetext = File.ReadAllLines("Purchase.txt");
                            for (int i = 0; i < filetext.Length; i++)
                            {
                                string[] text = filetext[i].Split();
                                DgwData.Rows.Add();
                                DgwData.Rows[i].Cells[0].Value = text[0];
                                DgwData.Rows[i].Cells[1].Value = text[1];
                                DgwData.Rows[i].Cells[2].Value = text[2];
                                DgwData.Rows[i].Cells[3].Value = text[3];
                            }
                        }
                        else
                        {
                            MessageBox.Show("Purchase.txt not exist");
                        }
                        break;
                    case 1:
                        if (File.Exists("Sells.txt"))
                        {
                            string[] filetext = File.ReadAllLines("Sells.txt");
                            for (int i = 0; i < filetext.Length; i++)
                            {
                                string[] text = filetext[i].Split();
                                DgwData.Rows.Add();
                                DgwData.Rows[i].Cells[0].Value = text[0];
                                DgwData.Rows[i].Cells[1].Value = text[1];
                                DgwData.Rows[i].Cells[2].Value = text[2];
                                DgwData.Rows[i].Cells[3].Value = text[3];
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sells.txt not exist");
                        }
                        break;
                    case 2:
                        if (File.Exists("Stock.txt"))
                        {
                            string[] filetext = File.ReadAllLines("Stock.txt");
                            for (int i = 0; i < filetext.Length; i++)
                            {
                                string[] text = filetext[i].Split();
                                DgwData.Rows.Add();
                                DgwData.Rows[i].Cells[0].Value = text[0];
                                DgwData.Rows[i].Cells[1].Value = text[1];
                                DgwData.Rows[i].Cells[2].Value = text[2];
                                DgwData.Rows[i].Cells[3].Value = text[3];
                            }
                        }
                        else
                        {
                            MessageBox.Show("Stock.txt not exist");
                        }
                        break;
                }
            }
        }

        private void TsmiWrite_Click(object sender, EventArgs e)
        {
            if (mode)//Мод базы данных
            {
                
            }
            else
            {
                StreamWriter sw;
                switch (table)
                {
                    case 0:
                        sw = new StreamWriter("Purchase.txt");
                        for (int i = 0; i < DgwData.Rows.Count - 1; i++)
                        {
                            sw.WriteLine($"{DgwData.Rows[i].Cells[0].Value} {DgwData.Rows[i].Cells[1].Value} {DgwData.Rows[i].Cells[2].Value} {DgwData.Rows[i].Cells[3].Value}");
                        }
                        sw.Close();
                        break;
                    case 1:
                        sw = new StreamWriter("Sells.txt");
                        for (int i = 0; i < DgwData.Rows.Count - 1; i++)
                        {
                            sw.WriteLine($"{DgwData.Rows[i].Cells[0].Value} {DgwData.Rows[i].Cells[1].Value} {DgwData.Rows[i].Cells[2].Value} {DgwData.Rows[i].Cells[3].Value}");
                        }
                        sw.Close();
                        break;
                    case 2:
                        sw = new StreamWriter("Stock.txt");
                        for (int i = 0; i < DgwData.Rows.Count - 1; i++)
                        {
                            sw.WriteLine($"{DgwData.Rows[i].Cells[0].Value} {DgwData.Rows[i].Cells[1].Value} {DgwData.Rows[i].Cells[2].Value} {DgwData.Rows[i].Cells[3].Value}");
                        }
                        sw.Close();
                        break;
                }
                TslWrite.Text = "Data was updated";
            }
        }
    }
}
