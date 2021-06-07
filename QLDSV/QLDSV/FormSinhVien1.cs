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
using DevExpress.XtraGrid.Columns;

namespace QLDSV
{ 
    
    public partial class FormSinhVien1 : DevExpress.XtraEditors.XtraForm
    {
        private bool dangthem ;
        public bool dangthemLop;

        String insertBack;
        String updateBack;
        
        String lastName;
        String firstName;
        String ClassID;
        bool male;
        DateTime date;
        String born;
        String address;
        String node;
        bool drop;
        Stack<String> undoStack;

        Stack<String> undoStackForClass;

        String insertBackForClass;
        String updateBackForClass;
        String beforeUpdateForClass;
        private void beginForm()
        {
            Groupbox1.Enabled = true;
            comboBoxKHOA.Enabled = false;
            if (Program.nhom.Equals("PGV"))
                comboBoxKHOA.Enabled = true;
            nGHIHOCCheckEdit.Enabled = true;
            //this.lOPComboBox.Enabled = true;
            lOPGridControl.Enabled = true;
            //comboBoxKHOA.Enabled = true;
            sINHVIENGridControl.Enabled = true;
            grpThongTin.Enabled = false;
            btnGhi.Enabled = false;
            btnXoa.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnThem.Enabled = true;
            if (undoStack.Count > 0)
                btnPhucHoi.Enabled = true;
            else
                btnPhucHoi.Enabled = false;
        }
        private void edit()
        {

            //this.lOPComboBox.Enabled = false;
            Groupbox1.Enabled = false;
            lOPGridControl.Enabled = false;
            comboBoxKHOA.Enabled = false;
            sINHVIENGridControl.Enabled = false;
            txtMASV.Enabled = false;
            grpThongTin.Enabled = true;
            btnXoa.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
        }
        private void insert()
        {
            Groupbox1.Enabled = false;
            nGHIHOCCheckEdit.Checked = false;
            nGHIHOCCheckEdit.Enabled = false;
            //this.lOPComboBox.Enabled = false;
            lOPGridControl.Enabled = false;
            comboBoxKHOA.Enabled = false;
            sINHVIENGridControl.Enabled = false;
            txtMASV.Enabled = true;
            grpThongTin.Enabled = true;
            btnXoa.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
        }
        private void checkedForm()
        {
            btnGhi.Enabled = true;
        }



        public FormSinhVien1()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormSinhVien1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.HOCPHI' table. You can move, or remove it, as needed.
            //this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);
            // TODO: This line of code loads data into the 'dS.HOCPHI' table. You can move, or remove it, as needed.
            //this.hOCPHITableAdapter.Connection.ConnectionString = Program.connectionString;

            // TODO: This line of code loads data into the 'dataSetMaster.V_DSPM' table. You can move, or remove it, as needed.
            ///this.v_DSPMTableAdapter.Fill(this.dataSetMaster.V_DSPM);
            ///
            //dS.EnforceConstraints = false;
            undoStack = new Stack<string>(10);
            //undoStackForClass = new Stack<string>(5);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);
            this.comboBoxKHOA.DataSource = Program.bindingSourceKHOA;
            comboBoxKHOA.DisplayMember = "description"; //ten khoa
            comboBoxKHOA.ValueMember = "subscriber_server"; // ten server
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
            grpThongTin.Enabled = false;
            mALOPTextEdit.Enabled = false;
            beginForm();
            button5.Enabled = false;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void comboBoxKHOA_SelectedIndexChanged(object sender, EventArgs e)
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
                this.sINHVIENTableAdapter.Connection = Program.sqlConnection;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                undoStack.Clear();
                beginForm();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangthem = true;
            //txtMALOP.Text = mALOPTextBox.Text;
            // add new là lệnh chính . tự động nhảy về cuối thêm 1 dòng trắng 
            this.sINHVIENBindingSource.AddNew();
            pHAICheckEdit.Checked = true;
            //grpThongTin.Enabled = true;
            //mALOPTextBox.Enabled = txtMASV.Enabled = true;
            insert();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
            if (dangthem)
                undoStack.Push(insertBack);
            else
                undoStack.Push(updateBack);
            beginForm();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.lOPTableAdapter.Fill(this.dS.LOP);
            //beginForm();
        }

        public void refresh()
        {
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.lOPTableAdapter.Fill(this.dS.LOP);
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMASV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }
            SqlConnection sqlConnection = new SqlConnection(Program.connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //kiem tra
            sqlCommand.CommandText = "sp_KIEMTRASVCODIEM";
            sqlCommand.Parameters.Add(new SqlParameter("@MASV", txtMASV.Text));
            SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
            sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(sqlParameter);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();

            int result = (int)sqlCommand.Parameters["@return"].Value;
            // 
            sqlConnection.Close();
            SqlConnection sqlConnection1 = new SqlConnection(Program.connectionString);

            SqlCommand sqlCommand1 = sqlConnection1.CreateCommand();
            sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            //kiem tra
            sqlCommand1.CommandText = "sp_KIEMTRASVCOHP";
            sqlCommand1.Parameters.Add(new SqlParameter("@MASV", txtMASV.Text));
            SqlParameter sqlParameter1 = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
            sqlParameter1.Direction = System.Data.ParameterDirection.ReturnValue;
            sqlCommand1.Parameters.Add(sqlParameter1);

            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();

            int result1 = (int)sqlCommand1.Parameters["@return"].Value;
            sqlConnection1.Close();
            if (result == 1 || result1 == 1)
            {
                MessageBox.Show("Sinh viên này đã có điểm hoặc đóng học phí, không xóa được");
                return;
            }
            if ((MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                try
                {
                    DataRowView drv = (DataRowView)sINHVIENBindingSource[sINHVIENBindingSource.Position];
                    lastName = drv["HO"].ToString();
                    firstName = drv["TEN"].ToString();
                    ClassID = drv["MALOP"].ToString();
                    male = (bool)drv["PHAI"];
                    date = (DateTime)drv["NGAYSINH"];
                    born = drv["NOISINH"].ToString();
                    address = drv["DIACHI"].ToString();
                    node = drv["GHICHU"].ToString();
                    drop = (bool)drv["NGHIHOC"];
                    String deleteBack;
                    deleteBack = "insert into SINHVIEN(MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC)";
                    deleteBack += " values('"+ txtMASV.Text + "' , "+"N'" + lastName+ "', " +
                    "N'" + firstName + "' , " +
                    "'" + ClassID + "' , " +
                    "'" + male + "' , " +
                    "'" + date.ToString("MM/dd/yyyy") + "' , " +
                    "N'" + born + "' , " +
                    "N'" + address + "' , " +
                    "N'" + node + "' , " +
                    "'" + drop + "' )";
                    Console.WriteLine(deleteBack);
                    undoStack.Push(deleteBack);
                    sINHVIENBindingSource.RemoveCurrent();
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    beginForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    return;
                }
            }

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sINHVIENBindingSource.Count == 0)
            {
                MessageBox.Show("Không Có Dữ Liệu Để Chỉnh Sửa");
                return;
            }
            Console.WriteLine(((DataRowView)sINHVIENBindingSource[sINHVIENBindingSource.Position])["NGHIHOC"].ToString());
            if ((bool)(((DataRowView)sINHVIENBindingSource[sINHVIENBindingSource.Position])["NGHIHOC"]))
            {
                MessageBox.Show("Sinh Viên này đã nghĩ học không được phép chỉnh sửa");
                return;
            }
            dangthem = false;
            DataRowView drv = (DataRowView)sINHVIENBindingSource[sINHVIENBindingSource.Position];
            lastName = drv["HO"].ToString();
            firstName = drv["TEN"].ToString();
            ClassID = drv["MALOP"].ToString();
            male = (bool)drv["PHAI"];
            date = (DateTime)drv["NGAYSINH"];
            born = drv["NOISINH"].ToString();
            address = drv["DIACHI"].ToString();
            node = drv["GHICHU"].ToString();
            drop = (bool)drv["NGHIHOC"];
            
            //mALOPTextBox.Enabled = txtMASV.Enabled = false;
            //grpThongTin.Enabled = true;
            edit();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            sINHVIENBindingSource.CancelEdit();
            if (!Program.KetNoi()) return;
            String lenh = undoStack.Pop();
            int n = Program.ExecSqlNonQuery(lenh);
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.lOPTableAdapter.Fill(this.dS.LOP);
            beginForm();
        }             
        private void btnThemDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnXoaDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }



        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void lOPBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void lOPBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dangthem == true)
            {
                DateTime now = DateTime.Now;
                if (txtngaysinh.DateTime.CompareTo(now) == 1)
                {
                    MessageBox.Show("Ngày Vượt Quá Cho Phép", "", MessageBoxButtons.OK);
                    txtMASV.Focus();
                    return;
                }
                if (txtMASV.Text.Trim() == ""|| txtMASV.Text.Contains(" "))
                {
                    MessageBox.Show("Vui lòng nhập thông tin mã sinh viên", "", MessageBoxButtons.OK);
                    txtMASV.Focus();
                    return;
                }
                if (txtMASV.Text.Length > 12)
                {
                    MessageBox.Show("Mã sinh viên quá dài", "", MessageBoxButtons.OK);
                    txtMASV.Focus();
                    return;
                }
                if (txtMALOP.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin mã lớp", "", MessageBoxButtons.OK);
                    txtMALOP.Focus();
                    return;
                }
                if (txtho.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin họ", "", MessageBoxButtons.OK);
                    txtho.Focus();
                    return;
                }
                if (txtten.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin tên", "", MessageBoxButtons.OK);
                    txtten.Focus();
                    return;
                }
                if (txtnoisinh.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin nơi sinh", "", MessageBoxButtons.OK);
                    txtnoisinh.Focus();
                    return;
                }
                if (txtdiachi.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin địa chỉ", "", MessageBoxButtons.OK);
                    txtdiachi.Focus();
                    return;
                }

                SqlConnection sqlConnection = new SqlConnection(Program.connectionString);

                SqlCommand sqlCommand = sqlConnection.CreateCommand(); 
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure; 
                //kiem tra
                sqlCommand.CommandText = "sp_KiemTraMaSinhVienTonTai";
                sqlCommand.Parameters.Add(new SqlParameter("@MASV", txtMASV.Text)); 
                SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
                sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
                sqlCommand.Parameters.Add(sqlParameter);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                int result = (int)sqlCommand.Parameters["@return"].Value;
                // 

                if (result == 1)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Sinh viên này đã tồn tại, không thêm được");
                    return;
                }
                this.sINHVIENBindingSource.EndEdit();
                insertBack = "delete from SINHVIEN where MASV = '" + txtMASV.Text + "'";
                //grpThongTin.Enabled = false;
                checkedForm();
            }
            if(dangthem == false)
            {
                if (txtho.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin họ", "", MessageBoxButtons.OK);
                    txtho.Focus();
                    return;
                }
                if (txtten.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin tên", "", MessageBoxButtons.OK);
                    txtten.Focus();
                    return;
                }
                if (txtnoisinh.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin nơi sinh", "", MessageBoxButtons.OK);
                    txtnoisinh.Focus();
                    return;
                }
                if (txtdiachi.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin địa chỉ", "", MessageBoxButtons.OK);
                    txtdiachi.Focus();
                    return;
                }
                if (nGHIHOCCheckEdit.Checked)
                {
                    string message = "Bạn có chắc chắn cho sinh viên này nghĩ học";
                    string title = "Nghỉ học";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                this.sINHVIENBindingSource.EndEdit();
                updateBack = "update sinhvien set HO = N'" + lastName+ "', " +
                    "TEN = N'" + firstName+ "' , " +
                    "MALOP = '" + ClassID + "' , " +
                    "PHAI = '" + male+ "' , " +
                    "NGAYSINH = '" + date.ToString("MM/dd/yyyy")+ "' , " +
                    "NOISINH = N'" + born + "' , " +
                    "DIACHI = N'" + address + "' , " +
                    "GHICHU = N'" + node+ "' , " +
                    "NGHIHOC = '"+drop + "' " +
                    "WHERE MASV = '" + txtMASV.Text + "';";
                Console.WriteLine(updateBack);
                //grpThongTin.Enabled = false;
                checkedForm();
            }
        }

        private void tENLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tENTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mALOPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelBn_Click(object sender, EventArgs e)
        {
            sINHVIENBindingSource.CancelEdit();
            //grpThongTin.Enabled = false;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            beginForm();
        }
        
        private void gcLop_Click(object sender, EventArgs e)
        {
           
        }

        private void nGHIHOCCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(nGHIHOCCheckEdit.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mALOPTextEdit.Enabled = true;
            dangthemLop = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = true;
            //AddNew : thêm 1 item vào danh sách
            //btnXoa.Enabled = false;
            //btnHieuChinh.Enabled = false;
            this.lOPBindingSource.AddNew();
            //grbLop.Enabled = true;
            //mAKHTextBox.Enabled = false;

            //this.lOPBindingSource.AddNew();
            String lenh = "SELECT TOP 1  MAKH FROM [dbo].KHOA";
            Program.myReader = Program.ExecSqlDataReader(lenh);
            if (!Program.myReader.HasRows)
            {
                //MessageBox.Show("Giảng Viên Rỗng Không thể truy xuất ngược mã khoa", "Thông báo", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Read();

            this.mAKHTextBox.Text = Program.myReader.GetString(0);
            Program.myReader.Close();
        }
        public void clearStack()
        {
            undoStack.Clear();
            beginForm();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (dangthemLop == true)
            {
                if (mALOPTextEdit.Text.Trim() == ""|| mALOPTextEdit.Text.Contains(" "))
                {
                    MessageBox.Show("Vui lòng nhập thông tin mã lớp", "", MessageBoxButtons.OK);
                    mALOPTextEdit.Focus();
                    return;
                }
                if (mALOPTextEdit.Text.Length > 8)
                {
                    MessageBox.Show("Mã Lớp quá dài", "", MessageBoxButtons.OK);
                    mALOPTextEdit.Focus();
                    return;
                }
                SqlConnection sqlConnection = new SqlConnection(Program.connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // kiem tra
                sqlCommand.CommandText = "sp_KIEMTRAMALOPTONTAI";
                sqlCommand.Parameters.Add(new SqlParameter("@MALOP", mALOPTextEdit.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@TENLOP", tENLOPTextEdit.Text));
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
                if (tENLOPTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin tên môn học", "", MessageBoxButtons.OK);
                    tENLOPTextEdit.Focus();
                    return;
                }
                this.lOPBindingSource.EndEdit();
                //grbLop.Enabled = false;
                //btnXoa.Enabled = btnHieuChinh.Enabled = btnthem.Enabled = true;
                insertBackForClass = "delete from LOP where MALOP = '" + mALOPTextEdit.Text + "'";
                undoStack.Push(insertBackForClass);
                checkedForm();
            }
            if (dangthemLop == false)
            {
                if (mALOPTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin mã lớp", "", MessageBoxButtons.OK);
                    mALOPTextEdit.Focus();
                    return;
                }
                SqlConnection sqlConnection = new SqlConnection(Program.connectionString);

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // kiem tra
                sqlCommand.CommandText = "sp_KIEMTRAMALOPTONTAI1";
                sqlCommand.Parameters.Add(new SqlParameter("@MALOP", mALOPTextEdit.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@TENLOP", tENLOPTextEdit.Text));
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
                if (tENLOPTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin tên môn học", "", MessageBoxButtons.OK);
                    tENLOPTextEdit.Focus();
                    return;
                }
                this.lOPBindingSource.EndEdit();
                updateBackForClass = "UPDATE LOP SET TENLOP = N'" + beforeUpdateForClass + "' WHERE MALOP = '" + mALOPTextEdit.Text + "';";
                undoStack.Push(updateBackForClass);
            }
            this.lOPTableAdapter.Update(this.dS.LOP);
            dangthemLop = false;
            button2.Enabled = true;
            button3.Enabled = true;
            mALOPTextEdit.Enabled = false;
            button5.Enabled = false;
            beginForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lOPBindingSource.Count == 0)
            {
                MessageBox.Show(" Làm gì còn lớp nào mà xóa!");
                return;
            }
            

            SqlConnection sqlConnection = new SqlConnection(Program.connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            // kiem tra
            sqlCommand.CommandText = "sp_KIEMTRALOPCOSV";
            sqlCommand.Parameters.Add(new SqlParameter("@MALOP", mALOPTextEdit.Text));

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
                    String deleteBack = "insert into LOP(MALOP,TENLOP,MAKH) values('" + mALOPTextEdit.Text + "',N'" + tENLOPTextEdit.Text + "','" + mAKHTextBox.Text + "')";
                    undoStack.Push(deleteBack);
                    lOPBindingSource.RemoveCurrent();
                    this.lOPTableAdapter.Update(this.dS.LOP);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    mALOPTextEdit.Enabled = false;
                    beginForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    mALOPTextEdit.Enabled = false;
                    return;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lOPBindingSource.CancelEdit();
            this.lOPTableAdapter.Fill(this.dS.LOP);
            dangthemLop = false;
            button2.Enabled = true;
            button3.Enabled = true;
            mALOPTextEdit.Enabled = false;
            button5.Enabled = false;
        }

        private void mALOPTextEdit_TextChanged(object sender, EventArgs e)
        {
            if(lOPBindingSource.Position!=-1)
                beforeUpdateForClass = ((DataRowView)lOPBindingSource[lOPBindingSource.Position])["TENLOP"].ToString();
        }
    }
    
}