
namespace QL_THUVIEN
{
    partial class frmTimkiemsach
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_nhaxb = new System.Windows.Forms.RadioButton();
            this.rdb_tinhtrang = new System.Windows.Forms.RadioButton();
            this.rdb_tacgia = new System.Windows.Forms.RadioButton();
            this.rdb_theloai = new System.Windows.Forms.RadioButton();
            this.rdb_tensach = new System.Windows.Forms.RadioButton();
            this.rdb_masach = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_tongso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(142, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(237, 40);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(370, 22);
            this.txt_timkiem.TabIndex = 1;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_nhaxb);
            this.groupBox1.Controls.Add(this.rdb_tinhtrang);
            this.groupBox1.Controls.Add(this.rdb_tacgia);
            this.groupBox1.Controls.Add(this.rdb_theloai);
            this.groupBox1.Controls.Add(this.rdb_tensach);
            this.groupBox1.Controls.Add(this.rdb_masach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(41, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // rdb_nhaxb
            // 
            this.rdb_nhaxb.AutoSize = true;
            this.rdb_nhaxb.Location = new System.Drawing.Point(397, 117);
            this.rdb_nhaxb.Name = "rdb_nhaxb";
            this.rdb_nhaxb.Size = new System.Drawing.Size(128, 24);
            this.rdb_nhaxb.TabIndex = 0;
            this.rdb_nhaxb.TabStop = true;
            this.rdb_nhaxb.Text = "Nhà xuất bản";
            this.rdb_nhaxb.UseVisualStyleBackColor = true;
            // 
            // rdb_tinhtrang
            // 
            this.rdb_tinhtrang.AutoSize = true;
            this.rdb_tinhtrang.Location = new System.Drawing.Point(397, 79);
            this.rdb_tinhtrang.Name = "rdb_tinhtrang";
            this.rdb_tinhtrang.Size = new System.Drawing.Size(105, 24);
            this.rdb_tinhtrang.TabIndex = 0;
            this.rdb_tinhtrang.TabStop = true;
            this.rdb_tinhtrang.Text = "Tình trạng";
            this.rdb_tinhtrang.UseVisualStyleBackColor = true;
            // 
            // rdb_tacgia
            // 
            this.rdb_tacgia.AutoSize = true;
            this.rdb_tacgia.Location = new System.Drawing.Point(397, 38);
            this.rdb_tacgia.Name = "rdb_tacgia";
            this.rdb_tacgia.Size = new System.Drawing.Size(85, 24);
            this.rdb_tacgia.TabIndex = 0;
            this.rdb_tacgia.TabStop = true;
            this.rdb_tacgia.Text = "Tác giả";
            this.rdb_tacgia.UseVisualStyleBackColor = true;
            // 
            // rdb_theloai
            // 
            this.rdb_theloai.AutoSize = true;
            this.rdb_theloai.Location = new System.Drawing.Point(180, 117);
            this.rdb_theloai.Name = "rdb_theloai";
            this.rdb_theloai.Size = new System.Drawing.Size(89, 24);
            this.rdb_theloai.TabIndex = 0;
            this.rdb_theloai.TabStop = true;
            this.rdb_theloai.Text = "Thể loại";
            this.rdb_theloai.UseVisualStyleBackColor = true;
            // 
            // rdb_tensach
            // 
            this.rdb_tensach.AutoSize = true;
            this.rdb_tensach.Location = new System.Drawing.Point(180, 79);
            this.rdb_tensach.Name = "rdb_tensach";
            this.rdb_tensach.Size = new System.Drawing.Size(99, 24);
            this.rdb_tensach.TabIndex = 0;
            this.rdb_tensach.TabStop = true;
            this.rdb_tensach.Text = "Tên sách";
            this.rdb_tensach.UseVisualStyleBackColor = true;
            // 
            // rdb_masach
            // 
            this.rdb_masach.AutoSize = true;
            this.rdb_masach.Location = new System.Drawing.Point(180, 38);
            this.rdb_masach.Name = "rdb_masach";
            this.rdb_masach.Size = new System.Drawing.Size(94, 24);
            this.rdb_masach.TabIndex = 0;
            this.rdb_masach.TabStop = true;
            this.rdb_masach.Text = "Mã sách";
            this.rdb_masach.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 228);
            this.dataGridView1.TabIndex = 3;
            // 
            // txt_tongso
            // 
            this.txt_tongso.Enabled = false;
            this.txt_tongso.Location = new System.Drawing.Point(780, 328);
            this.txt_tongso.Name = "txt_tongso";
            this.txt_tongso.Size = new System.Drawing.Size(138, 22);
            this.txt_tongso.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(786, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Tổng số sách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_THUVIEN.Properties.Resources.book__4_;
            this.pictureBox1.Location = new System.Drawing.Point(737, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frmTimkiemsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_tongso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label1);
            this.Name = "frmTimkiemsach";
            this.Load += new System.EventHandler(this.frmTimkiemsach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_nhaxb;
        private System.Windows.Forms.RadioButton rdb_tinhtrang;
        private System.Windows.Forms.RadioButton rdb_tacgia;
        private System.Windows.Forms.RadioButton rdb_theloai;
        private System.Windows.Forms.RadioButton rdb_tensach;
        private System.Windows.Forms.RadioButton rdb_masach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_tongso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}