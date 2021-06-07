using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace QLDSV
{
    static class 
        Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string nameOfUser = "";
        public static SqlConnection conn = new SqlConnection();
        public static string connstr;
        public static SqlDataReader myReader;
        public static string database = "QLDSV";
        public static string servername = "";
        public static string loginName = "";
        public static string password = "";
        public static string hoten = "";
        public static string nhom = "";
        public static int KHOA = 0;
        public static string username = "";
        public static string loginHienTai = "";
        public static string passwordHienTai = "";
        public static BindingSource kHOABindingSource = new BindingSource();
        public static string remoteLogin = "HTKN";
        public static string remotePassword = "123";
        public static FormChinh formChinh;
        public static FormLop formLop;
        public static FormDangNhap formDangNhap;
        public static FormMonHoc formMonHoc;
        public static FormSinhVien1 formSinhVien1;
        public static FormDiem1 formDiem1;
        //public static FormDongHocPhi1 formDongHocPhi1;
        public static  SqlConnection sqlConnection;
        public static BindingSource bindingSourceKHOA;
        public static Report.FormInDSSV formInDSSV;
        public static Report.FormBDMH formBDMH;
        public static Report.FormPhieuDiem formPhieuDiem;
        public static Report.FormInDSDONGHPCUALOP formInDSDONGHPCUALOP;
        public static Report.FormPhieuDiemThi formPhieuDiemThi;
        public static Report.FormBDTK formBDTK;
        public static FormTaoTaiKhoan formTaoTaiKhoan;
        public static DongHocPhi dongHocPhiForm;
        public static string connectBackup;
        public static FormThemHocPhi formThemHocPhi;
        public static XoaDangNhap formXoaDangNhap;
        public static string firstConnectionString;
        public static FormChuyenLop formChuyenLop;

        public static string connectionString = "";
        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập

        public static bool KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
               Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.loginHienTai + ";password=" + Program.passwordHienTai;
                Program.conn.ConnectionString = Program.connstr;
             
                Program.conn.Open();
                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }
        
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.sqlConnection);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.sqlConnection.State == ConnectionState.Closed) Program.sqlConnection.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.sqlConnection.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;
                
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            FormChinh formChinh = new FormChinh();
            Program.formChinh = formChinh;
            formChinh.Activate();
            formChinh.Show();
            Application.Run(formChinh);
            
            
        }

       

    }
}
