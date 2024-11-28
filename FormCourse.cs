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
    public partial class FormCourse : Form
    {
        private string courseID;
        public FormCourse(string courseID)
        {
            this.courseID = courseID;
            InitializeComponent(); 
        }

        private void FormCourse_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(courseID))  //Nếu không có thông tin => thêm mới môn học
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhật thông tin môn học";
                var r = new Database().Select("SelectCourse '" + courseID + "'");
                //MessageBox.Show(r[0].ToString());

                txtCourseName.Text = r["CourseName"].ToString();
                txtDepartmentID.Text = r["DepartmentID"].ToString();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            string courseName = txtCourseName.Text;
            string departmentID = txtDepartmentID.Text;

            List<CustomParameter> lstPara = new List<CustomParameter>();

                if (string.IsNullOrEmpty(courseID))
                {
                    sql = "CreateCourse";

                }
                else
                {
                    sql = "UpdateCourse";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@CourseID",
                        value = courseID
                    });
                }
                if (string.IsNullOrWhiteSpace(courseName))
                {
                    // Ném ra ngoại lệ với thông báo lỗi
                    MessageBox.Show("Tên không hợp lệ, vui lòng nhập lại.");
                    txtCourseName.Select();
                return;
                }
                else
                {
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@CourseName",
                        value = courseName
                    });
                }
                if (string.IsNullOrWhiteSpace(departmentID))
                {
                    MessageBox.Show("Mã không hợp lệ, vui lòng nhập lại.");
                    txtDepartmentID.Select();
                return;
                }
                else
                {
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@DepartmentID",
                        value = departmentID
                    });
                }            
                var rs = new Database().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(courseID))
                    {
                        MessageBox.Show("Thêm mới môn học thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin môn học thành công");
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Mã khoa không hợp lệ hoặc không tồn tại.Vui lòng nhập lại");
                    txtDepartmentID.Select();
                }      
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
