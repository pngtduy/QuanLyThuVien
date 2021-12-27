
namespace QL_THUVIEN
{
    partial class frmSachdangmuon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbo_tensach = new System.Windows.Forms.ComboBox();
            this.dausachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_THUVIENDataSet = new QL_THUVIEN.QL_THUVIENDataSet();
            this.dausachTableAdapter = new QL_THUVIEN.QL_THUVIENDataSetTableAdapters.DausachTableAdapter();
            this.txt_tongso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dausachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(135, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 225);
            this.dataGridView1.TabIndex = 2;
            // 
            // cbo_tensach
            // 
            this.cbo_tensach.DataSource = this.dausachBindingSource;
            this.cbo_tensach.DisplayMember = "TenSach";
            this.cbo_tensach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tensach.FormattingEnabled = true;
            this.cbo_tensach.Location = new System.Drawing.Point(264, 73);
            this.cbo_tensach.Name = "cbo_tensach";
            this.cbo_tensach.Size = new System.Drawing.Size(328, 24);
            this.cbo_tensach.TabIndex = 3;
            this.cbo_tensach.ValueMember = "TenSach";
            this.cbo_tensach.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dausachBindingSource
            // 
            this.dausachBindingSource.DataMember = "Dausach";
            this.dausachBindingSource.DataSource = this.qL_THUVIENDataSet;
            // 
            // qL_THUVIENDataSet
            // 
            this.qL_THUVIENDataSet.DataSetName = "QL_THUVIENDataSet";
            this.qL_THUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dausachTableAdapter
            // 
            this.dausachTableAdapter.ClearBeforeFill = true;
            // 
            // txt_tongso
            // 
            this.txt_tongso.Enabled = false;
            this.txt_tongso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongso.Location = new System.Drawing.Point(732, 383);
            this.txt_tongso.Name = "txt_tongso";
            this.txt_tongso.Size = new System.Drawing.Size(100, 27);
            this.txt_tongso.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(519, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Số sách đang mượn:";
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_export.Image = global::QL_THUVIEN.Properties.Resources.excel_icon;
            this.btn_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export.Location = new System.Drawing.Point(677, 58);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(150, 60);
            this.btn_export.TabIndex = 37;
            this.btn_export.Text = "   Xuất Excel";
            this.btn_export.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frmSachdangmuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 434);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.txt_tongso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbo_tensach);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmSachdangmuon";
            this.Load += new System.EventHandler(this.frmSachdangmuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dausachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbo_tensach;
        private QL_THUVIENDataSet qL_THUVIENDataSet;
        private System.Windows.Forms.BindingSource dausachBindingSource;
        private QL_THUVIENDataSetTableAdapters.DausachTableAdapter dausachTableAdapter;
        private System.Windows.Forms.TextBox txt_tongso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_export;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}