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
    public partial class FormInDSSV : DevExpress.XtraEditors.XtraForm
    {
        public FormInDSSV()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormInDSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.comboBoxKHOA.DataSource = Program.bindingSourceKHOA;
            comboBoxKHOA.DisplayMember = "description"; //ten khoa
            comboBoxKHOA.ValueMember = "subscriber_server"; // ten server
            if (Program.nhom == "KHOA")
            {
                comboBoxKHOA.Enabled = false;
                
            }
            if (Program.nhom.Equals("PGV"))
            {
                Program.kHOABindingSource.Filter = "description <> 'Phòng Kế Toán'";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                    this.lOPTableAdapter.Connection = Program.sqlConnection;
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMALOP.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống dữ liệu !");
                return;
            }
            XtraReportInDSSV indanhsachsinhvien = new Report.XtraReportInDSSV(txtMALOP.Text);
            ReportPrintTool print = new ReportPrintTool(indanhsachsinhvien);
            indanhsachsinhvien.xrLabelLop.Text = "Lớp: "+lOPComboBox.Text;
            indanhsachsinhvien.ShowPreviewDialog();
        }

        private void lOPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMALOP_TextChanged(object sender, EventArgs e)
        {

        }

        private void lOPBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_InDSSVTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.sp_InDSSVTableAdapter.Fill(this.dS.sp_InDSSV, txtMALOP.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}