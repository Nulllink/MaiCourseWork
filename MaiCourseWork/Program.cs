using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiCourseWork
{
    static class Program
    {
        public static List<Form> lof = new List<Form>();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            lof.Add(new LogIn());
            Application.Run(lof[0]);
        }
    }
}
