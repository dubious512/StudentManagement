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
    public partial class FormEnrollment : Form
    {
        private string enrollmentID;
        public FormEnrollment(string enrollmentID)
        {
            this.enrollmentID = enrollmentID;
            InitializeComponent();
        }

        private void FormEnrollment_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(enrollmentID))  //Nếu không có thông tin => thêm mới sinh viên
            {
                this.Text = "Thêm mới điểm cho sinh viên";
            }
            else
            {
                this.Text = "Cập nhật điểm sinh viên";
                var r = new Database().Select("SelectEnrollment '" + enrollmentID + "'");
                //MessageBox.Show(r[0].ToString());

                txtStudentID.Text = r["StudentID"].ToString();
                txtCourseID.Text = r["CourseID"].ToString();
                txtGrade.Text = r["Grade"].ToString();
                DateTime enrollmentDate = Convert.ToDateTime(r["EnrollmentDate"]);
                mtbEnrollmentDate.Text = enrollmentDate.ToString("dd/MM/yyyy");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            string studentID = txtStudentID.Text;
            string courseID = txtCourseID.Text;
            string grade = txtGrade.Text;
            DateTime enrollmentDate;
            enrollmentDate = mtbEnrollmentDate.Value;

            
            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(enrollmentID))
            {
                sql = "CreateEnrollment";

            }
            else
            {
                sql = "UpdateEnrollment";
                lstPara.Add(new CustomParameter()
                {
                    key = "@EnrollmentID",
                    value = enrollmentID
                });
            }

                lstPara.Add(new CustomParameter()
                {
                    key = "@StudentID",
                    value = studentID
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@CourseID",
                    value = courseID
                });
                        
            lstPara.Add(new CustomParameter()
            {
                key = "@Grade",
                value = grade
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@EnrollmentDate",
                value = enrollmentDate.ToString("yyyy-dd-MM")
            });

            var rs = new Database().ExeCute(sql, lstPara);

            if (rs == 1)
            {
                if (string.IsNullOrEmpty(studentID))
                {
                    MessageBox.Show("Thêm điểm thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật điểm thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ vui lòng nhập lại");               
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

    }
}
