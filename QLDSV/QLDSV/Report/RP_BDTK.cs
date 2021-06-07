using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class RP_BDTK : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_BDTK(string malop)
        {
            //InitializeComponent();
            InitializeComponent();
            Program.KetNoi();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            Console.WriteLine("String connect: " + Program.connstr);
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Fill();
        }

    }
}
