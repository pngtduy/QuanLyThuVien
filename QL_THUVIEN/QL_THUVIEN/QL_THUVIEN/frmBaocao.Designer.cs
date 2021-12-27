
namespace QL_THUVIEN
{
    partial class frmBaocao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PhieumuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Data_Report = new QL_THUVIEN.Data_Report();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_taobc = new System.Windows.Forms.Button();
            this.dateTime_start = new System.Windows.Forms.DateTimePicker();
            this.dateTime_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhieumuonTableAdapter = new QL_THUVIEN.Data_ReportTableAdapters.PhieumuonTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PhieumuonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Report)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // PhieumuonBindingSource
            // 
            this.PhieumuonBindingSource.DataMember = "Phieumuon";
            this.PhieumuonBindingSource.DataSource = this.Data_Report;
            // 
            // Data_Report
            // 
            this.Data_Report.DataSetName = "Data_Report";
            this.Data_Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.PhieumuonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_THUVIEN.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(407, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(758, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_taobc);
            this.groupBox1.Controls.Add(this.dateTime_start);
            this.groupBox1.Controls.Add(this.dateTime_end);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(29, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiện tạo báo cáo";
            // 
            // btn_taobc
            // 
            this.btn_taobc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.btn_taobc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taobc.ForeColor = System.Drawing.Color.White;
            this.btn_taobc.Image = global::QL_THUVIEN.Properties.Resources.export;
            this.btn_taobc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taobc.Location = new System.Drawing.Point(151, 132);
            this.btn_taobc.Name = "btn_taobc";
            this.btn_taobc.Size = new System.Drawing.Size(150, 46);
            this.btn_taobc.TabIndex = 2;
            this.btn_taobc.Text = "   Tạo báo cáo";
            this.btn_taobc.UseVisualStyleBackColor = false;
            this.btn_taobc.Click += new System.EventHandler(this.btn_taobc_Click);
            // 
            // dateTime_start
            // 
            this.dateTime_start.CustomFormat = "dd/MM/yyyy";
            this.dateTime_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_start.Location = new System.Drawing.Point(107, 31);
            this.dateTime_start.Name = "dateTime_start";
            this.dateTime_start.Size = new System.Drawing.Size(194, 22);
            this.dateTime_start.TabIndex = 1;
            // 
            // dateTime_end
            // 
            this.dateTime_end.CustomFormat = "dd/MM/yyyy";
            this.dateTime_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_end.Location = new System.Drawing.Point(107, 78);
            this.dateTime_end.Name = "dateTime_end";
            this.dateTime_end.Size = new System.Drawing.Size(194, 22);
            this.dateTime_end.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đến ngày";
            // 
            // PhieumuonTableAdapter
            // 
            this.PhieumuonTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_THUVIEN.Properties.Resources.report__2_;
            this.pictureBox1.Location = new System.Drawing.Point(83, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frmBaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaocao";
            this.Load += new System.EventHandler(this.frmBaocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhieumuonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Report)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTime_start;
        private System.Windows.Forms.DateTimePicker dateTime_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource PhieumuonBindingSource;
        private Data_Report Data_Report;
        private Data_ReportTableAdapters.PhieumuonTableAdapter PhieumuonTableAdapter;
        private System.Windows.Forms.Button btn_taobc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}