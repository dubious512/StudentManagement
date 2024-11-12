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
    public partial class FormDepartment : Form
    {
        private string departmentID;
        public FormDepartment(string departmentID)
        {
            this.departmentID = departmentID; // Truyền mã sinh viên vào form UpdateDepartment
            InitializeComponent();
        }
        private void FormDepartment_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(departmentID))  //Nếu không có thông tin => thêm mới khoa
            {
                this.Text = "Thêm mới khoa";
            }
            else
            {
                this.Text = "Cập nhật thông tin khoa";
                var r = new Database().Select("SelectDepartment '" + departmentID + "'");
                //MessageBox.Show(r[0].ToString());

                txtDepartmentName.Text = r["DepartmentName"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            string departmentName = txtDepartmentName.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(departmentID))
            {
                sql = "CreateDepartment";

            }
            else
            {
                sql = "UpdateDepartment";
                lstPara.Add(new CustomParameter()
                {
                    key = "@DepartmentID",
                    value = departmentID
                });
            }
            if (string.IsNullOrWhiteSpace(departmentName)|| int.TryParse(departmentName, out _))
            {
                // Ném ra ngoại lệ với thông báo lỗi
                MessageBox.Show("Tên không hợp lệ, vui lòng nhập lại.");
            }
            else
            {
                lstPara.Add(new CustomParameter()
                {
                    key = "@DepartmentName",
                    value = departmentName
                });
            }
            var rs = new Database().ExeCute(sql, lstPara);

            if (rs == 1)
            {
                if (string.IsNullOrEmpty(departmentID))
                {
                    MessageBox.Show("Thêm mới khoa thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin khoa thành công");
                }
                this.Dispose();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }


    }
}

