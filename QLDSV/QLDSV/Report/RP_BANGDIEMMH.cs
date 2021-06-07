using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class RP_BANGDIEMMH : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_BANGDIEMMH(string maLop,string maMH,string lan)
        {
            InitializeComponent();
            Program.KetNoi();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            Console.WriteLine("String connect: "+Program.connstr);
            this.sqlDataSource2.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource2.Queries[0].Parameters[1].Value = maMH;
            this.sqlDataSource2.Queries[0].Parameters[2].Value = Int32.Parse(lan);
            this.sqlDataSource2.Fill();
        }
       

    }
}
