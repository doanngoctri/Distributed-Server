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
using System.Timers;

namespace QLDSV
{
    public partial class FormDiem1 : DevExpress.XtraEditors.XtraForm
    {

        bool thaydoi = false;
        void beginForm()
        {
            comboBoxKHOA.Enabled = false;
            if (Program.nhom.Equals("PGV"))
                comboBoxKHOA.Enabled = true;
            thaydoi = false;
            //comboBoxKHOA.Enabled = true;
            sp_DANHSACHNHAPDIEMDataGridView.Visible = false;
            btnGhi.Enabled = false;
            btnThoat.Enabled = false;
            ExitForm.Enabled = true;
            btnBatDau.Enabled = true;
            groupBox1.Enabled = true;
        }

        void edit()
        {
            comboBoxKHOA.Enabled = false;
            groupBox1.Enabled = false;
            sp_DANHSACHNHAPDIEMDataGridView.Visible = true;
            btnGhi.Enabled = true;
            btnThoat.Enabled = true;
            ExitForm.Enabled = false;
            btnBatDau.Enabled = false;
        }
       
        public FormDiem1()
        {
            InitializeComponent();
        }

        private void FormDiem1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMaster1.V_DSPM' table. You can move, or remove it, as needed.
            //this.v_DSPMTableAdapter.Fill(this.dataSetMaster1.V_DSPM);
            beginForm();
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);
            this.comboBoxKHOA.DataSource = Program.bindingSourceKHOA;
            comboBoxKHOA.DisplayMember = "description";
            comboBoxKHOA.ValueMember = "subscriber_server";
            comboBoxKHOA.SelectedIndex = Program.KHOA;
            //comboBoxLan.Text = "1";
            if (Program.nhom.Equals("PGV"))
            {
                Program.kHOABindingSource.Filter = "description <> 'Phòng Kế Toán'";
            }
            if (Program.nhom == "PGV")
            {
                comboBoxKHOA.Enabled = true; 
            }
            else 
            {
                comboBoxKHOA.Enabled = false;
            }

            comboBoxLan.Items.Add("1");
            comboBoxLan.Items.Add("2");
            comboBoxLan.SelectedIndex = 0;

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        private void comboBoxKHOA_SelectedIndexChanged(object sender, EventArgs e)
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
                    this.mONHOCTableAdapter.Connection = Program.sqlConnection;
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

                }
               
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            if (thaydoi)
            {
                beginForm();
                return;
            }
            beginForm();
            for (int i = 0; i < sp_DANHSACHNHAPDIEMBindingSource.Count; i++)
            {
                String Diem = ((DataRowView)sp_DANHSACHNHAPDIEMBindingSource[i])["DIEM"].ToString();
                String Masv = ((DataRowView)sp_DANHSACHNHAPDIEMBindingSource[i])["MASV"].ToString();
                String Ten = ((DataRowView)sp_DANHSACHNHAPDIEMBindingSource[i])["HOTEN"].ToString();
                SqlConnection sqlConnection = new SqlConnection(Program.connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_ROLLBACKNHAPDIEM";
                sqlCommand.Parameters.Add(new SqlParameter("@MASV", Masv));
                sqlCommand.Parameters.Add(new SqlParameter("@MAMH", txtMAMH.Text));
               // sqlCommand.Parameters.Add(new SqlParameter("@DIEM", Diem));
                sqlCommand.Parameters.Add(new SqlParameter("@LAN", comboBoxLan.Text));
                SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
                sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Dữ Liệu Đã Bị Hủy Bỏ");

        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            dIEMBindingSource.CancelEdit();


        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            edit();
            int lan = Int32.Parse(comboBoxLan.Text);
            SqlConnection sqlConnection2 = new SqlConnection(Program.connectionString);
            SqlCommand sqlCommand2 = sqlConnection2.CreateCommand();
            this.sp_DANHSACHNHAPDIEMTableAdapter.Connection = sqlConnection2;
            sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand2.CommandText = "sp_KTLOPTHILANMOT";
            sqlCommand2.Parameters.Add(new SqlParameter("@MALOP", txtMALOP.Text));
            sqlCommand2.Parameters.Add(new SqlParameter("@MAMH", txtMAMH.Text));
            sqlCommand2.Parameters.Add(new SqlParameter("@LAN", 1));
            SqlParameter sqlParameter2 = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
            sqlParameter2.Direction = System.Data.ParameterDirection.ReturnValue;
            sqlCommand2.Parameters.Add(sqlParameter2);
            sqlConnection2.Open();
            sqlCommand2.ExecuteNonQuery();
            int result = (int)sqlCommand2.Parameters["@return"].Value;
            Console.WriteLine(result);
            sqlConnection2.Close();
            if (result == 1)
            {
                
                if (lan == 2)
                {
                    beginForm();
                    MessageBox.Show("Lớp này chưa thi môn này lần 1");
                    
                    return;
                }
            }
            else
            {

                SqlConnection sqlConnection3 = new SqlConnection(Program.connectionString);
                SqlCommand sqlCommand3 = sqlConnection3.CreateCommand();
                sqlCommand3.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand3.CommandText = "sp_KTLOPTHILANMOT";
                sqlCommand3.Parameters.Add(new SqlParameter("@MALOP", txtMALOP.Text));
                sqlCommand3.Parameters.Add(new SqlParameter("@MAMH", txtMAMH.Text));
                sqlCommand3.Parameters.Add(new SqlParameter("@LAN", 2));
                SqlParameter sqlParameter3 = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
                sqlParameter3.Direction = System.Data.ParameterDirection.ReturnValue;
                sqlCommand3.Parameters.Add(sqlParameter3);
                sqlConnection3.Open();
                sqlCommand3.ExecuteNonQuery();
                int result3 = (int)sqlCommand3.Parameters["@return"].Value;

                if (lan == 1)
                {
                    if (result3 == 2)
                    {
                        beginForm();
                        MessageBox.Show("Nhập Đã có điểm lần 2 không được phép sửa lần 1 nữa");
                        return;
                    }
                    this.sp_DANHSACHNHAPDIEMTableAdapter.Fill(this.dS.sp_DANHSACHNHAPDIEM, txtMALOP.Text, txtMAMH.Text, short.Parse(comboBoxLan.Text));
                    MessageBox.Show("Nhập Lại lần 1");
                    thaydoi = true;
                    return;
                }
                else if (lan == 2)
                {
                    
                    if (result3 == 2)
                    {
                        sqlConnection3.Close();
                        //this.sp_DANHSACHNHAPDIEMTableAdapter.ClearBeforeFill();
                        this.sp_DANHSACHNHAPDIEMTableAdapter.Fill(this.dS.sp_DANHSACHNHAPDIEM, txtMALOP.Text, txtMAMH.Text, short.Parse(comboBoxLan.Text));
                        MessageBox.Show("Nhập lại lần 2");
                        thaydoi = true;
                        return;
                    }
                }
            }

            



            try
            {
                String lenh = "SELECT MASV FROM SINHVIEN WHERE MALOP ='" + txtMALOP.Text + "' and NGHIHOC = 'false'";
                SqlDataReader kts = Program.ExecSqlDataReader(lenh);
                
                int k = 0;
                while (kts.Read())	//đọc từng dòng
                {
                    SqlConnection sqlConnection = new SqlConnection(Program.connectionString);
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandText = "sp_THEMDSSVNHAPDIEM";
                    sqlCommand.Parameters.Add(new SqlParameter("@MASV", kts.GetString(0)));
                    sqlCommand.Parameters.Add(new SqlParameter("@MAMH", txtMAMH.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("@LAN", comboBoxLan.Text));
                    SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
                    sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
                    sqlCommand.Parameters.Add(sqlParameter);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    k++;
                }
                Console.WriteLine(k);
                kts.Close();
                if (k == 0) {
                    beginForm();
                    MessageBox.Show("Lớp không có sinh viên"); 
                }
               
                this.sp_DANHSACHNHAPDIEMTableAdapter.Fill(this.dS.sp_DANHSACHNHAPDIEM, txtMALOP.Text, txtMAMH.Text, short.Parse(comboBoxLan.Text));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            
            int x = Int32.Parse(sp_DANHSACHNHAPDIEMBindingSource.Count.ToString());
            for(int i = 0; i < x; i++)
            {
                String Diem = ((DataRowView)sp_DANHSACHNHAPDIEMBindingSource[i])["DIEM"].ToString();

                float DiemInt = float.Parse(Diem);
                if (DiemInt > 10 || DiemInt < 0)
                {
                    String Ten = ((DataRowView)sp_DANHSACHNHAPDIEMBindingSource[i])["HOTEN"].ToString();
                    System.Windows.Forms.MessageBox.Show("Mời bạn nhập lại điểm cho sinh viên " + Ten + " ,nhập Điểm từ 0-10");
                    return;
                }
            }
            beginForm();
            for (int i = 0; i < x; i++)
            {
                String Diem = ((DataRowView)sp_DANHSACHNHAPDIEMBindingSource[i])["DIEM"].ToString();
                String Masv = ((DataRowView)sp_DANHSACHNHAPDIEMBindingSource[i])["MASV"].ToString();
                SqlConnection sqlConnection = new SqlConnection(Program.connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_SUADIEMSV";
                sqlCommand.Parameters.Add(new SqlParameter("@MASV", Masv));
                sqlCommand.Parameters.Add(new SqlParameter("@MAMH", txtMAMH.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@DIEM", Diem));
                sqlCommand.Parameters.Add(new SqlParameter("@LAN", comboBoxLan.Text));
                SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
                sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                
            }
            if (Program.formSinhVien1 != null)
            {
                Program.formSinhVien1.clearStack();
            }
            if (Program.formMonHoc != null)
            {
                Program.formMonHoc.clearStack();
            }
            System.Windows.Forms.MessageBox.Show("Thành Công");
        }

        private void dtgnhapdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sp_NhapDiemTheoMonHocBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void txtLan_TextChanged(object sender, EventArgs e)
        {

        }

        private void sp_DANHSACHNHAPDIEMDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTENLOP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExitForm_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void mALOPLabel_Click(object sender, EventArgs e)
        {

        }
    }
}