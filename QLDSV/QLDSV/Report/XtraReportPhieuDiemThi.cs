using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class XtraReportPhieuDiemThi : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportPhieuDiemThi( string maLop,string nienKhoa,int hocKi)
        {
            InitializeComponent();
            Program.KetNoi();
            this.sqlDataSource3.Connection.ConnectionString = Program.connstr;
            Console.WriteLine(Program.connstr);
            this.sqlDataSource3.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource3.Queries[0].Parameters[1].Value = nienKhoa;
            this.sqlDataSource3.Queries[0].Parameters[2].Value = hocKi;
            this.sqlDataSource3.Fill();
        }

    }
}
