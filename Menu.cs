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
    public partial class Menu : DevExpress.XtraEditors.XtraForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Dycibtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DYCI DYCI = new DYCI();
            DYCI.ShowDialog();
        }

        private void Stdbtn_Click(object sender, EventArgs e)
        {
            Stdpanel.Show();
            Mainbckbtn.Show();
            Dycibtn.Hide();
            Mainpanel.Hide();
        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.ShowDialog();
        }

        private void APbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AP AP = new AP();
            AP.ShowDialog();
        }

        private void Mainbckbtn_Click(object sender, EventArgs e)
        {
            Dycibtn.Show();
            Mainpanel.Show();
            Stdpanel.Hide();
            Mainbckbtn.Hide();
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

        private void ETbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EE EE = new EE();
            EE.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
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