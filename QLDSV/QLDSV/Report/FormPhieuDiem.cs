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
    public partial class FormPhieuDiem : DevExpress.XtraEditors.XtraForm
    {
        public FormPhieuDiem()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormPhieuDiem_Load(object sender, EventArgs e)
        {
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connectionString;
           
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.comboBoxKHOA.DataSource = Program.bindingSourceKHOA;
            comboBoxKHOA.DisplayMember = "description"; //ten khoa
            comboBoxKHOA.ValueMember = "subscriber_server"; // ten server
            if (Program.nhom == "KHOA")
            {
                comboBoxKHOA.Enabled = false;

            }
            /*if (Program.nhom.equals("pgv"))
            {
                Program.khoabindingsource.filter = "description <> 'phòng kế toán'";
            }*/

        }

        private void sINHVIENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void comboBoxKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxKHOA.ValueMember != "")
            {
                if(this.comboBoxKHOA.SelectedIndex!=-1)
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
                   + "Database=QLDSV;"
                   + "User id=" + Program.loginHienTai + ";"
                   + "Password=" + Program.passwordHienTai;
                    Program.sqlConnection = new SqlConnection(Program.connectionString);
                    Program.sqlConnection.Open();
                    this.sINHVIENTableAdapter.Connection = Program.sqlConnection;
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                }
            }
        }

        private void txtmasv_TextChanged(object sender, EventArgs e)
        {
            //this.sP_LayHoTenSVlOPTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.sP_LayHoTenSVlOPTableAdapter.Fill(this.qLDSVDataSet.SP_LayHoTenSVlOP, txtmalop.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống dữ liệu !");
                return;
            }
            String lenh = "SELECT * FROM SINHVIEN WHERE MASV ='" + txtmasv.Text + "'";
            SqlDataReader kts = Program.ExecSqlDataReader(lenh);
            if (!kts.Read())  //đọc từng dòng
            {
                MessageBox.Show("Mã Sinh Viên Này Không Tồn Tại Trên Khoa !");
                kts.Close();
                return;
            }
            kts.Close();
            Report.XtraReportPhieuDiem rptInPhieuDiem = new Report.XtraReportPhieuDiem(txtmasv.Text);
            rptInPhieuDiem.ShowPreviewDialog();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_PHIEUDIEMTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.sp_PHIEUDIEMTableAdapter.Fill(this.dS.sp_PHIEUDIEM, txtmasv.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}