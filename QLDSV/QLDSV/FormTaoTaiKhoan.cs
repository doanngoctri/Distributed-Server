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
    public partial class FormTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public FormTaoTaiKhoan(String Role)
        {
            InitializeComponent();
            if (String.Compare(Role, "PGV") == 0)
            {
                cmbNhom.Items.Add("PGV");
                cmbNhom.Items.Add("KHOA");
                cmbNhom.Items.Add("USER");
            }
            else if (String.Compare(Role, "PKTOAN") == 0)
            {
                cmbNhom.Items.Add("PKTOAN");
            }else if(String.Compare(Role, "KHOA") == 0)
            {
                cmbNhom.Items.Add("KHOA");
                cmbNhom.Items.Add("USER");
            }
            cmbNhom.SelectedIndex = 0;

        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connectBackup;
            // TODO: This line of code loads data into the 'dS.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
            // TODO: This line of code loads data into the 'dS.GETDSSV' table. You can move, or remove it, as needed.
            //this.gETDSSVTableAdapter.Fill(this.dS.GETDSSV);
            // TODO: This line of code loads data into the 'dS.GETDSSV' table. You can move, or remove it, as needed.
            this.gETDSSVTableAdapter.Connection.ConnectionString = Program.connectBackup;
            this.gETDSSVTableAdapter.Fill(this.dS.GETDSSV);
            //Console.WriteLine(Program.username);
            this.gETDSSVBindingSource.Filter = "MAGV <> '" +Program.nameOfUser + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tendangnhap = txtTaiKhoan.Text;
            String matkhau = txtMatKhau.Text;
            String ten = hO_TENComboBox.Text;
            int result = 0;
            String reMakhau = txtreMatKhau.Text;
            if (matkhau != reMakhau)
            {
                MessageBox.Show("Mật Khẩu nhập lại không khớp");
                return;
            }
            if (tendangnhap.Trim().Length == 0 || matkhau.Trim().Length == 0 || ten.Trim().Length == 0)
            {
                MessageBox.Show("Không thể tạo tài khoản khi dữ có dữ liệu rỗng");
                return;
            }
            //MessageBox.Show(cmbNhom.Text);
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Program.connectBackup);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //kirm tra
                sqlCommand.CommandText = "sp_TAOTAIKHOAN";
                sqlCommand.Parameters.Add(new SqlParameter("@LGNAME", tendangnhap));
                sqlCommand.Parameters.Add(new SqlParameter("@PASS", matkhau));
                sqlCommand.Parameters.Add(new SqlParameter("@USERNAME", ten));
                sqlCommand.Parameters.Add(new SqlParameter("@ROLE", cmbNhom.Text));
                SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
                sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();


                result = (int)sqlCommand.Parameters["@return"].Value;
                sqlConnection.Close();
                Console.WriteLine(result);
               
                if (result == 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công");
                    this.gETDSSVTableAdapter.Fill(this.dS.GETDSSV);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Tạo Login : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hO_TENComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void hO_TENLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
