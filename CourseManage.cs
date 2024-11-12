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
    public partial class CourseManage : Form
    {
        public CourseManage()
        {
            InitializeComponent();
        }

        private void CourseManage_Load(object sender, EventArgs e)
        {
            LoadCourseList();
        }
        private void LoadCourseList()
        {

            //Load toàn bộ danh sách khoa học

            //Khai báo list customparameter
            List<CustomParameter> lstPara = new List<CustomParameter>();
            string keyword = txtSearch.Text;
            lstPara.Add(new CustomParameter()
            {
                key = "@Keyword",
                value = keyword
            });

            dgvCourse.DataSource = new Database().SelectData("SelectAllCourse", lstPara);
            //Đặt tên cột  
            dgvCourse.Columns["CourseID"].HeaderText = "Mã môn học";
            dgvCourse.Columns["CourseName"].HeaderText = "Tên môn học";
            dgvCourse.Columns["DepartmentID"].HeaderText = "Mã khoa";
            
        }
        private void dgvCourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DoubleClick hiện ra form để cập nhật thông tin khoa học
            if (e.RowIndex >= 0)
            {
                var courseID = dgvCourse.Rows[e.RowIndex].Cells["CourseID"].Value.ToString();
                new FormCourse(courseID).ShowDialog();
                LoadCourseList();
            }

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            new FormCourse(null).ShowDialog();
            LoadCourseList();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCourseList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvCourse.CurrentRow.Cells["CourseID"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa môn học này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sql = "";
                string courseID = id.ToString();
                List<CustomParameter> lstpara = new List<CustomParameter>();

                {
                    sql = "DeleteCourse";
                    lstpara.Add(new CustomParameter()
                    {
                        key = "@CourseID",
                        value = courseID
                    });
                }
                var rs = new Database().ExeCute(sql, lstpara);
                if (rs == 1)
                {
                    if (!string.IsNullOrEmpty(courseID))
                    {
                        MessageBox.Show("Xóa Môn Thành Công!", "Thông Báo");
                        LoadCourseList();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa Môn Thất Bại!", "Thông Báo");
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
