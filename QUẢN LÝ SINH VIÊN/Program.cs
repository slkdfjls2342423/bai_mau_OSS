using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUẢN_LÝ_SINH_VIÊN
{
    static class Program
    {
        public static string conStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True;";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frDangnhap());
        }
    }
}
