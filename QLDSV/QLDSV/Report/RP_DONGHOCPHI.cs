using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class RP_DONGHOCPHI : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_DONGHOCPHI(String maLop,String nienKhoa,int hocKi)
        {
            InitializeComponent();
            Program.KetNoi();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            Console.WriteLine(Program.connstr);
            this.sqlDataSource2.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource2.Queries[0].Parameters[1].Value = nienKhoa;
            this.sqlDataSource2.Queries[0].Parameters[2].Value = hocKi;
            this.sqlDataSource2.Fill();
        }

    }
}
