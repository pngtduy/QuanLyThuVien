
namespace QL_THUVIEN
{
    partial class frmDangNhap
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
            this.btn_dangnhap = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.hashed = new MetroFramework.Controls.MetroTextBox();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.pic_mo = new System.Windows.Forms.PictureBox();
            this.pic_dong = new System.Windows.Forms.PictureBox();
            this.txt_tendn = new MetroFramework.Controls.MetroTextBox();
            this.txt_pass = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(262, 246);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(77, 44);
            this.btn_dangnhap.TabIndex = 8;
            this.btn_dangnhap.Text = "Login";
            this.btn_dangnhap.UseSelectable = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // hashed
            // 
            // 
            // 
            // 
            this.hashed.CustomButton.Image = null;
            this.hashed.CustomButton.Location = new System.Drawing.Point(38, 2);
            this.hashed.CustomButton.Name = "";
            this.hashed.CustomButton.Size = new System.Drawing.Size(17, 20);
            this.hashed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hashed.CustomButton.TabIndex = 1;
            this.hashed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hashed.CustomButton.UseSelectable = true;
            this.hashed.CustomButton.Visible = false;
            this.hashed.Lines = new string[0];
            this.hashed.Location = new System.Drawing.Point(339, 37);
            this.hashed.MaxLength = 32767;
            this.hashed.Name = "hashed";
            this.hashed.PasswordChar = '\0';
            this.hashed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hashed.SelectedText = "";
            this.hashed.SelectionLength = 0;
            this.hashed.SelectionStart = 0;
            this.hashed.ShortcutsEnabled = true;
            this.hashed.Size = new System.Drawing.Size(66, 24);
            this.hashed.TabIndex = 9;
            this.hashed.UseSelectable = true;
            this.hashed.Visible = false;
            this.hashed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hashed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(378, 246);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(77, 44);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(241, 188);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(66, 24);
            this.metroLink1.TabIndex = 11;
            this.metroLink1.Text = "Đăng ký ";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(419, 188);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(66, 24);
            this.metroLink2.TabIndex = 12;
            this.metroLink2.Text = "Nhập lại";
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // pic_mo
            // 
            this.pic_mo.Image = global::QL_THUVIEN.Properties.Resources.eye__1_;
            this.pic_mo.Location = new System.Drawing.Point(457, 152);
            this.pic_mo.Name = "pic_mo";
            this.pic_mo.Size = new System.Drawing.Size(22, 27);
            this.pic_mo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mo.TabIndex = 14;
            this.pic_mo.TabStop = false;
            this.pic_mo.Click += new System.EventHandler(this.pic_mo_Click);
            // 
            // pic_dong
            // 
            this.pic_dong.Image = global::QL_THUVIEN.Properties.Resources.hidden;
            this.pic_dong.Location = new System.Drawing.Point(457, 152);
            this.pic_dong.Name = "pic_dong";
            this.pic_dong.Size = new System.Drawing.Size(22, 27);
            this.pic_dong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_dong.TabIndex = 13;
            this.pic_dong.TabStop = false;
            this.pic_dong.Click += new System.EventHandler(this.pic_dong_Click);
            // 
            // txt_tendn
            // 
            // 
            // 
            // 
            this.txt_tendn.CustomButton.Image = null;
            this.txt_tendn.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txt_tendn.CustomButton.Name = "";
            this.txt_tendn.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_tendn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_tendn.CustomButton.TabIndex = 1;
            this.txt_tendn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_tendn.CustomButton.UseSelectable = true;
            this.txt_tendn.CustomButton.Visible = false;
            this.txt_tendn.DisplayIcon = true;
            this.txt_tendn.Icon = global::QL_THUVIEN.Properties.Resources.user__2_;
            this.txt_tendn.Lines = new string[0];
            this.txt_tendn.Location = new System.Drawing.Point(241, 91);
            this.txt_tendn.MaxLength = 32767;
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.PasswordChar = '\0';
            this.txt_tendn.PromptText = "Tên đăng nhập";
            this.txt_tendn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tendn.SelectedText = "";
            this.txt_tendn.SelectionLength = 0;
            this.txt_tendn.SelectionStart = 0;
            this.txt_tendn.ShortcutsEnabled = true;
            this.txt_tendn.Size = new System.Drawing.Size(244, 32);
            this.txt_tendn.TabIndex = 5;
            this.txt_tendn.UseSelectable = true;
            this.txt_tendn.WaterMark = "Tên đăng nhập";
            this.txt_tendn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_tendn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_pass
            // 
            // 
            // 
            // 
            this.txt_pass.CustomButton.Image = null;
            this.txt_pass.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txt_pass.CustomButton.Name = "";
            this.txt_pass.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pass.CustomButton.TabIndex = 1;
            this.txt_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pass.CustomButton.UseSelectable = true;
            this.txt_pass.CustomButton.Visible = false;
            this.txt_pass.DisplayIcon = true;
            this.txt_pass.Icon = global::QL_THUVIEN.Properties.Resources.padlock;
            this.txt_pass.Lines = new string[0];
            this.txt_pass.Location = new System.Drawing.Point(241, 149);
            this.txt_pass.MaxLength = 32767;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.PromptText = "Mật khẩu";
            this.txt_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pass.SelectedText = "";
            this.txt_pass.SelectionLength = 0;
            this.txt_pass.SelectionStart = 0;
            this.txt_pass.ShortcutsEnabled = true;
            this.txt_pass.Size = new System.Drawing.Size(244, 32);
            this.txt_pass.TabIndex = 6;
            this.txt_pass.UseSelectable = true;
            this.txt_pass.WaterMark = "Mật khẩu";
            this.txt_pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_THUVIEN.Properties.Resources.account__1_;
            this.pictureBox1.Location = new System.Drawing.Point(33, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 311);
            this.Controls.Add(this.pic_mo);
            this.Controls.Add(this.pic_dong);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.hashed);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.txt_tendn);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_dangnhap;
        private MetroFramework.Controls.MetroTextBox txt_tendn;
        private MetroFramework.Controls.MetroTextBox txt_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox hashed;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private System.Windows.Forms.PictureBox pic_dong;
        private System.Windows.Forms.PictureBox pic_mo;
    }
}