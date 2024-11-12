using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class MenuManage : Form
    {
        public MenuManage()
        {
            InitializeComponent();
        }

        private void MenuManage_Load(object sender, EventArgs e)
        {
            
        }

        private void MenuManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDerpartment_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentManage departmentManage = new DepartmentManage();
            departmentManage.ShowDialog();
            departmentManage = null;
            this.Show();   
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseManage courseManage = new CourseManage();
            courseManage.ShowDialog();
            courseManage = null;
            this.Show();
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollmentManage enrollmentManage = new EnrollmentManage();
            enrollmentManage.ShowDialog();
            enrollmentManage = null;
            this.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManage studentManage = new StudentManage();
            studentManage.ShowDialog();
            studentManage = null;
            this.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
            formReport = null;
            this.Show();
        }
    }
}
