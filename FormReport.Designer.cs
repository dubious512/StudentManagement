namespace StudentManagement
{
    partial class FormReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.View_StudentsByDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new StudentManagement.DataSet.DataSet1();
            this.viewStudentsByClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new StudentManagement.DataSet.DataSet2();
            this.View_DetailStudentByDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new StudentManagement.DataSet.DataSet3();
            this.viewDetailStudentByClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet5 = new StudentManagement.DataSet.DataSet5();
            this.studentGradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new StudentManagement.DataSet.DataSet4();
            this.viewStudentsByDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_StudentsByDepartmentTableAdapter = new StudentManagement.DataSet.DataSet1TableAdapters.View_StudentsByDepartmentTableAdapter();
            this.view_StudentsByClassTableAdapter = new StudentManagement.DataSet.DataSet2TableAdapters.View_StudentsByClassTableAdapter();
            this.View_StudentsByClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewDetailStudentByDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_DetailStudentByDepartmentTableAdapter = new StudentManagement.DataSet.DataSet3TableAdapters.View_DetailStudentByDepartmentTableAdapter();
            this.studentGradesTableAdapter = new StudentManagement.DataSet.DataSet4TableAdapters.StudentGradesTableAdapter();
            this.view_DetailStudentByClassTableAdapter = new StudentManagement.DataSet.DataSet5TableAdapters.View_DetailStudentByClassTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_StudentsByDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsByClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_DetailStudentByDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDetailStudentByClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsByDepartmentBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_StudentsByClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDetailStudentByDepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // View_StudentsByDepartmentBindingSource
            // 
            this.View_StudentsByDepartmentBindingSource.DataMember = "View_StudentsByDepartment";
            this.View_StudentsByDepartmentBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewStudentsByClassBindingSource
            // 
            this.viewStudentsByClassBindingSource.DataMember = "View_StudentsByClass";
            this.viewStudentsByClassBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_DetailStudentByDepartmentBindingSource
            // 
            this.View_DetailStudentByDepartmentBindingSource.DataMember = "View_DetailStudentByDepartment";
            this.View_DetailStudentByDepartmentBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewDetailStudentByClassBindingSource
            // 
            this.viewDetailStudentByClassBindingSource.DataMember = "View_DetailStudentByClass";
            this.viewDetailStudentByClassBindingSource.DataSource = this.dataSet5;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentGradesBindingSource
            // 
            this.studentGradesBindingSource.DataMember = "StudentGrades";
            this.studentGradesBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewStudentsByDepartmentBindingSource
            // 
            this.viewStudentsByDepartmentBindingSource.DataMember = "View_StudentsByDepartment";
            this.viewStudentsByDepartmentBindingSource.DataSource = this.dataSet1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(26, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(726, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(718, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Số lượng sinh viên mỗi Khoa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_StudentsByDepartmentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StudentManagement.Report.StudentByDepartment.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(706, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(718, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Số lượng sinh viên mỗi lớp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.viewStudentsByClassBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "StudentManagement.Report.StudentByClass.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 31);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(715, 246);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(718, 277);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sinh viên mỗi Khoa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.View_DetailStudentByDepartmentBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "StudentManagement.Report.DetailStudentByDepartment.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(6, 25);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(706, 246);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(718, 277);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sinh viên mỗi lớp";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            reportDataSource4.Name = "DataSet5";
            reportDataSource4.Value = this.viewDetailStudentByClassBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "StudentManagement.Report.DetailStudentByClass.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(7, 27);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(705, 246);
            this.reportViewer5.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(718, 277);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Điểm tổng hợp";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            reportDataSource5.Name = "DataSet4";
            reportDataSource5.Value = this.studentGradesBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "StudentManagement.Report.StudentGrade.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(6, 30);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(706, 246);
            this.reportViewer4.TabIndex = 0;
            // 
            // view_StudentsByDepartmentTableAdapter
            // 
            this.view_StudentsByDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // view_StudentsByClassTableAdapter
            // 
            this.view_StudentsByClassTableAdapter.ClearBeforeFill = true;
            // 
            // View_StudentsByClassBindingSource
            // 
            this.View_StudentsByClassBindingSource.DataMember = "View_StudentsByClass";
            this.View_StudentsByClassBindingSource.DataSource = this.dataSet2;
            // 
            // viewDetailStudentByDepartmentBindingSource
            // 
            this.viewDetailStudentByDepartmentBindingSource.DataMember = "View_DetailStudentByDepartment";
            this.viewDetailStudentByDepartmentBindingSource.DataSource = this.dataSet3;
            // 
            // view_DetailStudentByDepartmentTableAdapter
            // 
            this.view_DetailStudentByDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // studentGradesTableAdapter
            // 
            this.studentGradesTableAdapter.ClearBeforeFill = true;
            // 
            // view_DetailStudentByClassTableAdapter
            // 
            this.view_DetailStudentByClassTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tổng hợp";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_StudentsByDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsByClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_DetailStudentByDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDetailStudentByClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsByDepartmentBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View_StudentsByClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDetailStudentByDepartmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private DataSet.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource viewStudentsByDepartmentBindingSource;
        private DataSet.DataSet1TableAdapters.View_StudentsByDepartmentTableAdapter view_StudentsByDepartmentTableAdapter;
        private System.Windows.Forms.BindingSource View_StudentsByDepartmentBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private DataSet.DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource viewStudentsByClassBindingSource;
        private DataSet.DataSet2TableAdapters.View_StudentsByClassTableAdapter view_StudentsByClassTableAdapter;
        private System.Windows.Forms.BindingSource View_StudentsByClassBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private DataSet.DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource viewDetailStudentByDepartmentBindingSource;
        private DataSet.DataSet3TableAdapters.View_DetailStudentByDepartmentTableAdapter view_DetailStudentByDepartmentTableAdapter;
        private System.Windows.Forms.BindingSource View_DetailStudentByDepartmentBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private DataSet.DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource studentGradesBindingSource;
        private DataSet.DataSet4TableAdapters.StudentGradesTableAdapter studentGradesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private DataSet.DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource viewDetailStudentByClassBindingSource;
        private DataSet.DataSet5TableAdapters.View_DetailStudentByClassTableAdapter view_DetailStudentByClassTableAdapter;
    }
}