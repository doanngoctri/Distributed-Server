using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class FormChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormChinh()
        {
            InitializeComponent();
            
        }


        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void LoginTo()
        {
            string sql = "EXEC sp_LOGIN " + Program.loginName;
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            toolStripStatusLabelMAGV.Text = "ID = " + dataReader.GetValue(0).ToString();
            Program.nameOfUser = dataReader.GetValue(0).ToString();
            toolStripStatusLabelTEN.Text = "HOTEN = " + dataReader.GetValue(1).ToString();
            toolStripStatusLabelNHOM.Text = "NHOM = " + dataReader.GetValue(2).ToString();
            Program.nhom = dataReader.GetValue(2).ToString();
            ribbonPage1.Visible = true;
            ribbonPage2.Visible = true;
            ribbonPage3.Visible = true;
            ribbonPage4.Visible = true;

            barButtonItem1.Enabled = true;
            barButtonItem3.Enabled = true;
            barButtonItem2.Enabled = true;
            barButtonItem4.Enabled = true;

            barButtonItem5.Enabled = true;
            barButtonItem6.Enabled = true;
            barButtonItem7.Enabled = true;
            barButtonItem8.Enabled = true;
            barButtonItem9.Enabled = true;
            barButtonItem10.Enabled = true;
            barButtonItem11.Enabled = true;
            barButtonItem12.Enabled = true;

            barButtonItem13.Enabled = false;
            barButtonItem14.Enabled = true;
            barButtonItem17.Enabled = true;
            barButtonItem18.Enabled = false;
            barButtonItem19.Enabled = true;
            if (Program.nhom == "USER")
            {
                //ribbonPage1.Visible = false;
                ribbonPage3.Visible = false;
                barButtonItem9.Enabled = false;
                barButtonItem13.Enabled = false;
                barButtonItem5.Enabled = false;
                barButtonItem9.Enabled = false;
                ribbonPage2.Visible = false;
                barButtonItem17.Enabled = false;
                barButtonItem19.Enabled = false;
            }
            if (Program.nhom == "KHOA")
            {
                barButtonItem5.Enabled = false;
                barButtonItem9.Enabled = false;
            }
            if (Program.nhom == "PGV")
            {
                //5 và 9 có liên quan đến học phí
                barButtonItem5.Enabled = false;
                barButtonItem9.Enabled = false; // báo cáo  in DS ĐÓNG HP LỚP
            }
            if (Program.nhom == "PKTOAN")
            {
                barButtonItem1.Enabled = false;
                barButtonItem3.Enabled = false;
                barButtonItem2.Enabled = false;
                barButtonItem4.Enabled = false;

                barButtonItem5.Enabled = true;
                barButtonItem6.Enabled = false;
                barButtonItem7.Enabled = false;
                barButtonItem8.Enabled = false;
                barButtonItem9.Enabled = true;
                barButtonItem10.Enabled = false;
                barButtonItem11.Enabled = false;
                barButtonItem17.Enabled = false;
                barButtonItem18.Enabled = true;
            }
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            Program.formDangNhap = new FormDangNhap();
            Program.formDangNhap.MdiParent = this;
            Program.formDangNhap.Activate();
            Program.formDangNhap.Show();
            ribbonPage1.Visible = false;
            ribbonPage2.Visible = false;
            ribbonPage3.Visible = false;
            barButtonItem14.Enabled = false;
        }
        
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form opp = this.CheckExists(typeof(FormSinhVien1));
            if(opp != null)
                opp.Dispose();

            Form frm = this.CheckExists(typeof(FormLop));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Program.formLop = new FormLop();
                Program.formLop.MdiParent = this;
                Program.formLop.Activate();
                Program.formLop.Show();
            }

            /*Program.formLop = 
            Program.formLop.MdiParent = this;
            Program.formLop.Activate();
            Program.formLop.Show();*/
        }

        private void FormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formDangNhap.Visible = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                Program.formMonHoc = new FormMonHoc();
                Program.formMonHoc.MdiParent = this;
                Program.formMonHoc.Activate();
                Program.formMonHoc.Show();
            }
          
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form opp = this.CheckExists(typeof(FormLop));
            if (opp != null)
                opp.Dispose();
            Form frm = this.CheckExists(typeof(FormSinhVien1));
            if (frm != null)
            {
                frm.Activate();
                //frm.Refresh();
            }
            else
            {
                Program.formSinhVien1 = new FormSinhVien1();
                Program.formSinhVien1.MdiParent = this;
                Program.formSinhVien1.Activate();
                Program.formSinhVien1.Show();
            }


            
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDiem1));
            if (frm != null) frm.Activate();
            else
            {
                Program.formDiem1 = new FormDiem1();
                Program.formDiem1.MdiParent = this;
                Program.formDiem1.Activate();
                Program.formDiem1.Show();
            }

           
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(DongHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                Program.dongHocPhiForm = new DongHocPhi();
                Program.dongHocPhiForm.MdiParent = this;
                Program.dongHocPhiForm.Activate();
                Program.dongHocPhiForm.Show();
            }

            
        }

        private void toolStripStatusLabelMAGV_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(Report.FormInDSSV));
            if (frm != null) frm.Activate();
            else
            {
                Program.formInDSSV = new Report.FormInDSSV();
                Program.formInDSSV.MdiParent = this;
                Program.formInDSSV.Activate();
                Program.formInDSSV.Show();
            }


            
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Report.FormBDMH));
            if (frm != null) frm.Activate();
            else
            {
                Program.formBDMH = new Report.FormBDMH();
                Program.formBDMH.MdiParent = this;
                Program.formBDMH.Activate();
                Program.formBDMH.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(Report.FormPhieuDiem));
            if (frm != null) frm.Activate();
            else
            {
                Program.formPhieuDiem = new Report.FormPhieuDiem();
                Program.formPhieuDiem.MdiParent = this;
                Program.formPhieuDiem.Activate();
                Program.formPhieuDiem.Show();
            }


            
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(Report.FormInDSDONGHPCUALOP));
            if (frm != null) frm.Activate();
            else
            {
                Program.formInDSDONGHPCUALOP = new Report.FormInDSDONGHPCUALOP();
                Program.formInDSDONGHPCUALOP.MdiParent = this;
                Program.formInDSDONGHPCUALOP.Activate();
                Program.formInDSDONGHPCUALOP.Show();
            }


            
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Report.FormPhieuDiemThi));
            if (frm != null) frm.Activate();
            else
            {
                Program.formPhieuDiemThi = new Report.FormPhieuDiemThi();
                Program.formPhieuDiemThi.MdiParent = this;
                Program.formPhieuDiemThi.Activate();
                Program.formPhieuDiemThi.Show();
            }



           
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(Report.FormBDTK));
            if (frm != null) frm.Activate();
            else
            {
                Program.formBDTK = new Report.FormBDTK();
                Program.formBDTK.MdiParent = this;
                Program.formBDTK.Activate();
                Program.formBDTK.Show();
            }


            
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTaoTaiKhoan = new FormTaoTaiKhoan(Program.nhom);
                Program.formTaoTaiKhoan.MdiParent = this;
                Program.formTaoTaiKhoan.Activate();
                Program.formTaoTaiKhoan.Show();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null)
                frm.Activate();
            else
            {
                Console.WriteLine("Tao Moi");
                Program.formDangNhap = new FormDangNhap();
                Program.formDangNhap.MdiParent = this;
                Program.formDangNhap.Activate();
                Program.formDangNhap.Show();
                ribbonPage1.Visible = false;
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
                barButtonItem14.Enabled = false;
            }
        }
        private void logout()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
        }
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logout();
            ribbonPage1.Visible = false;
            ribbonPage2.Visible = false;
            ribbonPage3.Visible = false;
            barButtonItem14.Enabled = false;
            barButtonItem13.Enabled = true;
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                Program.formDangNhap = new FormDangNhap();
                Program.formDangNhap.MdiParent = this;
                Program.formDangNhap.Activate();
                Program.formDangNhap.Show();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logout();
            this.Close();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logout();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormChuyenLop));
            if (frm != null) frm.Activate();
            else
            {
                Program.formChuyenLop = new FormChuyenLop();
                Program.formChuyenLop.MdiParent = this;
                Program.formChuyenLop.Activate();
                Program.formChuyenLop.Show();
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormThemHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                Program.formThemHocPhi = new FormThemHocPhi();
                Program.formThemHocPhi.MdiParent = this;
                Program.formThemHocPhi.Activate();
                Program.formThemHocPhi.Show();
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(XoaDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                Program.formXoaDangNhap = new XoaDangNhap();
                Program.formXoaDangNhap.MdiParent = this;
                Program.formXoaDangNhap.Activate();
                Program.formXoaDangNhap.Show();
            }
        }
    }
}
