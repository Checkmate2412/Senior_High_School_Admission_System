using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Research
{
    public partial class Print : DevExpress.XtraReports.UI.XtraReport
    {
        public Print()
        {
            InitializeComponent();
        }
    }
}