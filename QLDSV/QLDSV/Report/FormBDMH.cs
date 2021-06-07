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
    public partial class FormBDMH : DevExpress.XtraEditors.XtraForm
    {
       
        public FormBDMH()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormBDMH_Load(object sender, EventArgs e)
        {
           
            
            this.lOPTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.comboBoxKHOA.DataSource = Program.bindingSourceKHOA;
            comboBoxKHOA.DisplayMember = "description"; //ten khoa
            comboBoxKHOA.ValueMember = "subscriber_server"; // ten server
            if (Program.nhom == "KHOA")
            {
                comboBoxKHOA.Enabled = false;

            }
            //if (Program.nhom == "PGV") comboBoxKHOA.Enabled = true;  // bật tắt theo phân quyền
            //else comboBoxKHOA.Enabled = false;
            if (Program.nhom.Equals("PGV"))
            {
                Program.kHOABindingSource.Filter = "description <> 'Phòng Kế Toán'";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.comboBoxKHOA.SelectedValue == null) return;
            if (comboBoxKHOA.SelectedValue.ToString() == "System.Data.DataRowView") return;
            {
                if(this.comboBoxKHOA.SelectedValue!=null)
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
                    this.mONHOCTableAdapter.Connection = Program.sqlConnection;
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //XtraReportBDMH bangdiemmonhoc = new Report.XtraReportBDMH(txttenmonhoc.Text, txttenlop.Text, txtlan.Text);
            //ReportPrintTool print = new ReportPrintTool(bangdiemmonhoc);
            //bangdiemmonhoc.ShowPreviewDialog();
            if(cmbTenLop.SelectedValue.ToString().Length==0|| cmbMonHoc.SelectedValue.ToString().Length==0|| txtLan.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống dữ liệu !");
                return;
            }
            //Report.XtraReportBDMH rptBDMH = new Report.XtraReportBDMH(cmbTenLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), txtLan.Text);
            Report.RP_BANGDIEMMH rptBDMH = new RP_BANGDIEMMH(cmbTenLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), txtLan.Text);
            rptBDMH.xrLabelLop.Text = "Lớp: "+cmbTenLop.Text;
            rptBDMH.xrLabelLan.Text = "Lần: "+ txtLan.Text;
            rptBDMH.xrLabelMonHoc.Text = "Môn học: "+cmbMonHoc.Text;
            rptBDMH.ShowPreviewDialog();
        }

        private void txtTENLOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txttenlop_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.sp_BANGDIEMMONHOCTableAdapter.Fill(this.dS.sp_BANGDIEMMONHOC, mALOPToolStripTextBox.Text, mAMHToolStripTextBox.Text, new System.Nullable<short>(((short)(System.Convert.ChangeType(lANToolStripTextBox.Text, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_BANGDIEMMONHOCTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.sp_BANGDIEMMONHOCTableAdapter.Fill(this.dS.sp_BANGDIEMMONHOC, cmbTenLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), short.Parse(txtLan.Text));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}