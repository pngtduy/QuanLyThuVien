using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_THUVIEN.DAO;
using DevExpress.XtraSplashScreen;
using System.Drawing.Drawing2D;
using DevExpress.XtraBars.Helpers;

namespace QL_THUVIEN
{
    public partial class frmManhinhchinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string tdn;
        public frmManhinhchinh(string _tdn)
        {
          
            FluentSplashScreenOptions fluentSplashScreenOptions = new FluentSplashScreenOptions();
            fluentSplashScreenOptions.Title = "Phần mềm quản lý thư viện";
            fluentSplashScreenOptions.Subtitle = "Môn Phát triển phần mềm Hướng đối tượng";
            fluentSplashScreenOptions.RightFooter = "Starting...";
            fluentSplashScreenOptions.LeftFooter = $"Copyright © 2021 Developer Express Inc.{Environment.NewLine}All right reserved";
            fluentSplashScreenOptions.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
            //fluentSplashScreenOptions.OpacityColor = Color.DarkOrange;
            fluentSplashScreenOptions.Opacity = 130;
            fluentSplashScreenOptions.AppearanceLeftFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowFluentSplashScreen(fluentSplashScreenOptions, customDrawEventHandler:CustomDraw, parentForm: this, useFadeIn: true, useFadeOut: true);
            InitializeComponent();
            tdn = _tdn;
            try
            {
                DataProvider _dt = new DataProvider();
                DataTable dt = _dt.GetData("select * from Account where Account.TenDN = '" + tdn + "'");
                string gt = dt.Rows[0]["Quyen"].ToString();
                if (gt == "1")
                {
                    ribbonPageGroup2.Visible = false;
                    ribbonPage2.Visible = false;
                    ribbonPage4.Visible = false;

                }
                else
                {
                    btn_thongtinmuon.Visibility = BarItemVisibility.Never;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                System.Threading.Thread.Sleep(8000);
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false, 100, this);
            }
           
          
           
        }
        private void CustomDraw(object sender, FluentSplashScreenCustomDrawEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(e.Bounds.Height + 1200, e.Bounds.Width),
                Color.FromArgb(34,143,207),
                Color.AliceBlue);
            e.Cache.FillRectangle(linGrBrush, e.Bounds);
        }

        private void btn_import_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (!Check_Form("frmImport"))
            {
                frmImport f = new frmImport();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmImport");
        }
        private bool Check_Form(string name)
        {
            bool kt = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        private void Active_Form(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void btn_exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.Show();
            this.Hide();
        }

        private void btn_changepass_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void btn_recovery_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmBackup"))
            {
                frmBackup f = new frmBackup();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmBackup");
        }

        private void btn_docgia_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmDocgia"))
            {
                frmDocgia f = new frmDocgia();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmDocgia");
        }

        private void btn_thedocgia_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmThedocgia"))
            {
                frmThedocgia f = new frmThedocgia();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmThedocgia");
        }

        private void btn_phieumuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmPhieumuon"))
            {
                frmPhieumuon f = new frmPhieumuon();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmPhieumuon");
        }

        private void btn_phieutra_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmPhieutra"))
            {
                frmPhieutra f = new frmPhieutra();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmPhieutra");
        }

        private void btn_dausach_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmDausach"))
            {
                frmDausach f = new frmDausach();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmDausach");
        }

        private void btn_loaisach_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmLoaisach"))
            {
                frmLoaisach f = new frmLoaisach();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmLoaisach");
        }

        private void btn_sach_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmSach"))
            {
                frmSach f = new frmSach();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmSach");
        }

        private void btn_timsach_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmTimkiemsach"))
            {
                frmTimkiemsach f = new frmTimkiemsach();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmTimkiemsach");
        }

        private void btn_thongtinmuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmDangmuon"))
            {
                frmDangmuon f = new frmDangmuon();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmDangmuon");
        }

        private void btn_thongke_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmSachdangmuon"))
            {
                frmSachdangmuon f = new frmSachdangmuon();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmSachdangmuon");
        }

        private void btn_baocao_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmBaocao"))
            {
                frmBaocao f = new frmBaocao();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmBaocao");
        }

        private void btn_info_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmInfo"))
            {
                frmInfo f = new frmInfo();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmInfo");

        }

        private void frmManhinhchinh_Load(object sender, EventArgs e)
        {
            barStaticItem1.Caption = "Tài khoản " + tdn;
            barStaticItem2.Caption = DateTime.UtcNow.ToShortDateString();
            //this.barAndDockingController1.LookAndFeel.ResetParentLookAndFeel();
            //this.barAndDockingController1.LookAndFeel.SetSkinStyle("Office 2019 Colorful");
            //this.barAndDockingController1.LookAndFeel.SetSkinMaskColors(Color.FromArgb(133,220,176), Color.White);
            

        }

        private void btn_doipass_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("frmDoipass"))
            {
                frmDoipass f = new frmDoipass(tdn);
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("frmDoipass");
        }
      
    }
}