using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class XtraReportBDMH : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportBDMH( string MALOP, string MAMH, string LAN)
        {
            InitializeComponent();
            //ds1.EnforceConstraints = false;
            //this.sp_BANGDIEMMONHOCTableAdapter1.Connection.ConnectionString = Program.connectionString;
           // this.sp_BANGDIEMMONHOCTableAdapter1.Fill(ds1.sp_BANGDIEMMONHOC, MALOP, MAMH, new System.Nullable<short>(((short)(System.Convert.ChangeType(LAN, typeof(short))))));
            //this.ds1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource4.Connection.ConnectionString = Program.connectionString;
            this.sqlDataSource4.Queries[0].Parameters[0].Value = MALOP;
            this.sqlDataSource4.Queries[0].Parameters[1].Value = MAMH;
            this.sqlDataSource4.Queries[0].Parameters[2].Value = LAN;
            this.sqlDataSource4.Fill();
        }

    }
}
