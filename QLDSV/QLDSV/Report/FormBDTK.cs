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
    public partial class FormBDTK : DevExpress.XtraEditors.XtraForm
    {
        public FormBDTK()
        {
            InitializeComponent();
        }

        private void FormBDTK_Load(object sender, EventArgs e)
        {
            this.lOPTableAdapter.Connection.ConnectionString = Program.connectionString;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
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

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.comboBoxKHOA.SelectedValue == null) return;
            if (comboBoxKHOA.SelectedValue.ToString() == "System.Data.DataRowView") return;
            {
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
            String lenh = "SELECT * FROM LOP WHERE MALOP ='" + txtMALOP.Text + "'";
            SqlDataReader kts = Program.ExecSqlDataReader(lenh);
            if (!kts.Read())  //đọc từng dòng
            {
                MessageBox.Show("Mã Lớp Không Tồn Tại !");
                kts.Close();
                return;
            }
            kts.Close();
            Report.RP_BDTK rptBDTK = new Report.RP_BDTK(txtMALOP.Text);
            rptBDTK.xrLabelLop.Text = "Lớp: "+txtTENLOP.Text;
            rptBDTK.ShowPreviewDialog();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.sp_BANGDIEMTONGKETTableAdapter.Fill(this.dS.sp_BANGDIEMTONGKET, malopToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_BANGDIEMTONGKETTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.sp_BANGDIEMTONGKETTableAdapter.Fill(this.dS.sp_BANGDIEMTONGKET, txtMALOP.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}