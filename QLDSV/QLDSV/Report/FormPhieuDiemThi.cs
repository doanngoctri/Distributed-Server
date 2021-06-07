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
    public partial class FormPhieuDiemThi : DevExpress.XtraEditors.XtraForm
    {
        public FormPhieuDiemThi()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKHOA.SelectedValue == null) return;
            if (comboBoxKHOA.SelectedValue.ToString() == "System.Data.DataRowView") return;
            if (Program.servername != this.comboBoxKHOA.SelectedValue.ToString())
            {
                Program.servername = this.comboBoxKHOA.SelectedValue.ToString();
                if (Program.loginHienTai != Program.remoteLogin)
                {
                    Program.loginHienTai = Program.remoteLogin;
                    Program.passwordHienTai = Program.remotePassword;
                }
                else
                {
                    Program.loginHienTai = Program.loginName;
                    Program.passwordHienTai = Program.password;
                }
                Program.connectionString = "Server=" + Program.servername + ";"
                 + "Database=" + Program.database + ";"
                 + "User Id=" + Program.loginHienTai + ";"
                 + "Password=" + Program.passwordHienTai;
                Program.sqlConnection = new SqlConnection(Program.connectionString);
                Program.sqlConnection.Open();
                this.lOPTableAdapter.Connection = Program.sqlConnection;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                this.mONHOCTableAdapter.Connection = Program.sqlConnection;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);


            }
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormPhieuDiemThi_Load(object sender, EventArgs e)
        {
           
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connectionString;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connectionString;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.comboBoxKHOA.DataSource = Program.bindingSourceKHOA;
            comboBoxKHOA.DisplayMember = "description";
            comboBoxKHOA.ValueMember = "subscriber_server";
            if (Program.nhom == "PGV")
            {
                Program.bindingSourceKHOA.Filter = "description <> 'Phòng Kế Toán'";
            }
            if (Program.nhom == "PGV")
            {
                comboBoxKHOA.Enabled = true;  // bật tắt theo phân quyền
            }
            else //truong hop user vs v khoa
            {
                comboBoxKHOA.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lanThi.Text.Length==0|| textBox1.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống dữ liệu !");
                return;
            }
            Report.XtraReportPhieuDiemThi rptPDT = new Report.XtraReportPhieuDiemThi(txtMaLop.Text, cmbTenMH.SelectedValue.ToString(),Int32.Parse(lanThi.Text));
            rptPDT.lanThi.Text = "Lần Thi: "+lanThi.Text;
            rptPDT.lop.Text = "Lớp: " + cmbLop.Text;
            rptPDT.ngayThi.Text = "Ngày thi: " + dateEditThi.Text;
            rptPDT.monHoc.Text = "Môn: " + cmbTenMH.Text;
            rptPDT.ShowPreviewDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.rP_DANHSACHTHIHETMONTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.rP_DANHSACHTHIHETMONTableAdapter.Fill(this.dS.RP_DANHSACHTHIHETMON, txtMaLop.Text, cmbTenMH.SelectedValue.ToString(), short.Parse(lanThi.Text));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}