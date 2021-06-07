using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class XtraReportInDSSV : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportInDSSV(string malop)
        {
            InitializeComponent();
            /*ds1.EnforceConstraints = false;
            this.sp_InDSSVTableAdapter1.Connection.ConnectionString = Program.connectionString;
            Console.WriteLine(Program.connectionString);
            this.sp_InDSSVTableAdapter1.Fill(this.ds1.sp_InDSSV, malop);*/
            Program.KetNoi();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource2.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource2.Fill();
        }

    }
}
