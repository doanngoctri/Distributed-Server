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

namespace QLDSV
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMaster.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dataSetMaster.V_DSPM);
            Program.bindingSourceKHOA = this.v_DSPMBindingSource;
            comboBoxKHOA.SelectedIndex = 1;
            comboBoxKHOA.SelectedIndex = 0;


        }

        private void v_DSPMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxKHOA.SelectedValue!=null)
                Program.servername = comboBoxKHOA.SelectedValue.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Program.servername = comboBoxKHOA.SelectedValue.ToString();
            string database = "QLDSV";
            Program.loginName = txtLoginName.Text;
            Program.password = txtPassword.Text;
            Program.loginHienTai = Program.loginName;
            Program.passwordHienTai = Program.password;
            Program.connectionString = "Server=" + Program.servername + ";"
                + "Database=" + database + ";"
                + "User id=" + Program.loginHienTai + ";"
                + "Password=" + Program.passwordHienTai;
            Program.sqlConnection = new SqlConnection(Program.connectionString);
            Program.connectBackup = Program.connectionString;
            if (txtLoginName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                Program.sqlConnection.Open();
                //MessageBox.Show("Kết nối thành công");
               
                Program.kHOABindingSource = v_DSPMBindingSource;
                Program.KHOA = comboBoxKHOA.SelectedIndex;
                Program.formChinh.LoginTo();
                   this.Visible = false;
            }
            catch (Exception a)
            {
                MessageBox.Show("Kết nối thất bại, sai Login Name hoặc Password" + a.Message);

            }
           



        }

        private void textBoxLoginName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}