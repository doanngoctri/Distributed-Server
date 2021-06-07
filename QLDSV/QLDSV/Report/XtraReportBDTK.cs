using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class XtraReportBDTK : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportBDTK(string malop)
        {
            InitializeComponent();
            /*ds1.EnforceConstraints = false;
            this.sp_BANGDIEMTONGKETTableAdapter1.Connection.ConnectionString = Program.connectionString;
            this.sp_BANGDIEMTONGKETTableAdapter1.Fill(this.ds1.sp_BANGDIEMTONGKET, malop);*/
            Program.KetNoi();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            Console.WriteLine("String connect: " + Program.connstr);
            this.sqlDataSource2.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource2.Fill();
        }

    }
}
