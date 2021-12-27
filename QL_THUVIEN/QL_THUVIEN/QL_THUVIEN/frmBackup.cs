using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using QL_THUVIEN.DAO;

namespace QL_THUVIEN
{
    public partial class frmBackup : MetroFramework.Forms.MetroForm
    {
        KetNoi context = new KetNoi();
        
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_location_bk.Text = dlg.SelectedPath;
                btn_backup.Enabled = true;
            }
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            context.connect();
            string database = context.conn.Database.ToString();
            if (txt_location_bk.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn để Backup", "Thông báo");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK= '" + txt_location_bk.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                context.conn.Open();
                SqlCommand command = new SqlCommand(cmd, context.conn);
                command.ExecuteNonQuery();
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(8000);
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Backup dữ liệu thành công", "Thông báo");
                context.conn.Close();
                btn_backup.Enabled = false;
            }
        }

        private void btn_brow_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup file|*.bak";
            dlg.Title = "Khôi phục dữ liệu";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_location_rt.Text = dlg.FileName;
                btn_restore.Enabled = true;
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            context.connect();
            string database = context.conn.Database.ToString();
            context.conn.Open();
            try
            {
                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, context.conn);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK ='" + txt_location_rt.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, context.conn);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, context.conn);
                cmd3.ExecuteNonQuery();
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(8000);
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Khôi phục dữ liệu thành công", "Thông báo");
                context.conn.Close();
                btn_restore.Enabled = false;
            }
            catch (SqlException ex)
            {
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(8000);
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
        }
    }
}
