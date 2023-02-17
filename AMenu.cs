using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Research
{
    public partial class AMenu : DevExpress.XtraEditors.XtraForm
    {
        public AMenu()
        {
            InitializeComponent();
        }

        private void Emailbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Email Email = new Email();
            Email.ShowDialog();
        }

        private void DBbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DB DB = new DB();
            DB.ShowDialog();
        }

        private void Xbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (dialog == DialogResult.No)
            {
            }
        }

        private void AMenu_Load(object sender, EventArgs e)
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

        private void Mainbckbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu Menu = new Menu();
            Menu.ShowDialog();
        }
    }
}