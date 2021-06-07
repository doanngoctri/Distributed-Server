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
    public partial class FormChuyenLop : DevExpress.XtraEditors.XtraForm
    {
        public FormChuyenLop()
        {
            InitializeComponent();
        }
        String connectionString;
        String serverName;
        void begin()
        {
            if(Program.nhom.Equals("PGV"))
                comboBoxKHOA.Enabled = true;
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            sINHVIENComboBox.Text = "";
        }
        void already()
        {
            comboBoxKHOA.Enabled = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }


        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormChuyenLop_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.V_STUDENT' table. You can move, or remove it, as needed.
            //this.v_STUDENTTableAdapter.Fill(this.dS.V_STUDENT);
            // TODO: This line of code loads data into the 'dataSetMaster.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dataSetMaster.V_DSPM);
            
           
            this.lOPTableAdapter.Connection.ConnectionString = Program.connectBackup;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connectBackup;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.sINHVIENBindingSource.Filter = "NGHIHOC = 0";
            //String serverName = "";
            this.comboBoxKHOA.DataSource = v_DSPMBindingSource; this.sINHVIENBindingSource.Position = -1;
            comboBoxKHOA.DisplayMember = "description"; //ten khoa
            comboBoxKHOA.ValueMember = "subscriber_server"; // ten server
            if (Program.nhom.Equals("PGV"))
            {
                v_DSPMBindingSource.Filter = "description <> 'Phòng Kế Toán'";
            }
            if (Program.nhom == "PGV")
            {
                comboBoxKHOA.Enabled = true;
            }
            else
            {
                comboBoxKHOA.Enabled = false;
            }
            comboBoxKHOA.SelectedIndex = 1;
            comboBoxKHOA.SelectedIndex = 0;
            already();
            Console.WriteLine(serverName);
            Console.WriteLine(connectionString);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKHOA.SelectedValue == null) return;
            if (comboBoxKHOA.SelectedValue.ToString() == "System.Data.DataRowView") return;
            if (serverName != this.comboBoxKHOA.SelectedValue.ToString())
            {
                serverName = this.comboBoxKHOA.SelectedValue.ToString();
                connectionString = "Server=" + serverName + ";"
                 + "Database=" + Program.database + ";"
                 + "User Id=" + Program.remoteLogin + ";"
                 + "Password=" + Program.remotePassword;

                this.lOPTableAdapter.Connection.ConnectionString = connectionString;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                Console.WriteLine(serverName);
                Console.WriteLine(connectionString);
            }
        }

        private void mASVLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Begin_Click(object sender, EventArgs e)
        {
            if (sINHVIENComboBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Không còn sinh viên để chuyển");
                return;
            }
            lOPBindingSource.Filter  = "MALOP <>'" + mALOPTextEdit1.Text+"'";
            begin();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            already();
        }

        private void Move_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Định Dạng Mã Sinh Viên Không Hợp Lệ");
                return;
            }
            SqlConnection sqlConnection = new SqlConnection(Program.connectBackup);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //kiem tra
            sqlCommand.CommandText = "SP_ChuyenLopPhanTan";
            sqlCommand.Parameters.Add(new SqlParameter("@MASV", sINHVIENComboBox.Text));
            sqlCommand.Parameters.Add(new SqlParameter("@MASVMOI", textBox1.Text));
            sqlCommand.Parameters.Add(new SqlParameter("@MALOPMOI", mALOPTextEdit.Text));
            SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
            sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(sqlParameter);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();

            int result = (int)sqlCommand.Parameters["@return"].Value;
            if (result == 0)
            {
                MessageBox.Show("Chuyển Thành Công");
            }
            else if(result == 1)
            {
                MessageBox.Show("Mã Sinh Viên Mới Bị Trùng");
                return;
            }
            else if(result == 3)
            {
                MessageBox.Show("Đã tự động tìm ra một sinh viên có thông tin tương tự.\nHệ thông tự động sử dụng lại mã sinh viên cũ.\n Nếu có thắc mắc gì vui lòng liên hệ kỹ thuật viên");
            }
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            //this.sINHVIENBindingSource.Filter = "NGHIHOC = 0";
            already();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sINHVIENComboBox_EditValueChanged(object sender, EventArgs e)
        {
            //var selectedSV = sINHVIENComboBox.GetSelectedDataRow() as DataRowView;
            int position = this.sINHVIENBindingSource.Find("MASV", sINHVIENComboBox.Text);
            this.sINHVIENBindingSource.Position = position;
        }
    }
}