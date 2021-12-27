
namespace QL_THUVIEN
{
    partial class frmDoipass
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_oldpass = new MetroFramework.Controls.MetroTextBox();
            this.txt_newpass = new MetroFramework.Controls.MetroTextBox();
            this.txt_renewpass = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.txt_dongy = new MetroFramework.Controls.MetroButton();
            this.btn_huy = new MetroFramework.Controls.MetroButton();
            this.hashed = new MetroFramework.Controls.MetroTextBox();
            this.hashed_old = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::QL_THUVIEN.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_THUVIEN.Properties.Resources.password;
            this.pictureBox1.Location = new System.Drawing.Point(42, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_oldpass
            // 
            // 
            // 
            // 
            this.txt_oldpass.CustomButton.Image = null;
            this.txt_oldpass.CustomButton.Location = new System.Drawing.Point(258, 2);
            this.txt_oldpass.CustomButton.Name = "";
            this.txt_oldpass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_oldpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_oldpass.CustomButton.TabIndex = 1;
            this.txt_oldpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_oldpass.CustomButton.UseSelectable = true;
            this.txt_oldpass.CustomButton.Visible = false;
            this.txt_oldpass.Lines = new string[0];
            this.txt_oldpass.Location = new System.Drawing.Point(269, 100);
            this.txt_oldpass.MaxLength = 32767;
            this.txt_oldpass.Name = "txt_oldpass";
            this.txt_oldpass.PasswordChar = '*';
            this.txt_oldpass.PromptText = "Mật khẩu cũ";
            this.txt_oldpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_oldpass.SelectedText = "";
            this.txt_oldpass.SelectionLength = 0;
            this.txt_oldpass.SelectionStart = 0;
            this.txt_oldpass.ShortcutsEnabled = true;
            this.txt_oldpass.Size = new System.Drawing.Size(286, 30);
            this.txt_oldpass.TabIndex = 1;
            this.txt_oldpass.UseSelectable = true;
            this.txt_oldpass.WaterMark = "Mật khẩu cũ";
            this.txt_oldpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_oldpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_oldpass.TextChanged += new System.EventHandler(this.txt_oldpass_TextChanged);
            // 
            // txt_newpass
            // 
            // 
            // 
            // 
            this.txt_newpass.CustomButton.Image = null;
            this.txt_newpass.CustomButton.Location = new System.Drawing.Point(258, 2);
            this.txt_newpass.CustomButton.Name = "";
            this.txt_newpass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_newpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_newpass.CustomButton.TabIndex = 1;
            this.txt_newpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_newpass.CustomButton.UseSelectable = true;
            this.txt_newpass.CustomButton.Visible = false;
            this.txt_newpass.Lines = new string[0];
            this.txt_newpass.Location = new System.Drawing.Point(269, 150);
            this.txt_newpass.MaxLength = 32767;
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.PasswordChar = '*';
            this.txt_newpass.PromptText = "Mật khẩu mới";
            this.txt_newpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_newpass.SelectedText = "";
            this.txt_newpass.SelectionLength = 0;
            this.txt_newpass.SelectionStart = 0;
            this.txt_newpass.ShortcutsEnabled = true;
            this.txt_newpass.Size = new System.Drawing.Size(286, 30);
            this.txt_newpass.TabIndex = 1;
            this.txt_newpass.UseSelectable = true;
            this.txt_newpass.WaterMark = "Mật khẩu mới";
            this.txt_newpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_newpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_renewpass
            // 
            // 
            // 
            // 
            this.txt_renewpass.CustomButton.Image = null;
            this.txt_renewpass.CustomButton.Location = new System.Drawing.Point(258, 2);
            this.txt_renewpass.CustomButton.Name = "";
            this.txt_renewpass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_renewpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_renewpass.CustomButton.TabIndex = 1;
            this.txt_renewpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_renewpass.CustomButton.UseSelectable = true;
            this.txt_renewpass.CustomButton.Visible = false;
            this.txt_renewpass.Lines = new string[0];
            this.txt_renewpass.Location = new System.Drawing.Point(269, 200);
            this.txt_renewpass.MaxLength = 32767;
            this.txt_renewpass.Name = "txt_renewpass";
            this.txt_renewpass.PasswordChar = '*';
            this.txt_renewpass.PromptText = "Nhập lại mật khẩu";
            this.txt_renewpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_renewpass.SelectedText = "";
            this.txt_renewpass.SelectionLength = 0;
            this.txt_renewpass.SelectionStart = 0;
            this.txt_renewpass.ShortcutsEnabled = true;
            this.txt_renewpass.Size = new System.Drawing.Size(286, 30);
            this.txt_renewpass.TabIndex = 1;
            this.txt_renewpass.UseSelectable = true;
            this.txt_renewpass.WaterMark = "Nhập lại mật khẩu";
            this.txt_renewpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_renewpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_renewpass.TextChanged += new System.EventHandler(this.txt_renewpass_TextChanged);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(480, 233);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 2;
            this.metroLink1.Text = "Nhập lại";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // txt_dongy
            // 
            this.txt_dongy.Location = new System.Drawing.Point(308, 262);
            this.txt_dongy.Name = "txt_dongy";
            this.txt_dongy.Size = new System.Drawing.Size(88, 41);
            this.txt_dongy.TabIndex = 3;
            this.txt_dongy.Text = "Đồng ý";
            this.txt_dongy.UseSelectable = true;
            this.txt_dongy.Click += new System.EventHandler(this.txt_dongy_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(455, 262);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(88, 41);
            this.btn_huy.TabIndex = 3;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseSelectable = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // hashed
            // 
            // 
            // 
            // 
            this.hashed.CustomButton.Image = null;
            this.hashed.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.hashed.CustomButton.Name = "";
            this.hashed.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.hashed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hashed.CustomButton.TabIndex = 1;
            this.hashed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hashed.CustomButton.UseSelectable = true;
            this.hashed.CustomButton.Visible = false;
            this.hashed.Lines = new string[] {
        "metroTextBox1"};
            this.hashed.Location = new System.Drawing.Point(308, 64);
            this.hashed.MaxLength = 32767;
            this.hashed.Name = "hashed";
            this.hashed.PasswordChar = '\0';
            this.hashed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hashed.SelectedText = "";
            this.hashed.SelectionLength = 0;
            this.hashed.SelectionStart = 0;
            this.hashed.ShortcutsEnabled = true;
            this.hashed.Size = new System.Drawing.Size(75, 23);
            this.hashed.TabIndex = 4;
            this.hashed.Text = "metroTextBox1";
            this.hashed.UseSelectable = true;
            this.hashed.Visible = false;
            this.hashed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hashed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // hashed_old
            // 
            // 
            // 
            // 
            this.hashed_old.CustomButton.Image = null;
            this.hashed_old.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.hashed_old.CustomButton.Name = "";
            this.hashed_old.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.hashed_old.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hashed_old.CustomButton.TabIndex = 1;
            this.hashed_old.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hashed_old.CustomButton.UseSelectable = true;
            this.hashed_old.CustomButton.Visible = false;
            this.hashed_old.Lines = new string[] {
        "metroTextBox1"};
            this.hashed_old.Location = new System.Drawing.Point(389, 63);
            this.hashed_old.MaxLength = 32767;
            this.hashed_old.Name = "hashed_old";
            this.hashed_old.PasswordChar = '\0';
            this.hashed_old.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hashed_old.SelectedText = "";
            this.hashed_old.SelectionLength = 0;
            this.hashed_old.SelectionStart = 0;
            this.hashed_old.ShortcutsEnabled = true;
            this.hashed_old.Size = new System.Drawing.Size(75, 23);
            this.hashed_old.TabIndex = 4;
            this.hashed_old.Text = "metroTextBox1";
            this.hashed_old.UseSelectable = true;
            this.hashed_old.Visible = false;
            this.hashed_old.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hashed_old.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmDoipass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 324);
            this.Controls.Add(this.hashed_old);
            this.Controls.Add(this.hashed);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.txt_dongy);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.txt_renewpass);
            this.Controls.Add(this.txt_newpass);
            this.Controls.Add(this.txt_oldpass);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDoipass";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoipass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txt_oldpass;
        private MetroFramework.Controls.MetroTextBox txt_newpass;
        private MetroFramework.Controls.MetroTextBox txt_renewpass;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton txt_dongy;
        private MetroFramework.Controls.MetroButton btn_huy;
        private MetroFramework.Controls.MetroTextBox hashed;
        private MetroFramework.Controls.MetroTextBox hashed_old;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}