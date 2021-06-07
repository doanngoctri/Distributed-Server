using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class FormInDSDONGHPCUALOP : DevExpress.XtraEditors.XtraForm
    {
        public FormInDSDONGHPCUALOP()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormInDSDONGHPCUALOP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            ///this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            //this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            
        }

        private void hOCKYLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtmalop.Text.Length==0|| txtnienkhoa.Text.Length==0 || txthocky.Text.Length == 0 )
            {
                MessageBox.Show("Không được để trống dữ liệu !");
                return;
            }
            RP_DONGHOCPHI indanhsachsinhvien = new Report.RP_DONGHOCPHI(txtmalop.Text, txtnienkhoa.Text, Int32.Parse(txthocky.Text));
            indanhsachsinhvien.xrLabel1.Text = "Danh Sách Học Phí";
            indanhsachsinhvien.xrLabelHocKy.Text = "Học Kì: " + txthocky.Text;
            indanhsachsinhvien.xrLabelNien.Text = "Niên Khóa: " + txtnienkhoa.Text;
            int position = -1;
            position = lOPBindingSource.Find("MALOP", txtmalop.Text);
            indanhsachsinhvien.xrLabelLop.Text = "Lớp: " + ((DataRowView)lOPBindingSource[position])["TENLOP"].ToString();
            ReportPrintTool print = new ReportPrintTool(indanhsachsinhvien);
            indanhsachsinhvien.ShowPreviewDialog();


        }


    }
}