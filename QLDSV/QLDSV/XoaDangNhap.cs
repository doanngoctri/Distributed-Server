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
    public partial class XoaDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public XoaDangNhap()
        {
            InitializeComponent();
        }

        private void XoaDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_LoginAcc' table. You can move, or remove it, as needed.
            this.v_LoginAccTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.v_LoginAccTableAdapter.Fill(this.dS.V_LoginAcc);
            
            this.v_LoginAccBindingSource.Filter = "[Tài Khoản] <> '"+Program.loginName+"'";
            if (Program.nhom == "KHOA")
                this.v_LoginAccBindingSource.Filter += " and [Quyền] <> 'PGV'";
            if (v_LoginAccBindingSource.Count == 0)
                delete.Enabled = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có thật sự muốn xóa tài khoản này này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                if (!Program.KetNoi()) return;
                string loginName = (((DataRowView)v_LoginAccBindingSource[v_LoginAccBindingSource.Position])["Tài Khoản"]).ToString();
                string userName = (((DataRowView)v_LoginAccBindingSource[v_LoginAccBindingSource.Position])["Tên"]).ToString();
                String lenh = "exec sp_dropuser "+ userName +" exec sp_droplogin "+ loginName;
                int n = Program.ExecSqlNonQuery(lenh);
                this.v_LoginAccTableAdapter.Fill(this.dS.V_LoginAcc);
            }
            if (v_LoginAccBindingSource.Count == 0)
                delete.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.v_LoginAccTableAdapter.Fill(this.dS.V_LoginAcc);
            if (v_LoginAccBindingSource.Count == 0)
                delete.Visible = false;
        }
    }
}