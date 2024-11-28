using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MenuManage mainForm = new MenuManage();
            Login loginForm = new Login(mainForm);

            // Chỉ hiển thị form đăng nhập khi chương trình khởi chạy
            //loginForm.Show();
            //mainForm.Hide();

            Application.Run(new EnrollmentManage());
        }
    }
}
