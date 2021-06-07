using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class XtraReportPhieuDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportPhieuDiem(string masv)
        {
            InitializeComponent();
            /* ds2.EnforceConstraints = false;
             this.sp_PHIEUDIEMTableAdapter1.Connection.ConnectionString = Program.connectionString;
             this.sp_PHIEUDIEMTableAdapter1.Fill(this.ds2.sp_PHIEUDIEM, masv);*/

            Program.KetNoi();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            Console.WriteLine("String connect: " + Program.connstr);
            this.sqlDataSource2.Queries[0].Parameters[0].Value = masv;
            //this.sqlDataSource2.Queries[0].Parameters[1].Value = maMH;
            //this.sqlDataSource2.Queries[0].Parameters[2].Value = Int32.Parse(lan);
            this.sqlDataSource2.Fill();
        }

    }
}
