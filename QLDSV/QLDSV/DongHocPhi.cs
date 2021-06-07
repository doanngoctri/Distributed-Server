using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLDSV
{
    public partial class DongHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public DongHocPhi()
        {
            InitializeComponent();
        }

        private void beginForm()
        {
            beginBn.Enabled = true;
            saveBn.Enabled = false;
            exitBn.Enabled = false;
            exitFormBn.Enabled = true;
            mASVTextEdit.Enabled = true;
            sP_THONGTINDONGHOCPHIGridControl.Enabled = false;
        }
        
        private void insert()
        {
            beginBn.Enabled = false;
            saveBn.Enabled = true;
            exitBn.Enabled = true;
            exitFormBn.Enabled = false;
            mASVTextEdit.Enabled = false;
            sP_THONGTINDONGHOCPHIGridControl.Enabled = true;
        }

        private void DongHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            //this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            beginForm();
        }

        private void beginBn_Click(object sender, EventArgs e)
        {
            
            if (!Program.KetNoi()) return;

            String lenh = "SELECT HO,TEN ,MALOP FROM [dbo].SINHVIEN WHERE MASV ='" + this.mASVTextEdit.Text + "' and NGHIHOC = 'false'";
            Program.myReader = Program.ExecSqlDataReader(lenh);
            if (!Program.myReader.HasRows)
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên này hoặc sinh viên đã nghĩ học", "Thông báo", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Read();
            
            this.hOTextBox.Text = Program.myReader.GetString(0);
            this.tENTextBox.Text = Program.myReader.GetString(1);
            this.mALOPTextBox.Text = Program.myReader.GetString(2);
            Program.myReader.Close();
            try
            {
                this.sP_THONGTINDONGHOCPHITableAdapter.Connection.ConnectionString = Program.connectionString;
                this.sP_THONGTINDONGHOCPHITableAdapter.Fill(this.dS.SP_THONGTINDONGHOCPHI, this.mASVTextEdit.Text);
                insert();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            
        }

        private void saveBn_Click(object sender, EventArgs e)
        {
            String maSV = this.mASVTextEdit.Text;

            String nienKhoa = (((DataRowView)sP_THONGTINDONGHOCPHIBindingSource[sP_THONGTINDONGHOCPHIBindingSource.Position])["NIENKHOA"].ToString());
            int hocKy = Int32.Parse((((DataRowView)sP_THONGTINDONGHOCPHIBindingSource[sP_THONGTINDONGHOCPHIBindingSource.Position])["HOCKY"].ToString()));
            int hocPhi = Int32.Parse((((DataRowView)sP_THONGTINDONGHOCPHIBindingSource[sP_THONGTINDONGHOCPHIBindingSource.Position])["HOCPHI"].ToString()));
            int soTienDaDong = Int32.Parse((((DataRowView)sP_THONGTINDONGHOCPHIBindingSource[sP_THONGTINDONGHOCPHIBindingSource.Position])["SOTIENDADONG"].ToString()));
            int soTienDong = Int32.Parse((((DataRowView)sP_THONGTINDONGHOCPHIBindingSource[sP_THONGTINDONGHOCPHIBindingSource.Position])["SOTIENDONG"].ToString()));
            if (soTienDong <= 0)
            {
                MessageBox.Show("Không thể ghi số nhỏ hơn hoặc bằng 0", "Thông báo", MessageBoxButtons.OK);

                return;
            }
            if (soTienDong + soTienDaDong > hocPhi)
            {
                MessageBox.Show("Số tiền đồng vượt quá học phí còn thiếu :" + (hocPhi - soTienDaDong), "Thông báo", MessageBoxButtons.OK);

                return;
            }
            if (!Program.KetNoi()) return;

            String lenh = "EXEC SP_DONGHOCPHI '" + maSV + "','" + nienKhoa + "','" + hocKy + "','" + soTienDong + "'";
            int n = Program.ExecSqlNonQuery(lenh);
            if (n == 0)
            {
                this.sP_THONGTINDONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_THONGTINDONGHOCPHITableAdapter.Fill(this.dS.SP_THONGTINDONGHOCPHI, this.mASVTextEdit.Text);
                MessageBox.Show("Ðóng tiền thành công", "Thông báo", MessageBoxButtons.OK);
            }else if (n == 1)
            {
                MessageBox.Show("Sinh Viên đã đóng trong trong ngày rồi", "Thông báo", MessageBoxButtons.OK);
            }
            //Program.sqlConnection.Close();
            beginForm();
        }

        private void exitBn_Click(object sender, EventArgs e)
        {
            this.sP_THONGTINDONGHOCPHIBindingSource.EndEdit();
            this.sP_THONGTINDONGHOCPHITableAdapter.Fill(this.dS.SP_THONGTINDONGHOCPHI, this.mASVTextEdit.Text);
            beginForm();
        }

        private void exitFormBn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}