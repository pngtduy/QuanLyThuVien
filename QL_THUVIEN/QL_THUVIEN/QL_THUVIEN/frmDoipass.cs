using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_THUVIEN.BUS;
using QL_THUVIEN.DTO;

namespace QL_THUVIEN
{
    public partial class frmDoipass : MetroFramework.Forms.MetroForm
    {
        Matkhau_BUS mkBus = new Matkhau_BUS();
        private string tdn;
        public frmDoipass(string _tdn)
        {
            InitializeComponent();
            tdn = _tdn;
        }

        private void txt_dongy_Click(object sender, EventArgs e)
        {
           
            if (txt_oldpass.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ", "Thông báo");
                return;
            }
            else if (txt_newpass.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông báo");
                return;
            }
            else if (txt_renewpass.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu", "Thông báo");
                return;
            }
            else if (txt_newpass.Text != txt_renewpass.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo");
                return;
            }

            if (mkBus.CheckExist(tdn, hashed_old.Text) == true)
            {
                QLnguoidung_DTO _tv = new QLnguoidung_DTO();
                _tv.TenDN = tdn;
                _tv.MatKhau = hashed.Text;

                mkBus.DoiMatKhau(_tv);
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(8000);
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                txt_newpass.Clear();
                txt_oldpass.Clear();
                txt_renewpass.Clear();
                txt_oldpass.Focus();
            }
            else
            {
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(8000);
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo");
            }
        }
        public string Md5hash(byte[] value)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var hash = md5.ComputeHash(value);
                return Convert.ToBase64String(hash);
            }
        }

       

        private void txt_oldpass_TextChanged(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txt_oldpass.Text.ToString());
            hashed_old.Text = Md5hash(passtohash);
        }

        private void txt_renewpass_TextChanged(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txt_renewpass.Text.ToString());
            hashed.Text = Md5hash(passtohash);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            txt_newpass.Clear();
            txt_oldpass.Clear();
            txt_renewpass.Clear();
            txt_oldpass.Focus();
        }

        private void frmDoipass_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
        }
    }
}
