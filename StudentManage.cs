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
    public partial class StudentManage : Form
    {
        public StudentManage()
        {
            InitializeComponent();
        }

        private void StudentManage_Load(object sender, EventArgs e)
        {
            LoadStudentList();
        }
        private void LoadStudentList()
        {

            //Load toàn bộ danh sách sinh viên

            //Khai báo list customparameter
            List<CustomParameter> lstPara = new List<CustomParameter>();
            string keyword = txtSearch.Text;
            lstPara.Add(new CustomParameter()
            {
                key = "@Keyword",
                value = keyword
            });

            dgvStudent.DataSource = new Database().SelectData("SelectAllStudent", lstPara);
            //Đặt tên cột
            dgvStudent.Columns["StudentID"].HeaderText = "Mã sinh viên";
            dgvStudent.Columns["FullName"].HeaderText = "Họ và tên";
            dgvStudent.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
            dgvStudent.Columns["Gender"].HeaderText = "Giới tính";
            dgvStudent.Columns["DepartmentID"].HeaderText = "Mã khoa";
        }

        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DoubleClick hiện ra form để cập nhật thông tin sinh viên
            if (e.RowIndex >= 0)
            {
                var studentID = dgvStudent.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
                new FormStudent(studentID).ShowDialog();

                LoadStudentList();
            }
        }

        private void btn_CreateStudent(object sender, EventArgs e)
        {
            new FormStudent(null).ShowDialog();
            LoadStudentList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStudentList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvStudent.CurrentRow.Cells["StudentID"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sql = "";
                string studentID = id.ToString();
                List<CustomParameter> lstpara = new List<CustomParameter>();

                {
                    sql = "DeleteStudent";
                    lstpara.Add(new CustomParameter()
                    {
                        key = "@StudentID",
                        value = studentID
                    });
                }
                var rs = new Database().ExeCute(sql, lstpara);
                if (rs == 1)
                {
                    if (!string.IsNullOrEmpty(studentID))
                    {
                        MessageBox.Show("Xóa Sinh Viên Thành Công!", "Thông Báo");
                        LoadStudentList();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa Sinh Viên Thất Bại!", "Thông Báo");
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
