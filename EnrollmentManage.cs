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
    public partial class EnrollmentManage : Form
    {
        
        public EnrollmentManage()
        {
            InitializeComponent();
        }

        private void EnrollmentManage_Load(object sender, EventArgs e)
        {
            LoadEnrollmentList();
        }
        private void LoadEnrollmentList()
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

            dgvEnrollment.DataSource = new Database().SelectData("SelectAllEnrollment", lstPara);
            //Đặt tên cột
            dgvEnrollment.Columns["EnrollmentID"].HeaderText = "Mã bản ghi";
            dgvEnrollment.Columns["StudentID"].HeaderText = "Mã sinh viên";
            dgvEnrollment.Columns["CourseID"].HeaderText = "Mã môn học";
            dgvEnrollment.Columns["Grade"].HeaderText = "Điểm";
            dgvEnrollment.Columns["EnrollmentDate"].HeaderText = "Ngày nhập";
            
        }

        private void dgvEnrollment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DoubleClick hiện ra form để cập nhật thông tin sinh viên
            if (e.RowIndex >= 0)
            {
                var enrollmentID = dgvEnrollment.Rows[e.RowIndex].Cells["EnrollmentID"].Value.ToString();
                new FormEnrollment(enrollmentID).ShowDialog();

                LoadEnrollmentList();
            }

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            new FormEnrollment(null).ShowDialog();
            LoadEnrollmentList();

        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadEnrollmentList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvEnrollment.CurrentRow.Cells["EnrollmentID"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa bản điểm này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sql = "";
                string enrollmentID = id.ToString();
                List<CustomParameter> lstpara = new List<CustomParameter>();

                {
                    sql = "DeleteEnrollment";
                    lstpara.Add(new CustomParameter()
                    {
                        key = "@EnrollmentID",
                        value = enrollmentID
                    });
                }
                var rs = new Database().ExeCute(sql, lstpara);
                if (rs == 1)
                {
                    if (!string.IsNullOrEmpty(enrollmentID))
                    {
                        MessageBox.Show("Xóa bản điểm Thành Công!", "Thông Báo");
                        LoadEnrollmentList();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa bản điểm Thất Bại!", "Thông Báo");
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
