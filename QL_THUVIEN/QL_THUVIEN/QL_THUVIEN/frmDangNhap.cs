using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using QL_THUVIEN.BUS;

namespace QL_THUVIEN
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        Nguoidung_BUS tvBus = new Nguoidung_BUS();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
           // this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (tvBus.DangNhap(txt_tendn.Text, hashed.Text) == true)
            {
                frmManhinhchinh f = new frmManhinhchinh(txt_tendn.Text);
                this.Hide();
                f.Show();
              
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string Md5hash(byte[] value)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var hash = md5.ComputeHash(value);
                return Convert.ToBase64String(hash);
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txt_pass.Text.ToString());
            hashed.Text = Md5hash(passtohash);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            frmDKy f = new frmDKy();
            f.Show();
            this.Hide();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            txt_pass.Clear();
            txt_tendn.Clear();
            txt_tendn.Focus();
        }

        private void pic_dong_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '\0')
            {
                pic_mo.BringToFront();
                txt_pass.PasswordChar = '*';
            }
        }

        private void pic_mo_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '*')
            {
                pic_dong.BringToFront();
                txt_pass.PasswordChar = '\0';
            }
        }
    }
}
