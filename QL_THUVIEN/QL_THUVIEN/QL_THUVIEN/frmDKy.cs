using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_THUVIEN.DTO;
using QL_THUVIEN.BUS;
using System.Threading;

namespace QL_THUVIEN
{
    public partial class frmDKy : MetroFramework.Forms.MetroForm
    {
        QLnguoidung_BUS qlNguoidungBUS = new QLnguoidung_BUS();
        public frmDKy()
        {
            InitializeComponent();
        }

        private void btn_dk_Click(object sender, EventArgs e)
        {
           
            if (txt_pass.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo");
            }
            else if (txt_repass.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu", "Thông báo");
            }
            else if (txt_pass.Text != txt_repass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo");
            }
            else
            {
                QLnguoidung_DTO nd = new QLnguoidung_DTO();
                nd.TenDN = txt_tendn.Text;
                nd.MatKhau = hashed.Text;


                //kiem tra loi
                int check = qlNguoidungBUS.Them(nd);
                if (check == 0)
                {
                    MessageBox.Show("Lỗi bỏ trống tên đăng nhập", "Thông báo");
                }

                else if (check == -1)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo");
                }
                else
                {
                    splashScreenManager1.ShowWaitForm();
                    Thread.Sleep(8000);
                    splashScreenManager1.CloseWaitForm();
                    MessageBox.Show("Đăng ký thành công", "Thông báo");
                    txt_pass.Clear();
                    txt_repass.Clear();
                    txt_tendn.Clear();
                }
            }
           
        }

        private void txt_repass_TextChanged(object sender, EventArgs e)
        {
           
            
                byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txt_pass.Text.ToString());
                hashed.Text = Md5hash(passtohash);
            
        }
        public string Md5hash(byte[] value)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var hash = md5.ComputeHash(value);
                return Convert.ToBase64String(hash);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.Show();
            this.Hide();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            txt_tendn.Clear();
            txt_pass.Clear();
            txt_repass.Clear();
            txt_tendn.Focus();
        }

        private void frmDKy_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
        }

      

       

        private void pic_mo_Click_1(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '*')
            {
                pic_dong.BringToFront();
                txt_pass.PasswordChar = '\0';
            }
        }

        private void pic_dong_Click_1(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '\0')
            {
                pic_mo.BringToFront();
                txt_pass.PasswordChar = '*';
            }
        }

       

        private void pic_mo1_Click_1(object sender, EventArgs e)
        {
            if (txt_repass.PasswordChar == '*')
            {
                pic_dong1.BringToFront();
                txt_repass.PasswordChar = '\0';
            }
        }

        private void pic_dong1_Click_1(object sender, EventArgs e)
        {
            if (txt_repass.PasswordChar == '\0')
            {
                pic_mo1.BringToFront();
                txt_repass.PasswordChar = '*';
            }
        }
    }
}
