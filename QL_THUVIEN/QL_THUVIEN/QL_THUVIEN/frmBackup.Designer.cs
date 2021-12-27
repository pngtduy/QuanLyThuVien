
namespace QL_THUVIEN
{
    partial class frmBackup
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_brow = new System.Windows.Forms.Button();
            this.txt_location_rt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txt_location_bk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::QL_THUVIEN.WaitForm1), true, true);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_restore);
            this.groupBox2.Controls.Add(this.btn_brow);
            this.groupBox2.Controls.Add(this.txt_location_rt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(43, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 183);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phục hồi dữ liệu";
            // 
            // btn_restore
            // 
            this.btn_restore.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_restore.Font = new System.Drawing.Font("Mohave", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restore.ForeColor = System.Drawing.Color.White;
            this.btn_restore.Image = global::QL_THUVIEN.Properties.Resources.data_recovery;
            this.btn_restore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_restore.Location = new System.Drawing.Point(443, 118);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(115, 43);
            this.btn_restore.TabIndex = 2;
            this.btn_restore.Text = "Restore";
            this.btn_restore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_brow
            // 
            this.btn_brow.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_brow.Font = new System.Drawing.Font("Mohave", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_brow.ForeColor = System.Drawing.Color.White;
            this.btn_brow.Image = global::QL_THUVIEN.Properties.Resources.open_file_icon__1_;
            this.btn_brow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_brow.Location = new System.Drawing.Point(443, 48);
            this.btn_brow.Name = "btn_brow";
            this.btn_brow.Size = new System.Drawing.Size(115, 43);
            this.btn_brow.TabIndex = 2;
            this.btn_brow.Text = "Browse";
            this.btn_brow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_brow.UseVisualStyleBackColor = false;
            this.btn_brow.Click += new System.EventHandler(this.btn_brow_Click);
            // 
            // txt_location_rt
            // 
            this.txt_location_rt.Location = new System.Drawing.Point(100, 44);
            this.txt_location_rt.Name = "txt_location_rt";
            this.txt_location_rt.Size = new System.Drawing.Size(304, 30);
            this.txt_location_rt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Location";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_backup);
            this.groupBox1.Controls.Add(this.btn_browse);
            this.groupBox1.Controls.Add(this.txt_location_bk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(43, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 178);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao lưu dữ liệu";
            // 
            // btn_backup
            // 
            this.btn_backup.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_backup.Font = new System.Drawing.Font("Mohave", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.ForeColor = System.Drawing.Color.White;
            this.btn_backup.Image = global::QL_THUVIEN.Properties.Resources.file_backup;
            this.btn_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_backup.Location = new System.Drawing.Point(443, 112);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(115, 43);
            this.btn_backup.TabIndex = 2;
            this.btn_backup.Text = "Backup";
            this.btn_backup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_backup.UseVisualStyleBackColor = false;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_browse.Font = new System.Drawing.Font("Mohave", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.Transparent;
            this.btn_browse.Image = global::QL_THUVIEN.Properties.Resources.open_file_icon__1_;
            this.btn_browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_browse.Location = new System.Drawing.Point(443, 39);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(115, 43);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Browse";
            this.btn_browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txt_location_bk
            // 
            this.txt_location_bk.Location = new System.Drawing.Point(100, 48);
            this.txt_location_bk.Name = "txt_location_bk";
            this.txt_location_bk.Size = new System.Drawing.Size(304, 30);
            this.txt_location_bk.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Location";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBackup";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_brow;
        private System.Windows.Forms.TextBox txt_location_rt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txt_location_bk;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}