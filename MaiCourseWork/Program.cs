using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MaiCourseWork
{
    static class Program
    {
        public static List<Form> lof = new List<Form>();
        public static string optionpath = "Options.txt";
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            lof.Add(new FrmLogIn());
            Application.Run(lof[0]);
        }
        public static void OptionFile()
        {
            string[] ot = new string[] 
            { 
                "Remember me:False",
                "root root",
                "DB mode:False"
            };
            File.WriteAllLines(optionpath, ot);
        }
    }
}
