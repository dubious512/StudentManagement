using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class FormStudent : Form
    {
        private string studentID;
        public FormStudent(string studentID)
        {
            this.studentID=studentID; // Truyền mã sinh viên vào form UpdateStudent
            InitializeComponent();
        } 
        private void FormStudent_Load_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentID))  //Nếu không có thông tin => thêm mới sinh viên
            {
                this.Text = "Thêm mới sinh viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin sinh viên";
                var r = new Database().Select("SelectStudent '"+studentID+"'");
                //MessageBox.Show(r[0].ToString());

                txtFirstName.Text = r["FirstName"].ToString();
                txtLastName.Text = r["LastName"].ToString();
                DateTime dateOfBirth = Convert.ToDateTime(r["DateOfBirth"]);
                mtbDateOfBirth.Text = dateOfBirth.ToString("dd/MM/yyyy");
              
                string gender = r["Gender"].ToString();
                if (gender == "Nam")
                {
                    rbtNam.Checked= true;
                    
                } else 
                {
                    rbtNu.Checked= true;
                }
                txtDepartmentID.Text = r["DepartmentID"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text; 
            string departmentID = txtDepartmentID.Text;
            DateTime dateOfBirth;
            try
            {
                dateOfBirth = mtbDateOfBirth.Value;
            }
            catch
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbDateOfBirth.Select();
                return;
            }
            string gender = rbtNam.Checked ? "Nam" : "Nữ";

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty (studentID))
            {
                sql = "CreateStudent";

            }
            else
            {
                sql = "UpdateStudent";
                lstPara.Add(new CustomParameter()
                {
                    key = "@StudentID",
                    value = studentID
                });
            }
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                // Ném ra ngoại lệ với thông báo lỗi
                MessageBox.Show("Tên không hợp lệ, vui lòng nhập lại.");
            }else
            {
                lstPara.Add(new CustomParameter()
                {
                    key = "@FirstName",
                    value = firstName
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@LastName",
                    value = lastName
                });
            }
            
            lstPara.Add(new CustomParameter()
            {
                key = "@DateOfBirth",
                value = dateOfBirth.ToString("yyyy-MM-dd")

            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Gender",
                value = gender
            });           
            lstPara.Add(new CustomParameter()
            {
                 key = "@DepartmentID",
                 value = departmentID
             });
            
            var rs = new Database().ExeCute(sql, lstPara);

            if (rs == 1)
            {
                if (string.IsNullOrEmpty(studentID))
                {
                    MessageBox.Show("Thêm mới sinh viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Mã khoa không tồn tại hoặc không hợp lệ");
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
