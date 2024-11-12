namespace StudentManagement
{
    partial class MenuManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDerpartment = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnEnrollment = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.btnStudent);
            this.groupBox1.Controls.Add(this.btnEnrollment);
            this.groupBox1.Controls.Add(this.btnCourse);
            this.groupBox1.Controls.Add(this.btnDerpartment);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 371);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System";
            // 
            // btnDerpartment
            // 
            this.btnDerpartment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDerpartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDerpartment.Location = new System.Drawing.Point(13, 24);
            this.btnDerpartment.Name = "btnDerpartment";
            this.btnDerpartment.Size = new System.Drawing.Size(86, 50);
            this.btnDerpartment.TabIndex = 0;
            this.btnDerpartment.Text = "Khoa";
            this.btnDerpartment.UseVisualStyleBackColor = false;
            this.btnDerpartment.Click += new System.EventHandler(this.btnDerpartment_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Location = new System.Drawing.Point(12, 93);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(86, 50);
            this.btnCourse.TabIndex = 1;
            this.btnCourse.Text = "Môn học";
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnEnrollment
            // 
            this.btnEnrollment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollment.Location = new System.Drawing.Point(11, 160);
            this.btnEnrollment.Name = "btnEnrollment";
            this.btnEnrollment.Size = new System.Drawing.Size(86, 50);
            this.btnEnrollment.TabIndex = 2;
            this.btnEnrollment.Text = "Điểm";
            this.btnEnrollment.UseVisualStyleBackColor = false;
            this.btnEnrollment.Click += new System.EventHandler(this.btnEnrollment_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Location = new System.Drawing.Point(11, 227);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(86, 50);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "Sinh viên";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(11, 295);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(86, 50);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManagement.Properties.Resources.Blog_image_Sweedu;
            this.pictureBox1.Location = new System.Drawing.Point(105, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MenuManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuManage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuManage_FormClosed);
            this.Load += new System.EventHandler(this.MenuManage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDerpartment;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnEnrollment;
        private System.Windows.Forms.Button btnCourse;
    }
}