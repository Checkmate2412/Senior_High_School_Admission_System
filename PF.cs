using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Research
{
    public partial class PF : DevExpress.XtraEditors.XtraForm
    {
        public PF()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            DB DB = new DB();
            DB.ShowDialog();
        }

        private void PF_Load(object sender, EventArgs e)
        {
            float width_ratio = (Screen.PrimaryScreen.Bounds.Width / 1378f);
            float height_ratio = (Screen.PrimaryScreen.Bounds.Height / 780f);

            SizeF scale = new SizeF(width_ratio, height_ratio);
            this.Scale(scale);

            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Calibri Light", control.Font.SizeInPoints * height_ratio * width_ratio);
            }
        }
    }
}