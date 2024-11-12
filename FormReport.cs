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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet5.View_DetailStudentByClass' table. You can move, or remove it, as needed.
            this.view_DetailStudentByClassTableAdapter.Fill(this.dataSet5.View_DetailStudentByClass);
            // TODO: This line of code loads data into the 'dataSet4.StudentGrades' table. You can move, or remove it, as needed.
            this.studentGradesTableAdapter.Fill(this.dataSet4.StudentGrades);
            // TODO: This line of code loads data into the 'dataSet3.View_DetailStudentByDepartment' table. You can move, or remove it, as needed.
            this.view_DetailStudentByDepartmentTableAdapter.Fill(this.dataSet3.View_DetailStudentByDepartment);
            // TODO: This line of code loads data into the 'dataSet2.View_StudentsByClass' table. You can move, or remove it, as needed.
            this.view_StudentsByClassTableAdapter.Fill(this.dataSet2.View_StudentsByClass);
            // TODO: This line of code loads data into the 'dataSet1.View_StudentsByDepartment' table. You can move, or remove it, as needed.
            this.view_StudentsByDepartmentTableAdapter.Fill(this.dataSet1.View_StudentsByDepartment);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }
    }
}
