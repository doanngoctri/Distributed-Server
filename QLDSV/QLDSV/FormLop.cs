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
    
    
    public partial class FormLop : DevExpress.XtraEditors.XtraForm
    {
       public bool dangthem;
        String insertBack;
        String updateBack;
        String beforeUpdate;
        Stack<String> undoStack;
        public FormLop()
        {
            InitializeComponent();
        }
        
        private void beginForm()
        {
            comboBoxKHOA.Enabled = false;
            if (Program.nhom.Equals("PGV"))
                comboBoxKHOA.Enabled = true;
            gcLop.Enabled = true;
            grbLop.Enabled = false;
            btnGhi.Enabled = false;
            btnXoa.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnthem.Enabled = true;
            if (undoStack.Count > 0)
                btnPhucHoi.Enabled = true;
            else
                btnPhucHoi.Enabled = false;
        }
        private void edit()
        {
           
            comboBoxKHOA.Enabled = false;
            gcLop.Enabled = false;
            txtMALOP.Enabled = false;
            grbLop.Enabled = true;
            btnXoa.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnthem.Enabled = false;
            btnHieuChinh.Enabled = false;
        }
        private void insert()
        {
            comboBoxKHOA.Enabled = false;
            gcLop.Enabled = false;
            txtMALOP.Enabled = true;
            grbLop.Enabled = true;
            btnXoa.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnthem.Enabled = false;
            btnHieuChinh.Enabled = false;
        }
        private void checkedForm()
        {
            btnGhi.Enabled = true;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMALOP.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMALOP.Focus();
                return;
            }
            if (txtTENLOP.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTENLOP.Focus();
                return;
            }
            if (txtMAKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                txtMAKH.Focus();
                return;
            }
            dangthem = true;
            //AddNew : thêm 1 item vào danh sách
            //btnXoa.Enabled = false;
            //btnHieuChinh.Enabled = false;
            this.lOPBindingSource.AddNew();
            //grbLop.Enabled = true;
            txtMAKH.Enabled = false;
            //btnGhi.Enabled = true;
            String lenh = "SELECT TOP 1  MAKH FROM [dbo].KHOA";
            Program.myReader = Program.ExecSqlDataReader(lenh);
            if (!Program.myReader.HasRows)
            {
                //MessageBox.Show("Giảng Viên Rỗng Không thể truy xuất ngược mã khoa", "Thông báo", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Read();

            txtMAKH.Text = Program.myReader.GetString(0);
            Program.myReader.Close();
            //txtMAKH.Text = ((DataRowView)lOPBindingSource[1])["MAKH"].ToString();
            insert();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMaster.V_DSPM' table. You can move, or remove it, as needed.
            //this.v_DSPMTableAdapter.Fill(this.dataSetMaster.V_DSPM);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            undoStack = new Stack<string>(5);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.comboBoxKHOA.DataSource = Program.bindingSourceKHOA;
            comboBoxKHOA.DisplayMember = "description"; //ten khoa
            comboBoxKHOA.ValueMember = "subscriber_server"; // ten server
            if (Program.nhom == "USER")
            {
                comboBoxKHOA.Enabled = false;
                btnthem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
            if (Program.nhom.Equals("PGV"))
            {
                Program.kHOABindingSource.Filter = "description <> 'Phòng Kế Toán'";
            }

            if (Program.nhom == "PGV")
            {
                comboBoxKHOA.Enabled = true;  // bật tắt theo phân quyền
            }
            else //truong hop user vs  khoa
            {
                comboBoxKHOA.Enabled = false;
            }
            beginForm();
        }

        private void tENLOPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mAKHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lOPTableAdapter.Update(this.dS.LOP);
            if (dangthem)
                undoStack.Push(insertBack);
            else
                undoStack.Push(updateBack);
            beginForm();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lOPTableAdapter.Fill(this.dS.LOP);
        }

        public void refresh()
        {
            //this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.lOPTableAdapter.Fill(this.dS.LOP);
        }
        private void comboBoxKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(this.comboBoxKHOA.ValueMember !="")
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
                    undoStack.Clear();
                    beginForm();
                }
            }
            
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lOPBindingSource.Count == 0)
            {
                MessageBox.Show("Không Có Dữ Liệu Để Chỉnh Sửa");
                return;
            }
            beforeUpdate = ((DataRowView)lOPBindingSource[lOPBindingSource.Position])["TENLOP"].ToString();
            dangthem = false;
            txtMALOP.Enabled = txtMAKH.Enabled = false;
            //grbLop.Enabled = true;
            //btnGhi.Enabled = true;
            edit();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           if (txtMALOP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa!");
                return;
            }

            
            SqlConnection sqlConnection = new SqlConnection(Program.connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            // kiem tra
            sqlCommand.CommandText = "sp_KIEMTRALOPCOSV";
            sqlCommand.Parameters.Add(new SqlParameter("@MALOP", txtMALOP.Text));
            
            SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
            sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(sqlParameter);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();

            int result = (int)sqlCommand.Parameters["@return"].Value;
            if (result == 1)
            {
                sqlConnection.Close();
                MessageBox.Show(" Lớp này đã có sinh viên, không xóa được !");
                return;
            }
            if ((MessageBox.Show("Bạn có thực sự muốn xóa lớp này ?", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                try
                {
                    String removeBack = "insert into LOP(MALOP,TENLOP,MAKH) values('" + txtMALOP.Text + "',N'" + txtTENLOP.Text + "','"+txtMAKH.Text+"')";
                    undoStack.Push(removeBack);
                    lOPBindingSource.RemoveCurrent();
                    this.lOPTableAdapter.Update(this.dS.LOP);
                    beginForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    return;
                }
            }
        }

        private void txtMALOP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            grbLop.Enabled = false;
            lOPBindingSource.CancelEdit();

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lOPBindingSource.CancelEdit();
            if (!Program.KetNoi()) return;
            String lenh = undoStack.Pop();
            int n = Program.ExecSqlNonQuery(lenh);
            //btnThem.Enabled = true;
            //grcmonhoc.Enabled = true;
            //this.lOPBindingSource.Fill();
            //beginForm();
            //btnthem.Enabled = true;
            //gcLop.Enabled = true;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            beginForm();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
       private void gcLop_Click(object sender, EventArgs e)
        {

        }
       private void grcLop_Enter(object sender, EventArgs e)
        {

        }
       private void button1_Click_1(object sender, EventArgs e)
        {
            if (dangthem == true)
            {
                if (txtMALOP.Text.Trim() == "" || txtMALOP.Text.Contains(" "))
                {
                    MessageBox.Show("Vui lòng nhập thông tin mã lớp", "", MessageBoxButtons.OK);
                    txtMALOP.Focus();
                    return;
                }
                if (txtMALOP.Text.Length > 8)
                {
                    MessageBox.Show("Mã Lớp quá dài", "", MessageBoxButtons.OK);
                    txtMALOP.Focus();
                    return;
                }
                SqlConnection sqlConnection = new SqlConnection(Program.connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // kiem tra
                sqlCommand.CommandText = "sp_KIEMTRAMALOPTONTAI";
                sqlCommand.Parameters.Add(new SqlParameter("@MALOP", txtMALOP.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@TENLOP", txtTENLOP.Text));
                SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
                sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                int result = (int)sqlCommand.Parameters["@return"].Value;
                if (result == 1)
                {
                    sqlConnection.Close();
                    MessageBox.Show(" Lớp này đã tồn tại, không thêm được !");
                    return;
                }
                if (txtTENLOP.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin tên môn học", "", MessageBoxButtons.OK);
                    txtTENLOP.Focus();
                    return;
                }
                this.lOPBindingSource.EndEdit();
                insertBack = "delete from LOP where MALOP = '" + txtMALOP.Text + "'";
                //grbLop.Enabled = false;
                //btnXoa.Enabled = btnHieuChinh.Enabled = btnthem.Enabled = true;
                checkedForm();
            }
            if (dangthem == false)
            {
                if (txtMALOP.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin mã lớp", "", MessageBoxButtons.OK);
                    txtMALOP.Focus();
                    return;
                }
                SqlConnection sqlConnection = new SqlConnection(Program.connectionString);

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // kiem tra
                sqlCommand.CommandText = "sp_KIEMTRAMALOPTONTAI1";
                sqlCommand.Parameters.Add(new SqlParameter("@MALOP", txtMALOP.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@TENLOP", txtTENLOP.Text));
                SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
                sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                int result = (int)sqlCommand.Parameters["@return"].Value;

                if (result == 1)
                {
                    sqlConnection.Close();
                    MessageBox.Show(" Lớp này đã tồn tại, không thêm được !");
                    return;
                }
                if (txtTENLOP.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin tên môn học", "", MessageBoxButtons.OK);
                    txtTENLOP.Focus();
                    return;
                }
                this.lOPBindingSource.EndEdit();
                updateBack = "UPDATE LOP SET TENLOP = N'" + beforeUpdate + "' WHERE MALOP = '" + txtMALOP.Text + "';";
                //grbLop.Enabled = false;
                //btnXoa.Enabled = btnHieuChinh.Enabled  = btnthem.Enabled = true;
                checkedForm();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //grbLop.Enabled = false;
            lOPBindingSource.CancelEdit();
            this.lOPTableAdapter.Fill(this.dS.LOP);
            beginForm();
        }        
    }
}