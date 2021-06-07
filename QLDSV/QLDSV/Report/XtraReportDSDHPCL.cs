using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class XtraReportDSDHPCL : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportDSDHPCL(string malop, string NIENKHOA, string HOCKY)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
           
        }

    }
}
