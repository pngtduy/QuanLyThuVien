using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_THUVIEN
{
    public partial class frmBaocao : MetroFramework.Forms.MetroForm
    {
        public frmBaocao()
        {
            InitializeComponent();
        }

        private void frmBaocao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Data_Report.Phieumuon' table. You can move, or remove it, as needed.
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;

        }

        private void btn_taobc_Click(object sender, EventArgs e)
        {
            this.PhieumuonTableAdapter.Fill(this.Data_Report.Phieumuon, Convert.ToString(dateTime_start.Value.Date), Convert.ToString(dateTime_end.Value.Date));

            this.reportViewer1.RefreshReport();
        }
    }
}
