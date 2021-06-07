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



    public partial class FormMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public bool dangthem;
        String insertBack;
        String updateBack;
        String beforeUpdate;
        public FormMonHoc()
        {
            InitializeComponent();
        }

        Stack<String> undoStack;
        private void beginForm()
        {
            comboBoxKHOA.Enabled = false;
            if (Program.nhom.Equals("PGV"))
                comboBoxKHOA.Enabled = true;
            //comboBoxKHOA.Enabled = true;
            grcmonhoc.Enabled = true;
            grbmonhoc.Enabled = false;
            btnGhi.Enabled = false;
            btnXoa.Enabled = true;
            if (undoStack.Count > 0)
                btnPhucHoi.Enabled = true;
            else
                btnPhucHoi.Enabled = false;
            btnHieuChinh.Enabled = true;
            btnThem.Enabled = true;
        }
        private void edit()
        {
            comboBoxKHOA.Enabled = false;
            grcmonhoc.Enabled = false;
            txtMAMH.Enabled = false;
            grbmonhoc.Enabled = true;
            btnXoa.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
        }
        private void insert()
        {
            comboBoxKHOA.Enabled = false;
            grcmonhoc.Enabled = false;
            txtMAMH.Enabled = true;
            grbmonhoc.Enabled = true;
            btnXoa.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
        }
        private void checkedForm()
        {
            btnGhi.Enabled = true;
        }


        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void mONHOCBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMaster.V_DSPM' table. You can move, or remove it, as needed.
            //this.v_DSPMTableAdapter.Fill(this.dataSetMaster.V_DSPM);
            //this.mONHOCTableAdapter.Connection = Program.sqlConnection;
            dS.EnforceConstraints = false;
            undoStack = new Stack<string>(5);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.comboBoxKHOA.DataSource = Program.bindingSourceKHOA;
            comboBoxKHOA.DisplayMember = "description";
            comboBoxKHOA.ValueMember = "subscriber_server";

            if (Program.nhom == "USER")
            {
                comboBoxKHOA.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
            if (Program.nhom.Equals("PGV"))
            {
                Program.kHOABindingSource.Filter = "description <> 'Phòng Kế Toán'";
            }
            beginForm();
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
                dS.EnforceConstraints = false;
                this.mONHOCTableAdapter.Connection = Program.sqlConnection;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                undoStack.Clear();
                beginForm();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangthem = true;
            this.mONHOCBindingSource.AddNew();
            //grbmonhoc.Enabled = true;
            //btnXoa.Enabled = btnHieuChinh.Enabled = false;
            //txtMAMH.Enabled = true;
            insert();
           
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (txtMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được rỗng", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            if (txtMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được rỗng", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            
            try
            {
                mONHOCBindingSource.EndEdit();
                mONHOCBindingSource.ResetCurrentItem();
                this.mONHOCTableAdapter.Update(this.dS.MONHOC);

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MAMH"))
                {
                    MessageBox.Show("Mã môn học không được trùng", "", MessageBoxButtons.OK);
                }
                if (ex.Message.Contains("UNIQUE"))
                {
                    MessageBox.Show("Tên môn học không được trùng", "", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Lỗi ghi môn học . " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            //btnThem.Enabled = true;
            //grbmonhoc.Enabled = true;

            if (dangthem)
                undoStack.Push(insertBack);
            else
                undoStack.Push(updateBack);
            beginForm();




        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
        }
        public void clearStack()
        {
            undoStack.Clear();
            beginForm();
        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!");
                return;
            }

           
            SqlConnection sqlConnection = new SqlConnection(Program.connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            // kiem tra
            sqlCommand.CommandText = "sp_KIEMTRAMHCODIEM";
            sqlCommand.Parameters.Add(new SqlParameter("@MAMH", txtMAMH.Text));
            SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
            sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(sqlParameter);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();

            int result = (int)sqlCommand.Parameters["@return"].Value;
            if (result == 1)
            {
                sqlConnection.Close();
                MessageBox.Show("Môn học này đã có điểm, không xóa được !");
                return;
            }
            if ((MessageBox.Show("Bạn có thực sự muốn môn học này ?", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                try
                {
                    String removeBack = "insert into MONHOC(MAMH,TENMH) values('" + txtMAMH.Text + "',N'"+ txtTENMH .Text+ "')";
                    undoStack.Push(removeBack);
                    mONHOCBindingSource.RemoveCurrent();
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                    beginForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    return;
                }
            }
        }
        private void mAMHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mONHOCBindingSource.Count == 0)
            {
                MessageBox.Show("Không Có Dữ Liệu Để Chỉnh Sửa");
                return;
            }
            beforeUpdate = ((DataRowView)mONHOCBindingSource[mONHOCBindingSource.Position])["TENMH"].ToString();
            dangthem = false;
            //grbmonhoc.Enabled = true;
            //txtMAMH.Enabled = false;    
            edit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           //grbmonhoc.Enabled = false;
            //btnXoa.Enabled = btnHieuChinh.Enabled = true;
            mONHOCBindingSource.CancelEdit();
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            beginForm();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            grbmonhoc.Enabled = false;
            this.mONHOCBindingSource.AddNew();
            btnThem.Enabled = false;
            txtMAMH.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            grcmonhoc.Enabled = true;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mONHOCBindingSource.CancelEdit();
            if (!Program.KetNoi()) return;
            String lenh = undoStack.Pop();
            int n = Program.ExecSqlNonQuery(lenh);
            //btnThem.Enabled = true;
            //grcmonhoc.Enabled = true;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            beginForm();
            
        }  
        private void button1_Click(object sender, EventArgs e)
        {
            this.mONHOCBindingSource.EndEdit();
            grbmonhoc.Enabled = false;
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(dangthem == true)
            {
                if (txtMAMH.Text.Trim() == ""|| txtMAMH.Text.Contains(" "))
                {
                    MessageBox.Show("Vui lòng nhập thông tin mã môn học", "", MessageBoxButtons.OK);
                    txtMAMH.Focus();
                    return;
              

                }
                if (txtMAMH.Text.Length > 6)
                {
                    MessageBox.Show("Mã môn quá dài", "", MessageBoxButtons.OK);
                    txtMAMH.Focus();
                    return;
                }
                SqlConnection sqlConnection = new SqlConnection(Program.connectionString);

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // kiem tra
                sqlCommand.CommandText = "sp_KIEMTRAMAMHTONTAI";
                sqlCommand.Parameters.Add(new SqlParameter("@MAMH", txtMAMH.Text));
                SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
                sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
                sqlCommand.Parameters.Add(sqlParameter);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                int result = (int)sqlCommand.Parameters["@return"].Value;
                if (result == 1)
                {
                    sqlConnection.Close();
                    MessageBox.Show(" Mã môn học này đã tồn tại, không thêm được !");
                    return;
                }
                if (txtTENMH.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin tên môn học", "", MessageBoxButtons.OK);
                    txtTENMH.Focus();
                    return;
                }
                this.mONHOCBindingSource.EndEdit();
                //grbmonhoc.Enabled = false;
                //btnXoa.Enabled = btnHieuChinh.Enabled = true;
                insertBack = "delete from MONHOC where MAMH = '" + txtMAMH.Text + "'";
                checkedForm();
            }
            if (dangthem == false)
            {
               
                if (txtTENMH.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin tên", "", MessageBoxButtons.OK);
                    txtTENMH.Focus();
                    return;
                }
                this.mONHOCBindingSource.EndEdit();
                updateBack = "UPDATE MONHOC SET TENMH = N'" + beforeUpdate + "' WHERE MAMH = '" + txtMAMH.Text + "';";
                
                //grbmonhoc.Enabled = false;
                //btnXoa.Enabled = btnHieuChinh.Enabled = true;
                checkedForm();
            }
        }
    }
    
}