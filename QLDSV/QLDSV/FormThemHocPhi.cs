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

namespace QLDSV
{
    public partial class FormThemHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public FormThemHocPhi()
        {
            InitializeComponent();
        }

        private void beginForm()
        {
            beginBn.Enabled = true;
            saveBn.Enabled = false;
            bnExitForm.Enabled = true;
            exitBn.Enabled = false;
            nkText.Enabled = false;
            hkText.Enabled = false;
            hpText.Enabled = false;
        }

        private void insert()
        {
            beginBn.Enabled = false;
            saveBn.Enabled = true;
            bnExitForm.Enabled = false;
            exitBn.Enabled = true;
            nkText.Enabled = true;
            hkText.Enabled = true;
            hpText.Enabled = true;
        }


        private void bnSave_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(hkText.Text.Trim(), out _))
            {
                MessageBox.Show("Định dạng Học Kì Không Hợp Lệ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            int hocki = Int32.Parse(hkText.Text);
            if (hocki >3 && hocki < 1)
            {
                MessageBox.Show("Học Kì Không Hợp Lệ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (nkText.Text.Trim().Length == 0|| !int.TryParse(nkText.Text.Trim(), out _))
            {
                MessageBox.Show("Định dạng niên khóa không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(hpText.Text.Trim().Length == 0 || !int.TryParse(hpText.Text.Trim(), out _))
            {
                MessageBox.Show("Định dạng học phí không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (!Program.KetNoi()) return;

            String lenh = "SELECT 1 FROM [dbo].HOCPHI WHERE MASV ='" + this.lookUpSinhVien.Text + "' and HOCKY = " + this.hkText.Text + " and NIENKHOA = '" + this.nkText.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(lenh);
            if (Program.myReader.HasRows)
            {
                MessageBox.Show("Học Phí này đã được thêm trước đó", "Thông báo", MessageBoxButtons.OK);
                Program.myReader.Close();
                Program.sqlConnection.Close();
                return;
            }
            Program.sqlConnection.Close();



            lenh = "insert into HOCPHI(MASV,NIENKHOA,HOCKY,HOCPHI) values('"+ lookUpSinhVien.Text+"',N'"+ nkText.Text.Trim() + "',"+ hkText.Text.Trim() + ","+hpText.Text+")";
            int n = Program.ExecSqlNonQuery(lenh);
            Program.sqlConnection.Close();
            if (n == 0)
            {
                MessageBox.Show("Thành Công", "Thông báo", MessageBoxButtons.OK);
                beginForm();
            }
            else
            {
                MessageBox.Show("Lỗi Không Xác Định", "Thông báo", MessageBoxButtons.OK);
            }
            this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);

        }

        private void beginBn_Click(object sender, EventArgs e)
        {
            if (!Program.KetNoi()) return;

            String lenh = "SELECT HO,TEN ,MALOP FROM [dbo].SINHVIEN WHERE MASV ='" + this.lookUpSinhVien.Text + "' and NGHIHOC = 'false'";
            Program.myReader = Program.ExecSqlDataReader(lenh);
            if (!Program.myReader.HasRows)
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên này hoặc sinh viên đã nghĩ học", "Thông báo", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Read();
            
            this.tenSVText.Text = Program.myReader.GetString(0) + " " + Program.myReader.GetString(1);
            this.mlText.Text = Program.myReader.GetString(2);
            Program.sqlConnection.Close();
            //this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);
            insert();
        }

        private void exitFormBn_Click(object sender, EventArgs e)
        {
            beginForm();
            this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);
        }

        private void hOCPHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCPHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormThemHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter1.Connection.ConnectionString = Program.connectionString;
            this.sINHVIENTableAdapter1.Fill(this.qLDSVDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            //this.sINHVIENTableAdapter1.Fill(this.qLDSVDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            
            //this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);
            dS.EnforceConstraints = false;
            this.hOCPHITableAdapter.Connection.ConnectionString = Program.connectionString;
            // TODO: This line of code loads data into the 'dS.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);
            // TODO: This line of code loads data into the 'dS.HOCPHI' table. You can move, or remove it, as needed.
            // this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);
            // TODO: This line of code loads data into the 'dS.HOCPHI' table. You can move, or remove it, as needed.
            //this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);
            

        }

        private void hOCPHIBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCPHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void hOCPHIBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCPHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void hOCPHIGridControl_Click(object sender, EventArgs e)
        {

        }

        private void bnExitForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}