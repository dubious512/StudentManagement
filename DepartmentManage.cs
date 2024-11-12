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
    public partial class DepartmentManage : Form
    {
        public DepartmentManage()
        {
            InitializeComponent();
        }

        private void DepartmentManage_Load(object sender, EventArgs e)
        {
            LoadDepartmentList();
        }
        private void LoadDepartmentList()
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

            dgvDepartment.DataSource = new Database().SelectData("SelectAllDepartment", lstPara);
            //Đặt tên cột  
            dgvDepartment.Columns["DepartmentID"].HeaderText = "Mã khoa";
            dgvDepartment.Columns["DepartmentName"].HeaderText = "Tên khoa";
        }
        private void dgvDepartment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DoubleClick hiện ra form để cập nhật thông tin khoa học
            if (e.RowIndex >= 0)
            {
                var departmentID = dgvDepartment.Rows[e.RowIndex].Cells["DepartmentID"].Value.ToString();
                new FormDepartment(departmentID).ShowDialog();
                LoadDepartmentList();
            }
        }

        private void btnCreateDepartment_Click(object sender, EventArgs e)
        {
            new FormDepartment(null).ShowDialog();
            LoadDepartmentList();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDepartmentList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvDepartment.CurrentRow.Cells["DepartmentID"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa khoa này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sql = "";
                string departmentID = id.ToString();
                List<CustomParameter> lstpara = new List<CustomParameter>();

                {
                    sql = "DeleteDepartment";
                    lstpara.Add(new CustomParameter()
                    {
                        key = "@DepartmentID",
                        value = departmentID
                    });
                }
                var rs = new Database().ExeCute(sql, lstpara);
                if (rs == 1)
                {
                    if (!string.IsNullOrEmpty(departmentID))
                    {
                        MessageBox.Show("Xóa Khoa Thành Công!", "Thông Báo");
                        LoadDepartmentList();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa Khoa Thất Bại!", "Thông Báo");
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
